using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ByteBankOutrosFormatos
{
    public class Json<T>
    {
        public static void CriaJSON(Array list)
        {
            List<Object> lista = new List<Object>();
            if (list.Length <= 0)
            {
                Console.WriteLine("... Não existe dados para exportação...");
                Console.ReadKey();
            }
            else
            {
                string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
                try
                {
                    FileStream fs = new FileStream(@"C:\Users\AmandaMarquesPardinh\Desktop\Performa\repositorios\CSharp---Criando-e-Distribuindo-Bibliotecas\tmp\contas2.json",
                        FileMode.Create);
                    using (StreamWriter streamwriter = new StreamWriter(fs))
                    {
                        streamwriter.WriteLine(json);
                    }
                    Console.WriteLine(@"Arquivo salvo em c:\tmp\contas2.json");
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
