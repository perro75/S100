/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 1.6.2017
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EksML
{
	/// <summary>
	/// Description of QuickFixWriter.
	/// </summary>
	public class QuickFixWriter
	{
		private SimpleType[] simpleTypes  = new SimpleType[50];
		
		public void writeQuickFixCsCode()
		{
			var sw = new SourceWriter("QuickFixesGml.cs", "gml");
			var index = 0;
			
			string[] intComponents = { "nonNegativeInteger", "positiveInteger", "integer", "duration"};
			foreach(string component in intComponents)
			{
				simpleTypes[index++] = new SimpleType(component, "int", null, null, "gml");
			}
			
			string[] stringComponents = {"gDay", "gMonth", "gMonthDay", "gYear", "gYearMonth","anyURI", "Name", "ID"};
			foreach(string component in stringComponents)
			{
				simpleTypes[index++] = new SimpleType(component, "string", null, null, "gml");
			}
			
			string[] dateComponents = {"date", "dateTime"};
			foreach(string component in dateComponents)
			{
				simpleTypes[index++] = new SimpleType(component, "DateTime", null, null, "gml");
			}
			
			simpleTypes[index++] = new SimpleType("boolean", "bool", null, null, "gml");
			simpleTypes[index++] = new SimpleType("time", "TimeSpan", null, null, "gml");
			
			sw.writeSimple(simpleTypes, index);
			sw.close();
		}
		
	}
}
