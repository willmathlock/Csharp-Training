﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    public class Transaction
    {
        // Properties
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes
        {
            get;

        }

        // Constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
