using System;
namespace LeituraTeclado {
    class TesteLeitura {
        static void Main(string[] args) {
            Console.Write("Seja bem-vinde! Vamos fazer uma opercação matemática?\n");
            Console.Write("Escolha uma das opções abaixo:\n");
            Console.Write("1 - Soma\n");
            Console.Write("2 - Subtração\n");
            Console.Write("3 - Multiplicação\n");
            Console.Write("4 - Divisão\n");

            //Lendo teclado
            string entrada;

            int naoDigitouCerto = 0;

            while (naoDigitouCerto == 0) {
                entrada = Console.ReadLine();
                
                if(Convert.ToInt32(entrada) < 1 && Convert.ToInt32(entrada) > 4) {
                    Console.Write("AVISO - É preciso escolher uma das opções!!!\n\n");
                    Console.Write("1 - Soma");
                    Console.Write("2 - Subtração\n");
                    Console.Write("3 - Multiplicação\n");
                    Console.Write("4 - Divisão\n");

                    naoDigitouCerto = 0;
                }
                else{
                    Console.Write("Você escolheu a opção " + entrada);
                    naoDigitouCerto = 1;
                }//Fim if
            }//Fim while

        }//Fim main
    }//Fim class
}//Fim namespace