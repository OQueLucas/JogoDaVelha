namespace JogoDaVelha.Entities
{
    internal class Tabuleiro
    {
        public char[,] JogoDaVelha { get; set; }
        public char Adversario { get; set; }
        public char Jogador { get; set; }
        public bool EmPartida { get; set; }
        public bool ProximoTurno { get; set; }
        public byte Dificuldade { get; set; }
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Tabuleiro(char[,] jogoDaVelha, char adversario, byte dificuldade)
        {
            JogoDaVelha = jogoDaVelha;
            Adversario = adversario;
            Jogador = 'X';
            EmPartida = true;
            ProximoTurno = false;
            Dificuldade = dificuldade;
        }

        public void IniciarJogo()
        {
            while (EmPartida)
            {
                try
                {
                    Tela.ImprimirPartida(JogoDaVelha);

                    if (Adversario == 'M' && Jogador == 'X')
                    {
                        MovimentoMaquina();
                    }
                    else
                    {
                        MovimentoJogador();
                    }

                    if (Vitoria.VerificaGanhador(Jogador, JogoDaVelha))
                    {
                        EmPartida = false;
                    }
                    else
                    {
                        PassarTurno();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private bool MovimentoJogador()
        {
            Console.Write($"Digite onde deseja inserir o {Jogador} de (1-9): ");
            char posicao = char.Parse(Console.ReadLine());

            if (TesteJogada(posicao) == true)
            {
                RealizarJogada();
            }

            return true;
        }

        private bool MovimentoMaquina()
        {
            if (Dificuldade == 0)
            {
                Facil();
            }
            else
            {
                Dificil();
            }

            RealizarJogada();

            return true;
        }

        private char Facil()
        {
            Random rng = new();
            int novo = rng.Next(1, 9);

            char posicao = char.Parse(novo.ToString());
            TesteJogada(posicao);
            return posicao;
        }

        private char Dificil()
        {
            char[] posicoes = { '1', '3', '7', '9' };

            var linha = JogadaAvancada.GetPosicaoLinha(Jogador, JogoDaVelha);
            var coluna = JogadaAvancada.GetPosicaoColuna(Jogador, JogoDaVelha);

            if (coluna != null)
            {
                foreach (char c in coluna)
                {
                    if (c != 'X' && c != 'O' && c != 0)
                    {
                        if (TesteJogada(c))
                        {
                            return c;
                        }
                    }
                }
            }

            for (int i = 0; i < posicoes.Length; i++)
            {
                try
                {
                    if (TesteJogada(posicoes[i]))
                    {
                        return posicoes[i];
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            return Facil();
        }

        private bool TesteJogada(char posicao)
        {
            for (int i = 0; i < JogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < JogoDaVelha.GetLength(1); j++)
                {
                    if (posicao == JogoDaVelha[i, j])
                    {
                        Linha = i;
                        Coluna = j;
                        return true;
                    }
                }
            }
            Console.Clear();
            throw new Exception($"Posicao {posicao} inserida é invalida!");
        }
        public char Fatality(char[] linha)
        {
            if (linha != null)
            {
                foreach (char c in linha)
                {
                    if (c != 'X' && c != 'O' && c != 0)
                    {
                        if (TesteJogada(c))
                        {
                            return c;
                        }
                    }
                }
            }
            return '0';
        }

        private void RealizarJogada()
        {
            JogoDaVelha[Linha, Coluna] = Jogador;
            ProximoTurno = true;
        }

        private void PassarTurno()
        {
            Console.Clear();
            Jogador = Jogador == 'X' ? 'O' : 'X';
            ProximoTurno = false;
        }
    }
}