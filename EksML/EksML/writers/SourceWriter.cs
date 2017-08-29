/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 26.5.2017
 * Time: 1.49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace EksML
{
	/// <summary>
	/// Description of SourceWriter.
	/// </summary>
	public class SourceWriter
	{
		private StreamWriter writer;
		private string ns;
		
		public SourceWriter(string filename, string ns)
		{
			this.writer = new StreamWriter(filename);
			this.ns = ns;
			this.writeHeader();
		}
		
		public void close()
		{
			this.writeFooter();
			this.writer.Close();
		}
		
		private void writeHeader()
		{
			this.writer.WriteLine(Common.nl("//EksML - S100 application schema to csCode " + DateTime.Now, false, false));
			this.writer.WriteLine(Common.nl("using System;", true, false));
			this.writer.WriteLine(Common.nl("using System.ComponentModel;", false, true));
			this.writer.WriteLine(Common.nl("using gml;", false, true));
			this.writer.WriteLine(Common.nl("namespace " + this.ns + " {", true, true));
		}
		
		private void  writeFooter()
		{
			this.writer.WriteLine(Common.nl("}", false, true));

		}
		
		public void writeSimple(SimpleType[] sArr, int count)
		{
			for(int i=0; i < count; i++)
			{
				this.writer.WriteLine(sArr[i].printCsCode());
			}
		}
		
		public void writeComplex(ComplexType[] sArr, int count)
		{
			for(int i=0; i < count; i++)
			{
				this.writer.WriteLine(sArr[i].printCsCode(ns));
			}
		}
		
		public void writeElement(Element[] sArr, int count)
		{
			string classDefs = "";
			
			for(int i=0; i < count; i++)
			{
				if (sArr[i] == null)
					continue;
				
				if (sArr[i].getElementPrintType() == ElementType.NoTypeDefinition)
				{
					classDefs += sArr[i].printCsCode(ns);
				}
				else
				{
					this.writer.WriteLine(sArr[i].printCsCode(ns));
				}
			}
			
			//write all using directives first
			this.writer.WriteLine(classDefs);
		}
		
	}
}
