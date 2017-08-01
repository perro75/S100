/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 25.5.2017
 * Time: 19.20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace EksML
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class GmlProfileReader : XmlReader
	{
		bool DEBUG = true;
		
		//ATTRIBUTES (AND GROUPS)
		private Attribut_[] attributes = new Attribut_[500];
		private int aIdx=0; //elements index
		
		//SIMPLE TYPES
		private SimpleType[] simpleTypes = new SimpleType[500];
		private int sIdx=0; //elements index
		
		//COMPLEX TYPES
		private ComplexType[] complexTypes = new ComplexType[500];
		private int cIdx=0; //elements index
		
		//COMMON LIST OF ALL TYPES
		public static ComplexType[] allComplexTypes = new ComplexType[1000];
		public static int acIdx=0; //elements index
		
		
		//ELEMENTS
		private Element[] elements = new Element[500];
		private int eIdx=0; //elements index
		
		 public GmlProfileReader(string inFileName, string csNameSpace) : base(inFileName, csNameSpace)
		{
		}
		
		public override void printCsCode(string outFileName)
		{
			readFile();
			printFile(outFileName);
			if(this.DEBUG)
				this.debug();
		}
		
		private void debug()
		{
			for(int i=0; i < sIdx; i++)
			{
				dw.wl(simpleTypes[i].printDebugLine(inFileName));
			}
			
			for(int i=0; i < cIdx; i++)
			{
				dw.wl(complexTypes[i].printDebugLine(inFileName));
				
				foreach(var at in complexTypes[i].getAttributes(true, true, false))
				{
					dw.wl(at.printDebugLine(complexTypes[i].getCleanName()));
				}
			}
			
			for(int i=0; i < eIdx; i++)
			{
				dw.wl(elements[i].printDebugLine(inFileName));
			}
			
			for(int i=0; i < aIdx; i++)
			{
				dw.wl(attributes[i].printDebugLine(inFileName));
			}
			
			for(int i=0; i < aIdx; i++)
			{
				dw.wl(attributes[i].printDebugLine(inFileName));
			}
		}
		
		private void readFile()
		{
			readAttributes();
			readAttributeGroups();
			
			readSimpleTypes();
			readComplexTypes();
			addComplexTypeInheritedValues();
			readElements();
		}
		
		private void printFile(string outfile)
		{
			var sw = new SourceWriter(outfile, csNameSpace);
			
			
			sw.writeSimple(this.simpleTypes, this.sIdx);
			sw.writeComplex(this.complexTypes, this.cIdx);
			sw.writeElement(this.elements, this.cIdx);
			
			sw.close();
		}
		
		private void readElements()
		{
			foreach (XmlNode element in this.getElements()) 
			{
				
				var name = CommonReader.readNodeAttribute(element, "name");
				
				//the namespace these elements are put into in csCode
				var ns = this.csNameSpace;
				
				var type = CommonReader.readNodeAttribute(element, "type");
				var isAbstract = CommonReader.readNodeAttribute(element, "abstract");
				var substGroup= CommonReader.readNodeAttribute(element, "substitutionGroup");
				var nillable = CommonReader.readNodeAttribute(element, "nillable");
				var documentation = CommonReader.readInnerText(this.getNodeDocumentation(element));
				
				var e = new Element(name, ns, type, isAbstract == "true",  substGroup, nillable, documentation);
				e = combineElementAndType(e);
				this.elements[this.eIdx++] = e;
			}
		}
		
		private Element combineElementAndType(Element e)
		{
			
			var type = e.elementTypeString();
			if (type == null)
				return e;
			
			foreach(ComplexType ct in this.complexTypes)
			{
				if (ct == null)
					break;
				
				if (type.Equals((ct.getRawName())))
			    {
					e.addType(ct);
					ct.isPartOfElement = true;
					return e;
			    }
			}
			
			foreach(SimpleType st in this.simpleTypes)
			{
				if (st == null)
					break;
				
				//type might have ns: name does not
				if (type.EndsWith(st.getRawName(),StringComparison.CurrentCulture))
			    {
					e.addType(st);
					st.isPartOfElement = true;
					return e;
			    }
			}
			
			//create custom type
			//TODO: Boolean encoding falls through unless type = "Boolean" is set
			var s = new SimpleType(e.getName(), type,"", null, csNameSpace);
			e.addType(s);
			s.isPartOfElement = true;
			return e;
		}
		
		private void readSimpleTypes()
		{
			foreach (XmlNode simple in this.getSimpleTypes()) {
				
				//get name
				var name_attr = simple.Attributes.GetNamedItem("name");
				var name = name_attr.InnerText;
				
				//get type (restriction base)
				var type_node = this.getNodeRestriction(simple);
				var type = (type_node != null) ? type_node.Attributes.GetNamedItem("base").InnerText : "no_type";
				
				var is_list = this.getNodeList(simple);
					type = (is_list != null) ? "list_" + is_list.Attributes.GetNamedItem("itemType").InnerText : type;
				
				//get documentation
				var description_node = this.getNodeDocumentation(simple);
				var description = (description_node != null) ? description_node.InnerText : "no description available";
				
				//create simple-object
				var s = new SimpleType(name, type, description, simple, this.csNameSpace);
				
				//add enumeration items
				
				s = readEnumerationItems(simple, s);
				s = readUnionMembers(simple, s);
				
				this.simpleTypes[this.sIdx++] = s;
			}
		}
		
		private SimpleType readEnumerationItems(XmlNode simple, SimpleType s)
		{
				//read enumeration items in simple type
				foreach (XmlNode enu in this.getEnumeration(simple)) 
				{
					var item = enu.Attributes.GetNamedItem("value").InnerText;
					//get documentation
					var item_description_node = this.getNodeDocumentation(enu);
					var item_description = (item_description_node != null) ? item_description_node.InnerText : "no description available";
					s.addItem(item, item_description);
				}
				
				return s;
		}
		
		//<union memberTypes="gml:NilReasonEnumeration anyURI"/>
		private SimpleType readUnionMembers(XmlNode simple, SimpleType s)
		{
			XmlNode enu =  this.getUnion(simple);
			
			if (enu == null)
				return s;
			
			var memberTypes = enu.Attributes.GetNamedItem("memberTypes");
			
			if (memberTypes == null)
				return s;
						
			var memberType = memberTypes.InnerText;
			var members = memberType.Split(' ');
			
			s.addUnion(members);
			return s;
		}
		
		private void readComplexTypes()
		{
			
			foreach (XmlNode comp in this.getComplex()) {
				
				//get name
				var name_attr = comp.Attributes.GetNamedItem("name");
				var abstract_attr = comp.Attributes.GetNamedItem("abstract");
				
				var name = name_attr.InnerText;
				var isAbstract = (abstract_attr != null && abstract_attr.InnerText.Equals("true"));
				
				var extbase = this.getExtensionBase(comp);
				var extendedBy = (extbase != null) ? extbase.Attributes.GetNamedItem("base").InnerText : null;
								
				var c = new ComplexType(name, extendedBy, isAbstract, csNameSpace);
				
				//get documentation
				var description_node = this.getNodeDocumentation(comp);
				var description = (description_node != null) ? description_node.InnerText : "no description available";
				c.addDescription(description);	
				
				c = readComplexTypeAttributes(comp, c);
				c = readComplexTypeAttributeGroup(comp, c);
				c = readComplexTypeElements(comp, c);
				this.complexTypes[this.cIdx++] = c;
				
				//add to common list also
				allComplexTypes[acIdx++] = c;
			}
		}
		
		private void addComplexTypeInheritedValues()
		{
			for (int j=0; j < cIdx; j++)
				{
					//check if type is inherited from one or several base classes. 
					//if so, add the needed data from those.
					var baseClass = complexTypes[j].getExtendsName();
					addExtendedData(j, baseClass, acIdx, 0);
				}
		}
		
		/// <summary>
		/// This function iterates the list of complex objects, and retreives all inherited attributes to be added.
		/// The inherited attributes are added to the ComplexType - object for use by the print- function
		/// </summary>
		/// <param name="j"></param>
		/// <param name="baseClass"></param>
		/// <param name="idx"></param>
		private void addExtendedData(int j, string baseClass, int idx, int level)
		{
			if (baseClass != " " && baseClass != null)
			{
				for (int k=0; k < idx; k++)
				{
					var cn = allComplexTypes[k].getCleanName();
					var ns = allComplexTypes[k].getNs();
					var cleanBase = Common.removeNs(baseClass);
					
					if (this.csNameSpace == ns || "gml" == ns || "S100" == ns || "S100EXT" == ns)
					{
					if (cn == cleanBase)
						{
							var mandatoryOwnAttributes = allComplexTypes[k].getAttributes(false, true, false);
							this.complexTypes[j].addItems(mandatoryOwnAttributes,true);
							
							//iterate
							if (level++ < 30)
								addExtendedData(j, allComplexTypes[k].getExtendsName(), idx, level);
						}
					}
				}
			}
		}			
		
		private ComplexType readComplexTypeElements(XmlNode comp, ComplexType c)
		{
			foreach (XmlNode ele in this.getElement(comp)) {
					
				if (ele.Attributes.GetNamedItem("name") == null)
					continue;
				
				var elename = ele.Attributes.GetNamedItem("name").InnerText;
				//XXX added check fotr null because of S100gmlbase
				var eletype = ele.Attributes.GetNamedItem("type") == null ? "no type" : ele.Attributes.GetNamedItem("type").InnerText;
				
				var min = ele.Attributes.GetNamedItem("minOccurs");
				var max = ele.Attributes.GetNamedItem("maxOccurs");
				
				var minoccurs = ( min == null ) ? "1" : min.InnerText;
				var maxoccurs = ( max == null ) ? "1" : max.InnerText;
				
				//check if element has parent "choice" and set minOccurs == 0
				if  (CommonReader.readParentTag(ele).Equals("xs:choice"))
					minoccurs = "0";
				
				//add feature attributes
				c.addItem(elename, eletype, minoccurs, maxoccurs, false, this.csNameSpace);
				}
			
			return c;
		}
		
		private ComplexType readComplexTypeAttributes(XmlNode comp, ComplexType c)
		{
			foreach (XmlNode ele in this.getComplexTypeAttribute(comp)) {
					
				if (ele.Attributes.GetNamedItem("ref") != null)
				{
					//read referenced attribute
					var eleref = ele.Attributes.GetNamedItem("ref").InnerText;
					for(var i=0; i < this.aIdx; i++)
					{
						if ( this.attributes[i].getNameWithNamespace().Equals(eleref))
							c.addItem(this.attributes[i].getName(), this.attributes[i].getType(), "1","1",false, this.attributes[i].getNs());
					}
					
				}
				else
				{
					//read inline data
					var elename = ele.Attributes.GetNamedItem("name").InnerText;
					var eletype = ele.Attributes.GetNamedItem("type").InnerText;
					//TODO: Read default value
					//var eledefault = ele.Attributes.GetNamedItem("default").InnerText;
					c.addItem(elename, eletype, "1", "1", false, this.csNameSpace);
				}
		
			}
			
			return c;
		}
		
		private ComplexType readComplexTypeAttributeGroup(XmlNode comp, ComplexType c)
		{
			foreach (XmlNode ele in this.getComplexTypeAttributeGroup(comp)) {
					
				if (ele.Attributes.GetNamedItem("ref") != null)
				{
					//read referenced attribute
					var eleref = ele.Attributes.GetNamedItem("ref").InnerText;
					for(var i=0; i < this.aIdx; i++)
					{
						if ( this.attributes[i].getGroupWithNamespace() != null && this.attributes[i].getGroupWithNamespace().Equals(eleref))
							c.addItem(this.attributes[i].getName(), this.attributes[i].getType(), "1","1",false, this.csNameSpace);
					}
				}
			}
			
			return c;
		}
		
		private void readAttributes()
		{
			foreach (XmlNode element in this.getAttributes()) 
			{
				var name = CommonReader.readNodeAttribute(element, "name");
				//the namespace these elements are put into in csCode
				var ns = this.csNameSpace;
				var type = CommonReader.readNodeAttribute(element, "type");
				var documentation = CommonReader.readInnerText(this.getNodeDocumentation(element));
				
				var a = new Attribut_(name, ns, type, documentation);
				attributes[aIdx++] = a;
			}
		}
		
		private void readAttributeGroups()
		{
			foreach (XmlNode group in this.getAttributeGroups()) 
			{
				var gName = CommonReader.readNodeAttribute(group, "name");
				var documentation = CommonReader.readInnerText(this.getNodeDocumentation(group));
				
				foreach (XmlNode element in this.getAttributes(group)) 
				{
					var name = CommonReader.readNodeAttribute(element, "name");
					var ns = this.csNameSpace;
					var type = CommonReader.readNodeAttribute(element, "type");
					//var documentation = this.readInnerText(this.fileReader.getNodeDocumentation(element));
					
					var a = new Attribut_(name, ns, type, documentation, gName);
					//put data into array
					attributes[aIdx++] = a;
				}
			}
		}
	}
}
