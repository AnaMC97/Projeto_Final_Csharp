using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Projeto
    {
        public Projeto()
        {
            Guid Id_Projeto = Guid.NewGuid();

            Guid Id_Equipa = Guid.NewGuid(); //Chave id
        }

        public  string Nome { get; set; }

        public List<Tarefas> Tarefas { get; set; }

    }
}
