﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse response)
    {
        if (ModelState.IsValid)
        {
            Repository.AddResponse(response);
            return View("Thanks", response);
        }
        else
        {
            return View();
        }
        
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Responses.Where(r => r.WillAttend ?? false));
    }
}
