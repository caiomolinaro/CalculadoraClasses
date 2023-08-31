namespace CalculadoraClasses
{
    public class Subtrair : Soma
    {
        public override void ExibirResultado()
        {
            Console.WriteLine($"O resultado de {num1} - {num2} = {num1 - num2}");

        }
    }
}
