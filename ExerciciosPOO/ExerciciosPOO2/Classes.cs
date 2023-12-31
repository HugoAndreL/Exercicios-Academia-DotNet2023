﻿namespace ExerciciosPOO2
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Preco { get; set; }
        public int QuantEstoque { get; set; }

        public Produto() { }

        public Produto(int Id, string Name, double Preco, int QuantEstoque)
        {
            this.Id = Id;
            this.Name = Name;
            this.Preco = Preco;
            this.QuantEstoque = QuantEstoque;
        }

        public void AddProd(List<Produto> estoque)
        {
            // Faz um loop
            while (true)
            {
                // Id auto-icremento
                Id++;

                // Lê os valores
                Console.Write("Digite o nome do produto: ");
                Name = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                Preco = double.Parse(Console.ReadLine());

                Console.Write("Insira a quantidade do estoque do produto: ");
                QuantEstoque = int.Parse(Console.ReadLine());

                // Cria um construtor desse produto e adiciona na lista
                Produto prod = new(Id, Name, Preco, QuantEstoque);
                estoque.Add(prod);

                // Quebra de linha
                Console.WriteLine();


                Console.Write("Gostaria de adicionar mais um valor (s/n): ");
                char op = char.Parse(Console.ReadLine());

                if (op == 's' || op == 'S')
                    // Continua o loop
                    continue;
                else
                {
                    Console.WriteLine("Opção cancelada. Retornando à pagina de titulo.\n");
                    // Retorna ao menu 
                    return;
                }
            }
        }

        public void DelProd(List<Produto> estoque)
        {
            Console.WriteLine("Insira o id da produto: \n");

            Console.WriteLine("Consulta: ");
            MostrarProd(estoque);

            int id = int.Parse(Console.ReadLine());

            foreach (Produto prod in estoque.ToList())
            {
                if (prod.Id == id)
                    estoque.Remove(prod);
                else if (estoque.Count == 0)
                    Console.WriteLine("Não há produto para ser deletado!");
            }
            Console.WriteLine("Produto deletado com sucesso!");
        }

        public void MostrarProd(List<Produto> estoque)
        {
            Console.WriteLine("----------------------------------------");
            foreach (Produto prod in estoque)
            {
                Console.WriteLine("Id do produto: " + prod.Id);
                Console.WriteLine("Descrição da Tarefa: " + prod.Name);
                Console.WriteLine("Data de Vencimento da tarefa: " + prod.Preco);
                Console.WriteLine("Quantidade do produto: " + prod.QuantEstoque);
                Console.WriteLine("----------------------------------------");
            }
            // Caso não tenha nenhum produto disponivel, avisar
            if (estoque.Count == 0)
                Console.WriteLine("Não há produtos!");
        }
        public void BuscarProd(List<Produto> estoque)
        {
            Console.WriteLine("Insira o id do Imóvel: \n");

            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            foreach (Produto prod in estoque)
                if (prod.Id == id)
                {
                    Console.WriteLine("O telefone buscado foi o:");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Código: " + prod.Id);
                    Console.WriteLine("Nome: " + prod.Name);
                    Console.WriteLine("Preço: " + prod.Preco);
                    Console.WriteLine("Quantidade em estoque: " + prod.QuantEstoque);
                }
        }
    }

    internal class RegistroCompras
    {
        public RegistroCompras() { }

        public DateOnly Dat { get; set; }
        public string Prod { get; set; }
        public double Val { get; set; }

        public RegistroCompras(DateOnly Dat, string Prod, double Val)
        {
            this.Dat = Dat;
            this.Prod = Prod;
            this.Val = Val;
        }

        public void AddCompra(List<RegistroCompras> registros)
        {
            Console.Write("Insira a data da compra neste formato (AAAA, MM, DD): ");
            Dat = DateOnly.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            Prod = Console.ReadLine();

            Console.Write("Insira o valor do produto: ");
            Val = double.Parse(Console.ReadLine());

            RegistroCompras reg = new(Dat, Prod, Val);
            registros.Add(reg);
            Console.WriteLine();
        }

        public void ListarCompra(List<RegistroCompras> registros)
        {
            Console.WriteLine("A lista de compra de hoje foi de:");
            foreach (RegistroCompras r in registros)
            {
                Console.WriteLine("Data da compra: " + r.Dat);
                Console.WriteLine("Produto: " + r.Prod);
                Console.WriteLine("Valor do produto: " + r.Val);
                Console.WriteLine();
            }
        }

    }

    internal class CorretoraImoveis
    {
        public CorretoraImoveis() { }

        public int Id { get; set; }
        public string End { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public CorretoraImoveis(int Id, string End, double Preco, string Tipo)
        {
            this.Id = Id;
            this.End = End;
            this.Preco = Preco;
            this.Tipo = Tipo;
        }

        public void ListarImoveis(List<CorretoraImoveis> corretoraImoveis)
        {
            while (true)
            {
                // Id auto-icremento
                Id++;

                Console.Write("Digite o endereço da compra: ");
                End = Console.ReadLine();

                Console.Write("Digite o nome do produto: ");
                Preco = double.Parse(Console.ReadLine());

                Console.Write("Insira o valor do produto: ");
                Tipo = Console.ReadLine();

                CorretoraImoveis ci = new(Id, End, Preco, Tipo);
                corretoraImoveis.Add(ci);

                Console.WriteLine();

                Console.Write("Gostaria de adicionar mais um valor (s/n): ");
                char op = char.Parse(Console.ReadLine());
                if (op == 's' || op == 'S')
                {
                    continue;
                }
                else
                    Console.WriteLine("Opção cancelada. Retornando à pagina de titulo.\n");
                // Retorna ao seleção de exercicios 
                return;
            }
        }

        public void Calcular(List<CorretoraImoveis> corretoraImoveis)
        {
            double sum = 0;
            // Calcula a soma dos preços
            foreach (CorretoraImoveis ci in corretoraImoveis)
                sum += ci.Preco;
            double media = sum / corretoraImoveis.Count;
            Console.WriteLine("A média dos imóveis disponiveis é: " + media);
            // Caso não tenha nenhum imovel disponivel, avisar
            if (corretoraImoveis.Count == 0)
                Console.WriteLine("Não há imóveis disponiveis!");
        }

        internal void ApresentarImoveis(List<CorretoraImoveis> corretoraImoveis)
        {
            foreach (CorretoraImoveis ci in corretoraImoveis)
            {
                Console.WriteLine("Id do Imóvel: " + ci.Id);
                Console.WriteLine("Endereço do Imovel: " + ci.End);
                Console.WriteLine("Preço do Imovel: " + ci.Preco);
                Console.WriteLine("Tipo do Imovel: " + ci.Tipo);
                Console.WriteLine("----------------------------------------");
            }
            // Caso não tenha nenhum imovel disponivel, avisar
            if (corretoraImoveis.Count == 0)
                Console.WriteLine("Não há imóveis disponiveis!");
        }

        internal void AlterarPreco(List<CorretoraImoveis> corretoraImoveis)
        {
            Console.WriteLine("Isira o id do Imóvel: \n");

            // Consulta
            Console.WriteLine("Consulta: ");
            ApresentarImoveis(corretoraImoveis);

            Console.WriteLine();

            int id = int.Parse(Console.ReadLine());

            foreach (CorretoraImoveis ci in corretoraImoveis)
                if (id == ci.Id)
                {
                    Console.WriteLine("Digite o novo preço do Imóvel: ");
                    ci.Preco = double.Parse(Console.ReadLine());
                }
        }
    }

    internal class AgendaTelefonica
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public AgendaTelefonica() { }

        public AgendaTelefonica(int Id, string Name, string Tel, string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Tel = Tel;
            this.Email = Email;
        }

        public void AddTel(List<AgendaTelefonica> agendaTelefonica)
        {
            while (true)
            {
                // Id auto-icremento
                Id++;

                Console.Write("Digite o nome do contato: ");
                Name = Console.ReadLine();

                Console.Write("Digite o telefone do contato: ");
                Tel = Console.ReadLine();

                Console.Write("Digite o email do contato: ");
                Email = Console.ReadLine();

                AgendaTelefonica tel = new(Id, Tel, Name, Email);
                agendaTelefonica.Add(tel);

                Console.WriteLine();

                Console.Write("Gostaria de adicionar mais um valor (s/n): ");
                char op = char.Parse(Console.ReadLine());
                if (op == 's' || op == 'S')
                    continue;
                else
                    Console.WriteLine("Opção cancelada. Retornando à pagina de titulo.\n");
                // Retorna ao menu 
                return;
            }
        }

        public void DelTel(List<AgendaTelefonica> agendaTelefonica)
        {
            Console.WriteLine("Insira o id do Imóvel: \n");

            Console.WriteLine("Consulta: ");
            MostrarContato(agendaTelefonica);

            int id = int.Parse(Console.ReadLine());

            foreach (AgendaTelefonica tel in agendaTelefonica.ToList())
            {
                if (tel.Id == id)
                    agendaTelefonica.Remove(tel);
                else if (agendaTelefonica.Count == 0)
                    Console.WriteLine("Não há contato para ser deletado!");
            }
            Console.WriteLine("Contato deletado com sucesso!");
        }

        public void BuscarTel(List<AgendaTelefonica> agendaTelefonica)
        {
            Console.WriteLine("Insira o id do Imóvel: \n");

            Console.WriteLine("Consulta: ");
            MostrarContato(agendaTelefonica);

            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();

            foreach (AgendaTelefonica tel in agendaTelefonica)
                if (tel.Id == id)
                {
                    Console.WriteLine("O telefone buscado foi o:");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Telefone: " + tel.Tel);
                    Console.WriteLine("Nome: " + tel.Name);
                    Console.WriteLine("Email: " + tel.Email);
                }
        }

        public void MostrarContato(List<AgendaTelefonica> agendaTelefonica)
        {
            foreach (AgendaTelefonica tel in agendaTelefonica)
            {
                Console.WriteLine("Id do Imóvel: " + tel.Id);
                Console.WriteLine("Endereço do Imovel: " + tel.Tel);
                Console.WriteLine("Preço do Imovel: " + tel.Name);
                Console.WriteLine("Tipo do Imovel: " + tel.Email);
                Console.WriteLine("----------------------------------------");
            }
            // Caso não tenha nenhum imovel disponivel, avisar
            if (agendaTelefonica.Count == 0)
                Console.WriteLine("Não há imóveis disponiveis!");
        }
    }

    internal class GerenciadorTarefas
    {
        public GerenciadorTarefas() { }

        public int Id { get; set; }
        public string Desc { get; set; }
        public DateOnly DatVenc { get; set; }
        public bool Executada { get; set; }

        public GerenciadorTarefas(int Id, string Desc, DateOnly DatVenc, bool Executada)
        {
            this.Id = Id;
            this.Desc = Desc;
            this.DatVenc = DatVenc;
            this.Executada = Executada;
        }

        public void AddTarefa(List<GerenciadorTarefas> gerenciadorTarefas)
        {
            while (true)
            {
                // Id auto-icremento
                Id++;

                Console.Write("Digite a descrição da tarefa: ");
                Desc = Console.ReadLine();

                Console.Write("Digite a data de vencimento da tarefa neste formato (AAAA, MM, DD): ");
                DatVenc = DateOnly.Parse(Console.ReadLine());

                bool sw = false;

                if (DiaHoje())
                    sw = true;

                GerenciadorTarefas tarefa = new(Id, Desc, DatVenc, sw);
                gerenciadorTarefas.Add(tarefa);

                Console.WriteLine();

                Console.Write("Gostaria de adicionar mais um valor (s/n): ");
                char op = char.Parse(Console.ReadLine());
                if (op == 's' || op == 'S')
                {
                    continue;
                }
                else
                    Console.WriteLine("Opção cancelada. Retornando à pagina de titulo.\n");
                // Retorna ao menu 
                return;
            }
        }

        public void DelTarefa(List<GerenciadorTarefas> gerenciadorTarefas)
        {
            Console.WriteLine("Insira o id da Tarefa: \n");

            Console.WriteLine("Consulta: ");
            MostrarTarefas(gerenciadorTarefas);

            int id = int.Parse(Console.ReadLine());

            foreach (GerenciadorTarefas tarefa in gerenciadorTarefas.ToList())
            {
                if (tarefa.Id == id)
                    gerenciadorTarefas.Remove(tarefa);
                else if (gerenciadorTarefas.Count == 0)
                    Console.WriteLine("Não há contato para ser deletado!");
            }
            Console.WriteLine("Tarefa deletada com sucesso!");
        }

        public void MostrarTarefas(List<GerenciadorTarefas> gerenciadorTarefas)
        {
            foreach (GerenciadorTarefas tarefa in gerenciadorTarefas)
            {
                Console.WriteLine("Id da Tarefa: " + tarefa.Id);
                Console.WriteLine("Descrição da Tarefa: " + tarefa.Desc);
                Console.WriteLine("Data de Vencimento da tarefa: " + tarefa.DatVenc);
                Console.WriteLine("Execução da tarefa: " + tarefa.Executada);
                Console.WriteLine("----------------------------------------");
            }
            // Caso não tenha nenhum imovel disponivel, avisar
            if (gerenciadorTarefas.Count == 0)
                Console.WriteLine("Não há tarefas disponiveis!");
        }

        public bool DiaHoje()
        {
            bool diaHoje = false;
            Console.Write("Gostaria de executar a tarefa no dia de hoje (s/n): ");
            char sw = char.Parse(Console.ReadLine());
            if (sw == 's' || sw == 'S')
                diaHoje = true;
            return diaHoje;
        }
    }

    internal class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string Nome, string Autor, string Gravadora)
        {
            this.Nome = Nome;
            this.Autor = Autor;
            this.Gravadora = Gravadora;
        }
    }

    class Playlist
    {
        public List<Musica> Musicas { get; set; } = new List<Musica>();
        public string DonoPlaylist = Environment.UserName;

        public Playlist() { }

        public void TocarMusica()
        {
            Random rdn = new();
            Musica musica = Musicas[rdn.Next(Musicas.Count)];
            Console.WriteLine("Reprodução: " + musica.Nome + " de " + musica.Autor);
        }

        public void AddMusica(Musica musicaAdd)
        {
            Console.WriteLine("Gostaria de adicionar a musica " + musicaAdd.Nome + " em sua playlist? (s/n)");
            char op = char.Parse(Console.ReadLine());
            if (op == 's' || op == 'S')
                Musicas.Add(musicaAdd);
        }
    }
}
