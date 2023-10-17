namespace JogoDaVelha.Entities
{
    internal class Tela
    {
        public static void ImprimirPartida(char[,] jogoDaVelha)
        {
            Console.WriteLine();
            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    Console.ResetColor();
                    Console.Write(j == 0 ? " " : " | ");
                    if (jogoDaVelha[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(jogoDaVelha[i, j]);
                    }
                    else if (jogoDaVelha[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(jogoDaVelha[i, j]);
                    } else
                    {
                        Console.ResetColor();
                        Console.Write(jogoDaVelha[i, j]);
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(i == 2 ? "" : "---+---+---");
            }
        }
    }
}
