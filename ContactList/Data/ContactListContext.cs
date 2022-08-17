using ContactList.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactList.Data
{
    public class ContactListContext : DbContext
    {
        
        public ContactListContext(DbContextOptions<ContactListContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
