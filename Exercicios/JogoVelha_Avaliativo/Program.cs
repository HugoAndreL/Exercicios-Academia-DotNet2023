using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Threading.Channels;

namespace JogoVelha_Avaliativo
{
    internal class Program
    {
        static void Main()
        {
            ReniciarJogo();
        }

        static void LerPosicaoJogador(int player, char[,] game)
        {
            while (true)
            {
                int row = 0, col = 0;

                Console.WriteLine($"----- Vez do Jogador {player} -----");

                // Faz o loop de verificação da linha e coluna
                while (true)
                {
                    // Lê a linha
                    Console.Write($"Insira a LINHA desejada para o jogador {player}: ");
                    row = int.Parse(Console.ReadLine());

                    // Verifica a linha
                    if (row < 1 || row > 3)
                        Console.WriteLine("Valor da linha inválidos! Tente novamente.");

                    // Lê a coluna
                    Console.Write($"Agora insira a COLUNA desejada para o jogador {player}: ");
                    col = int.Parse(Console.ReadLine());

                    // Verifica se a coluna é um valor valido
                    if (col < 1 || col > 3)
                        Console.WriteLine("Valor invalido! Tente novamente.");

                    // Verifica se a linha e a coluna ja estão ocupados
                    else if (game[row - 1, col - 1] != '-')
                        Console.WriteLine($"Linha {row} e coluna {col} já ocupada.");

                    else break;
                }

                // Verifica se é o player 1 ou 2
                if (player == 1)
                    game[row - 1, col - 1] = 'X';
                else if (player == 2)
                    game[row - 1, col - 1] = 'O';

                return;
            }
        }

        static void MostrarGame(char[,] game)
        {
            Console.WriteLine("-------------------------");

            // Mostra a Matriz desejada
            Console.WriteLine($"O jogo está assim:");

            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                    Console.Write($"| {game[i, j]} ");
                Console.Write("|");
                Console.WriteLine();
            }
        }

        static bool Winner(char player, char[,] game)
        {
            // Verificar linhas
            for (int row = 0; row < game.GetLength(0); row++)
                if (game[row, 0] == player && game[row, 1] == player && game[row, 2] == player)
                    return true;

            // Verificar colunas
            for (int col = 0; col < game.GetLength(1); col++)
                if (game[0, col] == player && game[1, col] == player && game[2, col] == player)
                    return true;

            // Verificar 1º diagonal
            else if (game[0, 0] == player && game[1, 1] == player && game[2, 2] == player)
                return true;

            // Verificar 2º diagonal
            else if (game[0, 2] == player && game[1, 1] == player && game[2, 0] == player)
                return true;

            return false; // Retorna falso caso ninguém venceu
        }

        static bool Draw(char[,] game)
        {
            for (int row = 0; row < game.GetLength(0); row++)
                for (int col = 0; col < game.GetLength(1); col++)
                    if (game[row, col] == '-')
                        return false;

            // Se não houver células vazias e ninguém venceu, o jogo é um empate.
            return true;
        }

        static void ReniciarJogo()
        {
            char player = 'X';
            char[,] game = new char[3, 3] {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

            Console.WriteLine("----- Jogo da Velha -----");

            // Faz um loop para mostrar a vez de cada jogador
            for (int i = 0; i <= 9; i++)
            {
                MostrarGame(game);
                LerPosicaoJogador((player == 'X') ? 1 : 2, game);
                if (Winner(player, game))
                {
                    MostrarGame(game);
                    Console.WriteLine($"Vencedor: {(player == 'X' ? 1 : 2)}º Jogador");
                    break;
                }
                else if (Draw(game))
                {
                    MostrarGame(game);
                    Console.WriteLine("Empate!!!");
                    break;
                }

                player = (player == 'X') ? 'O' : 'X';
            }


            // Caso queira reniciar o jogo denovo
            Console.Write("\nDeseja reniciar o jogo (s - Sim | n - Não): ");
            char swcth = char.Parse(Console.ReadLine());
            if (swcth == 's' || swcth == 'S')
            {
                Console.Clear();
                ReniciarJogo();
            }
        }
    }
}