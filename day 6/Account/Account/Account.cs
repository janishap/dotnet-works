using System;


namespace Account
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal _balance;




        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        public void createaccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            _balance = balance;
        }

        public void displayinfo()
        {
            Console.WriteLine("Account id: "+ Id);
            Console.WriteLine("Account name: "+Name);
            Console.WriteLine("Balance : "+ Balance);
        }
        public void Deposit(decimal amount)
        {
            _balance += amount;

            Console.WriteLine("Now balance is " + _balance);
        }
        public void Withdraw(decimal amount)
        {
            if (_balance - amount < 500)
            {
                Console.WriteLine("insufcient balance");

            }
            else
            {
                _balance = _balance - amount;
                Console.WriteLine("Balance after withdrawl : " + _balance);

            }
        }
        public void checkbalance()
        {

            Console.WriteLine(" balance is " + _balance);
            
        }
    }
}

      


