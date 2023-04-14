using System;


namespace Account
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;


        public void createaccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void displayinfo()
        {
            Console.WriteLine("Account id: "+ Id);
            Console.WriteLine("Account name: "+Name);
            Console.WriteLine("Balance : "+ Balance);
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;

            Console.WriteLine("Now balance is " + Balance);
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 500)
            {
                Console.WriteLine("insufcient balance");

            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Balance after withdrawl : " + Balance);

            }
        }
    }
}

      


