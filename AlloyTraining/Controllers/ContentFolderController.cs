﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class ContentFolderController : PartialContentController<ContentFolder>
    {
        private readonly IContentLoader _loader;

        public ContentFolderController(IContentLoader loader)
        {
            _loader = loader;
        }

        public override ActionResult Index(ContentFolder currentContent)
        {
            var viewModel = new ContentFolderViewModel
            {
                CurrentFolder = currentContent,
                ItemsCount = _loader.GetChildren<IContent>(currentContent.ContentLink).Count()
            };

            return PartialView(viewModel);
        }
    }
}
