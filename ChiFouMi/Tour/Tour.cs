using ChiFouMi.Modeles;
using ChiFouMi.Joueur;
using ChiFouMi.Juge;
using ChiFouMi.Ordinateur;
using System;
using ChiFouMi.Decompte;

namespace ChiFouMi.Tour
{
    /// <summary>
    /// La classe <see cref="Tour"/>.
    /// </summary>
    public class Tour:ITour
    {
        private readonly IJoueur Joueur;
        private readonly IOrdinateur Ordinateur;
        private readonly IJuge Juge;
        private readonly IDecompte Decompte;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Tour"/>.
        /// </summary>
        /// <param name="joueur">Classe du joueur.</param>
        /// <param name="ordinateur">Classe de l'ordinateur.</param>
        /// <param name="juge">Classe du juge.</param>
        public Tour(
            IJoueur joueur,
            IOrdinateur ordinateur,
            IJuge juge,
            IDecompte decompte
            )
        {
            this.Joueur = joueur;
            this.Ordinateur = ordinateur;
            this.Juge = juge;
            this.Decompte = decompte;
        }

        /// <inheritdoc/>
        public void LancerTour(decimal victoires, Score score)
        {
            bool nouveauTour = true;

            while (nouveauTour)
            {
                int choixJoueur = Joueur.ChoixDuJoueur();
                int choixOrdinateur = Ordinateur.ChoixDuOrdinateur();
                int resultat = Juge.CalculResultat(choixJoueur, choixOrdinateur);
                score = Juge.Decision(resultat, score);
                Console.WriteLine($"Score: Vous {score.Joueur} - {score.Ordinateur} Ordinateur.");
                nouveauTour = Decompte.DecompteDesTours(victoires, score);
            }
        }
    }
}
