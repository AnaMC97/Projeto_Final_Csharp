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
            public static int Endereço { get; set; }
            public static int Cod_Postal { get; set; }
        }
        struct Telefone
        {

            public int Indicativo { get; set; }
            public int Numero { get; set; }

        }
    }
}
