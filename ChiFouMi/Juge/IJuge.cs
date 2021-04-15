using ChiFouMi.Modeles;

namespace ChiFouMi.Juge
{
    /// <summary>
    /// Interface du juge.
    /// </summary>
    public interface IJuge
    {
        /// <summary>
        /// Calcul du resultat.
        /// </summary>
        /// <param name="choixJoueur">Choix du joueur.</param>
        /// <param name="choixOrdinateur">Choix de l'ordinateur.</param>
        /// <returns>Un chiffre representant le resultat du match.</returns>
        int CalculResultat(int choixJoueur, int choixOrdinateur);

        /// <summary>
        /// Decision du juge.
        /// </summary>
        /// <param name="resultat">Code du resultat.</param>
        /// <param name="score">Score actuel.</param>
        /// <returns>Le score mis a jour.</returns>
        Score Decision(int resultat, Score score);
    }
}