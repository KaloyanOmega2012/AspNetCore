﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaForums.Data;
using LambdaForums.Data.Models;
using LambdaForums.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel
                {
                    Id = forum.Id,
                    Name = forum.Titlle,
                    Description = forum.Descriptiom
                });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }
    }
}