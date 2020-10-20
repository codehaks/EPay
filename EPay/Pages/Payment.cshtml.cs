using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EPay.Pages
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public Payment Payment { get; set; }

        public void OnPost()
        {

        }
    }
}
