/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 11.5.2017
 * Time: 16:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	public enum fileType
	{
		ApplicationShema,
		GmlBase,
		GmlProfile
	}
	
	public enum gmlType
	{
		SimpleType,
		ComplexType
	}
	
	public enum ElementType
	{
		ExtendsComplexType,
		SameNameAsCompexType,
		NoTypeDefinition
	}
	
	
	/// <summary>
	/// Static class containing common functions needed for several purposes.
	/// </summary>
	public static class Common
	{
		// return string in double newlines
		public static string  nlT1(string data, bool before, bool after)
		{
			var bf = before ? "\r\n" : "";
			var af = after? "\r\n" : "";
			data = "\t" + data.Replace("\r\n", "\r\n\t");
			return  bf + data + af;
		}

		// return string in double newlines
		public static string  nl(string data, bool before, bool after)
		{
			var bf = before ? "\r\n" : "";
			var af = after? "\r\n" : "";
			return  bf + data + af;
		}
		
		private static string cleanComment(string original)
		{
			if (original == null)
				return "";
			
			return System.Text.RegularExpressions.Regex.Replace(original.Trim().Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ").Replace("\t", " "), " {2,}", " ");
		}
		
		// return string in double newlines
		public static string  comment(string data)
		{
			//add comment if linebreak
			data = "//" + cleanComment(data);
			
			return  nl(data, true, false);
		}		
		
		// return string in double newlines
		public static string  summary(string data)
		{
			//add comment if linebreak
			data = "///" + cleanComment(data);
			
			return  nl("///<summary>", true, true) + data + nl("///</summary>", true, true);
		}		
		
		// return string in double newlines
		public static string  summaryT1(string data)
		{
			//add comment if linebreak
			data = "\t///" + cleanComment(data);
			
			return  nl("\t///<summary>", true, true) + data + nl("\t///</summary>", true, true);
		}
		
		public static string getNs(string name)
		{
			if (name == null)
				return null;
			
			if (name.IndexOf(':') < 1)
				return null;
			
			return name.Split(':')[0];
			
		}
		
		
		public static string removeNs(string name)
		{
			
			if (name == null)
				return null;
			
					var item = name.Replace(' ', '_');
					item = item.Replace(',', '_');
					item = item.Replace('/', '_');
					item = item.Replace('(', '_');
					item = item.Replace(')', '_');
					item = item.Replace('-', '_');
					item = item.Replace('.', '_');
					name = item.Replace('\'', '_');
					
					if (name.IndexOf(':') > 0)
						name = name.Split(':')[1];
			
					
			return convertBaseType(name);
		}
		
		public static string convertBaseType(string type)
		{
			switch (type)
			{
				case "list_double":
					return "double[]";
					
				case "boolean":
					return "boolean";
				
				case "integer":
					return "integer";
			}
			
			return type;
		}
		
		/// <summary>
		/// Convert xs- types to C#
		/// TODO: Add definitions of the missing types!
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		private static string convertType(string type, string name)
		{
			switch (type)
			{
				case "xs:boolean":
					return "bool";
				
				case "xs:integer":
				case "xs:int": //XXX S-123 and S-201 uses xs.int
					return "int";
					
				case "xs:string":
				//case "xs:anyURI":
					
				case "S100:DataSetIdentificationType":
				case "S100:DataSetStructureInformationType":
					return "string";

				/*<list itemType="double"/> is returned as list:double*/
				case "list_double":
					return "double[]";
					
				case "xs:gDay":
				case "xs:gMonth":
				case "xs:gYear":
				case "xs:gMonthDay":
				case "xs:gYearMonth":
					return "string";
				
				case "xs:double":
				case "xs:decimal":
					return "double";
				
				case "xs:date":
				case "xs:dateTime":
					return "DateTime";
				
				case "xs:duration":
				case "xs:time":					
					return "TimeSpan";
					
				case "S100EXT:PointPropertyType":
				case "S100EXT:CurvePropertyType":
				case "S100EXT:SurfacePropertyType":
				case "S100EXT:PointOrSurfacePropertyType":
				case "S100EXT:PointCurveSurfacePropertyType":
					
				//case "gml:AbstractFeatureType":
				//case "S100:AbstractFeatureType":
				//case "S100:AbstractInformationType":
				//case "gml:AbstractFeatureMemberType":
					
					return "object";
				
				case "gml:ReferenceType":
					return lookupReference(name);
					
				default:
					return cleanUp(type);
			}
		}
		
		//get type of asociated object based on role-name
		//type in gml is always gml:referenceType
		private static string lookupReference(string name)
		{
			switch(name)
			{
				case "appliesInLocation":
						return "FeatureType";
			
				case "isApplicableTo":
					return "ApplicabilityType";

				case "theOrganisation":
					return "Authority";
				
				case "providesInformation":
					return "InformationTypeType";
					
				default:
					return "object";
			}
		}
		
		/// <summary>
		/// check names for reserved words and illegal naming
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private static string checkReserved(string name)
		{
			string[] reserved = new string[3];
			
			reserved[0] = "private";
			reserved[1] = "public";
			reserved[2] = "fixed";
			
			foreach( string word in reserved)
			{
				if ( word.Equals(name))
				{
					return "_" + name;
				}
			}
			
			//starting with digit not allowed
			if (Char.IsDigit(name[0]))
		    {
		    	return "_" + name;
		    }
			    
			return name;
		}
		
		//clean illegal characters
		public static string cleanUp(string item)
		{
			switch (item)
			{
				case "-":
					return "minus";
				case "+":
					return "plus";
					
				default:
					item = item.Replace(' ', '_');
					item = item.Replace(',', '_');
					item = item.Replace('/', '_');
					item = item.Replace('(', '_');
					item = item.Replace(')', '_');
					item = item.Replace('-', '_');
					item = item.Replace('.', '_');
					item = item.Replace('\'', '_');
					
					//namespaces
					item = item.Replace("s100:", "S100.");
					item = item.Replace("S100:", "S100.");
					
					item = item.Replace(':', '_');
					
					item = item.Replace("gml_", "gml.");
					item = item.Replace("xs_double", "xs._double");
					item = item.Replace("xs_", "xs.");
					return checkReserved(item);
			}
						
			
		
		}
	
	}
}
