/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 24.5.2017
 * Time: 17.45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	/// <summary>
	/// Description of Attribute.
	/// </summary>
	public class Attribut_
	{
		private string name, ns, ele_type, documentation;
		private string group;
		
		public Attribut_(string name, string ns, string ele_type, string documentation)
		{
			this.name = name;
			this.ns = ns;
			this.ele_type = Common.removeNs(ele_type);
			this.documentation = documentation;
		}
		
		public Attribut_(string name, string ns, string ele_type, string documentation, string group)
		{
			this.name = name;
			this.ns = ns;
			this.ele_type = Common.removeNs(ele_type);
			this.documentation = documentation;
			this.group = group;
		}
		
		public string getName()
		{
			return this.name;
		}
		
		public string getNs()
		{
			return this.ns;
		}
		
		public string getNameWithNamespace()
		{
			return this.ns +":"+ this.name;
		}
		
		public string getType()
		{
			return this.ele_type;
		}
		
		public string getGroup()
		{
			return this.group;
		}
		
		public string getGroupWithNamespace()
		{
			return this.ns +":"+ this.group;
		}
		
		public void debug()
		{
			var gName = this.group == null ? "" : this.group + ":";
			var typechar = this.group == null ? "" : "G";
			Console.WriteLine(this.ns + "\t" + "A" + typechar +"\t"+ gName + this.name + "\t" + this.ele_type);
		}
		
		public string printDebugLine(string printRequester)
		{
			return printRequester + ";Attribute;" + this.ns + ";" +  this.ele_type + ";"+ this.name;
		}
	}
}
