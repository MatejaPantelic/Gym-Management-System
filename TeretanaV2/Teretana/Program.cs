using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces;
using Shared.Models;
using TeretanaBusiness;
using Microsoft.Extensions.DependencyInjection;
using TeretanaData;


namespace Teretana
{
     static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services= new ServiceCollection();
            ConfigureServices(services);



            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var prijav = serviceProvider.GetRequiredService<Prijavljivanje>();
                Application.Run(prijav);
            }
            
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ITrenerBusiness, TrenerBusiness>();
            services.AddScoped<ITrenerRepository, TrenerRepository>();
            services.AddScoped<IKorisnikBusiness, KorisnikBusiness>();
            services.AddScoped<IKorisnikRepository, KorisnikRepository>();
            services.AddScoped<IVezbaBusiness, VezbaBusiness>();
            services.AddScoped<IVezbaRepository, VezbaRepository>();


            services.AddScoped<EvidencijaKorisnika>();
            services.AddScoped<Prijavljivanje>();
            services.AddScoped<RegistracijaTrenera>();
        }
    }
}
