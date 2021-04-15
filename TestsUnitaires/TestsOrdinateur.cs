using ChiFouMi.Ordinateur;
using System.Collections.Generic;
using Xunit;

namespace TestsUnitaires
{
    /// <summary>
    /// Tests de la classe <see cref="TestsOrdinateur"/>.
    /// </summary>
    public class TestsOrdinateur
    {
        private readonly Ordinateur ordinateur;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="TestsOrdinateur"/>.
        /// </summary>
        public TestsOrdinateur()
        {
            this.ordinateur = new Ordinateur();
        }

        /// <summary>
        /// Verifie que le choix de l'ordinateur est 5, 7 ou 11.
        /// </summary>
        [Fact]
        public void ChoixAleatoireDuOrdinateur()
        {
            List<int> list = new List<int> { 5, 7, 11 };

            int choix = this.ordinateur.ChoixDuOrdinateur();

            Assert.Contains(choix, list);
        }
    }
}
