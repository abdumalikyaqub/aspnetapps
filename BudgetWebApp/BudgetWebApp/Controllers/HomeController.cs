﻿using BudgetWebApp.Models.ViewModels;
using BudgetWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BudgetWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBudgetRepository _budgetRepository;
        public HomeController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public IActionResult Index()
        {
            var transactions = _budgetRepository.GetTransactions();

            var viewModel = new BudgetViewModel
            {
                Transactions = transactions
            };

            return View(viewModel);
        }

        
    }
}