namespace JogoDaVelha.Entities
{
    internal static class Vitoria
    {
        public static int Linha;
        public static int Coluna;

        public static bool VerificaGanhador(char jogador, char[,] jogoDaVelha)
        {
            bool verificaDiagonal = VerificaDiagonal(jogador, jogoDaVelha);
            bool verificaSecundaria = VerificaDiagonalSecundaria(jogador, jogoDaVelha);
            bool verificaLinha = VerificaLinha(jogador, jogoDaVelha);
            bool verificaColuna = VerificaColuna(jogador, jogoDaVelha);
            bool empate = VerificaEmpate(jogoDaVelha);

            if (verificaDiagonal)
            {
                Console.Clear();
                Tela.ImprimirPartida(jogoDaVelha);
                Console.WriteLine($"Jogador {jogador} ganhou na diagonal!");
                return true;
            }
            else if (verificaSecundaria)
            {
                Console.Clear();
                Tela.ImprimirPartida(jogoDaVelha);
                Console.WriteLine($"Jogador {jogador} ganhouna diagonal secundária!");
                return true;
            }
            else if (verificaLinha)
            {
                Console.Clear();
                Tela.ImprimirPartida(jogoDaVelha);
                Console.WriteLine($"Jogador {jogador} ganhou na {Linha + 1}ª linha!");
                return true;
            }
            else if (verificaColuna)
            {
                Console.Clear();
                Tela.ImprimirPartida(jogoDaVelha);
                Console.WriteLine($"Jogador {jogador} ganhou na {Coluna + 1}ª coluna!");
                return true;
            }
            else if (empate)
            {
                Console.Clear();
                Tela.ImprimirPartida(jogoDaVelha);
                Console.WriteLine($"Empate!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificaDiagonal(char jogador, char[,] jogoDaVelha)
        {
            int count = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogador == jogoDaVelha[i, j] && i == j)
                    {
                        count++;
                    }
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificaDiagonalSecundaria(char jogador, char[,] jogoDaVelha)
        {
            int count = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogador == jogoDaVelha[i, j] && i + j == jogoDaVelha.GetLength(1) - 1)
                    {
                        count++;
                    }
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificaLinha(char jogador, char[,] jogoDaVelha)
        {
            int count = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogador == jogoDaVelha[i, j])
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    Linha = i;
                    break;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificaColuna(char jogador, char[,] jogoDaVelha)
        {
            int count = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(1); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(0); j++)
                {
                    if (jogador == jogoDaVelha[j, i])
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    Coluna = i;
                    break;
                }
                else
                {
                    count = 0;
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerificaEmpate(char[,] jogoDaVelha)
        {
            int count = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogoDaVelha[i, j] == 'X' || jogoDaVelha[i, j] == 'O')
                    {
                        count++;
                    } else
                    {
                        break;
                    }
                }
            }

            if (count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
