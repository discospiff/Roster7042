using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Roster19FS7024.Pages
{
    public class FeedModel : PageModel
    {
        public JsonResult OnGet()
        {
            return new JsonResult(ShortcutRoster.allShortcuts);
        }
    }
}