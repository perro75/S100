/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 15.5.2017
 * Time: 9:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	/// <summary>
	/// Class holds and prints attributes for ComplexTypes.
	/// </summary>
	public class ComplexTypeAttribute
	{
		
		private string name;
		private string type;
		private bool isOptional;
		private int sizeMax;
		private bool isInherited;
		private string ns;
		
		public ComplexTypeAttribute(string name, string type, bool isOptional, int sizeMax, bool isInherited, string ns)
		{
			this.name = name;
			this.type = Common.removeNs(type);
			this.isOptional = isOptional;
			this.sizeMax = sizeMax;
			this.isInherited = isInherited;
			this.ns = ns;
		}
		
		public string getNs()
		{
			return this.ns;
		}
			
		public bool isDuplicate(ComplexTypeAttribute check)
		{
			return (this.getName() == check.getName() && this.getType() == check.getType());
		}
			
		public string getName()
		{
			return this.name;
		}
		
		public string getType()
		{
			return this.type;
		}
		
		
		public int getSizeMax()
		{
			return this.sizeMax;
		}
		
		public bool isOptionalAttribute()
		{
			return this.isOptional;
		}
		
		public bool isInheritedAttribute()
		{
			return this.isInherited;
		}
		
		public string printConstructorDefinition(string ns_parent)
		{
			var ns_use = this.ns.Equals(ns_parent) ? "" : this.ns + ".";
			return ns_use + this.getType() + this.arrMark() + " " + this.getName();
		}
		
		public string printConstructorSetter()
		{
			return "this." + this.getName() + "=" + this.getName();
		}
		
		public string printBaseAttribute()
		{
			return this.getName();
		}
		
		public string printDefinition(string ns_parent)
		{
			var ns_use = this.ns.Equals(ns_parent) ? "" : this.ns + ".";
			
			var convType = ns_use + this.getType() + this.arrMark();
			var cleanName = this.getName();
			var arrInit = this.addArrayInit();
			
			//REMOVED array init
			return "\r\n\t" + "public " + convType + " " + cleanName + ";";
		}
		
		private string arrMark()
		{
			return this.sizeMax > 1 ? "[]" : "";
		}
				
		private string addArrayInit()
		{
			var typ = this.type;
			var sz = this.sizeMax;
			return sz > 1 ? " = new " + typ + "[" + sz + "]" : "";
		}
		
		public string printDebugLine(string printRequester)
		{
			return ";ComplexTypeAttribute;" + this.ns + ";" +  this.type + ";"+ this.name + ";" + ((isOptional) ? "Optional" : "Mandatory") + ";"+ ((isInherited) ? "Inherited" : "Defined");
		}
	}
}
