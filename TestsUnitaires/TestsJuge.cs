using ChiFouMi.Juge;
using ChiFouMi.Modeles;
using System;
using System.IO;
using Xunit;
using FluentAssertions;

namespace TestsUnitaires
{
    /// <summary>
    /// Tests de la classe <see cref="TestsJuge"/>.
    /// </summary>
    public class TestsJuge
    {
        private readonly Juge juge;
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="TestsJuge"/>.
        /// </summary>
        public TestsJuge()
        {
            this.juge = new Juge();
        }

        /// <summary>
        /// Verifie que le resultat est bien calcule.
        /// </summary>
        [Fact]
        public void CalculDuResultat()
        {
            int choixJoueur = 3;
            int choixOrdinateur = 5;

            int resultat = this.juge.CalculResultat(choixJoueur, choixOrdinateur);

            Assert.Equal(15, resultat);
        }

        /// <summary>
        /// Verifie que la decision du juge est correcte.
        /// </summary>
        [Fact]
        public void DecisionDuJuge()
        {
            int resultat = 21;
            Score score = new Score();

            var output = new StringWriter();
            Console.SetOut(output);

            this.juge.Decision(resultat, score);

            Assert.Equal("Victoire: ciseaux contre feuille \n\r\n", output.ToString());
        }

        /// <summary>
        /// Verifie que le score est mis a jour.
        /// </summary>
        [Fact]
        public void MiseAJourDuScore()
        {
            int resultat = 21;
            Score score = new Score()
            {
                Joueur = 0,
                Ordinateur = 0
            };

            Score nouveauScore = new Score()
            {
                Joueur = 1,
                Ordinateur = 0
            };

            Score scoreActuel = this.juge.Decision(resultat, score);

            scoreActuel.Should().BeEquivalentTo(nouveauScore);
        }
    }
}
