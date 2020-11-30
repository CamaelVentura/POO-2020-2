using System;
using System.Collections.Generic;
using System.Text;

namespace ca04
{
    class Estacionamento : Tempo
    {
        private string n_carro;
        private string marca;
        private Tempo hr_entrada = new Tempo();
        private Tempo hr_saida = new Tempo();

        public Estacionamento()
        {
            this.n_carro = "";
            this.marca = "";
            this.hr_entrada.setHora(0);
            this.hr_entrada.setMinuto(0);
            this.hr_entrada.setSegundo(0);
            this.hr_saida.setHora(0);
            this.hr_saida.setMinuto(0);
            this.hr_saida.setSegundo(0);
        }

        public void solicitarDados()
        {
            Console.WriteLine("Digite o numero da chapa do carro: ");
            this.n_carro = Console.ReadLine();
            Console.WriteLine("Digite a marca do carro: ");
            this.marca = Console.ReadLine();
            Console.WriteLine("Digite a hora de entrada: ");
            int hora_entrada = Convert.ToInt32(Console.ReadLine());
            this.hr_entrada.setHora(hora_entrada);
            int minuto_entrada = Convert.ToInt32(Console.ReadLine());
            this.hr_entrada.setMinuto(minuto_entrada);
            int segundo_entrada = Convert.ToInt32(Console.ReadLine());
            this.hr_entrada.setMinuto(segundo_entrada);
            Console.WriteLine("Digite a hora de saida: ");
            int hora_saida = Convert.ToInt32(Console.ReadLine());
            this.hr_saida.setHora(hora_saida);
            int minuto_saida = Convert.ToInt32(Console.ReadLine());
            this.hr_saida.setMinuto(minuto_saida);
            int segundo_saida = Convert.ToInt32(Console.ReadLine());
            this.hr_saida.setMinuto(segundo_saida);
        }

        public void imprimirDados()
        {
            Console.WriteLine("Numero da chapa do carro: " + this.n_carro);
            Console.WriteLine("Marca do carro: " + this.marca);
            Console.WriteLine("Horário de entrada: " + this.hr_entrada.getHora() + "H:" + this.hr_entrada.getMinuto() + "M:" + this.hr_entrada.getSegundo() + "S");
            Console.WriteLine("Horário de saida: " + this.hr_saida.getHora() + "H:" + this.hr_saida.getMinuto() + "M:" + this.hr_saida.getSegundo() + "S");
        }

        public int valorCobradoPorHora()
        {
            int VALORCOBRADOPORHORA = 7;
            Tempo tempoEstacionado = new Tempo();
            tempoEstacionado = hr_saida.sub(hr_entrada);
            int valorTotal = VALORCOBRADOPORHORA * tempoEstacionado.getHora();
            Console.WriteLine("Valor total cobrado do carro: " + valorTotal + "R$");
            return valorTotal;
        }
    }
}
