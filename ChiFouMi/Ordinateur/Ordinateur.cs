using System;
using System.Collections.Generic;

namespace ChiFouMi.Ordinateur
{
    /// <summary>
    /// La classe <see cref="Ordinateur"/>.
    /// </summary>
    public class Ordinateur :IOrdinateur
    {
        /// <inheritdoc/>
        public int ChoixDuOrdinateur()
        {
            Random rnd = new Random();
            List<int> list = new List<int> { 5,7,11 };
            int index = rnd.Next(3);
            return list[index];
        }
    }
}
