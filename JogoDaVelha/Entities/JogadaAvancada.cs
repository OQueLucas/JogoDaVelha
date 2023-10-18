namespace JogoDaVelha.Entities
{
    internal static class JogadaAvancada
    {
        public static char[] PosicaoLinha = new char[3];
        public static char[] PosicaoColuna = new char[3];

        public static char[] GetPosicaoLinha(char jogador, char[,] jogoDaVelha)
        {
            char[] linhas = new char[3];

            if (VerificaLinha(jogador, jogoDaVelha))
            {
                linhas = PosicaoLinha;
            }

            return linhas;
        }

        public static char[] GetPosicaoColuna(char jogador, char[,] jogoDaVelha)
        {
            char[] coluna = new char[3];

            if (VerificaColuna(jogador, jogoDaVelha))
            {
                coluna = PosicaoColuna;
            }

            return coluna;
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
            char adversario = (jogador == 'X') ? 'O' : 'X';
            int countJogador = 0;
            int countAdversario = 0;
            int podeGanhar;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    PosicaoLinha[j] = jogoDaVelha[i, j];
                    if (jogador == jogoDaVelha[i, j])
                    {
                        countJogador++;
                    }
                    else if (adversario == jogoDaVelha[i, j])
                    {
                        countAdversario++;
                    }
                }

                podeGanhar = countJogador - countAdversario;
                if (podeGanhar == 2)
                {
                    return true;
                }
                else
                {
                    countJogador = 0;
                    countAdversario = 0;
                }
            }
            return false;
        }

        public static bool VerificaColuna(char jogador, char[,] jogoDaVelha)
        {
            char adversario = (jogador == 'X') ? 'O' : 'X';
            int countJogador = 0;
            int countAdversario = 0;
            int podeGanhar;

            for (int i = 0; i < jogoDaVelha.GetLength(1); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(0); j++)
                {
                    PosicaoColuna[j] = jogoDaVelha[j, i];
                    if (jogador == jogoDaVelha[j, i])
                    {
                        countJogador++;
                    }
                    else if (adversario == jogoDaVelha[j, i])
                    {
                        countAdversario++;
                    }
                }

                podeGanhar = countJogador - countAdversario;
                if (podeGanhar == 2)
                {
                    return true;
                }
                else
                {
                    countJogador = 0;
                    countAdversario = 0;
                }
            }
            return false;
        }
    }
}
