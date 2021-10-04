using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDBContext : DBContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public (DbSet<Item>) Items { get; set; }
    }
}
