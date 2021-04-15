using ChiFouMi.Joueur;
using System;
using System.IO;
using Xunit;

namespace TestsUnitaires
{
    /// <summary>
    /// Tests de la classe <see cref="TestsJoueur"/>.
    /// </summary>
    public class TestsJoueur
    {
        private readonly Joueur joueur;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="TestsJoueur"/>.
        /// </summary>
        public TestsJoueur()
        {
            this.joueur = new Joueur();
        }

        /// <summary>
        /// Verifie que le choix du joueur est bien recu.
        /// </summary>
        [Fact]
        public void ChoixDuJoueur()
        {
            var input = new StringReader("3");
            Console.SetIn(input);

            int choix = this.joueur.ChoixDuJoueur();

            Assert.Equal(3, choix);
        }
    }
}
