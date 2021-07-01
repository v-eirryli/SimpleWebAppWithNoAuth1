﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleWebAppWithNoAuth1.Models;

namespace SimpleWebAppWithNoAuth1.Pages.Blogs
{
    public class IndexModel : PageModel
    {
        private readonly SimpleWebAppWithNoAuth1.Models.BloggingContext _context;

        public IndexModel(SimpleWebAppWithNoAuth1.Models.BloggingContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blogs.ToListAsync();
        }
    }
}
