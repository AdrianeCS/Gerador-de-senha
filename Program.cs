using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Entre com um valor de cacteres da sua senha: ");
            int qte = int.Parse(Console.ReadLine()!);
            string Possiblechars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" 
                + "abcdefghijklmnopqrstuvwxyzç" 
                + "123456789" + "#@%$!&";
            Random sort = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder passWorld = stringBuilder;
            for (int i = 0; i < qte; i++)
            {
                int sortNumber = V;
                sortNumber = sort.Next(0, Possiblechars.Length - 1);
                passWorld.Append(Possiblechars[sortNumber]);
            }
            Console.WriteLine($"A senha gerada é: {passWorld}");
            Console.WriteLine();
            Question:
            Console.WriteLine("Gerar Nova senha? (S/N)");
            char res = char.Parse(Console.ReadLine()!);
            if(res == 's' || res == 'S')
            {
                Console.Clear();
                goto Inicio;
            }
            else if (res == 'n' || res == 'N')
            {
                Console.WriteLine("Obrigado por usar esta Aplicação :D");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite um comando valido!");
                goto Question;
            }
        }
    }
}

