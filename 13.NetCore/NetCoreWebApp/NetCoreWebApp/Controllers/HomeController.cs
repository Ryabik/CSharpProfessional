using Microsoft.AspNetCore.Mvc;
using NetCoreWebApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICharacterRepository characterRepository;

        public HomeController(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }

        public string Index()
        {
            return characterRepository.Characters.FirstOrDefault().FirstName;
        }

        public ViewResult Data()
        {
            var character = characterRepository.Characters.FirstOrDefault();
            return View(character);
        }

        public ViewResult All()
        {
            ViewData["Characters"] = characterRepository.Characters;
            return View();
        }
    }
}
