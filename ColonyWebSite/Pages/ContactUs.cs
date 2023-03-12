﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColonyWebSite.Pages
{
    public class ContactUsModel : PageModel
    {
        private readonly ILogger<ContactUsModel> _logger;

        public ContactUsModel(ILogger<ContactUsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
