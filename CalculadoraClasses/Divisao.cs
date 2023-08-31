namespace CalculadoraClasses
{
    public class Divisao : Soma
    {
        public override void ExibirResultado()
        {
            Console.WriteLine($"O resultado de {num1} / {num2} = {(double)num1 / num2}");
            Console.WriteLine($"O resto da divisão é {num1 % num2}");
        }
    }
}
