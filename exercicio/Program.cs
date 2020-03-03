using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PARA NOSSA ALEGRIA:");
              Console.ForegroundColor = ConsoleColor.Green;
            string musica = @"Nos galhos secos de uma árvore qualquer
             Onde ninguém jamais pudesse imaginar
             O Criador vê uma flor à brotar

            Olhai, olhai, olhai
            Os lírios cresceram no campo
            E o Senhor nosso Deus
            Os têm alimentado para nossa alegria";
            Console.WriteLine(musica);
            Console.ForegroundColor = ConsoleColor.Red;
            string refrao = @"Para nossa alegria..... Para nossa alegria...!!!! Para nossa alegria!!!!!";
            Console.WriteLine(refrao);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
