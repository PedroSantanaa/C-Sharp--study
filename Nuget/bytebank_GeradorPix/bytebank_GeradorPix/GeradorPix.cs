using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorPix
{
    /// <summary>
    /// Classe que gera chaves PIX utilizando o formato Guid
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Metodo que retorna uma chave aleatória PIX
        /// </summary>
        /// <returns>Retorna uma chave PIX no formato string</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// Metodo que retorna uma lista aleatoria de chaves PIX
        /// </summary>
        /// <param name="numeroDeChaves">Quantidade de Chaves para retornar</param>
        /// <returns>Retorna uma lista de strings de chaves PIX</returns>
        public static List<string> GetChavesPix(int numeroDeChaves) { 
        
            if(numeroDeChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves=new List<string>();
                for(int i = 0; i < numeroDeChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}
