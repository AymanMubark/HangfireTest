using System;
using Hangfire;
using HangfireTest.Data;
using Microsoft.Extensions.DependencyInjection;

namespace HangfireTest
{
    public class MessageService
    {
        IServiceProvider _serviceProvider;
        public MessageService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Send()
        {
            using (IServiceScope scope = _serviceProvider.CreateScope())
            using (ApplicationDbContext ctx = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                var auction = ctx.Auctions.Find(1);
                Console.WriteLine(auction.Name);
            }
        }
    }
}