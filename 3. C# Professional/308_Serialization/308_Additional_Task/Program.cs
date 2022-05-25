using System;
using System.Xml.Serialization;
using System.IO;

namespace _308_Additional_Task
{
	class Program
	{
		static void Main()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Cuboid));

			Cuboid solid = new Cuboid();

			FileStream stream = new FileStream("Serialisation.xml", FileMode.Create, FileAccess.Write);

			serializer.Serialize(stream, solid);

			stream.Close();

			//Delay
			Console.ReadKey();

		}
	}
}
