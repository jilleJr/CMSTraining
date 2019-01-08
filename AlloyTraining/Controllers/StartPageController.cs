﻿using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public StartPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(StartPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));
        }
    }
}