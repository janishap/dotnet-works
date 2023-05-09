﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankexeception
{
    internal class BankException:Exception
    { 

        int acc;

        int bal;

        public BankException(int a, int b)

        {

            acc = a;

            bal = b;

        }

        public void inform()

        {

            Console.WriteLine("Account Number: " + acc

         + " Balance left: " + bal);

        }

    }
}
