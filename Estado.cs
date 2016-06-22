/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/
/*
 * Criado por SharpDevelop.
 * Usuário: m31692
 * Data: 1/11/2007
 * Hora: 23:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PartCnj
{
    /// <summary>
    /// Description of Estado.
    /// </summary>
    public class Estado : IComparable
    {
        //List<Grupo> grupos;
        //List<int> Items = new List<int>(Global.TamanhoGrade);
        int[] Items = new int[Global.TamanhoGrade];
        //O item está localizado pela ordem na lista.
        private double total = 0;
        public bool GerouFilhos = false;
        private bool _isValid;

        public Estado()
        {


        }

        public void Build()
        {
            ////A População incial é gerada baseada em números do relógio
            ////Eh feita uma para na thread atual de 1 milisegundo,
            //// para dar tempo de gerar uma nova sequencia de números aleatórios
            //// gerando um inicio de solução extremamente embaralhado.
            //Thread.Sleep(1);
            //Random r = new Random();

            long cnt = 0;
            do
            {
                for (int i = 0; i < Global.TamanhoGrade; i++)
                {

                    Items[i] = Global.Random.Next(0, Global.MaxGrupos - 1);

                }
                cnt++;
                if (cnt > 100000) { 
                    MessageBox.Show("Um loop infinito foi detectado, o resultado foi comprometido, mude os valores e inicie novamente.");
                    return;
                }
            } while (!isValid);



        }

        //Retorna um novo estado
        public Estado BuildNew()
        {
            Estado e = new Estado();
            e.Build();
            return e;
        }

        public bool isValid
        {
            get
            {
                getResultado();
                return _isValid;
            }
        }

        public double Resultado
        {
            // A prosição no array identifica o item que deve ser buscado na grade
            // O Valor do array identifica o  grupo a q esse item pertence;
            get
            {
                return getResultado();
            }
        }

        // Função objetivo
        private double getResultado()
        {
            // A prosição no array identifica o item que deve ser buscado na grade
            // O Valor do array identifica o  grupo a q esse item pertence;

            {
                if (total == 0)
                {
                    double totInterno = 0;
                    double totExterno = 0;

                    //int[] grupos = new int[Global.MaxGrupos];
                    Dictionary<int, Grupo> grupos = new Dictionary<int, Grupo>();


                    for (int i = 0; i < Global.TamanhoGrade; i++)
                    {
                        int grupo = Items[i];
                        if (grupos.ContainsKey(Items[i]))
                        {
                            grupos[grupo].Items.Add(i);
                        }
                        else
                        {
                            grupos.Add(grupo, new Grupo(grupo));
                            grupos[grupo].Items.Add(i);
                        }

                    }

                    _isValid = grupos.Count >= Global.MinGrupos;

                    foreach (Grupo g in grupos.Values)
                    {
                        //dentro de cada grupo está a soma de todos com todos, dentro do mesmo grupo
                        totInterno += g.getTotal;

                        foreach (Grupo gg in grupos.Values)
                        {
                            if (gg != g)
                            {
                                totExterno += g.getSumWithOtherGroups(gg);
                            }
                            else {
                                //Console.WriteLine("Teste");
                            }
                        }

                    }

                    //A função obejetivo retorna o seguinte cálculo
                    // A soma dos itens dentro dos grupos é inversamente
                    // proporcional a soma dos itens com outros grupos.
                    totExterno += .0000001;//Faz com que não exista divisão por zero;
                    total = totInterno * (1 /  totExterno);

                }


                return total;
            }
        }


        public List<Estado> getFilhos(Estado progenitor2)
        {
            //Random r = new Random();
            int pnt_Corte = Global.Random.Next(0, Global.TamanhoGrade - 1);

            int tamanho1 = Global.TamanhoGrade - pnt_Corte;
            int tamanho2 = Global.TamanhoGrade - tamanho1;

            Estado e1 = new Estado();
            Estado e2 = new Estado();

            //O principal do algoritmo genetico, o ponto de corte e o cruzamento:
            Array.ConstrainedCopy(Items, 0, e1.Items, 0, tamanho1);
            Array.ConstrainedCopy(progenitor2.Items, Global.TamanhoGrade - pnt_Corte, e1.Items, Global.TamanhoGrade - pnt_Corte, tamanho2);

            Array.ConstrainedCopy(progenitor2.Items, 0, e2.Items, 0, tamanho1);
            Array.ConstrainedCopy(Items, Global.TamanhoGrade - pnt_Corte, e2.Items, Global.TamanhoGrade - pnt_Corte, tamanho2);

            e1.Sorteia_EfetuaMutacao_Valida(false);
            e2.Sorteia_EfetuaMutacao_Valida(false);

            List<Estado> ret = new List<Estado>();
            ret.Add(e1);
            ret.Add(e2);

            this.GerouFilhos = true;
            progenitor2.GerouFilhos = true;

            return ret;
        }

        public void Sorteia_EfetuaMutacao_Valida(bool ForcaMutacao)
        {
            //Random r = new Random();
            //20% de chance de um novo estado sofrer mutação
            if (ForcaMutacao || Global.Random.Next(0, 5) == 4)
            {
                Items[Global.Random.Next(0, Global.TamanhoGrade - 1)] = Global.Random.Next(0, Global.MaxGrupos - 1);
            }
            while (!this.isValid)
            {
                Items[Global.Random.Next(0, Global.TamanhoGrade - 1)] = Global.Random.Next(0, Global.MaxGrupos - 1);
                total = 0;
            }

        }

        public Estado getNewEstadoMutado() {
            Estado e = new Estado();
            for (int i = 0; i < Global.TamanhoGrade; i++) {
                e.Items[i] = Items[i];
            }
            e.Sorteia_EfetuaMutacao_Valida(true);
            return e;
        }

        public override string ToString()
        {
            string ret = "";

            foreach(int i in Items){
                ret += i+", ";
            }

            ret = ret.Substring(0, ret.Length - 2);

            return ret;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            Estado e = (Estado)obj;
            if (this.Resultado > e.Resultado)
            {
                return 1;
            }
            else if (this.Resultado < e.Resultado)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}
