using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;

namespace Notes.Models.Controllers
{
    public class TestController : Controller

    {
        private readonly NotesContext db;

        public TestController(NotesContext context)
        {
            db = context;
        }

        public string AddNote(string title, string body)
        {
            Note newNote = new Note()
            {
                Title = title,
                Body = body
            };

            db.Notes.Add(newNote);
            db.SaveChanges();
            return "ok";

        }

        public JsonResult CheckNotes()
        {
            return Json(db.Notes);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}