using ChiFouMi.Modeles;

namespace ChiFouMi.Tour
{
    /// <summary>
    /// Interface du tour.
    /// </summary>
    public interface ITour
    {
        /// <summary>
        /// Lancer un tour.
        /// </summary>
        /// <param name="victoires">Victoires pour gagner.</param>
        /// <param name="score">Score actuel.</param>
        void LancerTour(decimal victoires, Score score);
    }
}