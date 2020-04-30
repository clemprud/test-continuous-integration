using System;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// Retourne un nombre donné sous forme d'une chaine de caractère
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static int GetInt(string nombre)
        {
            var res = int.Parse(nombre);
            return res + 1;            
        }
    }
}
