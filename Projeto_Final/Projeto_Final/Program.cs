using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_Final
{
    public class Program
    {
        public static List<Equipa> list_equipa = new List<Equipa>();

        public static List<Membro> list_membros = new List<Membro>();

        public static List<Tarefas> list_tarefas = new List<Tarefas>();

        public static List<Projeto> list_projeto = new List<Projeto>();

        static void Main(string[] args)
        {
            //Devem ser facultadas interfaces que permitam ao utilizador
            int op;

            Equipa equipa = new Equipa();
            Membro membro = new Membro();
            Tarefas tarefas = new Tarefas();
            Projeto projeto = new Projeto();

            try
            {
                do
                {
                    Console.WriteLine("---------- MENU ----------");
                    Console.WriteLine("1 - Adicionar e Remover Registos "); //Listas?????????????
                    Console.WriteLine("2 - Edição de Projectos, Equipas e Tarefas "); //(bonificação de 20 %)
                    Console.WriteLine("3 - Imprimir relatório das Tarefas que passaram do prazo por concluir ");//(bonificação de 15 %)
                    Console.WriteLine("4 - Impressão de um relatório por entidade com todos os campos ");//(bonificação de 10 %)
                    Console.WriteLine("0 - Para Sair ");
                    op = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("Saindo do programa..."); break;
                        case 1:
                            Console.WriteLine("Escolha a opção a realizar");
                            Console.WriteLine("1 - Adicionar");
                            Console.WriteLine("2 - Remover");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1://Adicionar
                                    Console.WriteLine("Escolhe entidade a adicionar registo");
                                    Console.WriteLine("1 - Equipa");
                                    Console.WriteLine("2 - Membro");
                                    Console.WriteLine("3 - Tarefas");
                                    Console.WriteLine("4 - Projeto");
                                    Console.WriteLine("0 - Sair do programa");
                                    op = Convert.ToInt32(Console.ReadLine());

                                    switch (op)
                                    {
                                        case 1:
                                            /*Equipa equipa = new Equipa();
                                            Console.WriteLine("Insira nome da equipa:");
                                            equipa.Nome_Equipa = Console.ReadLine();
                                            //lista de membros
                                            list_equipa.Add(equipa);*/
                                            Equipa.Adicionar_Equipa();
                                            break;
                                        case 2:
                                            Membro.Adicionar_Membro();
                                            break;
                                        case 3:
                                            Tarefas.Adicionar_Tarefas();
                                            break;
                                        case 4:
                                            Projeto.Adicionar_Projeto();
                                            break;
                                        case 0:
                                            Console.WriteLine("A sair do programa"); break;
                                        default:
                                            Console.WriteLine("Opção Inválida. Tente outra vez"); break;
                                    }
                                    break;
                                case 2: //Remover
                                    Console.WriteLine("Escolhe entidade a remover registo");
                                    Console.WriteLine("ATENÇÃO - Remove o primeiro registo efetuado");
                                    Console.WriteLine("1 - Equipa");
                                    Console.WriteLine("2 - Membro");
                                    Console.WriteLine("3 - Tarefas");
                                    Console.WriteLine("4 - Projeto");
                                    Console.WriteLine("0 - Sair do programa");
                                    op = Convert.ToInt32(Console.ReadLine());

                                    switch (op)
                                    {
                                        case 1:
                                            list_equipa.Remove(equipa);
                                            break;
                                        case 2:
                                            list_membros.Remove(membro);
                                            break;
                                        case 3:
                                            list_tarefas.Remove(tarefas);
                                            break;
                                        case 4:
                                            list_projeto.Remove(projeto);
                                            break;
                                        case 0: Console.WriteLine("Voltando ao menu"); break;
                                        default:
                                            Console.WriteLine("Opção Inválida. Tente outra vez"); break;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Escolha o que pretende editar:");
                            Console.WriteLine("1 - Projetos");
                            Console.WriteLine("2 - Equipas");
                            Console.WriteLine("3 - Tarefas");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1: //Edição de projetos
                                    break;
                                case 2: //Edição de Equipas
                                    break;
                                case 3: //Edição de tarefas
                                    break;
                            }
                            break;
                        case 3:

                            break;
                        case 4:
                            Console.WriteLine("Escolha a entitade a imprimir:");
                            Console.WriteLine("1 - Relatório de Equipa");
                            Console.WriteLine("2 - Relatório de Projeto");
                            Console.WriteLine("3 - Relatório de Tarefas");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1: //Equipa  
                                    Equipa.Imprimir_Equipa();
                                    break;
                                case 2: //Projeto
                                    Projeto.Imprimir_Projeto();
                                    break;
                                case 3: //Tarefas
                                    Tarefas.Imprimir_Tarefas();
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Opção Inválida. Tente outra vez"); break;
                    }

                } while (op != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro encontrado. Tente outra vez");
            }


        }
    }
}
