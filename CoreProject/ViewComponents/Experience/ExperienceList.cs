﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceManager.GetAll();
            return View(values);
        }
    }
}
