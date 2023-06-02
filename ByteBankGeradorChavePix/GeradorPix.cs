using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankGeradorChavePix
{
    public static class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<string> GetChavesPix(int numeroChaves)
        {
            if(numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for(int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
