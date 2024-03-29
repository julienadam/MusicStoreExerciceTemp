﻿using Microsoft.AspNetCore.Mvc;
using MusicStore.Domain;
using MusicStore.Entities;
using MusicStore.Models;

namespace MusicStore.Controllers;

public class CustomerController : Controller
{
    private readonly ICustomerRepository repository;

    public CustomerController(ICustomerRepository customers)
    {
        this.repository = customers;
    }

    public IActionResult Create()
    {
        CustomerCreateViewModel model = new CustomerCreateViewModel
        {
            Email = ""
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Create(CustomerCreateViewModel model)
    {
        if(repository.IsEmailTaken(model.Email))
        {
            ModelState.AddModelError("Email", "Email déja utilisé");
        }

        if (ModelState.IsValid)
        {
            var customer = new Customer
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                // ...
            };
            repository.CreateCustomer(customer);

            // Redirection vers la page de liste des clients
            return RedirectToAction("Index");
        }
        else
        {
            return View(model);
        }
    }


    public IActionResult Index()
    {
        var customers = repository.GetAllCustomers();


        return View(customers);
    }
}