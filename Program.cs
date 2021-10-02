using System;

namespace OperadoresLogicosRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var a = 2;
            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");
                Console.WriteLine("==============");
            }
            else if (a == 2)
            {
                Console.WriteLine("Caiu no bloco do senão se");
            }
            else
            {
                Console.WriteLine("Caiu no bloco do senão");
            }
            Console.WriteLine("Olá Pessoal");
            Console.ReadLine();*/

            //OPERADOR SWITCH
            /*var a = 3; 
            switch(a)
            {
                case 'M':
                    Console.WriteLine("caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;

            }
            Console.WriteLine("Olá Mundo");
            Console.Read();
            */
            //OPERADOR TERNARIO
            var d = 5;
            string teste = "Davi";

            teste = (d == 1 ? "O valor de a" : "Mais um");
            Console.WriteLine("Olá Pessoal " + teste);
            Console.Read();
        }




    }
}
