using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ByteBankOutrosFormatos
{
    public class Xml<T>
    {
        public static void CriaXML(Array list)
        {
            List<Object> lista = new List<Object>();
            if (list.Length <= 0)
            {
                Console.WriteLine("... Não existe dados para exportação...");
                Console.ReadKey();
            }
            else
            {
                try
                {
                    FileStream fileStreamXml = new FileStream(@"C:\Users\AmandaMarquesPardinh\Desktop\Performa\repositorios\CSharp---Criando-e-Distribuindo-Bibliotecas\tmp\contas3.xml", FileMode.Create);
                    using (StreamWriter streamwriter = new StreamWriter(fileStreamXml))
                    {
                        XmlSerializer serializador = new XmlSerializer(typeof(List<Object>));

                        serializador.Serialize(streamwriter, lista);
                    }
                    Console.WriteLine(@"Arquivo salvo em c:\tmp\contas3.xml");
                    Console.ReadKey();
                }
                catch (Exception excecao)
                {
                    Console.WriteLine("Ocorreu um erro ao exportar as contas: " + excecao.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}

