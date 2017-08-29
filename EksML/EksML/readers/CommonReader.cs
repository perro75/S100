/*
 * Created by SharpDevelop.
 * User: L708383
 * Date: 25.5.2017
 * Time: 19.53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;

namespace EksML{
	
	/// <summary>
	/// Description of CommonReader.
	/// </summary>
	public static class CommonReader
	{
		public static string readNodeAttribute(XmlNode node, string attribute)
		{
			if (node == null)
				return null;
			
			var node_attribute = node.Attributes.GetNamedItem(attribute);
			
			if (node_attribute == null)
				return null;
			
			return node_attribute.InnerText;
		}
		
		public static string readInnerText(XmlNode node)
		{
			if (node == null)
			return null;
			
			return node.InnerText;
		}
		
		public static string readParentTag(XmlNode node)
		{
			if (node == null)
			return null;
			
			return node.ParentNode.Name;
		}
	}
}
