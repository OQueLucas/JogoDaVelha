namespace JogoDaVelha.Entities
{
    internal class Tabuleiro
    {
        public char[,] JogoDaVelha { get; set; } = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' } , { '7', '8', '9' } } ;
        public int Turno { get; set; }
        public bool EmPartida { get; set; }

        public Tabuleiro()
        {
            Turno = 1;
            EmPartida = true;
        }

        public static void IniciarJogo(char[,] JogoDaVelha)
        {
            foreach (char item in JogoDaVelha)
            {
                Console.WriteLine(item);
            }
        }
    }
}
