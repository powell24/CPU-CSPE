using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterenaryClinic
{
	public class Dogs : Pets
	{
		public DateTime birthdate { get; set; }
		private int age;
		public double height { get; set; }


		public Dogs() : base()
		{
			birthdate = DateTime.Now;
			height = 0;
		}

		public Dogs(String name, String type, DateTime birthdate, String color, double weight, double height, double length)
			: base(name, type, color, weight, length)
		{

			{
				this.birthdate = birthdate;
				this.height = height;
			}

		}

		private void CalcAge()
		{
			age = DateTime.Now.Year - birthdate.Year;
			if(DateTime.Now.Month < birthdate.Month
				|| (DateTime.Now.Month == birthdate.Month &&
				DateTime.Now.Day < birthdate.Day))
			{
				age--;
			}
		}

		public int GetAge()
		{
			CalcAge();
			return age;
		}

		public String GetDogDetails()
		{
			return GetPetDetails() +
				"Birthdate: " + birthdate
				+ "\nAge: " + GetAge()
				+ "\nHeight: " + height + "\n";
		}
	}
}
