using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Roster19FS7024.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KeyboardShortcut { get; set; }
        public string Software { get; set; }
        public string WhatDo { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            // update the local map.
            string stuff = FirstName + LastName + KeyboardShortcut + Software + WhatDo;
            Console.WriteLine(stuff);
        }
    }
}
