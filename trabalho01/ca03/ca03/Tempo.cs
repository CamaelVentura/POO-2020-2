using System;
using System.Collections.Generic;
using System.Text;

namespace ca03
{
    class Tempo
    {
        private int hora;
        private int minuto;
        private int segundo;

        public Tempo()
        {
            this.hora = 0;
            this.minuto = 0;
            this.segundo = 0;
        }

        public Tempo(int _hora, int _minuto, int _segundo)
        {
            this.hora = _hora;
            this.minuto = _minuto;
            this.segundo = _segundo;
        }

        public void setHora(int _hora)
        {
            this.hora = _hora;
        }

        public int getHora()
        {
            return this.hora;
        }
        public void setMinuto(int _minuto)
        {
            this.minuto = _minuto;
        }

        public int getMinuto()
        {
            return this.minuto;
        }

        public void setSegundo(int _segundo)
        {
            this.segundo = _segundo;
        }

        public int getSegundo()
        {
            return this.segundo;
        }

        public void imprimirTempo()
        {
            Console.WriteLine("Tempo: " + this.hora + "H:" + this.minuto + "M:" + this.segundo + "S");
        }

        public void criarObjetosTempo()
        {
            Tempo t1 = new Tempo();
            Tempo t2 = new Tempo(10, 10, 10);
            Tempo t3 = new Tempo(20, 20, 20);

            t1 = t2.soma(t3);

            Console.WriteLine("Imprimindo t1");
            t1.imprimirTempo();
        }

        public Tempo soma(Tempo t)
        {
            this.hora += t.hora;
            this.minuto += t.minuto;
            this.segundo += t.segundo;
            Console.WriteLine("Soma efetuada com sucesso.");
            return this;
        }

    }
}
