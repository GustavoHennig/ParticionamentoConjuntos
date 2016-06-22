/*
 * Criado por SharpDevelop.
 * Usuário: Gustavo Augusto Hennig
 * Data: 1/11/2007
 * Hora: 23:15
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Collections.Generic;

namespace PartCnj
{
    /// <summary>
    /// Description of Grupo.
    /// </summary>
    public class Grupo
    {
        private int Numero;

        public Grupo(int Numero)
        {
            this.Numero = Numero;
        }

        //Itens inseridos no grupo atual
        public List<int> Items = new List<int>();

        public int getTotal
        {
            get
            {
                int acum = 0;
                Dictionary<int, int> perc = new Dictionary<int, int>();

                //Percorre todos com todos
                foreach (int i in Items)
                {
                    foreach (int i2 in Items)
                    {
                        //Não acumula ele com si próprio
                        //Não repete a contagem, caso ele jah tenha sido contado
                        if (i2 != i && !perc.ContainsKey(i2))
                        {
                            acum += Global.Matriz.getValues(i, i2);//A ordem dos parâmetros não altera essa função
                        }

                    }


                    perc.Add(i, i);
                }
                return acum;
            }
        }

        //Soma os elementos desse grupos com elementos do outro grupo
        public int getSumWithOtherGroups(Grupo g)
        {

            int acum = 0;


            //Percorre todos com todos
            foreach (int i in Items)
            {
                foreach (int i2 in g.Items)
                {
                    //compara todo do grupo atual com todos do outro grupo e soma os valores
                    acum += Global.Matriz.getValues(i, i2);//A ordem dos parâmetros não altera essa função

                }


            }
            return acum;
        }
    }
}
