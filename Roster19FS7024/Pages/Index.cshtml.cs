using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Roster19FS7024.Pages
{
    
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Shortcut shortcut { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["ShortcutList"] = ShortcutRoster.allShortcuts;
        }

        public void OnPost()
        {
            // update the local map. 
            string stuff = shortcut.FirstName + shortcut.LastName + shortcut.KeyboardShortcut + shortcut.Software + shortcut.WhatDo;
            ShortcutRoster.allShortcuts.Add(shortcut);

            ViewData["ShortcutList"] = ShortcutRoster.allShortcuts;
        }
    }
}
