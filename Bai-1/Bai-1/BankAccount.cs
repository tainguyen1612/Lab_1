﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class BankAccount
    {
        private int id;
        private double balance;

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
