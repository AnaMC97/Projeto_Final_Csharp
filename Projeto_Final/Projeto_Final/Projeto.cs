using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Projeto
    {
        public Guid Id_Projeto { get; set; }
        public Projeto()
        {
            Id_Projeto = Guid.NewGuid();
            ///NOTA -> ID EQUIPA
        }

        public string Nome { get; set; }

        public List<Tarefas> Tarefas { get; set; }

        public static void Adicionar_Projeto()
        {
            Projeto projeto = new Projeto();
            Console.WriteLine("Insira nome do projeto");
            projeto.Nome = Console.ReadLine();
            //lista tarefas
            Program.list_projeto.Add(projeto);
        }

        public static void Imprimir_Projeto()
        {
            foreach (Projeto p in Program.list_projeto)
            {
                Console.WriteLine(p.Id_Projeto);
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Tarefas);
            }
        }

    }
}
