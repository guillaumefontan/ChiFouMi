using ChiFouMi.Demarrage;
using System;
using System.IO;
using Xunit;

namespace TestsUnitaires
{
    /// <summary>
    /// Tests de la classe <see cref="Demarrage"/>.
    /// </summary>
    public class TestsDemarrage
    {
        private readonly Demarrage demarrage;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="TestsDemarrage"/>.
        /// </summary>
        public TestsDemarrage()
        {
            this.demarrage = new Demarrage();
        }

        /// <summary>
        /// Verifie que le choix du joueur est bien recu.
        /// </summary>
        [Fact]
        public void NombreDeTours()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("3");
            Console.SetIn(input);

            decimal tours = this.demarrage.NombreDeTours();

            Assert.Equal(3, tours);
        }

        /// <summary>
        /// Verifie le calcul du nombre de victoires necessaires pour remporter une partie.
        /// </summary>
        [Fact]
        public void CalculDesToursAGagner()
        {
            decimal tours = 3;

            decimal victoires = this.demarrage.ToursAGagner(tours);

            Assert.Equal(2, victoires);
        }
    }
}
