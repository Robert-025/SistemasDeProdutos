using System;

namespace SistemasDeProdutos
{
    class Program
    {
        static void CadastrarProduto(string[] nome, float[] preco, bool[] promocao, int contador = 0){
            if (contador < 10)
                    {
                        Console.WriteLine($"Insira o {contador + 1}º produto a ser cadastrado:");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        nome[contador] = Console.ReadLine();
                        Console.ResetColor();
                                
                        Console.WriteLine($"Qual o preço deste produto? ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        preco[contador] = float.Parse(Console.ReadLine());
                        Console.ResetColor();

                        Console.WriteLine($"Este produto está na promoção ? true/false ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        promocao [contador] = bool.Parse(Console.ReadLine());
                        Console.ResetColor();

                    }else{
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Limite de produtos excedido");
                        Console.ResetColor();
                    
                    }
        }
        static void MostrarProduto(string[] nome, float[] preco, bool[] promocao, int contador =  0){
            for (int i = 0; i < contador; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Produto: {nome[i]}");
                    Console.WriteLine($"Preço: {preco[i]}");
                    Console.WriteLine($"Promoção: {promocao[i]}");
                    
                    Console.WriteLine($"---------------------------------");
                    
                    Console.ResetColor();
                }
                
        }
        static void Main(string[] args)
        {
            //Variáveis
            int escolha;
            int contador = 0;
            string resposta;

            //Informações sobre o produto
            string[] nome = new string[10];
            float[] preco = new float [10];
            int[] unidades = new int [10];
            bool[] promocao = new bool[10];

            //menu
            do
            {  
                Console.WriteLine($"Menu");
                Console.WriteLine($"Escolha uma das opções abaixo");

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"[1] - Cadastrar produto");
                Console.WriteLine($"[2] - Mostrar os produtos");
                Console.WriteLine($"[3] - Sair");

                Console.ForegroundColor = ConsoleColor.DarkGreen;;

                escolha = int.Parse(Console.ReadLine());

                Console.ResetColor();

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine($"Cadastrar o produto ");

                        do
                        {
                            CadastrarProduto(nome,preco,promocao,contador);
                            contador++;

                            Console.WriteLine($"Quer cadastrar outro produto? sim/não");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            resposta = Console.ReadLine();
                            Console.ResetColor();
                            
                        } while (resposta == "sim");

                      break;

                     case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Mostrar os produtos.");

                        MostrarProduto(nome,preco,promocao,contador);
                        
                        break;

                    case 3:
                        Console.WriteLine($"Agradecemos a preferência :)");
                        
                      break;

                    default: Console.WriteLine($"Opção inválida!");
                    
                        break;
                }
                
            } while (escolha != 3);

        }
    }
}
