using System;
using System.Xml.Serialization;
using System.IO;

namespace _308_Task2
{
	class Program
	{
		static void Main()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Flat1));

			FileStream stream = new FileStream("Serialization1.xml", FileMode.Create, FileAccess.Write);

			Flat1 flat1 = new Flat1();

			serializer.Serialize(stream, flat1);

			stream.Close();


			serializer = new XmlSerializer(typeof(Flat2));

			stream = new FileStream("Serialization2.xml", FileMode.Create, FileAccess.Write);

			Flat2 flat2 = new Flat2();

			serializer.Serialize(stream, flat2);

			stream.Close();
		}
	}
}
