using ChiFouMi.Modeles;

namespace ChiFouMi.Decompte
{
    /// <summary>
    /// Interface du decompte.
    /// </summary>
    public interface IDecompte
    {
        /// <summary>
        /// Calcul du resultat.
        /// </summary>
        /// <param name="victoires">Victoires pour gagner.</param>
        /// <param name="score">Score de la partie.</param>
        /// <returns>Un boolean indiquant si un nouveau tour est necessaire.</returns>
        bool DecompteDesTours(decimal victoires, Score score);
    }
}