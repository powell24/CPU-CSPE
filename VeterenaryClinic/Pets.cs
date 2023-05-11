using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterenaryClinic
{
	public class Pets
	{
		public String name { get; set; }
		public String type { get; set; }
		public String color { get; set; }
		public double weight { get; set; }
		public double length { get; set; }

		public Pets()
		{
			name = "";
			type = "";
			color = "red";
			weight = 0;
			length = 0;
		}

		public Pets(String name, String type, String color, double weight, double length)
		{
			this.name = name;
			this.type = type;
			this.color = color;
			this.weight = weight;
			this.length = length;
		}

		public String GetPetDetails()
		{
			return "Name: " + name
				+ "\nType: " +type
				+ "\nColor: " +color
				+ "\nWeight: " +weight
				+ "\nLength: " +length + "\n";
		}
	}
}
