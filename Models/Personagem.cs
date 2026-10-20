using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Prorotype.Models
{
    public class Personagem
    {
        public string Nome {  get; set; }

        public int QuantidadeVida {  get; set; }    

        public int ForcaAtaque {  get; set; }

        public string Classe { get; set; }



        public Personagem Clone()
        {
            return new Personagem
            {
                Nome = this.Nome,
                QuantidadeVida = this.QuantidadeVida,
                ForcaAtaque = this.ForcaAtaque,
                Classe = this.Classe

            };
        }

    }
}
