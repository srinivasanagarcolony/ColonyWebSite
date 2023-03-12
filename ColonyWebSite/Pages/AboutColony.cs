using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyWebSite.Pages
{
    public class AboutColonyModel : PageModel
    {
        private readonly ILogger<AboutColonyModel> _logger;

        public AboutColonyModel(ILogger<AboutColonyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
