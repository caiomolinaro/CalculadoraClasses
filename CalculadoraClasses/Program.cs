using CalculadoraClasses;

bool condicao = true;

do
{
    Console.WriteLine("Digite\n(+) para fazer Soma\n(-) para Subtrair\n(X) para Multiplicar\n(/) para Dividir\nDigite (S) para Sair\n");

    string? operacao = Console.ReadLine().ToLower();

    Console.WriteLine();

    Console.Clear();

    if (operacao == "+")
    {
        Soma soma = new();
        Console.WriteLine("Digite o primeiro numero: ");
        soma.num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        soma.num2 = Convert.ToDouble(Console.ReadLine());
        soma.ExibirResultado();
        Console.WriteLine();
    }


    else if (operacao == "-")
    {
        Subtrair sub = new();
        Console.WriteLine("Digite o primeiro numero: ");
        sub.num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        sub.num2 = Convert.ToDouble(Console.ReadLine());
        sub.ExibirResultado();
        Console.WriteLine();
    }

    else if (operacao == "x")
    {
        Multiplicacao mult = new();
        Console.WriteLine("Digite o primeiro numero: ");
        mult.num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        mult.num2 = Convert.ToDouble(Console.ReadLine());
        mult.ExibirResultado();
        Console.WriteLine();
    }

    else if (operacao == "/")
    {
        Divisao div = new();
        Console.WriteLine("Digite o primeiro numero: ");
        div.num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        div.num2 = Convert.ToDouble(Console.ReadLine());
        div.ExibirResultado();
        Console.WriteLine();
    }

    else if (operacao == "s")
    {
        Console.Clear();
        condicao = false;
    }
    
    else {Console.WriteLine("Você digitou algo errado\n");}

} while(condicao == true);
