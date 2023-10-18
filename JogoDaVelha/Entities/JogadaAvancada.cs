namespace JogoDaVelha.Entities
{
    internal static class JogadaAvancada
    {
        public static char[] PosicaoLinha = new char[3];
        public static char[] PosicaoColuna = new char[3];
        public static char[] PosicaoDiagonal = new char[3];
        public static char[] PosicaoDiagonalSecundaria = new char[3];

        public static char[] GetPosicao(char jogador, char[,] jogoDaVelha)
        {
            if (VerificaLinha(jogador, jogoDaVelha))
            {
                return PosicaoLinha;
            }
            else if (VerificaColuna(jogador, jogoDaVelha))
            {
                return PosicaoColuna;
            }
            else if (VerificaDiagonal(jogador, jogoDaVelha))
            {
                return PosicaoDiagonal;
            }
            else if (VerificaDiagonalSecundaria(jogador, jogoDaVelha))
            {
                return PosicaoDiagonalSecundaria;
            }
            else
            {
                char[] vazio = { '\0', '\0', '\0' };
                return vazio;
            }
        }

        public static bool VerificaDiagonal(char jogador, char[,] jogoDaVelha)
        {
            int countJogador = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogador == jogoDaVelha[i, j] && i == j)
                    {
                        countJogador++;
                    }
                    if (i == j)
                    {
                        PosicaoDiagonal[i] = jogoDaVelha[i, j];
                    }
                }

                if (countJogador == 2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VerificaDiagonalSecundaria(char jogador, char[,] jogoDaVelha)
        {
            int countJogador = 0;

            for (int i = 0; i < jogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < jogoDaVelha.GetLength(1); j++)
                {
                    if (jogador == jogoDaVelha[i, j] && i + j == jogoDaVelha.GetLength(1) - 1)
                    {
                        countJogador++;
                    }
                    if (i + j == jogoDaVelha.GetLength(1) - 1)
                    {
                        PosicaoDiagonalSecundaria[i] = jogoDaVelha[i, j];
                    }
                }

                if (countJogador == 2)
                {
                    return true;
                }
            }
            return false;
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
