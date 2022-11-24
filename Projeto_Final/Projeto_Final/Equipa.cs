using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Equipa
    {
        public Equipa()
        {
            Guid Id_Equipa = Guid.NewGuid();
        }
        public virtual string Nome_Equipa { get; set; }

        public List<Membro> Membros { get; set; }
        


    }
}
