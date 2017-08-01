/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 11.5.2017
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace EksML
{
	
	/// <summary>
	/// Class reads Application schema XSD- file.
	/// Class holds funcrtions for reading the file into XmlNOde- objects for further processing.
	/// Funciton printCsCode makes a call to class CsCodeCreator
	/// </summary>
	public class XmlReader
	{
		public static DebugWriter dw = new DebugWriter("statistics.csv");
		
		private XmlNamespaceManager nsManager;
		private XmlNode xmlRootNode;
		protected string csNameSpace;
		protected string inFileName;
		
		public XmlReader(string inFileName, string csNameSpace)
		{
			this.csNameSpace = csNameSpace;
			this.xmlRootNode = readFile(inFileName);
			
			this.inFileName = inFileName;
		}
		
		public virtual void printCsCode(string outFileName)
		{
			new CsCodeCreator(this, outFileName, csNameSpace).printCodeFile(csNameSpace);
		}
				
		/* Read S100 Application Schema */
		private XmlNode readFile(string inFileName)
		{
			var doc = new XmlDocument();
			doc.Load(inFileName);
			
			this.nsManager = new XmlNamespaceManager(doc.NameTable);
			this.nsManager.AddNamespace("xs", "http://www.w3.org/2001/XMLSchema");
			
			//read first xs:schema object as root
			return doc.SelectSingleNode("descendant::xs:schema", this.nsManager);	
		}
		
		public XmlNode getXmlRootNode()
		{
			return this.xmlRootNode;
		}
		
		/*
		 Get documentation of the entire schema
		*/ 
		public XmlNode getSchemaDocumentation()
		{
			return this.xmlRootNode.SelectSingleNode("xs:annotation/xs:documentation", this.nsManager);
		}
		
		/*
			Get the definition of a type
		*/
		public XmlNode getNodeDocumentation(XmlNode node)
		{
			return node.SelectSingleNode("xs:annotation/xs:documentation", this.nsManager);
		}
		
		/*
			Restriction- block holds type
		*/
		public XmlNode getNodeRestriction(XmlNode node)
		{
			return node.SelectSingleNode("xs:restriction", this.nsManager);
		}
		
		/*
		 	List type is an array of values separated by spaces.
		 */
		
		public XmlNode getNodeList(XmlNode node)
		{
			return node.SelectSingleNode("xs:list", this.nsManager);
		}
		
		
		/*
			Read only top-level SimpleTypes
		*/
		public XmlNodeList getSimpleTypes()
		{
			return this.xmlRootNode.SelectNodes("xs:simpleType", this.nsManager);
		}
		
		/*
		 	Read Enumeration items of SimpleType
		*/
		public XmlNodeList getEnumeration(XmlNode simple)
		{
			return simple.SelectNodes("descendant::xs:enumeration",this.nsManager);
		}
		
		/*
		 	Read union memberTypes
		*/
		public XmlNode getUnion(XmlNode simple)
		{
			return simple.SelectSingleNode("xs:union",this.nsManager);
		}
		
		/*
			Read only top-level ComplexTypes
		*/
		public XmlNodeList getComplex()
		{
			return this.xmlRootNode.SelectNodes("xs:complexType", this.nsManager);
		}
		
		
		/*
			Read only top-level Elements
		*/
		public XmlNodeList getElements()
		{
			return this.xmlRootNode.SelectNodes("xs:element", this.nsManager);
		}
		
		/*
			Read only top-level Attributes
		*/
		public XmlNodeList getAttributes()
		{
			return this.xmlRootNode.SelectNodes("xs:attribute", this.nsManager);
		}
				
		/*
			Read Attributes from beneath given node
		*/
		public XmlNodeList getAttributes(XmlNode group)
		{
			return group.SelectNodes("xs:attribute", this.nsManager);
		}
		
		public XmlNodeList getAttributeGroups()
		{
			return this.xmlRootNode.SelectNodes("xs:attributeGroup", this.nsManager);
		}
		/*
			Read Complex attributes
		*/
		public XmlNodeList getElement(XmlNode complex)
		{
			return complex.SelectNodes("descendant::xs:element",this.nsManager);
		}
		
		
		public XmlNodeList getComplexTypeAttribute(XmlNode complex)
		{
			return complex.SelectNodes("descendant::xs:attribute",this.nsManager);
		}
		
		public XmlNodeList getComplexTypeAttributeGroup(XmlNode complex)
		{
			return complex.SelectNodes("descendant::xs:attributeGroup",this.nsManager);
		}
		/*
			Read extension base
		*/
		public XmlNode getExtensionBase(XmlNode complex)
		{
			return complex.SelectSingleNode("xs:complexContent/xs:extension", this.nsManager);
		}
	}
}
