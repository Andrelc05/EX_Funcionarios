using System;
using EX_Funcionarios.Entities;
using System.Collections.Generic;

namespace EX_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva os dados dos Funcionarios");

            //Console.WriteLine() vazo para espaçamento
            Console.WriteLine();
            Console.Write("Quantidade de Funcionarios a serem cadastrados: ");
            int NumeroFuncionarios = Convert.ToInt16(Console.ReadLine());

            //Intanciando Listas
            List<Funcionario> Lista = new List<Funcionario>();
            List<FuncionarioTerceiro> ListaTerceiro = new List<FuncionarioTerceiro>();

            //Loop para obter os dados da quantidade de funcionarios
            for (int i = 1; i <= NumeroFuncionarios; i++)
            {
                Console.WriteLine($"Cadastro {i}#");
                Console.Write("O Funcionario é Terceiro? S/N: ");
                char TipoFuncionrio = char.Parse(Console.ReadLine());

                //Validação para saber se o funcionario é terceiro ou não
                if (TipoFuncionrio == 'N' || TipoFuncionrio == 'n')
                {
                    Console.WriteLine();
                    Console.Write("Escreva o nome do Funcionario: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Escreva as horas trabalhadas: ");
                    int HorasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Escreva o valor por hora: ");
                    double ValorHora = double.Parse(Console.ReadLine());
                    Lista.Add(new Funcionario(Nome, HorasTrabalhadas, ValorHora));
                }

                else if (TipoFuncionrio == 'S' || TipoFuncionrio == 's')
                {
                    Console.WriteLine();
                    Console.Write("Escreva o nome do Funcionario: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Escreva as horas trabalhadas: ");
                    int HorasTrabalhadas = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Escreva o valor por hora: ");
                    double ValorHora = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Escreva a % da Taxa: ");
                    double Taxa = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Nome da Empresa Terceira: ");
                    string Empresa = Console.ReadLine();
                    ListaTerceiro.Add(new FuncionarioTerceiro(Nome, HorasTrabalhadas, ValorHora, Empresa, Taxa));
                }
                Console.WriteLine();
            }

            //loop para retornar os resultados contidos na lista
            foreach (Funcionario List in Lista)
            {
                List.ImprimeDados();
            }

            foreach (FuncionarioTerceiro List in ListaTerceiro)
            {
                List.ImprimeDados();
            }

            Console.ReadKey();

        }


    }
}
