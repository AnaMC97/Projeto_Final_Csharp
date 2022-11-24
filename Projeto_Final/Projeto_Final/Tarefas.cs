using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Tarefas
    {
        public Tarefas()
        {
            Guid Id_Tarefas = Guid.NewGuid();
            Guid Id_Membros = Guid.NewGuid(); //chave Id estrangeira
        }

        public  string Titulo { get; set; }
        public  int Data_Inicio { get; set; }
        public  int Data_Fim { get; set; }

        enum Estado { PorIniciar = 1, Iniciado = 2, Pendente = 3, Bloqueado = 4, Completo = 5 }

    }
}
