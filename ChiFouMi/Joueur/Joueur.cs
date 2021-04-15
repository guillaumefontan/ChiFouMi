using System;

namespace ChiFouMi.Joueur
{
    /// <summary>
    /// La classe <see cref="Joueur"/>.
    /// </summary>
    public class Joueur:IJoueur
    {
        /// <inheritdoc/>
        public int ChoixDuJoueur()
        {
            Console.WriteLine("A vous de jouer. Choisissez 1 pour 'pierre', 2 pour 'feuille' ou 3 pour 'ciseaux'.");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
