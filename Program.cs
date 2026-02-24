////Crie um programa para saber se um numero e par ou impar

//Console.WriteLine("Digite um numero inteiro: ");

//string entradaUser = Console.ReadLine();
//int numero;

////int num = Convert.ToInt32(entradaUser);

//if(int.TryParse(entradaUser, out numero))
//{
//    string resultado = (numero % 2 == 0) ? "PAR" : "IMPAR";
//    Console.WriteLine(resultado);
//}

///*if(num % 2 == 0)
//{
//    Console.WriteLine($"O numero {num} é PAR");
//}
//else
//{
//    Console.WriteLine($"O numero {num} é IMPAR");
//}*/

// 2. IMprimaa tabuada de um numero

//Console.WriteLine("Digite um numero para ver a tabuada");

//int numero = Convert.ToInt32(Console.ReadLine());
//int b = 0;

//while(b <= 10)
//{
//    int x = numero * b;
//    Console.WriteLine($" {numero} * {b} = {x}");

//    b++;
//}

//for (int i = 0; i <= 10; i++)
//{
//    int y = numero * i;
//    Console.WriteLine($" {numero} * {i} = {y}");
//}

// 3. Crie umasoma que calculat todos os numero de uma lista
//int[] numeros = { 10, 20, 30, 40, 50 };
//int soma = 0;

//foreach (int i in numeros)
//{
//    soma += i;
//}

//Console.WriteLine($"A soma dos numeros {soma}");

//4- criar um programa que so aceita numeros positivos e continua solicitando o novo valor ate que seja
//inserido um valido

int numero;

do
{
    Console.WriteLine("Digite um numero positivo");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero < 0)
    {
        Console.WriteLine("Numero invalido");
    }

} while (numero < 0);      