namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //escrevendo asteriscos com o Break
            Console.WriteLine("Executando Projeto 13");
                for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
              
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
    
                    Console.Write("*");

                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }
                

                //uma forma diferente de fazer o desenho dos asteriscos
            Console.ReadLine();
        }
    }

}