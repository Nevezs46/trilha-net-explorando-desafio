using System.Data;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (Suite.Capacidade >= hospedes.Count())
            {
              Hospedes = hospedes; 
              Console.WriteLine("Capacidade Aceita");
            }
            else
            {
             throw new Exception("Capacidade menor que o numeros de hospede");
            }
        }
        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return(Hospedes.Count());
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
             valor -= Decimal.Divide(Decimal.Multiply(valor, 10), 100);

            }
        
            return valor;
        }
    }
}