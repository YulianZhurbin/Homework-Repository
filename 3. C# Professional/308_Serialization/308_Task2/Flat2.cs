using System;
using System.Xml.Serialization;

namespace _308_Task2
{
	public class Flat2
	{
		double overallArea = 45.4;
		double kitchenArea = 10.3;
		int roomNumber = 2;

		[XmlAttribute]
		public double OverallArea
		{
			get { return overallArea; }
			set { overallArea = value; }
		}

		[XmlAttribute]
		public double KitchenArea
		{
			get { return kitchenArea; }
			set { kitchenArea = value; }
		}

		[XmlAttribute]
		public int RoomNumber
		{
			get { return roomNumber; }
			set { roomNumber = value; }
		}
	}
}
