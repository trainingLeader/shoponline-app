using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class ShopApiContext : DbContext
    {
        public ShopApiContext(DbContextOptions options) : base(options)
        {
        }
    }
}