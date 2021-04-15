using System;

namespace ChiFouMi.Demarrage
{
    /// <summary>
    /// La classe <see cref="Demarrage"/>.
    /// </summary>
    public class Demarrage:IDemarrage
    {
        /// <inheritdoc/>
        public void Bienvenu()
        {
            Console.WriteLine("Bienvenu au Chi-Fou-Mi!");
            Console.WriteLine("\n");
        }

        /// <inheritdoc/>
        public decimal NombreDeTours()
        {
            Console.WriteLine("Choisissez le nombre de tours par partie (par example, 1, 3, 5 etc...)");
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <inheritdoc/>
        public decimal ToursAGagner(decimal tours)
        {
            decimal victoires = Math.Ceiling(tours / 2);
            Console.WriteLine($"Partie en {tours} tours. Le premier a {victoires} victoire(s) remporte la partie. Que le meilleur gagne.");
            return victoires;
        }
    }
}
