using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Infrastructure
{
    class WorkContextFactory:IDesignTimeDbContextFactory<WorkContext>
    {
        public WorkContextFactory()
        {

        }
        public WorkContext CreateDbContext(string[] args)
        {
            return new WorkContext(@"Server=LAPTOP-R308IB89\SQLEXPRESS;Database=WorkersMigration;Trusted_Connection=True;");
        }
    }
}
