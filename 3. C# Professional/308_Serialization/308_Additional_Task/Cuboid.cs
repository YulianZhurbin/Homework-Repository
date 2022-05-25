using System;
using System.Xml.Serialization;

namespace _308_Additional_Task
{
	public class Cuboid
	{
		double dx = 10;
		double dy = 5;
		double dz = 5;
		bool isSolid = false;
		string sampleNumber = "4";

		[XmlElement("Length")]
		public double Dx
		{
			get { return dx; }
			set { dx = value; }
		}

		[XmlElement("Width")]
		public double Dy
		{
			get { return dy; }
			set { dy = value; }
		}

		[XmlElement("Height")]
		public double Dz
		{
			get { return dz; }
			set { dz = value; }
		}

		[XmlIgnore]
		public bool IsSolid
		{
			get { return isSolid; }
			set { isSolid = value; }
		}

		[XmlAttribute("SampleNumber")]
		public string SampleNumber
		{
			get { return sampleNumber; }
			set { sampleNumber = value; }
		}
	}
}
