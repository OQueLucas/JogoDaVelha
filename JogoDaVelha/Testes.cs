using JogoDaVelha.Entities;

namespace JogoDaVelha
{
    internal class Testes
    {
        public static void VerificaLinha()
        {
            char[,] linhaUm = new char[3, 3] { { 'X', 'X', 'X' }, { '4', '5', '6' }, { '7', '8', '9' } };
            char[,] linhaDois = new char[3, 3] { { '1', '2', '3' }, { 'X', 'X', 'X' }, { '7', '8', '9' } };
            char[,] linhaTres = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { 'X', 'X', 'X' } };

            Vitoria.VerificaGanhador('X', linhaUm);
            Vitoria.VerificaGanhador('X', linhaDois);
            Vitoria.VerificaGanhador('X', linhaTres);
        }
        public static void VerificaColuna()
        {
            char[,] colunaUm = new char[3, 3] { { 'X', '2', '3' }, { 'X', '5', '6' }, { 'X', '8', '9' } };
            char[,] colunaDois = new char[3, 3] { { '1', 'X', '3' }, { '4', 'X', '6' }, { '7', 'X', '9' } };
            char[,] colunaTres = new char[3, 3] { { '1', '2', 'X' }, { '4', '5', 'X' }, { '7', '8', 'X' } };

            Vitoria.VerificaGanhador('X', colunaUm);
            Vitoria.VerificaGanhador('X', colunaDois);
            Vitoria.VerificaGanhador('X', colunaTres);
        }
        public static void VerificaDiagonal()
        {
            char[,] diagonal = new char[3, 3] { { 'X', '2', '3' }, { '4', 'X', '6' }, { '7', '8', 'X' } };
            char[,] diagonalSecundaria = new char[3, 3] { { '1', '2', 'X' }, { '4', 'X', '6' }, { 'X', '8', '9' } };

            Vitoria.VerificaGanhador('X', diagonal);
            Vitoria.VerificaGanhador('X', diagonalSecundaria);
        }
        public static void VerificaEmpate()
        {
            char[,] empate = new char[3, 3] { { 'X', 'O', 'X' }, { 'O', 'O', 'X' }, { 'X', 'X', 'O' } };

            Vitoria.VerificaGanhador('X', empate);
        }
    }
}
