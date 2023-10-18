using System.Buffers;

namespace ProjetoEditortexto
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção!");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short opc = short.Parse(Console.ReadLine());
            Operacoes(opc);
        }
        static void Operacoes(short opc)
        {
            switch (opc)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: AbrirArquivo(); break;
                case 2: CriarArquivo(); break;
                default: Menu(); break;
            }

        }

        static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string text = arquivo.ReadToEnd();//ler todo o arquivo
                Console.WriteLine(text);
            }
            Console.WriteLine(" ");
            Console.ReadLine();
            Menu();

        }

        static void CriarArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo, ou (Pressione ESC para SAIR)");
            Console.WriteLine("----------------------------------------------------");
            string text = "";

            do
            {

                text += Console.ReadLine();
                text = Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine(text);
            Thread.Sleep(1000);
            Console.WriteLine("Salvando..");
            SalvaArquivo(text);// AnaLISAR PQ O TEXTO NÃO É MOSTRADO

        }

        static void SalvaArquivo(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para salvar o arquivo.");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(path);
            }

            Thread.Sleep(1000);
            Console.WriteLine($"Arquivo {path} salvo!");
            Console.ReadLine();
            Menu();

        }

    }
}