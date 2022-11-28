using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Tarefas
    {
        public Guid Id_Tarefas { get; set; }
        public Tarefas()
        {
            Id_Tarefas = Guid.NewGuid();
            //NOTA -> ID MEMBROS
        }

        public string Titulo { get; set; }
        public int Data_Inicio { get; set; }
        public int Data_Fim { get; set; }

        enum Estado { PorIniciar = 1, Iniciado = 2, Pendente = 3, Bloqueado = 4, Completo = 5 }

        public static void Adicionar_Tarefas()
        {
            Tarefas tarefas = new Tarefas();
            Console.WriteLine("Insira titulo da tarefa:");
            tarefas.Titulo = Console.ReadLine().Trim();
            Console.WriteLine("Insira data de inicio");
            tarefas.Data_Inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira data de fim");
            tarefas.Data_Fim = Convert.ToInt32(Console.ReadLine());
            Program.list_tarefas.Add(tarefas);
        }

        public static void Imprimir_Tarefas()
        {
            foreach (Tarefas t in Program.list_tarefas)
            {
                //Id_Tarefas
                Console.WriteLine(t.Titulo);
                Console.WriteLine(t.Data_Inicio);
                Console.WriteLine(t.Data_Fim);
                Console.WriteLine(); //NOTA -> Enum Estado
            }
        }

    }
}
