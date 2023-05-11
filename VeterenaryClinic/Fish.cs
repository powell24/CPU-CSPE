using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterenaryClinic
{
	public class Fish : Pets
	{
		public Fish() :base()
		{

		}

		public Fish(String name, String type, String color, double weight, double length) : base(name, type, color, weight, length)
		{

		}

		public String GetFishDetails()
		{
			return GetPetDetails();
		}
	}
}
