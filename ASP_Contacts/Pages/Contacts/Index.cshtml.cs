using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesContact.Data;
using RazorPagesContact.Models;

namespace ASP_Contacts.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesContact.Data.RazorPagesContactContext _context;

        public IndexModel(RazorPagesContact.Data.RazorPagesContactContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
