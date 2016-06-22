/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace PartCnj
{
    [Serializable]
    public class Matriz
    {

        public int[,] matriz = new int[Global.TamanhoGrade, Global.TamanhoGrade];

        public Matriz()
        {
            matriz = getMatriz2();// new int[Global.TamanhoGrade, Global.TamanhoGrade];
            //A Matriz pode ser definida utizando uma das funções abaixo
            //A matriz fica gravada num arquivo saveddata.xml(ficou muito complicado).
            //Para criar uma nova matriz esse arquivo deve ser apagado.

            //Atenção essa matriz está invertida, funciona da seguinte forma:
            // 0
            // 1
            // 2
            // 3
            // 4
            // 5
            // 6
            // 7
            // 8
            // 9
            //    0, 1, 2, 3, 4, 5, 6, 7, 8, 9

            //Onde os valores não são necessários, deve-se colocar -1

        }

        public int[,] getMatriz()
        {
            int[,] ret = {
                    { -1 ,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 7 ,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 3, 8 ,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 1, 4, 6 ,-1,-1,-1,-1,-1,-1, -1},
                    { 4, 6, 2, 1 ,-1,-1,-1,-1,-1, -1},
                    { 15, 10, 3, 7, 0 ,-1,-1,-1,-1, -1},
                    { 20, 8, 10, 8, 3, 2 ,-1,-1,-1, -1},
                    { 0, 12, 10, 6, 5, 4, 1,-1,-1 , -1},
                    { 3, 7, 8, 4, 5, 6, 7, 8,-1 , -1},
                    { 20, 17, 16, 15, 14, 13, 12, 11, 10 , -1}
        };
            return ret;
        }
        public int[,] getMatriz2()
        {
            int[,] ret = {
                    { -1 ,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 67 ,-1,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 3, 8 ,-1,-1,-1,-1,-1,-1,-1, -1},
                    { 1, 4, 6 ,-1,-1,-1,-1,-1,-1, -1},
                    { 4, 6, 2, 1 ,-1,-1,-1,-1,-1, -1},
                    { 15, 10, 3, 7, 0 ,-1,-1,-1,-1, -1},
                    { 260, 8, 10, 8, 3, 2 ,-1,-1,-1, -1},
                    { 0, 12, 10, 6, 5, 4, 1,-1,-1 , -1},
                    { 3, 7, 8, 4, 5, 6, 7, 8,-1 , -1},
                    { 20, 17, 16, 15, 164, 13, 12, 11, 10 , -1}
        };
            return ret;
        }
        public int getValues(int x1, int x2)
        {

            int ret;

            ret = matriz[x1, x2];
            if (ret == -1)
            {
                ret = matriz[x2, x1];
            }


            return ret;
        }

    }
}
