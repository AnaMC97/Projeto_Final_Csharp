using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Membro
    {
        public Membro()
        {
            Guid Id_Membros = Guid.NewGuid();
        }

        public  string Nome { get; set; }
        //ficheiro para struct
        public string Morada { get; set; }
        public int telefone { get; set; }
        public  string Email { get; set; }
        public  int Idade { get; set; }



    }
}
