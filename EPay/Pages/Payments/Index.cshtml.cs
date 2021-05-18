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
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;

        }

        public IList<Payment> Payments { get; set; }

        public void OnGet()
        {
            Payments = _db.Payments.ToList();
        }
    }
}
