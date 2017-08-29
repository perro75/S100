/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 11.5.2017
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	/// <summary>
	/// Class holds and prints Complex Types read form XSD
	/// </summary>
	public class ComplexType : BaseType
	{
		
		private string extends;
		private string extends_ns;
		private bool isAbstract;
		
		
		public bool isPartOfElement = false;
		
		private ComplexTypeAttribute[] attributes = new ComplexTypeAttribute[100];
		
		private int index = 0;
		
		public ComplexType(string name, string extends, bool isAbstract, string ns)
		{
			base.gType = gmlType.ComplexType;
			
			this.name = Common.removeNs(name);
			this.extends = Common.removeNs(extends);
			this.extends_ns = Common.getNs(extends);
			this.isAbstract = isAbstract;
			this.ns = ns;
			
		}
		
		private string getName()
		{
			return Common.cleanUp(this.name);
		}
		
		
		public void addItem(string item, string type, string min, string max, bool isInherited, string nsext)
		{
			var iMax = (max == "unbounded") ? 99 : Convert.ToInt32(max);
			//add to attributes
			var isOption = (min == "0");
			var attr = new ComplexTypeAttribute(item, type, isOption, iMax, isInherited, nsext);
			
			//only add if no duplicate
			for (int i=0; i < this.index; i++)
			{
				if (this.attributes[i].isDuplicate(attr))
				  return;
			}
			
			this.attributes[this.index] = attr;
			this.index++;
		}
		
		public void addItems(ComplexTypeAttribute[] attributes, bool isInherited)
		{
			foreach (var attr in attributes) 
			{
				var nme = attr.getName();
				var tpe = attr.getType();
				var min = attr.isOptionalAttribute() ? "0" : "1";
				var max = attr.getSizeMax().ToString();
				var nsext = attr.getNs();
				
				this.addItem(nme, tpe, min, max, isInherited, nsext);
			}
		}
		
		public string getExtendsName()
		{
			//name needed only for reference lookup
			return (this.extends == null) ? "" : this.extends;
		}
		
		public string getExtends()
		{
			//name needed only for reference lookup
			if ( this.extends == null)
				return "";
			
			var ns_use = extends_ns == null || this.ns.Equals(extends_ns) ? "" : extends_ns + ".";
			return " : " + ns_use + this.extends;
		}
		
		
		
		public void addDescription(string desc)
		{
			this.desc = desc;
		}
			
				
		public string printCsCode(string ns)
		{
			var cName = getName();
			var abst = isAbstract ? " abstract " : " ";
			
			var exte = this.getExtends();
			return this.getDescription() + "public" + abst + "class " + cName + exte + " { " + this.printItems() + this.printConstructor(ns) + "\r\n\r\n}";
		}
		
		private int countAttributes(bool countInherited, bool countOwn, bool includeOptional)
		{
			
			var counter = 0;
			for (int i=0; i < this.index; i++)
			{
				if ( ( includeOptional || ( !this.attributes[i].isOptionalAttribute() ) ) && ( ( countInherited && this.attributes[i].isInheritedAttribute() ) || ( countOwn && !this.attributes[i].isInheritedAttribute() ) ))
				{
				    	counter++;
				    }
				}
			
			return counter;
		}
		
		public ComplexTypeAttribute[] getAttributes(bool countInherited, bool countOwn, bool includeOptional)
		{
			var c = this.countAttributes(countInherited, countOwn, includeOptional);
			var attr = new ComplexTypeAttribute[c];
			var j=0;
			
			for (int i = 0; i < this.index; i++)
			{
				if ( ( includeOptional || ( !this.attributes[i].isOptionalAttribute() ) ) && ( ( countInherited && this.attributes[i].isInheritedAttribute() ) || ( countOwn && !this.attributes[i].isInheritedAttribute() ) ))
				    {
						attr[j++] = this.attributes[i];
				    }
				}
			
			return attr;
		}
		
				
		public string printConstructor(string ns)
		{
			string itemList = "";
			string setList = "\r\n\t";
			var baseList = "";
			
			//for (int i = 0; i < this.index; i++) {
			
			//add all mandatory to constructor, including inherited
			foreach(var ownMandatory in this.getAttributes(true, true, false))
			{
				itemList += " " + ownMandatory.printConstructorDefinition(ns) + ",";
			}
			itemList = itemList.Trim(',');
			
			//add setters only for own attributes (not inherited)
			foreach(var ownMandatory in this.getAttributes(false, true, false))
			{
				setList += "\t" + ownMandatory.printConstructorSetter() + ";\r\n\t";
			}
			
			//add setters only for own attributes (not inherited)
			foreach(var ownMandatory in this.getAttributes(true, false, false))
			{
				baseList += " " + ownMandatory.printBaseAttribute() + ",";
			}			
			
			baseList = baseList.Trim(',');
						
			//add extended data to constructor definitions
			//itemList += this.extendedFieldDefinitions;
			
			var baseExte = "";
			
			if (this.extends != null)
			{
				baseExte = " : base(" + baseList + ")";
			}
			
			var constType = isAbstract ? "protected " : "public ";
			
			var ret =  "\r\n\r\n\t" + constType + getName() + "(" + itemList + ")" + baseExte + "\r\n\t{" + setList + "}";
			//add private constructor
			if (baseList.Length > 1 || itemList.Length > 1)
				ret += 	   "\r\n\r\n\t" + "protected " + getName() + "(): base()\r\n\t{}";
			
			return ret;
		}
		
		public string printItems()
		{
			string itemList = "\r\n";
			
			foreach(var ownMandatory in this.getAttributes(false, true, true))
			{
				itemList += ownMandatory.printDefinition(ns);
			}
		
			return itemList.Trim(',');
		}
		
		public void debug()
		{
			var isElePart = (this.isPartOfElement) ? "Y" : "-";
			Console.WriteLine("\t" + "C"+isElePart+"\t"+this.name + "\t");
		}
		
		public string printDebugLine(string printRequester)
		{
			return printRequester + ";ComplexType;" + this.ns + ";" +  " - " + ";"+ this.name;
		}
		
	}
}
