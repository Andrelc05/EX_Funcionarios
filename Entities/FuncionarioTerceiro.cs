using System;


namespace EX_Funcionarios.Entities
{
    class FuncionarioTerceiro : Funcionario
    {   //Variaveis para setar as Properties
        private string _empresaNome;
        private double _valorTaxa;

        private string _empresaOrigem {

            get { return _empresaNome; }
            set { }
        
        }

        private double _taxaServico
        {

            get { return _valorTaxa; }
            set { }

        }
        //Construtor Padrão
        public FuncionarioTerceiro()
        {
        }

        //Sobrecarga
        public FuncionarioTerceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico):base(nome, cargaHoraria, valorHora)
        {
            _empresaNome = empresaOrigem;
            _valorTaxa = taxaServico;
        }

        //Calcular salario com a taxa em %
        public new double CalculaSalario() 
        {
           double Calcular = CargaHoraria * ValorHora;
           return Calcular += Calcular * (_taxaServico / 100);
        }

        //Imprimir Valores
        public new void ImprimeDados() 
        {
            Console.WriteLine($"Nome do Funcionario Terceiro: {Nome}, Empresa Terceira: {_empresaOrigem}, Valor a receber: ${CalculaSalario().ToString("F2")}");
        }

    }
}
