using ChiFouMi.Demarrage;
using ChiFouMi.Modeles;
using ChiFouMi.Tour;

namespace ChiFouMi.Execution
{
    /// <summary>
    /// La classe <see cref="Execution"/>.
    /// </summary>
    public class Execution:IExecution
    {
        private readonly IDemarrage Demarrage;
        private readonly ITour Tour;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Execution"/>.
        /// </summary>
        /// <param name="demarrage">Classe de demarrage.</param>
        /// <param name="tour">Classe du tour.</param>
        public Execution(
            IDemarrage demarrage,
            ITour tour
            )
        {
            this.Demarrage = demarrage;
            this.Tour = tour;
        }

        /// <inheritdoc/>
        public void Go()
        {
            Score score = new Score()
            {
                Joueur = 0,
                Ordinateur = 0
            };

            Demarrage.Bienvenu();
            decimal tours = Demarrage.NombreDeTours();
            decimal victoires = Demarrage.ToursAGagner(tours);
            Tour.LancerTour(victoires, score);
        }
    }
}
