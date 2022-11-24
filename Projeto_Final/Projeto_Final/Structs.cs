using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Structs
    {
        struct Morada
        {
            public int Endereço { get; set; }
            public int Cod_Postal { get; set; }
        }
        struct Telefone
        {

            public int Indicativo { get; set; }
            public int Numero { get; set; }

        }
    }
}
