using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("◤━━━━━━━━━━━ Cronometro ━━━━━━━━━━━◥");
        Console.WriteLine("〡 S = Segundo -> 10s = 10 Segundos〡");
        Console.WriteLine("〡 M = Minuto -> 1m = 1 Minuto     〡");
        Console.WriteLine("〡 0 - Sair                        〡");
        Console.WriteLine("◣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━◢");
        Console.Write("Quanto tempo deseja contar? ");

        string data = Console.ReadLine()!.ToLower();

        if(data.Length > 1 && data != "0")
        {
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            PreStart(time * multiplier);
        }
        else if (data == "0")
        {   
            Console.WriteLine("Saindo...");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
        else
        {   
            Console.WriteLine("");
            Console.WriteLine("Digite uma opção valida!");
            Thread.Sleep(2000);

            for (int i = 3; i > 0; i--){
                Console.Clear();
                Console.WriteLine("Digite uma opção valida!");
                Console.WriteLine($"Voltando ao menu em: {i} Segundos");
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Menu();
         }
    }
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("[Ready...]");
        Thread.Sleep(1000);
        Console.WriteLine("[Set...]");
        Thread.Sleep(1000);
        Console.WriteLine("[Go...]");
        Thread.Sleep(2500);

        Start(time);
    }
    static void Start(int time)
    {
        
        int currentTime = 0_0;

        double totalPorcentagem = (double)time;

        while (currentTime != time)
        {
            totalPorcentagem = (100 / (double)time) * (currentTime + 1);

            Console.Clear();
            currentTime++;
            Console.WriteLine("◤━━━━━━━━━━━━━━━━━━━━◥");
            Console.WriteLine($"    Cronometro: {currentTime}    ");

            if(totalPorcentagem < 20)
                Console.WriteLine("   [■□□□□□□□□□] 10%   ");
            else if(totalPorcentagem >= 20 && totalPorcentagem < 30)
                Console.WriteLine("   [■■□□□□□□□□] 20%   ");
            else if(totalPorcentagem >= 30 && totalPorcentagem < 40)
                Console.WriteLine("   [■■■□□□□□□□] 30%   ");
            else if(totalPorcentagem >= 40 && totalPorcentagem < 50)
                Console.WriteLine("   [■■■■□□□□□□] 40%   ");
            else if(totalPorcentagem >= 50 && totalPorcentagem < 60)
                Console.WriteLine("   [■■■■■□□□□□] 50%   ");
            else if(totalPorcentagem >= 60 && totalPorcentagem < 70)
                Console.WriteLine("   [■■■■■■□□□□] 60%   ");
            else if(totalPorcentagem >= 70 && totalPorcentagem < 80)
                Console.WriteLine("   [■■■■■■■□□□] 70%   ");
            else if(totalPorcentagem >= 80 && totalPorcentagem < 90)
                Console.WriteLine("   [■■■■■■■■□□] 80%   ");
            else if(totalPorcentagem >= 90 && totalPorcentagem < 100)
                Console.WriteLine("   [■■■■■■■■■□] 90%   ");
            else if(totalPorcentagem == 100)
                Console.WriteLine("   [■■■■■■■■■■] 100%  ");
            
            Console.WriteLine("◣━━━━━━━━━━━━━━━━━━━━◢");
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("◤━━━━━━━━━━━━━━━━━━━━━◥");
        Console.WriteLine("  Stopwatch finalizado");
        Console.WriteLine("◣━━━━━━━━━━━━━━━━━━━━━◢");
        Thread.Sleep(2000);
        
        Menu();
    }
}