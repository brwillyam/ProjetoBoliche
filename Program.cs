using System;

namespace Boliche
{
    class Program
    {
        static void Main(string[] args)
        {
    
            string j1 , j2;
            Console.WriteLine("Digite o nome do jogador 1:");
            j1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador 2: ");
            j2 = Console.ReadLine();

            Console.WriteLine(j1 + " 1° frame:");
            Jogada();

            Console.WriteLine(j2 + " 1° frame ");
            Jogada();

            Console.WriteLine(j1 + " 2° frame:");
            Jogada();

            Console.WriteLine(j2 + " 2° frame ");
            Jogada();

           /* Console.WriteLine(j1 + " 3° frame:");
            Jogada(frame = 3);

            Console.WriteLine(j2 + " 3° frame ");
            Jogada(frame = 3);

            Console.WriteLine(j1 + " 4° frame:");
            Jogada(frame = 4);

            Console.WriteLine(j2 + " 4° frame ");
            Jogada(frame = 4);*/

            Console.ReadKey();


        }
        static void Jogada()
        {
            int b1 =0;
            int b2 = 0;
            Console.WriteLine("Jogue a primaira bola: ");
            b1 = int.Parse(Console.ReadLine());
            
            if(b1 == 10)
            {
                Console.WriteLine("STRIKE");
            }
            else{
                Console.WriteLine("jogue a segunda bola: ");
                 b2 = int.Parse(Console.ReadLine());
            }
            if(b2+b1 == 10)
            {
                Console.WriteLine("Spare");
            }
            int res = 0;
            res = b1+b2;
            if(res - b2 == 10)
            {

                res = res + 0;
                Console.WriteLine("O resultado eh: " + res);
            }
            else if(res == 10)
            {
                res = res + res ;
                Console.WriteLine("O resultado eh: " + res);
            }
            else
            {
                Console.WriteLine("o resultado eh: " + res);
            }



            Console.ReadKey();
        }

    }

}
