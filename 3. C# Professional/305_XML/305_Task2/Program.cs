using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace _305_Task2
{
	class Program
	{
		static void Main()
		{
			FileStream xmlDocument = new FileStream("TelephoneBook.xml", FileMode.Open);

			StreamReader reader = new StreamReader(xmlDocument);

			string line;
			do
			{
				line = reader.ReadLine();
				Console.WriteLine(line);
			}
			while (line != null);

			reader.Close();
			xmlDocument.Close();

			Console.WriteLine(new string('-', 80));

			xmlDocument = new FileStream("TelephoneBook.xml", FileMode.Open);

			XmlTextReader xmlReader = new XmlTextReader(xmlDocument);

			while (xmlReader.Read())
			{
				Console.WriteLine("NodeType: {0,-15}|NodeName: {1,-15}|NodeValue: {2,-15}",
					xmlReader.NodeType,
					xmlReader.Name,
					xmlReader.Value);
			}

			xmlReader.Close();
			xmlDocument.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
