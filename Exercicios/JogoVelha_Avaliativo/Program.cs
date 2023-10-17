namespace JogoVelha_Avaliativo
{
    internal class Program
    {
        static void Main()
        {
            // Pergunta se jogara com alguem ou com a máquina
            Console.WriteLine("Multiplayer ou VS. maquina (1 - Multiplayer - M - Máquina)");
            char swcth = char.Parse(Console.ReadLine());

            // Verifica se jogará multiplayer ou vs. máquina
            if (swcth == '1')
                ReniciarJogo();
            else
            {
                Console.WriteLine("Você é o player 1.");
                ReniciarJogoMaquina();
            }
        }

        static void LerPosicaoJogador(string player, char[,] game)
        {
            while (true)
            {
                int row, col;

                Console.WriteLine("Obs.: Player 1 - X, Player 2 - O");
                Console.WriteLine($"----- Vez do Jogador {player} -----");

                // Faz o loop de verificação da linha e coluna
                while (true)
                {
                    // Lê a linha
                    Console.Write($"Insira a LINHA desejada para o jogador {player}: ");
                    row = int.Parse(Console.ReadLine());

                    // Lê a coluna
                    Console.Write($"Agora insira a COLUNA desejada para o jogador {player}: ");
                    col = int.Parse(Console.ReadLine());

                    // Verifica se a linha e coluna é um valor valido
                    if ((row < 1 || row > 3) || (col < 1 || col > 3))
                        Console.WriteLine("Valor invalido! Tente novamente.");

                    // Verifica se a linha e a coluna ja estão ocupados
                    else if (game[row - 1, col - 1] != '-')
                        Console.WriteLine($"Linha {row} e coluna {col} já ocupada. Tente novamente");

                    else break;
                }

                // Verifica se é o player 1 ou 2
                if (player == "1")
                    game[row - 1, col - 1] = 'X';
                else if (player == "2")
                    game[row - 1, col - 1] = 'O';

                return;
            }
        }

        static void MostrarGame(char[,] game)
        {
            // Mostra o game
            Console.WriteLine($"O jogo está assim:");

            // Dessenhando uma interface amigavel
            Console.WriteLine();
            for (int i = 0; i < game.GetLength(0); i++)
            {
                for (int j = 0; j < game.GetLength(1); j++)
                    Console.Write((j == 0 ? " " : " | " ) + game[i, j]);

                Console.WriteLine();
                Console.WriteLine(i == 2 ? "" : "---+---+---");
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

            return true; // Se não houver células vazias e ninguém venceu, o jogo é um empate.
        }

        static void ReniciarJogo()
        {
            char player = 'X';
            char[,] game = new char[3, 3] {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

            // Faz um loop para mostrar a vez de cada jogador
            for (int i = 0; i <= 9; i++)
            {
                Console.Clear();
                Console.WriteLine("##### Jogo da Velha #####");
                MostrarGame(game);
                LerPosicaoJogador((player == 'X') ? "1" : "2", game);
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


            // Lê a entrada para reniciar o jogo
            Console.Write("\nDeseja reniciar o jogo (s - Sim | n - Não): ");
            char swcth = char.Parse(Console.ReadLine());

            // Verifica se renicia o jogo
            if (swcth == 's' || swcth == 'S')
            {
                Console.Clear();
                Main();
            }
        }

        static void ReniciarJogoMaquina()
        {
            
        }
    }
}