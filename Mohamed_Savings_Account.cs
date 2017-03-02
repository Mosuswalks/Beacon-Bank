using System;
namespace assignment1
{
	class Mohamed_Savings_Acccount
	{
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value;}
		}
		public string LastName
		{
			get;
			set;
		}

		public string SocInsur
		{
			get;
			set;
		}
		public string homeAddress
		{
			get;
			set;
		}
		public decimal openBalance
		{
			get;
			set;
		}

		private decimal initWith { get; set; }
		public decimal fundDepo { get; set; }
		public decimal transctionFee { get; set; }
		public decimal finalBalance { get; set; }

		public decimal calcAccountBalance(decimal oBalance)
		{
			decimal interestRate = .1m, monthlyFee = 5, transFee = 5;

			oBalance = openBalance + (openBalance * interestRate) - transFee - monthlyFee;

			return oBalance;
		}

	}
}