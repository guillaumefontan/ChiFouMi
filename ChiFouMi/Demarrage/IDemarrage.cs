namespace ChiFouMi.Demarrage
{
    /// <summary>
    /// Interface de demarrage.
    /// </summary>
    public interface IDemarrage
    {
        /// <summary>
        /// Message de bienvenu.
        /// </summary>
        void Bienvenu();

        /// <summary>
        /// Demande le nombre de tours.
        /// </summary>
        /// <returns>Nombre de tours a jouer.</returns>
        decimal NombreDeTours();

        /// <summary>
        /// Decrit le nombre de tours a gagner afin de remporter la victoire.
        /// </summary>
        /// <returns>Nombre de tours a gagner.</returns>
        decimal ToursAGagner(decimal tours);
    }
}