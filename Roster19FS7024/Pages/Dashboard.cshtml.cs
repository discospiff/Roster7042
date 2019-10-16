using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Roster19FS7024
{
    public class DashboardModel : PageModel
    {

        IList<Shortcut> shortcuts { get; set; }

        public void OnGet()
        {
            shortcuts = ShortcutRoster.allShortcuts;
            ViewData["ShortcutList"] = shortcuts;
        }
    }
}
