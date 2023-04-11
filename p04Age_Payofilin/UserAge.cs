using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p04Age_Payofilin
{
	internal class UserAge
	{
		public int age { get; set; }
		public string message;

		public UserAge()
		{
			age = 0;
		}

		private void calcAge()
		{
			while (true)
			{
				Console.Write("Enter your age: ");
				age = int.Parse(Console.ReadLine());
				if (age < 13) 
				{
					Console.WriteLine("Sorry. Try again");
					Console.WriteLine();
				}

				else if (age >= 13)
				{
					message = "Welcome!!";
					break;
				}
			}
		}

		public string getAge()
		{
			calcAge();
			return message; 
		}
	}
}
