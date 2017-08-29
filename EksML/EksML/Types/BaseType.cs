/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 17.5.2017
 * Time: 12:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	/// <summary>
	/// Description of BaseType.
	/// </summary>
	public class BaseType
	{
		protected string name;
		protected string desc;
		protected string ns;
		
		protected gmlType gType;
		
		public BaseType()
		{
			
		}
		
		public string getNs()
		{
			return this.ns;
		}
		
		public gmlType getType()
		{
			return this.gType;
		}
		
		
		public virtual string getDescription()
		{
			return Common.summary(this.desc);
		}
		
		public virtual string getDescriptionText()
		{
			return this.desc;
		}
		
		public string getCleanName()
		{
			return Common.removeNs(this.name);
		}
		
		public string getRawName()
		{
			return this.name;
		}
		
		public bool isSimpleType()
		{
			return this.gType == gmlType.SimpleType;
		}
	}
}
