using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pasta_projeto.Models
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
            int numeroHospedes = hospedes.Count;
            int capacidadeSuite = Suite.Capacidade;
            if (numeroHospedes <= capacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Numero de hospedes superior a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int QuanditadeHospedes = Hospedes.Count;
            return QuanditadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            bool desconto = DiasReservados >= 10;

            if (desconto == true)
            {
                valor = valor*90/100;
            }

            return valor;
        }
    }
}