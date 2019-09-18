using System;
using System.Collections.Generic;
//GREICI EVANI DE SOUZA - RA:2019102652

/* 
  Elabore e implemente um projeto em Visual Studio – C#, que atenda as boas práticas da POO. 
O projeto deve implementar um sistema de cadastro com restrição de acesso, em MVC e collections e 
conforme as especificações abaixo:  
 
1) Menu com as opções de Incluir, Alterar, Excluir, Listar, Pesquisar e Sair. 
2) Na opção incluir o sistema deve possibilitar um cadastro de sua escolha com três (3) campos, 
que utilize uma classe entidade e List. 
3) Na opção alterar o sistema deve possibilitar que o usuário indique o registro a ser alterado 
(ID). O sistema deve mostrar os dados da referida posição e fazer novas leituras. 
4) Na opção excluir o sistema deve possibilitar que o usuário indique o registro a ser excluído 
(ID) e proceder a exclusão do referido registro. 
5) Na opção pesquisar o sistema deve possibilitar pesquisa textual por um dos campos e o 
resultado deve ser uma listagem que atenda o elemento pesquisado. 
6) Na opção sair o sistema deve dar uma mensagem de encerramento e encerrar a aplicação. 

 */
namespace TrabProg_1Bim
{
    class Program
    {

        static void Main(string[] args)
        {
            bool continuar = true;
            List<Cadastro> listaCadastro = new List <Cadastro>();

            do
            {

                // 1) Menu com as opções de Incluir, Alterar, Excluir, Listar, Pesquisar e Sair.
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Incluir");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Excluir");
                Console.WriteLine("4- Listar");
                Console.WriteLine("5- Pesquisar");
                Console.WriteLine("9- Sair");
                Console.Write("Digite a opção desejada: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //2) Na opção incluir o sistema deve possibilitar um cadastro de sua escolha com três (3) campos, que utilize uma classe entidade e List. 
                        listaCadastro.Add(incluirCadastro());
                        break;

                    case "2":

                        //3) Na opção alterar o sistema deve possibilitar que o usuário indique o registro a ser alterado (ID). 
                        //O sistema deve mostrar os dados da referida posição e fazer novas leituras. 
                        Console.WriteLine("Insira o ID do cadastro que deseja alterar: ");
                        int alterarCadastro = int.Parse(Console.ReadLine());
                        Cadastro buscaAlterar = listaCadastro.Find(x => x.Id == alterarCadastro);
                        if (buscaAlterar != null)
                        {
                            listaCadastro.Remove(buscaAlterar);
                            listaCadastro.Add(incluirCadastro());
                            Console.WriteLine("Cadastro alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado!");
                        }

                        break;

                    case "3":
                        //4) Na opção excluir o sistema deve possibilitar que o usuário indique o registro a ser excluído
                        //(ID) e proceder a exclusão do referido registro. 
                        Console.WriteLine("Insira o ID do cadastro que deseja excluir: ");
                        int excluirCadastro = int.Parse(Console.ReadLine());
                        Cadastro buscaExcluir = listaCadastro.Find(x => x.Id == excluirCadastro);
                        if (buscaExcluir != null)
                        {
                            listaCadastro.Remove(buscaExcluir);
                            Console.WriteLine("Cadastro excluído com sucesso! ");
                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado!");
                        }
                            break;
                        
                    case "4":
                        //Listar
                        Console.WriteLine("Lista de cadastrados: ");
                        foreach (Cadastro cadastro in listaCadastro)
                        {
                            Console.WriteLine(cadastro);
                        }

                        break;

                    case "5":
                        //5) Na opção pesquisar o sistema deve possibilitar pesquisa textual por um dos campos e o 
                        //resultado deve ser uma listagem que atenda o elemento pesquisado. 
                        Console.WriteLine("Insira o ID do cadastro que deseja pesquisar: ");
                        int pesquisaId = int.Parse(Console.ReadLine());

                        Cadastro pesquisar = listaCadastro.Find(pesq => pesq.Id == pesquisaId);

                        if (pesquisar != null)
                        {
                            Console.WriteLine("Cadastro localizado: " + pesquisar);

                        }
                        else
                        {
                            Console.WriteLine("ID não encontrado!");
                        }



                        break;

                    case "9":
                        //6) Na opção sair o sistema deve dar uma mensagem de encerramento e encerrar a aplicação. 
                        Console.WriteLine("Você está saindo do sistema!");

                        continuar = false;
                        
                        break;

                    default:

                        Console.WriteLine("OPÇÃO INVÁLIDA!");

                        break;

                }
                                                                            
            }
            while (continuar);

            Console.ReadKey();
        }
             

        private static Cadastro incluirCadastro()
        {

            Cadastro cadastro = new Cadastro();
            Console.WriteLine("Insira os seguintes dados: ");
            Console.Write("ID: ");
            cadastro.Id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            cadastro.Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            cadastro.Telefone = Console.ReadLine();
                       
            return (cadastro);
        }
    }
}