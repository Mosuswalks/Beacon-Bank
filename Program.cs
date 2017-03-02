using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace assignment1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var Client1 = new Mohamed_Savings_Acccount();
			WriteLine("Plese Enter Your First Name: ");
			Client1.FirstName = ReadLine();
			WriteLine("Plese Enter Your Last Name: ");
			Client1.LastName = ReadLine();
			WriteLine("Plese Enter Your Social Insurance: ");
			Client1.SocInsur = ReadLine();
			WriteLine("Please Enter Your Address: ");
			Client1.homeAddress = ReadLine();
			Write("Please Enter the Opening Balance: ");
			Client1.openBalance = decimal.Parse(ReadLine());
			WriteLine("Opening Balance: {0:C}", Client1.openBalance);

			decimal balance = Client1.calcAccountBalance(Client1.openBalance);
			WriteLine("Your Current Balance is: {0:C}",balance);

			WriteLine("\n{0} - {1} - {2} - {3}", Client1.FirstName, Client1.LastName, Client1.SocInsur, Client1.homeAddress);

			var Client2 = new Mohamed_Savings_Acccount();
			Write("\nPlese Enter Your First Name: ");
			Client2.FirstName = ReadLine();
			Write("\nPlese Enter Your Last Name: ");
			Client2.LastName = ReadLine();
			Write("\nPlese Enter Your Social Insurance: ");
			Client2.SocInsur = ReadLine();
			Write("\nPlease Enter Your Address: ");
			Client2.homeAddress = ReadLine();
			Write("Please Enter the Opening Balance: ");
			Client2.openBalance = decimal.Parse(ReadLine());
			WriteLine("Opening Balance: {0:C}", Client2.openBalance);

			decimal balance2 = Client2.calcAccountBalance(Client2.openBalance);
			WriteLine("Your Current Balance is: {0:C}", balance2);

			WriteLine("\n{0} - {1} - {2} - {3}", Client2.FirstName, Client2.LastName, Client2.SocInsur, Client2.homeAddress);

			WriteLine("\n\t**********************************************************************");
			WriteLine("\n\t\t\t Client Statement");
			WriteLine("\t\t\t   Client Name: "  + Client1.FirstName + " " + Client1.LastName);
			WriteLine("\t\t\t   Social Insurance Number: " + Client1.SocInsur);
			WriteLine("\t\t\t   Home Address: " + Client1.homeAddress);
			WriteLine("\t\t\t   Opening Balance: {0:C}", Client2.openBalance);



			ReadKey();
		}
	}
}
