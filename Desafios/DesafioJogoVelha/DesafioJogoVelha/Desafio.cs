namespace JogoVelha_Avaliativo;

class Desafio
{
    static void Main()
    {
        Color(ConsoleColor.Yellow, "##### Bem Vindos ao Jogo da Velha #####");
        Color(ConsoleColor.Cyan, "© Hugo André 2023");

        Console.Write("Primeiro selecione seu modo (2 - Multiplayer/0 - Máquina): ");
        int swc = int.Parse(Console.ReadLine());

        if (swc == 2)
            JogoMult();
        else if (swc == 0)
            JogoPC();
    }

    // Muda a cor do texto
    static void Color(ConsoleColor cor, string texto)
    {
        Console.ForegroundColor = cor;
        Console.WriteLine(texto);
        Console.ResetColor(); // Redefini a cor do texto para branco denovo
    }

    static void LerPosicaoJogador(char player, char[,] game)
    {
        while (true)
        {
            int pl = (player == 'X' ? 1 : 2);
            int row, col;

            Console.WriteLine("Obs.: Player 1 - X, Player 2 - O");

            Color((pl == 1 ? ConsoleColor.Green : ConsoleColor.Red), $"----- Vez do {pl}º Jogador -----");

            // Faz o loop de verificação da linha e coluna
            while (true)
            {
                // Lê a linha
                Console.Write($"Insira a LINHA desejada para o jogador {pl}: ");
                row = int.Parse(Console.ReadLine());

                // Lê a coluna
                Console.Write($"Agora insira a COLUNA desejada para o jogador {pl}: ");
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
            _ = (pl == 1) ? game[row - 1, col - 1] = ('X') : game[row - 1, col - 1] = 'O';

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
            {
                Console.Write(j == 0 ? " " : " | ");
                // Formatação de interface
                if (game[i, j] == 'X')
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (game[i, j] == 'O')
                    Console.ForegroundColor = ConsoleColor.Red;
                else Console.ResetColor();
                Console.Write(game[i, j]);
                Console.ResetColor();
            }

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

        return false; // Retorna falso caso ninguém tenha vencido
    }

    static bool Draw(char[,] game)
    {
        for (int row = 0; row < game.GetLength(0); row++)
            for (int col = 0; col < game.GetLength(1); col++)
                if (game[row, col] == '-')
                    return false;

        return true; // Se não houver células vazias e ninguém venceu, o jogo é um empate.
    }

    static void JogoMult()
    {
        char pl = 'X';
        char[,] game = new char[3, 3] {
            { '-', '-', '-' },
            { '-', '-', '-' },
            { '-', '-', '-' }
        };

        // Faz um loop para mostrar a vez de cada jogador
        for (int i = 0; i < 9; i++)
        {
            Console.Clear();
            MostrarGame(game);
            LerPosicaoJogador(pl, game);

            if (Winner(pl, game))
            {
                MostrarGame(game);
                Console.Write("\n");
                Color(pl == 'X' ? ConsoleColor.Green : ConsoleColor.Red, $"Vencedor: {(pl == 'X' ? 1 : 2)}º Jogador");
                break;
            }
            else if (Draw(game))
            {
                MostrarGame(game);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Empate!!!");
            }

            pl = (pl == 'X') ? 'O' : 'X';
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

    // Extra
    static void JogoPC()
    {
        char[,] game = new char[3, 3] {
                { '-', '-', '-' },
                { '-', '-', '-' },
                { '-', '-', '-' }
            };

        for (int i = 0; i < 9; i++)
        {
            Console.Clear();
            Console.WriteLine("##### Jogo da Velha #####");

            // Verifica se é a vez do PC ou do Jogador
            if (i % 2 == 0)
                PC(game);
            else
            {
                MostrarGame(game);
                LerPosicaoJogador('X', game);
            }

            // Verifica quem ganha 
            if (Winner('X', game))
            {
                MostrarGame(game);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vencedor: Jogador!");
                Console.ResetColor();
                break;
            }
            else if (Winner('O', game))
            {
                MostrarGame(game);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vencedor: Computador!");
                Console.ResetColor();
                break;
            }

            else if (Draw(game))
            {
                MostrarGame(game);
                Console.WriteLine("Empate!");
            }
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

    static void PC(char[,] game)
    {
        Color(ConsoleColor.Red, "Definindo a jogada da máquina.");

        // Escolher aleatoriamente um dos cantos como primeira jogada
        Random rdm = new Random();
        int[] cantos = new int[2] { 0, 2 };
        int row = cantos[rdm.Next(cantos.Length)];
        int col = cantos[rdm.Next(cantos.Length)];

        if (game[row, col] == '-')
            game[row, col] = 'O';
        else
            while (true)
            {
                row = rdm.Next(0, 2);
                col = rdm.Next(0, 2);

                if (game[row, col] == '-')
                {
                    game[row, col] = 'O';
                    break;
                }
            }
    }
}