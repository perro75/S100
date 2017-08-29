/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 31.5.2017
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace EksML
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class DebugWriter
	{
		private StreamWriter writer;
		
		public DebugWriter(string filename)
		{
			this.writer = new StreamWriter(filename);
		}
		
		public void close()
		{
			this.writer.Close();
		}
		
		public void wl(string data)
		{
			this.writer.WriteLine(data);
		}
	}
}
