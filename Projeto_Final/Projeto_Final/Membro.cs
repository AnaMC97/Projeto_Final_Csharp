using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    public class Membro
    {
        public Guid Id_Membros { get; set; }
        public Membro()
        {
            Id_Membros = Guid.NewGuid();
        }

        public string Nome { get; set; }
        //ficheiro para struct
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public static void Adicionar_Membro()
        {
            Membro membro = new Membro();
            Console.WriteLine("Insira nome de membro:");
            membro.Nome = Console.ReadLine();
            Console.WriteLine("Insira morada do membro:");
            membro.Morada = Console.ReadLine();
            Console.WriteLine("Insira telefone do membro:");
            membro.Telefone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira email do membro:");
            membro.Email = Console.ReadLine();
            Console.WriteLine("Insira idade do membro:");
            membro.Idade = Convert.ToInt32(Console.ReadLine());
            Program.list_membros.Add(membro);
        }

        public static void Imprimir_Membro()
        {
            //NOTA -> Para ver se os dados estao a ser guardados
        }

    }
}
