using ChiFouMi.Decompte;
using ChiFouMi.Demarrage;
using ChiFouMi.Execution;
using ChiFouMi.Joueur;
using ChiFouMi.Juge;
using ChiFouMi.Ordinateur;
using ChiFouMi.Tour;
using Microsoft.Extensions.DependencyInjection;

namespace ChiFouMi
{
    class Program
    {
        static void Main()
        {
            var services = new ServiceCollection()
                .AddSingleton<IDemarrage, Demarrage.Demarrage>()
                .AddSingleton<IExecution, Execution.Execution>()
                .AddSingleton<IJoueur, Joueur.Joueur>()
                .AddSingleton<IOrdinateur, Ordinateur.Ordinateur>()
                .AddSingleton<IJuge, Juge.Juge>()
                .AddSingleton<ITour, Tour.Tour>()
                .AddSingleton<IDecompte, Decompte.Decompte>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetService<IExecution>();
            service.Go();
        }
    }
}
