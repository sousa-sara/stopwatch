using System;
using System.Threading; //sleep
namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); //tolower converte tudo para minúsculo se o usuário usar maiúscula
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //último dígito e no data substring o primeiro numero é inicial e o segundo é a quantidade de caractere (nesse caso, utiliza o length -1 pq começa do 0)
            //exemplo de banana> b= 0 a=1 n=2 etc. o 'a' é o valor (1,1)
            int time = int.Parse(data.Substring(0, data.Length - 1));
            //Console.WriteLine(data);
            int multiplier = 1;
            //definir abaixo tempo que vai contar com base nos segundos. mudar apenas multiplicador (60)
            //uma das opções abaixo:

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier); //passa pra essa tela do prestart antes do start
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready..."); //ready set go (preparar, apontar, fogo em inglês)
            Thread.Sleep(1000); //1 segundo
            Console.WriteLine("Set...");
            Thread.Sleep(1000); //1 segundo
            Console.WriteLine("Go...");
            Thread.Sleep(2500); //tempinho maior antes de começar a execução

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0; //vai percorrer de 0 até 10 (minuto atual)

            while (currentTime != time) //enquanto o tempo atual for diferente do tempo que a gente quer contar
            {
                Console.Clear(); //limpar a tela e digitar o tempo atual na tela
                currentTime++; //conta mais 1 até chegar no tempo 10
                Console.WriteLine(currentTime); //exibir na tela a contagem
                Thread.Sleep(1000); //dormir por 1000milisegundos ou seja, 1 segundo pra cada repetição do laço 
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500); //tempo de demora pra finalizar a aplicação depois

            /*Ao executar o dotnet run:
            "S = Segundo => 10s = 10 segundos
            M = Minuto => 1m = 1 minuto
            0 = Sair
            Quanto tempo deseja contar?"

            Ex.: 5s
            Enter

            "Ready...
            Set...
            Go...
            1
            2
            3
            4
            5
            Stopwatch finalizado"
            */
        }

    }
}