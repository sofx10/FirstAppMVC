using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstApp.Models;

namespace firstApp.Controllers
{
    public class PersonalController : Controller
    {
        
        public IActionResult index()
        {
            Personal personal = new Personal();            
            personal.name ="Sofia Gissell";
            personal.lastname ="Hernandez Ascencio";
            personal.age = 17;
            personal.Gmail = "sofihernandez059@gmail.com";
            personal.Mobile = 74190930;
            personal.Direction ="Jucuapa, Usulutan";

            return View(personal); //pasa el objeto a la vista
        }
    }   
}