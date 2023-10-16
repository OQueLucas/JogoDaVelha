namespace JogoDaVelha
{
    internal class Vitoria
    {
        public static bool VerificaGanhador(char jogador, char[,] jogoDaVelha)
        {
            bool diagonal = Diagonal(jogador, jogoDaVelha);
            bool secundaria = DiagonalSecundaria(jogador, jogoDaVelha);
            bool linha = Linha(jogador, jogoDaVelha);
            bool coluna = Coluna(jogador, jogoDaVelha);

            if (diagonal || linha || coluna || secundaria)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Diagonal(char jogador, char[,] jogoDaVelha)
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

        public static bool DiagonalSecundaria(char jogador, char[,] jogoDaVelha)
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

        public static bool Linha(char jogador, char[,] jogoDaVelha)
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
                if (count != 3)
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

        public static bool Coluna(char jogador, char[,] jogoDaVelha)
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
                if (count != 3)
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

    }
}
