using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPay.Data;
using EPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EPay.Pages.Payments
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public IActionResult OnPost()
        {
            Payment.TimeCreated = DateTime.Now;
            _db.Payments.Add(Payment);
            _db.SaveChanges();

            return RedirectToPage("./index");
        }
    }
}
