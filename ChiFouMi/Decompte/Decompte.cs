using ChiFouMi.Modeles;
using System;

namespace ChiFouMi.Decompte
{
    /// <summary>
    /// La classe <see cref="Decompte"/>.
    /// </summary>
    public class Decompte:IDecompte
    {
        /// <inheritdoc/>
        public bool DecompteDesTours(decimal victoires, Score score)
        {
            bool nouveauTour = false;

            if (score.Joueur == victoires)
            {
                Console.WriteLine($"Felicitations, victoire {score.Joueur} a {score.Ordinateur}.");
            }
            else if (score.Ordinateur == victoires)
            {
                Console.WriteLine($"Catastrophe. Defaite {score.Joueur} a {score.Ordinateur}.");
                Console.WriteLine($"Fatigué? Le Somnonaute (TM) est fait pour vous. Contactez votre medecin pour plus d'information.");
            }
            else
            {
                nouveauTour = true;
            }

            return nouveauTour;
        }
    }
}
