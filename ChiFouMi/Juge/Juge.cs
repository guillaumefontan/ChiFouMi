using ChiFouMi.Modeles;
using System;

namespace ChiFouMi.Juge
{
    /// <summary>
    /// La classe <see cref="Juge"/>.
    /// </summary>
    public class Juge:IJuge
    {
        /// <inheritdoc/>
        public int CalculResultat(int choixJoueur, int choixOrdinateur)
        {
            return choixJoueur * choixOrdinateur;
        }

        /// <inheritdoc/>
        public Score Decision(int resultat, Score score)
        {
            switch (resultat)
            {
                case 5:
                    Console.WriteLine("Egalite: pierre contre pierre \n");
                    break;
                case 7:
                    Console.WriteLine("Defaite: pierre contre feuille \n");
                    score.Ordinateur += 1;
                    break;
                case 11:
                    Console.WriteLine("Victoire: pierre conte ciseaux \n");
                    score.Joueur += 1;
                    break;
                case 10:
                    Console.WriteLine("Victoire: feuille contre pierre \n");
                    score.Joueur += 1;
                    break;
                case 14:
                    Console.WriteLine("Egalite: feuille contre feuille \n");
                    break;
                case 22:
                    Console.WriteLine("Defaite: feuille contre ciseaux \n");
                    score.Ordinateur += 1;
                    break;
                case 15:
                    Console.WriteLine("Defaite: ciseaux contre pierre \n");
                    score.Ordinateur += 1;
                    break;
                case 21:
                    Console.WriteLine("Victoire: ciseaux contre feuille \n");
                    score.Joueur += 1;
                    break;
                case 33:
                    Console.WriteLine("Egalite: ciseaux contre ciseaux \n");
                    break;
            }

            return score;
        }
    }
}
