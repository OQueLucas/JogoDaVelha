using JogoDaVelha.Entities;

namespace JogoDaVelha
{
    internal class Program
    {
        static void Main()
        {
            bool novoJogo;
            char confirmacao = 'N';
            char adversario = 's';
            //Testes.VerificaLinha();
            //Testes.VerificaColuna();
            //Testes.VerificaDiagonal();
            //Testes.VerificaEmpate();


            do
            {
                if (confirmacao == 'N')
                {
                    Console.WriteLine("::::::'##::'#######:::'######::::'#######:::::'########:::::'###:::::::'##::::'##:'########:'##:::::::'##::::'##::::'###::::\r\n:::::: ##:'##.... ##:'##... ##::'##.... ##:::: ##.... ##:::'## ##:::::: ##:::: ##: ##.....:: ##::::::: ##:::: ##:::'## ##:::\r\n:::::: ##: ##:::: ##: ##:::..::: ##:::: ##:::: ##:::: ##::'##:. ##::::: ##:::: ##: ##::::::: ##::::::: ##:::: ##::'##:. ##::\r\n:::::: ##: ##:::: ##: ##::'####: ##:::: ##:::: ##:::: ##:'##:::. ##:::: ##:::: ##: ######::: ##::::::: #########:'##:::. ##:\r\n'##::: ##: ##:::: ##: ##::: ##:: ##:::: ##:::: ##:::: ##: #########::::. ##:: ##:: ##...:::: ##::::::: ##.... ##: #########:\r\n ##::: ##: ##:::: ##: ##::: ##:: ##:::: ##:::: ##:::: ##: ##.... ##:::::. ## ##::: ##::::::: ##::::::: ##:::: ##: ##.... ##:\r\n. ######::. #######::. ######:::. #######::::: ########:: ##:::: ##::::::. ###:::: ########: ########: ##:::: ##: ##:::: ##:\r\n:......::::.......::::......:::::.......::::::........:::..:::::..::::::::...:::::........::........::..:::::..::..:::::..::");
                    Console.WriteLine();
                    Console.WriteLine("Deseja jogar contra máquina ou jogador?");
                    Console.Write("M - Maquina / J - Jogador / S - Sair do Jogo\n> ");
                    adversario = char.Parse(Console.ReadLine().ToUpper());
                    if (adversario == 'S')
                    {
                        break;
                    }
                    Console.Clear();
                }


                char[,] jogoDaVelha = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

                Tabuleiro tabuleiro = new(jogoDaVelha, adversario);

                tabuleiro.IniciarJogo();

                Console.Write("Deseja jogar novamente? (S/N)\n> ");
                _ = char.TryParse(Console.ReadLine().ToUpper(), out confirmacao);

                if (confirmacao == 'S' || adversario != 'S')
                {
                    novoJogo = true;
                    Console.Clear();
                }
                else
                {
                    novoJogo = false;
                }
            }
            while (novoJogo);
        }
    }
}