/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace PartCnj
{
    /*
     * tempera de simulação
     * recozimento simulado
    */
    public class SimulatedAnnealing
    {


        /*
         * gera uma solução

        efetuar mutação sobre essa solução


         * re avaliar a solução

         * ideia: gerar solução e ir em direção ao melhor resultado

         
         */
        public Estado MelhorResultado;
        private int Iteracoes = 40;

        public void Process()
        {

            Estado eS = new Estado().BuildNew();
            //Verifica se ele eh melhor que o melhor
            Add_Verf_MelhorResult(eS);

            int k = 1;//Contador

            while (k < Global.NroIteracoes)
            {
                //Gera um novo estado
                Estado eS1 = eS.getNewEstadoMutado();

                //Verifica se ele eh melhor que o melhor
                Add_Verf_MelhorResult(eS1);

                double Temp = 100;//Temperatura inicial

                //while (!ParaLoopAlg)
                for (int i = 0; i < Iteracoes; i++)
                {
                    //while (!Equilibrio)
                    {

                        Estado eS2 = eS1.getNewEstadoMutado();

                        //Verifica se ele eh melhor que o melhor
                        Add_Verf_MelhorResult(eS2);

                        double d = eS1.Resultado - eS2.Resultado;
                        double calc = Math.Exp(-d/Temp);
                        
                        //Console.WriteLine(calc);
                        if (d < 0) {
                            //Acelera a conclusão desse bloco, 
                            // cada vez que não se encontra resultados melhores
                            i++;
                        }

                        double prob = Min(1,calc);

                        if (Global.Random.NextDouble() <= prob)
                        {
                            eS1 = eS2;
                        }
                        else {
                            //Console.WriteLine("Teste");
                        }


                    }
                    Temp-=.01;
                }
                k++;
            }



        }

        private bool ParaLoopAlg
        {
            get
            {
                //TODO: Pensar no critério
                return false;
            }
        }

        private bool Equilibrio
        {
            get
            {
                //TODO: Pensar no equilibrio
                return false;
            }
        }

        private double Min(double v1, double v2)
        {

            if (v1 <= v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        public void Add_Verf_MelhorResult(Estado e)
        {

            if (MelhorResultado == null)
            {
                MelhorResultado = e;
                Global.TempoUltimoMelhorResult = DateTime.Now.Ticks;
            }
            else
            {
                if (e.Resultado > MelhorResultado.Resultado)
                {
                    MelhorResultado = e;
                    Global.TempoUltimoMelhorResult = DateTime.Now.Ticks;
                }
            }
        }
    }
}
