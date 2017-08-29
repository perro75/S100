/*
 * EksML reads S-100 based application schemas, and writes C# code.
 * 15.5.2017, tested on current versions of S-122, S-123, S-201
 */
 
using System;
using System.Diagnostics;

namespace EksML
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			//set to open the generated file in the default application after creation.
			bool show = false;
			
			//print cs-files of XSD
			
			printCode("s100\\S100_gmlProfile.xsd", fileType.GmlProfile, "gml",  "S100gmlProfile.cs", show);
			printCode("s100\\S100gmlbase.xsd", fileType.GmlProfile,  "S100",  "S100gmlbase.cs", show);
			printCode("s100\\S100gmlbaseExt.xsd", fileType.GmlProfile, "S100EXT",  "S100gmlbaseExt.cs", show);
			printCode("s100\\S122.xsd", fileType.GmlProfile, "S122",  "S122.cs", show);
			printCode("s100\\S123.xsd", fileType.GmlProfile,"S123",  "S123.cs", show);
			printCode("s100\\S201.xsd", fileType.GmlProfile,"S201",  "S201.cs", show);
			
			new QuickFixWriter().writeQuickFixCsCode();
				
			//Console.Write("Press any key to continue . . . ");
			//Console.ReadKey(true);
		}
		
		public static void printCode(string inFileName, fileType fType, string schemaNameSpace, string outFileName, bool showFile)
		{
			
			XmlReader appReader = null;
				
			// convert type
			if (fType == fileType.GmlProfile)
			{
				appReader = new GmlProfileReader(inFileName, schemaNameSpace);
			}
			else
			{
				//create fileReader
				appReader = new XmlReader(inFileName, schemaNameSpace);
			}
			
			//create CS- code of application schema
			appReader.printCsCode(outFileName);
						
			//show outfile in default application
			if(showFile)
				Process.Start(outFileName);
		}
	}
}