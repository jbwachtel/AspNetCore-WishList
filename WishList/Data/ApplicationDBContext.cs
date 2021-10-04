using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DBContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public (DbSet<Item>, object) Items { get; set; }
    }
}
