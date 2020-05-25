using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoPessoa
{
    class Atleta
    {
        private string nome;
        private int idade;
        private double peso;
        private double altura;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }

        public int Idade
        {
            set
            {
                if (value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("O peso deverá ser maior que 1 quilo.");
                }
            }
            get { return this.idade; }
        }

        public double Peso
        {
            set {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso deverá ser maior que 1 quilo.");
                }
            }
            get { return this.peso; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura deverá ser maior que 1 metro.");
                }
            }
            get { return this.altura; }
        }

        public double CalcularIMC()
        {
            double AlturaCalculada = this.altura * this.altura;
            double IMC = this.peso / AlturaCalculada;
            return IMC;
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n\nNome: " +
                    this.nome + "\nIdade: " +
                    this.idade + "\nPeso: " +
                    this.peso + "\nAltura: " + this.altura.ToString("0.00") + "m.";
        }
    }
}