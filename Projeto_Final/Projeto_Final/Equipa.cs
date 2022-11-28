using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Equipa
    {
        public Guid Id_Equipa { get; set; }
        public Equipa()
        {
            Id_Equipa = Guid.NewGuid();
        }

        public virtual string Nome_Equipa { get; set; }

        public List<Membro> Membros { get; set; }

        public static void Adicionar_Equipa()
        {
            Equipa equipa = new Equipa();//
            Console.WriteLine("Insira nome da equipa:");
            equipa.Nome_Equipa = Console.ReadLine();
            //lista de membros
            Program.list_equipa.Add(equipa);
            //Program.list_equipa.Add(); -> Adicionar lista de membros
        }

        public static void Imprimir_Equipa()
        {
            foreach (Equipa e in Program.list_equipa)
            {
                Console.WriteLine(e.Id_Equipa);
                Console.WriteLine(e.Nome_Equipa);
                //Console.WriteLine(e.Membros);
            }
        }





    }
}
