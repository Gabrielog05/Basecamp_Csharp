using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectLodging.Models
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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
           int totalHospedes = hospedes.Count;

            if (Suite.Capacidade >= totalHospedes)
            {
                Hospedes = hospedes;                
            }
            else if (Suite.Capacidade < totalHospedes)
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*                    
                throw new Exception("Quantidade de hospede maior do que o suportado pela suite");
            }                                
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int qtde  = 0;
            for(int i = 0; i  < Hospedes.Count;  i++)
            {
                qtde += 1;
            }

            return qtde;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*                    
            
            decimal diaria = Suite.ValorDiaria;                    
            decimal valor = diaria * DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal desconto = decimal.Multiply(valor, 0.1m);
                valor -= desconto;
            }

            return valor;
        }
    }
}
