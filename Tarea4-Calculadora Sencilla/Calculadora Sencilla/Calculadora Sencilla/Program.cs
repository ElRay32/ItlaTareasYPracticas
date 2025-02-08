
decimal number1;
decimal number2;
string opcionOperation;

try { 
Console.WriteLine("Calculadora Sencilla");
Console.WriteLine("Digite el numero de que operacion quiere realizar: 1.Suma, 2.Resta, 3.Multiplicacion, 4.Division. ");
opcionOperation = Console.ReadLine();


Console.WriteLine("Inserte el primer numero que quieres calcular(Dato numerico tiene que ser digitado)");
number1 = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Inserte el segundo numero que quieres calcular(Dato numerico tiene que ser digitado)");
number2 = Convert.ToDecimal(Console.ReadLine());

decimal result = 0;

switch (opcionOperation)
{
    case "1":
        {
            result = number1 + number2;
            break;
        }
    case "2":
        {
            result = number2 - number1;
            break;
        }
    case "3":
        {
            result = number1 * number2;
            break;
        }
    case "4":
        {
            result = number1 / number2;
            break;
        }
    default:
        result = 0;
        break;
}

Console.WriteLine($"Resultado:  {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArithmeticException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine($"No tiene el formato correcto");
}
catch (Exception ex) {
    Console.WriteLine(ex.Message); 
}



Console.ReadKey();
