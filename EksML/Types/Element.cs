/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 16.5.2017
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace EksML
{
	/// <summary>
	/// Description of Element.
	/// </summary>
	public class Element
	{
		private string name, ns, ele_type,  substGroup, nillable, documentation;
		private bool isAbstract;
		
		// a complex(?) type representing the element setup
		private BaseType gml_type;
		
		public Element(string name, string ns, string ele_type, bool isAbstract, string substGroup, string nillable, string documentation)
		{
			this.name = name;
			this.ns = ns;
			this.ele_type = Common.removeNs(ele_type);
			this.isAbstract = isAbstract;
			this.substGroup = substGroup;
			this.nillable = nillable;
			this.documentation = documentation;
		}
		
		public void debug()
		{
			var typeChar = this.gml_type == null ? "-" : "Y";
			Console.WriteLine(this.ns + "\t" + "E" + typeChar +"\t"+this.name + "\t");
		}
				
		public void addType(BaseType gml_type)
		{
			this.gml_type = gml_type;
		}
		
		public string elementTypeString()
		{
			return this.ele_type;
		}
		
		public string getName()
		{
			return this.name;
		}
		
		public string getDescription(string addText)
		{
			return Common.summary("(Type)" + addText + "(Element)" + this.documentation);
		}
		
		public ElementType getElementPrintType()
		{
			if (this.gml_type == null)
				return ElementType.NoTypeDefinition;
			
			var eName = Common.cleanUp(this.name);
			var cType = this.gml_type == null ? "" : this.gml_type.getCleanName();
			
			if ( eName == cType)
				return ElementType.SameNameAsCompexType;
			
			return ElementType.ExtendsComplexType;
			
		}
		
		public string printCsCode(string ns)
		{
			var eName = this.name;
			var cType = this.ele_type;
			var abst = isAbstract ? " abstract " : " ";
			
			// no type, create class only, constructor not needed
			if ( this.getElementPrintType() == ElementType.NoTypeDefinition)
				return this.getDescription(null) + "public" + abst + "class " + eName + " {\r\n}";
			
			if ( this.getElementPrintType() == ElementType.SameNameAsCompexType)
			{
				return "//" + eName + " refers same name";
			}
			
			//extend ComplexType
			if (this.gml_type.getType() == gmlType.ComplexType)
			{
				var bType = (ComplexType) this.gml_type;
				var eleType = new ComplexType(eName, cType, this.isAbstract, ns);
				eleType.addDescription(this.getDescription(bType.getDescriptionText()));
				eleType.addItems(bType.getAttributes(true, true, false), true);
				
				return eleType.printCsCode(ns);
				
			}
			
			return "//" + eName + " refers simple-type";
		}
		
		public string printDebugLine(string printRequester)
		{
			return printRequester + ";Element;" + this.ns + ";" +  this.ele_type + ";"+ this.name;
		}
	}
}
