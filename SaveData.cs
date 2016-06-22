/* 
* por: Gustavo Augusto Hennig
* novembro de 2007
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace PartCnj
{
    [Serializable]
    public class SaveData
    {
        static string filename = AppDomain.CurrentDomain.BaseDirectory + "\\saveddata.xml";

        public List<List<int>> matriz = new List<List<int>>();

        public static void GravaMatriz()
        {
            Stream stream=null;
            try
            {

                //Opens a file and serializes the object into it in binary format.
                stream = File.Open(filename, FileMode.Create);
                //BinaryFormatter formatter = new BinaryFormatter();
                XmlSerializer formatter = new XmlSerializer(typeof(SaveData));

                SaveData sd = new SaveData();
                //BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < Global.Matriz.matriz.GetLength(0); i++)
                {

                    List<int> ma = new List<int>();

                    for (int ii = 0; ii < Global.Matriz.matriz.GetLength(1); ii++)
                    {
                        ma.Add(Global.Matriz.matriz[i, ii]);
                    }
                    sd.matriz.Add(ma);
                }
                formatter.Serialize(stream, sd);
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }



        public static void CarregaMatriz()
        {
            Stream stream=null;
            try
            {
                if (File.Exists(filename))
                {
                    //BinaryFormatter formatter = new BinaryFormatter();
                    //Opens file "data.xml" and deserializes the object from it.
                    stream = File.Open(filename, FileMode.Open);

                    XmlSerializer formatter = new XmlSerializer(typeof(SaveData));
                    //formatter = new BinaryFormatter();

                    object obj = formatter.Deserialize(stream);
                    stream.Close();

                    SaveData sd = (SaveData)obj;
                    //BinaryFormatter formatter = new BinaryFormatter();
                    for (int i = 0; i < sd.matriz.Count; i++)
                    {
                        for (int ii = 0; ii < sd.matriz[i].Count; ii++)
                        {
                            Global.Matriz.matriz[i, ii] = sd.matriz[i][ii];
                        }

                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }
    }
}
