using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace _305_Task3
{
	class Program
	{
		static void Main()
		{
			XmlTextReader reader = new XmlTextReader("TelephoneBook.xml");

			while (reader.Read())
			{
				if (reader.Name.Equals("Contact"))
				{
					Console.WriteLine(reader.GetAttribute("TelephoneNumber"));
				}
			}

			reader.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
