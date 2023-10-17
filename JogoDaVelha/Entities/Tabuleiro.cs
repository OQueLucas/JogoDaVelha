namespace JogoDaVelha.Entities
{
    internal class Tabuleiro
    {
        public char[,] JogoDaVelha { get; set; }
        public char Adversario { get; set; }
        public char Jogador { get; set; }
        public bool EmPartida { get; set; }
        public bool ProximoTurno { get; set; }

        public Tabuleiro(char[,] jogoDaVelha, char adversario)
        {
            JogoDaVelha = jogoDaVelha;
            Adversario = adversario;
            Jogador = 'X';
            EmPartida = true;
            ProximoTurno = false;
        }

        public void IniciarJogo()
        {
            while (EmPartida)
            {
                try
                {
                    Tela.ImprimirPartida(JogoDaVelha);

                    if (Adversario == 'M' && Jogador == 'O')
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
            bool entrada = char.TryParse(Console.ReadLine(), out char posicao);

            RealizarJogada(posicao);

            if (!ProximoTurno || !entrada)
            {
                Console.Clear();
                throw new Exception("Casa inserida é invalida!");
            }
            return true;
        }


        private bool MovimentoMaquina()
        {
            Random rng = new();
            int novo = rng.Next(1, 9);

            char posicao = char.Parse(novo.ToString());
            Console.WriteLine(posicao);

            RealizarJogada(posicao);

            if (!ProximoTurno)
            {
                Console.Clear();
                throw new Exception("Casa inserida é invalida!");
            }
            return true;
        }

        private void RealizarJogada(char posicao)
        {
            for (int i = 0; i < JogoDaVelha.GetLength(0); i++)
            {
                for (int j = 0; j < JogoDaVelha.GetLength(1); j++)
                {
                    if (posicao == JogoDaVelha[i, j])
                    {
                        JogoDaVelha[i, j] = Jogador;
                        ProximoTurno = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (ProximoTurno)
                {
                    break;
                }
            }
        }

        private void PassarTurno()
        {
            Console.Clear();
            Jogador = Jogador == 'X' ? 'O' : 'X';
            ProximoTurno = false;
        }
    }
}

