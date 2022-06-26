﻿using System.ComponentModel.DataAnnotations;

namespace BudgetWebApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public TransactionType TransactionType { get; set; }

    }

    public enum TransactionType
    {
        [Display(Name = "Income")]
        Income = 1,

        [Display(Name = "Income")]
        Expense = 2
    }
}
