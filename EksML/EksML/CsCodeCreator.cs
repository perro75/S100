/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 11.5.2017
 * Time: 14:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Xml;

namespace EksML
{
	/// <summary>
	/// Create Cs-code of S100 application schema. 
	/// Functions in the class ApplicationSchemaReader are used to get XML- data as XmlNode- objects
	/// TODO: Reading and writing of types could be separated into multiple functions. 
	/// </summary>
	
	public class CsCodeCreator
	{
		private XmlReader fileReader;
		private string outFileName;
		private string csNameSpace;
		
		//Array if complex types in the file
		ComplexType[] cTypes = new ComplexType[500];
		
		//Array if simple types in the file
		SimpleType[] sTypes = new SimpleType[500];
		
		//Aray of elements in this file
		Element[] elems = new Element[500];
		
		//Aray of elements in this file
		Attribut_[] attribs = new Attribut_[500];
		
		private int cIdx=0; //complex types index
		private int sIdx=0; //simple types index
		private int eIdx=0; //elements index
		private int aIdx=0; //elements index
		
				
		public CsCodeCreator(XmlReader fileReader, string outFileName, string csNameSpace)
		{
			this.fileReader = fileReader;
			this.outFileName = outFileName;
			this.csNameSpace= csNameSpace;
		}
		
		/// <summary>
		/// Function prints a complete C# source-code file.
		/// </summary>
		public void printCodeFile(string ns)
		{
			//create file
			StreamWriter file = new StreamWriter(this.outFileName);
		
			//add headerdata
			file.WriteLine(Common.nl("//EksML - S100 application schema to csCode " + DateTime.Now, false, false));
			this.printSchemaHeader(file);
			//using
			file.WriteLine(Common.nl("using System;", true, false));
			file.WriteLine(Common.nl("using System.ComponentModel;", false, true));
			
			file.WriteLine(Common.nl("namespace " + this.csNameSpace + " {", true, true));
						
			//print Applicationschema
			this.printSimpleTypes(file);
			this.printComplexTypes(file, ns);
			
			// XXX Test
			this.readElements();
			this.readAttributes();
			this.readAttributeGroups();
			
			file.WriteLine(Common.nl("}", false, true));
			file.Close();
			
		}
				
		private void printSchemaHeader(StreamWriter file)
		{
			file.WriteLine(Common.comment(this.fileReader.getSchemaDocumentation().InnerText));
		}
		
		private string readNodeAttribute(XmlNode node, string attribute)
		{
			if (node == null)
				return null;
			
			var node_attribute = node.Attributes.GetNamedItem(attribute);
			
			if (node_attribute == null)
				return null;
			
			return node_attribute.InnerText;
		}
		
		private string readInnerText(XmlNode node)
		{
			if (node == null)
			return null;
			
			return node.InnerText;
		}
	
		private void readElements()
		{
			foreach (XmlNode element in this.fileReader.getElements()) 
			{
				
				var name = readNodeAttribute(element, "name");
				
				//the namespace these elements are put into in csCode
				var ns = this.csNameSpace;
				
				var type = readNodeAttribute(element, "type");
				var isAbstract = readNodeAttribute(element, "abstract");
				var substGroup= readNodeAttribute(element, "substitutionGroup");
				var nillable = readNodeAttribute(element, "nillable");
				var documentation = this.readInnerText(this.fileReader.getNodeDocumentation(element));
				
				var e = new Element(name, ns, type, (isAbstract == "true"), substGroup, nillable, documentation);
				
				if (type != null)
				{
					foreach(ComplexType ct in cTypes)
					{
						if (ct == null)
							break;
						
						//type might have ns: name does not
						if (type.EndsWith(ct.getRawName()))
					    {
							e.addType(ct);
					    }
					}
					
					foreach(SimpleType st in sTypes)
					{
						if (st == null)
							break;
						
						//type might have ns: name does not
						if (type.EndsWith(st.getRawName()))
					    {
							e.addType(st);
					    }
					}
				}
				//e.debug();
				//put data into array
				elems[eIdx++] = e;
			}
		}
		
		private void readAttributes()
		{
			foreach (XmlNode element in this.fileReader.getAttributes()) 
			{
				var name = readNodeAttribute(element, "name");
				//the namespace these elements are put into in csCode
				var ns = this.csNameSpace;
				var type = readNodeAttribute(element, "type");
				var documentation = this.readInnerText(this.fileReader.getNodeDocumentation(element));
				
				var a = new Attribut_(name, ns, type, documentation);
			
				a.debug();
				//put data into array
				attribs[aIdx++] = a;
			}
		}
		
		private void readAttributeGroups()
		{
			foreach (XmlNode group in this.fileReader.getAttributeGroups()) 
			{
				var gName = readNodeAttribute(group, "name");
				var documentation = this.readInnerText(this.fileReader.getNodeDocumentation(group));
				
				foreach (XmlNode element in this.fileReader.getAttributes(group)) 
				{
					var name = readNodeAttribute(element, "name");
					var ns = this.csNameSpace;
					var type = readNodeAttribute(element, "type");
					//var documentation = this.readInnerText(this.fileReader.getNodeDocumentation(element));
					
					var a = new Attribut_(name, ns, type, documentation, gName);
				
					a.debug();
					
					//put data into array
					attribs[aIdx++] = a;
				}
			}
		}
		
		private void printSimpleTypes(StreamWriter file)
		{
			foreach (XmlNode simple in this.fileReader.getSimpleTypes()) {
				
				//get name
				var name_attr = simple.Attributes.GetNamedItem("name");
				var name = name_attr.InnerText;
				
				//get type (restriction base)
				var type_node = this.fileReader.getNodeRestriction(simple);
				var type = (type_node != null) ? type_node.Attributes.GetNamedItem("base").InnerText : "no_type";
				
				var is_list = this.fileReader.getNodeList(simple);
					type = (is_list != null) ? "list_" + is_list.Attributes.GetNamedItem("itemType").InnerText : type;
				
				//get documentation
				var description_node = this.fileReader.getNodeDocumentation(simple);
				var description = (description_node != null) ? description_node.InnerText : "no description available";
				
				//create simple-object
				var simpleType = new SimpleType(name, type, description, simple, this.csNameSpace);
				
											
								
				//read enumeration items in simple type
				foreach (XmlNode enu in this.fileReader.getEnumeration(simple)) {
					var item = enu.Attributes.GetNamedItem("value").InnerText;
					//get documentation
					var item_description_node = this.fileReader.getNodeDocumentation(enu);
					var item_description = (item_description_node != null) ? item_description_node.InnerText : "no description available";
					simpleType.addItem(item, item_description);
				}
								
				file.WriteLine(simpleType.printCsCode());
				//put data into array
				sTypes[sIdx++] = simpleType;
			}
		}
		
		private void printComplexTypes(StreamWriter file, string ns)
		{
			
			foreach (XmlNode comp in this.fileReader.getComplex()) {
				
				//get name
				var name_attr = comp.Attributes.GetNamedItem("name");
				var abstract_attr = comp.Attributes.GetNamedItem("abstract");
				
				var name = name_attr.InnerText;
				var isAbstract = (abstract_attr != null && abstract_attr.InnerText.Equals("true"));
				
				var extbase = this.fileReader.getExtensionBase(comp);
				var extendedBy = (extbase != null) ? extbase.Attributes.GetNamedItem("base").InnerText : null;
								
				var codeClass = new ComplexType(name, extendedBy, isAbstract, csNameSpace);
				
				//get documentation
				var description_node = this.fileReader.getNodeDocumentation(comp);
				var description = (description_node != null) ? description_node.InnerText : "no description available";
				codeClass.addDescription(description);			
				
				//xs:element
				foreach (XmlNode ele in this.fileReader.getElement(comp)) {
					
					if (ele.Attributes.GetNamedItem("name") == null)
						continue;
					
					var elename = ele.Attributes.GetNamedItem("name").InnerText;
					//XXX added check fotr null because of S100gmlbase
					var eletype = ele.Attributes.GetNamedItem("type") == null ? "no type" : ele.Attributes.GetNamedItem("type").InnerText;
					
					var min = ele.Attributes.GetNamedItem("minOccurs");
					var max = ele.Attributes.GetNamedItem("maxOccurs");
					
					var minoccurs = ( min == null ) ? "1" : min.InnerText;
					var maxoccurs = ( max == null ) ? "1" : max.InnerText;
					
					//add feature attributes
					codeClass.addItem(elename, eletype, minoccurs, maxoccurs, false, this.csNameSpace);
					
					}
					//put data into array
					cTypes[cIdx++] = codeClass;
			}
				
				for (int j=0; j < cIdx; j++)
				{
					//check if type is inherited from one or several base classes. 
					//if so, add the needed data from those.
					var baseClass = cTypes[j].getExtendsName();
					addExtendedData(j, baseClass, cIdx);
					
					file.WriteLine(cTypes[j].printCsCode(ns));
				}
		}
		
		/// <summary>
		/// This function iterates the list of complex objects, and retreives all inherited attributes to be added.
		/// The inherited attributes are added to the ComplexType - object for use by the print- function
		/// </summary>
		/// <param name="j"></param>
		/// <param name="baseClass"></param>
		/// <param name="idx"></param>
		private void addExtendedData(int j, string baseClass, int idx)
		{
			if (baseClass != " ")
			{
				for (int k=0; k < idx; k++)
				{
					if (cTypes[k].getCleanName().Equals(baseClass))
					{
						var mandatoryOwnAttributes = cTypes[k].getAttributes(false, true, false);
						cTypes[j].addItems(mandatoryOwnAttributes, true);
						
						//iterate
						addExtendedData(j, cTypes[k].getExtendsName(), idx);
					}
				}
			}
		}			
	}
}
