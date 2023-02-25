using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContextFactory
{
    public interface IDbContextFactory
    {
        //DbContext CreateDbContext(int tenantId);
        DbContext CreateDbContext();
    }
}
