/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 11.5.2017
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace EksML
{
	/// <summary>
	/// Class holds and prints Simple types read from XSD.
	/// </summary>
	public class SimpleType : BaseType
	{

		private string type;
		
		private string[] list_desc = new string[100];
		private string[] list = new string[100];
		
		private int index = 0;
		
		private XmlNode simpleType;
		
		private string[] unionMembers;
		
		public bool isPartOfElement = false;
		
		
		public SimpleType(string name, string type, string desc, XmlNode simpleType, string ns)
		{
			base.gType = gmlType.SimpleType;
			
			this.name = name;
			this.type= Common.removeNs(type);
			this.desc= desc;
			this.ns = ns;
			
			this.simpleType = simpleType;
		}
		
		public void addUnion(string[] memberTypes)
		{
			this.unionMembers = memberTypes;
		}
		
			
		public void addItem(string item, string desc)
		{
			this.list_desc[this.index] = desc;
			this.list[this.index++] = item;
		}
		
		
		private string getItemDescription(int index)
		{
			return Common.summaryT1(this.list_desc[index]);
		}
		
		public string printCsCode()
		{
			var cName = Common.cleanUp(this.name);
			var cType= Common.removeNs(this.type);
			
			//if union found
			if (this.unionMembers != null)
			{
				//Simple type as type
				return this.getDescription() + "public struct " + cName +" { \r\n " + this.printUnionMembers() + "\r\n}";
			}
			
			//if no enumeration
			if (this.index == 0)
			{
				//Simple type as class
				//return this.getDescription() + "public struct " + cName +" { " + Common.nlT1("public " + cType + " value { get; set; }", true, true) + "}";
				
				//Simple type as 
				return this.getDescription() + this.printNewType(cName, cType);
		
			}
			
			//Enumeration as enum
			return this.getDescription() + "public enum " + cName +" { " + this.printItems() + "\r\n}";
		}
			
		private string printNewType(string csName, string csType)
		{
			var stringFormatted = "";
			
			if (csType.Equals("DateTime"))
			{
			stringFormatted = @"
	
	public string ToString(string format)
	{
		return this.VALUE.ToString(format);
	}";
			}
			
			var definition = @"
public struct NewInt3 {

	private Int32 VALUE;
		
	public static implicit operator Int32( NewInt3 value ) {
		return value.VALUE;
	}
	
	public static implicit operator NewInt3( Int32 value ) {
		var _ReturnValue = new NewInt3();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	" + stringFormatted + @"
}";
			
			definition = definition.Replace("NewInt3", csName);
			definition = definition.Replace("Int32", csType);
			
			return definition;
		}

		private string printItems()
		{
			string itemList = "";
			
			for (int i=0; i < this.index; i++)
			{
				var description = "[Description(\""+ this.list[i]+"\")]";
				//print enumeration items
				itemList += this.getItemDescription(i) + "\t" + description +"\r\n\t" + Common.cleanUp(this.list[i]) + "=" + (i+1) + ",";
			}
		
			return itemList.Trim(',');
		}
		
		private string printUnionMembers()
		{
			var union = "";
			
			foreach (var mem in this.unionMembers)
			{
				var cType = Common.cleanUp(mem);
				var cName = Common.removeNs(mem);
				cType = Common.convertBaseType(cType);
				
				union += "\tpublic " + cType + " " + "_" + cName + ";\r\n";
			}
		
			return union;
		}
		
		public string printDebugLine(string printRequester)
		{
			return (printRequester + ";SimpleType;" + this.ns + ";" +  this.type + ";"+ this.name);
		}
		
	}
}
