using System;
using System.IO;
using System.Xml.Serialization;

namespace _308_Task3
{
	class Program
	{
		static void Main()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Flat1));

			FileStream stream = new FileStream("Serialization1.xml", FileMode.Open, FileAccess.Read);

			Flat1 flat1 = new Flat1();

			flat1 = serializer.Deserialize(stream) as Flat1;

			Console.WriteLine("Apartment area: {0}\nKitchen area: {1}\nNumber of rooms: {2}", flat1.OverallArea, 
																			flat1.KitchenArea, flat1.RoomNumber);
			stream.Close();

			//Delay
			Console.ReadKey();
		}
	}
}
