using System;

namespace EX_Funcionarios.Entities
{
    class Funcionario
    {   //Variaveis
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public double ValorHora { get; set; }

        //Construtor Padrão
        public Funcionario()
        {
        }

        //Sobrecarga
        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            ValorHora = valorHora;
        }

        //Calcular o Salario
        public double CalculaSalario() 
        {
            return CargaHoraria * ValorHora;
        }

        //Imprimir dados
        public void ImprimeDados() 
        {
            Console.WriteLine($"Nome do Funcionario: {Nome}, Valor a receber: ${CalculaSalario().ToString("F2")}");
        }
    }
}
