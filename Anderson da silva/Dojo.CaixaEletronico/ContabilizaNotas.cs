using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.CaixaEletronico
{
    public class quantidadeDeNotas
    {
        private int valorDeSaque = 0;
        private int notaDeDez = 0;
        private int notaDeVinte = 0;
        private int notaDeCinquenta = 0;
        private int notaDeCem = 0;

        public int Saque
        {
            get
            {
                return valorDeSaque;
            }
            set
            {
                this.valorDeSaque = value;
            }
        }

        public int Dez
        {
            get
            {
                return notaDeDez;
            }
            set
            {
                this.notaDeDez=value;
            }

        }

        public int Vinte
        {
            get
            {
                return notaDeVinte;
            }
            set
            {
                this.notaDeVinte=value;
            }

        }

        public int cinquenta
        {
            get
            {
                return notaDeCinquenta;
            }
            set
            {
                this.notaDeCinquenta=value;
            }
        }

        public int Cem
        {
            get
            {
                return notaDeCem;
            }
            set
            {
                this.notaDeCem = value;
            }

        }

        public int ContabilizaCedulas(int valor)
        {
            int valorDeSaque = valor;
             
            while (valorDeSaque >= 100)
            {
                valorDeSaque -= 100;
                notaDeCem++;
            }

            while (valorDeSaque >= 50)
            {
                valorDeSaque -= 50;
                notaDeCinquenta++;
            }

            while (valorDeSaque >= 20)
            {
                valorDeSaque -= 20;
                notaDeVinte++;
            }

            while (valorDeSaque >= 10)
            {
                valorDeSaque -= 10;
                notaDeDez++;
            }

            if (valorDeSaque != 0)
            {
                throw new ArgumentException("Valor solicitador é invalido!");
            }

            return 0;
        }

        public void ContabilizaCedulas(object p)
        {
            throw new ArgumentException("Não foi informado valor");
            
        }

    }
}