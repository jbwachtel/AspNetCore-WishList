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
        public ApplicationDBContext()
        {
        }

        public ApplicationDBContext() : base(options)
        {
            var DbContextOptions(options);
        }

        public var Items(DbSet<Item>)
        {
            get{}
            set{ }
        }
    }
}
