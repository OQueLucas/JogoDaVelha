namespace JogoDaVelha
{
    internal class Program
    {
        static void Main()
        {
            char[,] jogoDaVelha = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            bool emPartida = true;
            char jogador = 'X';
            bool proximoTurno = false;

            while (emPartida)
            {
                Console.Clear();
                for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
                {
                    for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                    {
                        Console.Write(jogoDaVelha[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.Write($"Digite onde deseja inserir o {jogador}: ");
                bool entrada = char.TryParse(Console.ReadLine(), out char posicao);

                if (!entrada)
                {
                    Console.Clear();
                    Console.WriteLine("Casa inserida é invalida!");
                    continue;
                }

                for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
                {
                    for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                    {
                        if (posicao == jogoDaVelha[i, j])
                        {
                            jogoDaVelha[i, j] = jogador;
                            proximoTurno = true;
                            break;
                        }
                    }
                    Console.WriteLine();
                    if (proximoTurno)
                    {
                        break;
                    }
                }

                if (!proximoTurno)
                {
                    Console.Clear();
                    Console.WriteLine("Casa inserida é invalida!");
                    continue;
                }

                if (Vitoria.VerificaGanhador(jogador, jogoDaVelha))
                {
                    Console.WriteLine($"Jogador {jogador} ganhou");
                    emPartida = false;
                }

                if (jogador == 'X')
                {
                    jogador = 'Y';
                }
                else
                {
                    jogador = 'X';
                }

                proximoTurno = false;


            }
        }
    }
}