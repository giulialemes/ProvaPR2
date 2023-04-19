using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("escolha um exercicio: ");
            Console.WriteLine(" ==========MENU============ ");
            Console.WriteLine(" 1- EXERCÍCIO 1 ");
            Console.WriteLine(" 2- EXERCÍCIO 2 ");
            Console.WriteLine(" 3- EXERCÍCIO 3 ");
            Console.WriteLine(" 4- EXERCÍCIO 4 ");
            Console.WriteLine(" 5- EXERCÍCIO 5 ");
            Console.WriteLine(" 6- EXERCÍCIO 6 ");
            Console.WriteLine(" 7- EXERCÍCIO 7 ");
            Console.WriteLine(" ========================= ");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:

                    int numero;
                    Console.WriteLine("Digite um numero qualquer: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        numero = -numero;
                    }

                    Console.WriteLine("O valor absoluto do número é: " + numero);
                    Console.ReadKey();
                    break;


                case 2:

                    int NUMERE;
                    Console.WriteLine("Digite um numero inteiro: ");
                    NUMERE = int.Parse(Console.ReadLine());

                    if ((NUMERE % 3 == 0) && (NUMERE % 5 == 0))
                    {
                        Console.WriteLine("{0} é múltiplo de 3 e 5", NUMERE);
                    }
                    else if ((NUMERE % 4 == 0) && (NUMERE % 7 == 0))
                    {
                        Console.WriteLine("{0} é múltiplo de 4 e 7", NUMERE);
                    }
                    else if ((NUMERE % 3 == 0) && (NUMERE % 4 == 0) && (NUMERE % 5 == 0) && (NUMERE % 7 == 0))
                    {
                        Console.WriteLine("{0} é múltiplo de 3, 4, 5 e 7", NUMERE);
                    }
                    else if (NUMERE % 3 == 0)
                    {
                        Console.WriteLine("{0} é múltiplo de 3", NUMERE);
                    }
                    else if (NUMERE % 4 == 0)
                    {
                        Console.WriteLine("{0} é múltiplo de 4", NUMERE);
                    }
                    else if (NUMERE % 5 == 0)
                    {
                        Console.WriteLine("{0} é múltiplo de 5", NUMERE);
                    }
                    else if (NUMERE % 7 == 0)
                    {
                        Console.WriteLine("{0} é múltiplo de 7", NUMERE);
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir {0} por nenhum dos números 3, 4, 5 ou 7", NUMERE);
                    }
                       Console.ReadKey();
                    break;

                       

                case 3:

                    int numere1, numere2, numere3, maior;
                    Console.WriteLine("Digite 3 numeros de 1 a 10: ");
                    maior = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o primeiro numero: ");
                    numere1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    numere2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro numero: ");
                    numere3 = int.Parse(Console.ReadLine());

                    if (numere1 > numere2 && numere1 > numere3)
                    {
                        maior = numere1;
                    }
                    else if (numere2 > numere1 && numere2 > numere3)
                    {
                        maior = numere2;
                    }
                    else
                    {
                        maior = numere3;
                    }

                    Console.ReadKey();
                    break;


                case 4:

                    int number;

                    Console.WriteLine("====== MENU ======");
                    Console.WriteLine("1 - segunda - feira");
                    Console.WriteLine("2 - terça - feira");
                    Console.WriteLine("3 - quarta - feira");
                    Console.WriteLine("4 - quinta - feira");
                    Console.WriteLine("5 - sexta - feira");
                    Console.WriteLine("6 - sabado");
                    Console.WriteLine("7 - domingo");
                    Console.WriteLine("==================");

                    Console.WriteLine("Escreva um numero de 1 á 7: ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("segunda - feira: Filosofia, Portugues, Matematica");
                            break;
                        case 2:
                            Console.WriteLine("terça - feira: Quimica, Historia, Ingles");
                            break;
                        case 3:
                            Console.WriteLine("quarta - feira: Biologia, Portugues, Programação");
                            break;
                        case 4:
                            Console.WriteLine("quinta - feira: Fisica, Rede de computadores, Sociologia");
                            break;
                        case 5:
                            Console.WriteLine("sexta - feira: Geografia, Matematica, Banco de dados");
                            break;
                        case 6:
                            Console.WriteLine("sabado: Caminhar de manhã");
                            break;
                        case 7:
                            Console.WriteLine("domingo: Almoço de familia");
                            break;

                        default:
                            Console.WriteLine("Opção invalida");
                            Console.ReadKey();
                            break;
                    }
                    break;


                case 5:

                    int num, menor, Maior, parada = 1;
                    Maior =int.Parse(Console.ReadLine());
                    {
                        Console.Write("Digite um número inteiro: ");
                        num = int.Parse(Console.ReadLine());

                        menor = num;
                        maior = num;

                        for(int i = 0; parada !=0; i++)

                        
                        {
                            Console.WriteLine("Digite um numero: ");
                            num = int.Parse(Console.ReadLine());
                            if (num > Maior)
                            {
                                maior = num;
                            }

                            if (num < menor)
                            {
                                menor = num;
                            }
                            Console.WriteLine("Digite 1 para continuar ou {0} para parar");
                        }
                    }
                    
                    Console.WriteLine("O menor número da sequência é: " + menor);
                    Console.WriteLine("O maior número da sequência é: " + Maior);

                    Console.ReadKey();
                    break;


                case 6:

                    int numer, soma = 0;
                    Console.Write("Digite um número inteiro e PERFEITO: ");
                    numer = int.Parse(Console.ReadLine());

                    for (int i = 1; i < numer; i++)
                    {
                        if (numer % i == 0)
                        {
                            soma += i;
                        }
                    }

                    if (soma == numer)
                    {
                        Console.WriteLine(numer + " é um número perfeito");
                    }
                    else
                    {
                        Console.WriteLine(numer + " não é um número perfeito");
                        Console.ReadKey();
                        break;
                    }
                    break;
                    }
            Console.ReadKey();



        }
    }
}
