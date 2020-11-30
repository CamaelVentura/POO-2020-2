using System;

namespace ca04
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento[] array_veiculos = new Estacionamento[5];
            Estacionamento carro1 = new Estacionamento();
            Estacionamento carro2 = new Estacionamento();
            Estacionamento carro3 = new Estacionamento();
            Estacionamento carro4 = new Estacionamento();
            Estacionamento carro5 = new Estacionamento();

            array_veiculos[0] = carro1;
            array_veiculos[1] = carro2;
            array_veiculos[2] = carro3;
            array_veiculos[3] = carro4;
            array_veiculos[4] = carro5;

            for (int i = 0; i<array_veiculos.Length; i++)
            {
                array_veiculos[i].solicitarDados();
            }
            for (int i = 0; i < array_veiculos.Length; i++)
            {
                array_veiculos[i].imprimirDados();
                array_veiculos[i].valorCobradoPorHora();
            }
        }
    }
}
