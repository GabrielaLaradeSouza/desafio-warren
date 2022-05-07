using System;

namespace WarrenDesafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite = 1000000; // Configura limite que deseja validar
            int numeroInvertido = 0; // Variavel para armazenar o numero invertido
            int soma = 0; // Variavel que armazena o valor total N + reverso(n)
            //int contaNumero = 0; //Variavel para apresentar quantidade de registros (somente execução teste)
            

            Console.WriteLine("Retorna os numeros \"invertido\" + ele mesmo que resulta em um valor impar: ");

            for (int j = 0; j <= limite; j++) {
                numeroInvertido = retornaInvertido(j); // Preenche valor do numero reverso com função
                if (numeroInvertido > 0)
                {
                    soma = j + numeroInvertido; // Soma N + reverso(n)
                    if (((soma % 2) != 0) && (soma <= limite)) // Avalia se a soma dos numeros é IMPAR 
                    {                        
                        Console.WriteLine(j.ToString()); // Retorna os numeros reversiveis entre 0 e o limite configurado acima
                        /*Console.WriteLine(contaNumero++.ToString() + ": "
                            + j.ToString()
                            + " + "
                            + numeroInvertido.ToString()
                            + " = "
                            + soma.ToString());*/ // este comando serve para apresentar na tela a soma e quantidade de numeros
                    }
                }
            }

        }

        static public int retornaInvertido(int numero) {

            string auxNumero = numero.ToString();
            string numeroInvertido = "";

            // Nesta função transformo o numero em uma string e incremento ela somando o caractere em questão + a string anterior
            for (int i = 0; i < auxNumero.Length; i++){
                numeroInvertido = auxNumero.Substring(i, 1) + numeroInvertido;
            };
            if (numeroInvertido.Substring(0, 1) == "0")
            {
                // Validação para ignorar numeros que começam com '0'
                return 0;
            } else {
                // Retorna o numero invertido
                return Int32.Parse(numeroInvertido);
            }   
        }


    }
}
