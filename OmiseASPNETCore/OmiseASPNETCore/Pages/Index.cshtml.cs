using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OmiseASPNETCore.Pages
{
    public class IndexModel : PageModel
    {
        public string PublicKey { get; private set; } = OmiseKeys.PublicKey;
        public void OnGet()
        {

        }
    }
}
