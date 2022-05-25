using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _305_AdditionalTask
{
	class Program
	{
		static void Main()
		{

			FileStream xmlDocument = File.Create("TelephoneBook.xml");
			xmlDocument.Close();

			var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);
			xmlWriter.Formatting = Formatting.Indented;

			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("MyContacts");
			xmlWriter.WriteStartElement("Contact");
			xmlWriter.WriteStartAttribute("TelephoneNumber");
			xmlWriter.WriteString("8-916-088-36-45");
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteString("John");
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();

			xmlWriter.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
