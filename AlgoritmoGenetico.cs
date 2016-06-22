/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/
/*
 * Criado por SharpDevelop.
 * Usuário: m31692
 * Data: 1/11/2007
 * Hora: 23:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Collections.Generic;

namespace PartCnj
{
    /// <summary>
    /// Description of Algoritmo.
    /// </summary>
    public class AlgoritmoGenetico
    {


        //public List<Grupo> Grupos = new List<Grupo>();
        public List<Estado> PopulacaoAtual = new List<Estado>();
        public List<Estado> PopulacaoFutura = new List<Estado>();
        public Estado MelhorResultado;


        public AlgoritmoGenetico()
        {


            ////Cria possíveis grupos
            //for (int i = 0; i <= Global.MaxGrupos; i++)
            //{
            //    Grupos.Add(new Grupo(i));
            //}

        }

        public void GeraPopulacaoInicial()
        {
            Estado e = new Estado();
            for (int i = 0; i < Global.TamPopulacao; i++)
            {
                Estado novo = e.BuildNew();
                Add_Verf_MelhorResult(novo);
                PopulacaoAtual.Add(novo);
            }


        }

        public void GeraProximaPopulacao()
        {


            for (int i = 0; i < Global.TamPopulacao / 2; i++)
            {

                List<Estado> new_est = getProgenitorSorteado().getFilhos(getProgenitorSorteado());
                //Estado e2 = ;
                foreach (Estado e in new_est)
                {
                    Add_Verf_MelhorResult(e);
                }
                PopulacaoFutura.AddRange(new_est);

            }
            //PopulacaoFutura.AddRange(
        }

        public void MesclaPopulacoes()
        {
            List<Estado> listaGeral = new List<Estado>();

            listaGeral.AddRange(this.PopulacaoAtual);
            listaGeral.AddRange(this.PopulacaoFutura);

            listaGeral.Sort();

            listaGeral.RemoveRange(0,  listaGeral.Count - Global.TamPopulacao);
            PopulacaoAtual = listaGeral;
            this.PopulacaoFutura.Clear();

        }

        public Estado getProgenitorSorteado()
        {
            //Método da roleta

            List<int> vet = new List<int>();

            //Percorre todos estados atuais
            for (int i = 0; i < PopulacaoAtual.Count; i++)
            {
                //Adiciona no vetor temporário a posição do estado atual, n vezes o resultado.
                for (int i2 = 0; i2 < PopulacaoAtual[i].Resultado; i2++)
                {
                    vet.Add(i);
                }
            }
            
            int posEscolhida = vet[Global.Random.Next(0, (vet.Count - 1))];
            return PopulacaoAtual[posEscolhida];

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

        public void EfetuaProcessamento()
        {
            GeraPopulacaoInicial();

            for (int i = 0; i < Global.NroIteracoes; i++)
            {
                GeraProximaPopulacao();
                MesclaPopulacoes();
                if (DateTime.Now.Ticks - Global.TempoUltimoMelhorResult >= (TimeSpan.TicksPerSecond * 3)) {
                    break;
                }
            }
        }

    }
}
