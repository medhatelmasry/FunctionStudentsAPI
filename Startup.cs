using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(FunctionStudentsAPI.Startup))]
namespace FunctionStudentsAPI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var connStr = Environment.GetEnvironmentVariable("CSTRING");
            builder.Services.AddDbContext<SchoolDbContext>(
              option => option.UseSqlServer(connStr));

            builder.Services.AddHttpClient();
        }
    }
}
