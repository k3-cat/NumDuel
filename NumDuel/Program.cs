using System;

namespace NumDuel {
    class Program {
        static void Main(string[] args) {
            Console.Title = "NumDuel by Pix-00";
            Console.Write("secert: ");
            var secert = Console.ReadLine();
            var title = Console.Title + $" | {secert} | ";
            var input = new Input();
            var token = new Token(secert);
            var game = new Game();

            while (true) {
                Console.Title = title + $"({game.win}/{game.lose}/{game.draw})";
                Console.WriteLine("- - - - - - - - - - - -");
                Console.Write("a: ");
                var a = input.GetSelect();
                token.Generate(a);
                Console.WriteLine($"time: {token.now}");
                Console.WriteLine($"token: {token.tk}");
                Console.WriteLine("- - - - -");
                Console.Write("b: ");
                var b = input.GetSelect();
                Console.Write("time: ");
                var time = Console.ReadLine();
                Console.Write("token: ");
                var tk = Console.ReadLine();
                if (token.Check(b, time, tk)) {
                    Console.WriteLine(" [ Token Valid ]");
                } else {
                    Console.WriteLine(" [ Token Invalid ]");
                }
                var result = game.CheckWin(a, b);
                if (result == 1) {
                    game.win += 1;
                    Console.WriteLine("You win!");
                } else if (result == -1) {
                    game.lose += 1;
                    Console.WriteLine("You lose!");
                } else {
                    game.draw += 1;
                    Console.WriteLine("Draw!");
                }
            }
        }
    }
}
