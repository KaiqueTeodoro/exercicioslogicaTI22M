using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI22M
{
    class ExerciciosModel
    {
        //área de variáveis
        private double area;
        private double IMC;
        public int[] idade;//estrutura de dados finita
        public int[] numeros;
        public string[] nomes;
        public int media;
        public double[] altura;
        public double[] salario;
        public int[] par;
        public int[] impar;
        public int[] soma1;
        public int[] soma2;
        public int[,] matriz;//matriz
        public int[,] matrizB;
        public int[,] matrizC;
        public int[,] mat;
        public int[,] matB;
        public int[,] matrizD;
        //método construtor
        public ExerciciosModel() 
        {
            this.area = 0;
            this.IMC = 0;
            this.idade = new int[10];// de 0 a 9
            this.numeros = new int[10];
            this.nomes = new string[10];
            this.media = 0;
            this.altura = new double[10];
            this.salario = new double[10];
            this.par = new int[10];
            this.impar = new int[10];
            this.soma1 = new int[10];
            this.soma2 = new int[10];
            this.matriz = new int[3,3];//instanciar matriz
            this.matrizB = new int[4,4];
            this.matrizC = new int[3,3];
            this.mat = new int[2,2];
            this.matB = new int[2,2];
            this.matrizD = new int[5,5];
        }//fim do construtor

        //método get set
        public double ModificarArea 
        {
            get { return this.area; }
            set { this.area = value; }
        }//fim do método get set

        public double ModificarIMC 
        {   
            get { return this.IMC; }
            set { this.IMC = value; }
        }//fim do método get set


        //1. Leia um número e exiba seu triplo
        public int Triplo(int num) 
        {   
            return num * 3;
        }//fim do método

        //2. Leia um número e exiba sua metade
        public int Metade(int num) 
        {
            return num / 2;
        }//fim do método

        //3. Converta um valor de dólares para reais com uma taxa fixa
        public double ConverterReais(double dolar, double taxaCambio)   
        {
            if(dolar <= 0 || taxaCambio <= 0)
            {
                return -1;
            }
            else 
            {
                return dolar * taxaCambio;
            }         
        }//fim do método

        //4. Calcule o perímetro de um quadrado com base no lado
        public double PerimetroQuadrado(double lado) 
        {
            if(lado <= 0) 
            { 
                return -1; 
            }
            else 
            {
                return 4 * lado;
            }// fim if else
        }// fim do método

        //5. Converta um valor de horas para minutos.
        public double HorasMinutos(double horas) 
        {
            if(horas <= 0) 
            { 
                return -1; 
            }
            else 
            {
                return horas * 60;
            }//fim if else
        }//fiom do método

        //6. Leia um número e exiba 10% dele
        public double NumeroPorcentagem(double numero) 
        {
            if(numero <= 0) 
            {
                return -1;
            }
            else 
            {
                return numero * 0.10;
            }//fim if else
        }//fim do método

        //7. Leia um número e exiba 25% dele.
        public double NumeroPorc(double numero) 
        {
            if (numero <= 0) 
            {
                return -1;
            }
            else 
            {
                return numero * 0.25;
            }//fim if else
        }// fim do método

        //8. Calcule a área de um losango com base nas diagonais
        //área = (diagonalMaior * diagonalMenor) / 2
        public double AreaLosango(double diagonalMaior, double diagonalMenor) 
        {
            //validação
            if (diagonalMaior > 0 && diagonalMenor > 0) 
            {
                ModificarArea = (diagonalMaior * diagonalMenor) / 2;
            }
            else 
            {
                ModificarArea = -1; //criando um alerta com um símbolo
            }//fim do if else
            return ModificarArea;
        }//fim do método

        //9. Calcule o volume de um cilindro a partir do raio e altura
        //volume = math.pi * math.pow(raio,2) * altura
        public double VolumeCilindro(double raio, double altura) 
        {
            if(raio > 0 && altura > 0) 
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else 
            {
                return -1;
            }//fim do if else
        }//fim do método

        //10. Leia um número e exiba seu valor absoluto.
        public double NumeroAbsoluto(double numero) 
        {
           return Math.Abs(numero);
        }//fim do método

        //11. Converta um valor de quilômetros para metros.
        public double QuilometroMetro(double km) 
        {
            if (km < 0)
            {
                return -1;
            }
            else
            {
                return km * 1000;
            }//fim if else
        }//fim do método

        //12. Leia um número e exiba sua quinta potência
        public double QuintaPotencia(double numero) 
        {
            if(numero <= 0) 
            {
                return -1;
            }
            else 
            {
                return Math.Pow(numero, 5);
            }// fim if else
        }//fim do método

        //13. Calcule o tempo de uma viagem com base na distância e velocidade.
        public double TempoViagem(double distancia, double velocidade) 
        {
            if (distancia <= 0|| velocidade <= 0) 
            {
                return -1;
            }
            else 
            {
                return distancia / velocidade;
            }//fim if else
        }//fim do método

        //14. Calcule o consumo médio de combustível com base em km e litros.
        public double ConsumoMedio( double km, double litros) 
        {
            if (km  <= 0 || litros <= 0)
            {
                return -1;
            }
            else
            {
                return km / litros;
            }//fim if else
        }//fim do método

        //15. Leia um número e calcule o seu fatorial(sem estrutura de repetição)

        //16. Leia a altura e peso de uma pessoa e calcule o IMC 
        //se IMC < 18.5 - Abaixo do peso
        //se IMC > 18.5 e IMC < 24.9 - Peso normal
        //se IMC >= 24.9 e IMC < 29.9 - Sobrepeso
        //se IMC >= 29.9 e IMC < 34.4 - Obesidade Grau I
        //se IMC >= 34.4 e IMC < 39.9 - Obesidade Grau II
        //se IMC >= 39.9 - Obesidade Grau III
        //devolva o grau
        public string CalcularIMC(double peso, double altura) 
        {
            string resultado = ""; //declaração local
            if(peso >= 0 && altura >= 0) 
            {
                //Calculei
                ModificarIMC = peso / Math.Pow(altura, 2);
                //Verificando a resposta
                resultado = "\nSeu IMC é: " + ModificarIMC;
                if (ModificarIMC < 18.5)
                {
                    resultado += " - Abaixo do peso";
                }
                else if (ModificarIMC < 24.9) 
                {
                    resultado += " - Peso normal";
                }
                else if (ModificarIMC < 29.9) 
                {
                    resultado += " - Sobrepeso";
                }
                else if (ModificarIMC < 34.9) 
                {
                    resultado += " - Obesidade Grau I";
                }
                else if (ModificarIMC < 39.9)
                {
                    resultado += " - Obesidade Grau II";
                }
                else 
                {
                    resultado += " - Obesidade Grau III";
                }
            }
            else 
            {
                resultado = "Impossível calcular IMC com peso e/ou altura negativosModificarIMC";
            }// fim do if resultado;
            return resultado;
        }//fim do IMC

        //17. Calcule o salário anual com base no valor mensal.
        public double CalculoAnual(double salario) 
        {
            if (salario <= 0 ) 
            {
                return -1;
            }
            else 
            {
                return salario * 12;
            }//fim if else
        }//fim do cálculo

        //18. Leia um número e exiba seu logaritmo natural.
        public double LogaritmoNatural(double numero) 
        {
            if(numero <= 0) 
            {
                return -1;
            }
            else 
            {
                return Math.Log(numero);
            }//fim if else
        }//fim exercício

        //19. Leia um número e exiba o seu seno
        public double ExibirSeno(double numero) 
        {
            return Math.Sin(numero);
        }//fim do exercício

        //20. Leia um número e exiba o seu cosseno.
        public double ExibirCosseno(double numero)
        {
            return Math.Cos(numero);
        }//fim do exercício

        //21. Calcule a área de um trapézio com base na base maior, base menor e altura
        public double AreaTrapezio(double baseMaior, double baseMenor, double altura) 
        {
            if(baseMaior <= 0 || baseMenor <= 0 || altura <= 0) 
            {
                return -1;
            }
            else 
            {
                return (baseMaior + baseMenor) * altura / 2;
            }
        }

        //22. Converta um valor de dias pára segundos
        public int DiasSegundos(int dias) 
        {
            if(dias  <= 0) 
            {
                return -1;
            }
            else 
            {
                return dias * 24 * 60 * 60;
            }
        }

        //23. Leia um número e exiba a soma de seus dígitos
        public int ContarLetras(int num) 
        {
            int somar = 0;
            if(num <= 0) 
            {
                num = num * -1;
            }
            string nume = "" + num;
            for(int i = 0; i < nume.Length; i++) 
            {
                somar += Convert.ToInt32(nume.Substring(i, 1));
            }// fim do for
            return somar;
        }

        //25. Calcule a hipotenusa de um triângulo retângulo com base nos catetos
        public double HipTriang(double cat1, double cat2) 
        {
            if(cat1 <= 0 || cat2 <= 0) 
            {
                return -1;
            }
            else 
            {
                return Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
            }
        }

        //28. Leia um valor e calcule sua raiz cúbica
        public double RaizCubica(double numero) 
        {
            return Math.Pow(numero, 1.0 / 3.0);
        }

        //31. Leia um ângulo em graus e converta para radianos.
        public double GrauRadiano(double graus)
        {
            return graus * (Math.PI / 180);
        }

        //32. Leia um valor e exiba seu valor em porcentagem.
        public double ValorPorcentagem(double valorPorcentagem)
        {
            return (valorPorcentagem / 100) * valorPorcentagem;
        }

        //33. Calcule a média ponderada entre três notas com pesos diferentes
        public double MediaPonderada(double n1, double n2, double n3, double p1, double p2, double p3)
        {
            double media = 0;
            if (n1 <= 0 || n2 <= 0 || n3 <= 0)
            {
                return -1;
            }
            else
            {
                media = (n1 * p1) + (n2 * p2) + (n3 * p3) / p1 + p2 + p3;
            }
            return media;
        }//fim do método

        //35. Leia o saldo de uma conta e adicione uma taxa fixa de rendimento
        public double SaldoConta(double saldo)
        {
            double taxa = 1.5;
            if(saldo <= 0)
            {
                return -1;
            }
            else
            {
                Console.WriteLine(saldo + (saldo * taxa));
            }
            return taxa*saldo;
        }

        //36. Calcule o gasto de energia elétrica com base em potência e tempo de uso.
        public double GastoEnergia(double potencia, double tempoUso)
        {
            double energia = 0;
            if(potencia <= 0 || tempoUso <= 0)
            {
                return -1;
            }
            else
            {
                energia = ((potencia * tempoUso) / 1000);
            }
            return energia;
        }// fim do método

        //37. Vetor
        public void PreencherVetor()
        {
            for(int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write(i + 1 + "ª idade: ");
                    idade[i] = Convert.ToInt32(Console.ReadLine());
                    if (idade[i] <= 0)
                    {
                        Console.WriteLine("Erro, informe uma idade positiva!");
                    }// fim validação
                } while (idade[i] <=0);
            }//fim do for
        }//fim do método

        //38. método de consultar
        public void ConsultarVetor()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1} ª idade: {idade[i]}");
            }// fim for
        }//fim consultar

        //39. Buscar Idade
        public void BuscarIdade(int idade)
        {
            Boolean flag = false;
            for(int i = 0;i < 10; i++)
            {
                if (this.idade[i] == idade)
                {
                    flag = true;
                    Console.WriteLine($"A idade {idade} está na posição: {i+1}");
                }
            }//fim do for
            if(flag == false)
            {
                Console.WriteLine($"A idade {idade} não está no vetor");
            }
        }//fim do método

        //40. Leia 10 números e armazene em um vetor
        public void PreencherNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }// fim do for
        }// fim do método
        
        //método para mostrar
    

        //41. Leia 10 números e exiba-os na ordem inversa
        public void OrdemInversa()
        {
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine($"{10 - i}º número (inverso): {numeros[i]}");
            }
        }//fim do método

        //42. Leia 10 números e exiba apenas os pares.
        public void NumerosPares()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} º número: {numeros[i]}");
            }// fim do for
        }// fim do método

        public void BuscarPares()
        {
            Console.Write("Os números pares são: ");
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
        }// fim do método

        //43. Leia 10 números e exiba a média
        public void NumerosMedia()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} º número: {numeros[i]}");
            }
        }

        public void ExibirMedia()
        {
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += numeros[i]; 
            }

            media = (int)soma / 10; 

            Console.WriteLine($"A média dos números é: {media}");
        }

        //44. Leia 10 nomes e exiba os que começam com "A"
        public void PreencherNomes()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1} º nome: ");
                nomes[i] = Console.ReadLine();
            }
        }

        public void NomesA()
        {
            for (int i = 0; i < 10; i++)
            {
                if (nomes[i].Substring(0, 1) == "a" || nomes[i].Substring(0, 1) == "A")
                {
                    Console.WriteLine(nomes[i]);
                }
            }//fim do for
        }//fim do método

        //45. Leia 10 números e conte quantos são maiores que a média
        public void MaiorMedia()
        {
            for(int i = 0;i < 10; i++)
            {
                if (numeros[i] > media)
                {
                    Console.WriteLine($"Os números maiores que a média são: {numeros[i]}");
                }//fim if
            }//fim for
        }//fim método

        //46. Leia 10 idades e exiba a maior
        public void PreencherIdade()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine($"{i + 1} º idade: ");
                    idade[i] = Convert.ToInt32(Console.ReadLine());
                    if (idade[i] <= 0)
                    {
                        Console.WriteLine("Informe uma idade válida");
                    }//fim if
                } while (idade[i] <= 0);
             }//fim for
        }//fim método  
        
        public void MaiorIdade()
        {
            int maior = 0;
            for (int i = 0;i < 10; i++)
            {
                if(idade[i] > maior)
                {
                    maior = idade[i];   
                }//fim if
            }//fim for
            Console.WriteLine($"A maior idade é: {maior}");
        }//fim método

        //47. Leia 10 alturas e exiba a média
        public void AlturaMedia()
        {
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine($"{i + 1}º altura: ");
                    altura[i] = Convert.ToDouble(Console.ReadLine());
                    if (altura[i] <= 0)
                    {
                        Console.WriteLine("Informe uma altura válida");
                    }//fim if
                } while (altura[i] <= 0);
            }//fim for
        }//fim método

        public void AltMed()
        {
            double soma1 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma1 += altura[i];
            }//fim for
            Console.WriteLine($"A média das alturas é de: {soma1 /10}");
        }//fim método

        //48. Leia 10 salários e exiba quantos ganham abaixo de R$1.200,00.
        public void InserirSalario()
        {
            for(int i = 0;i < 10 ; i++)
            {
                do
                {
                    Console.WriteLine($"{i + 1}º salário: ");
                    salario[i] = Convert.ToDouble(Console.ReadLine());
                    if(salario[i] <= 0)
                    {
                        Console.WriteLine("Informe um salário válido");
                    }//fim if
                }while(salario[i] <= 0);
            }// fim for
        }// fim método

        public void SalarioAbaixo()
        {
            double abaixo = 1200;
            int contar = 0;
            for(int i = 0;i < 10 ; i++)
            {
                if (salario[i] < abaixo)
                {
                    contar++;
                }// fim if
            }// fim for
            Console.WriteLine($"Os salários abxido de R$ 1,200,00 são: {contar}");
        }//fim método

        //49. Leia 10 números e exiba quantos são múltiplos de 5.
        public void MultiploCinco()
        {
            for(int i = 0;i < 10 ; i++)
            {
                if(numeros[i] % 5 == 0)
                {
                    Console.WriteLine($"Os números divisíveis por 5 são: {numeros[i]}");
                }//fim if
            }//fim for
        }//fim método

        //50. Leia 10 valores e os armazene em dois vetores(pares e ímpares).
        public void NumPar()
        {
            int contpar = 0;
            int contimpar = 0;
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    contpar = numeros[i];
                    contpar++;
                }
                else {
                    contimpar = numeros[i];
                    contimpar++;
                }// fim if else
            }// fim for
            Console.WriteLine($"Esse número{contpar} é do vetor par");
            Console.WriteLine($"Esse número{contimpar} é do vetor ímpar");
        }//fim método

        //51. Leia 10 valores e ordene do maior para o menor.
        public void MaiorMenor()
        {
            int aux = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[i];
                        numeros[i] = aux;
                    }//fim if                    
                }//fim for
            }//fim do for
        }//fim do Metodo

        public void Consulta()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}ªNumero {numeros[i]}");
            }//fim for
        }//fim consultar

        //52. Leia 10 números e exiba os repetidos.
        public void NumRepetidos()
        {
            for(int i = 1;i < 5; i++)
            {
                for( int j = 6;j < 10; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        Console.WriteLine($"Os números iguais são: {numeros[i]}");
                    }//fim if
                }// fim for
            }// fim for   
        }//fim método

        //53. Some dois vetores de 10 posições(fim vetor)
        public void SomaV1()
        {
            for(int i =0; i < 10; i++)
            {
                Console.Write(i + 1 + "º número: ");
                soma1[i] = Convert.ToInt32(Console.ReadLine());
            }//fim for
        }// fim método

        public void SomaV2()
        {
            for(int i  = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "º número: ");
                soma2[i] = Convert.ToInt32(Console.ReadLine());
            }// fim for
        }// fim método

        public void SomaVetores()
        {
            int soma = 0;
            for(int i = 0; i < 10; i++)
            {
                soma += soma1[i] + soma2[i];
            }//fim for
            Console.WriteLine($"A soma dos vetores é de: {soma}");
        }// fim for

        //54. Criar o Preencher Matriz - Método de preenchimento
        public void PreencherMatriz()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }//fim coluna
            }//fim linha
        }// fim método

        public void MostrarMatriz()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"{matriz[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método

        //55. Preencher Zero(matriz)
        public void PreencherZero()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    if (linha == coluna)
                    {
                        matriz[linha, coluna] = 0;
                    }
                    else
                    {
                        matriz[linha, coluna] = 1;
                    }// fim if else
                }//fim coluna
            }//fim linha
        }//fim método

        //56. Some todos os elementos de uma matriz 3x3.
        public void SomaElementos()
        {
            int soma = 0;
            for(int linha = 0;linha <= 2; linha++)
            {
                for( int coluna = 0;coluna <= 2; coluna++)
                {
                    soma += matriz[linha,coluna];
                }// fim coluna
            }//fim linha
            Console.WriteLine($"A soma dos valores dessa matriz é de: {soma}");
        }// fim método

        //57. Calcule a média dos elementos de uma matriz 4x4
        public void PreencherMatrizB()
        {
            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.matrizB[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }//fim coluna
            }//fim linha
        }// fim método

        public void SomaElementosB()
        {
            int soma = 0;
            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    soma += matrizB[linha, coluna];
                }// fim coluna
            }//fim linha
            Console.WriteLine($"A soma dos valores dessa matriz é de: {soma}");
        }// fim método

        public void MediaElementos()
        {
            int media = 0;
            int soma = 0;
            for(int linha = 0;linha <= 3;linha++)
            {
                for(int coluna = 0;coluna <= 3; coluna++)
                {
                    soma += matrizB[linha, coluna];
                }//fim coluna
            }//fim linha
            media += soma / 16;
            Console.WriteLine($"A média da soma dos elementos dessa matriz é de: {media}");
        }//fim método

        //58. Leia uma matriz 3x3 e exiba apenas a diagonal principal       
        public void DiagonalPrincipal()
        {
            for(int linha = 0;linha <= 2;linha++)
            {
                for(int coluna = 0;coluna <= 2;coluna++)
                {
                    if(linha == coluna)
                    {
                        Console.Write(matriz[linha, coluna] + " ");
                    }//fim if
                }//fim coluna
            }// fim linha
        }//fim método

        //59. Exiba a diagonal secundária de uma matriz 3x3
        public void DiagonalSecundaria()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (linha + coluna == 2)
                    {
                        Console.Write(matriz[linha, coluna] + " ");
                    }//fim if
                }//fim coluna
            }//fim for
        }//fim método

        //60. Leia uma matriz 4x4 e conte os elementos maiores que 10.
        public void MostrarMatrizB()
        {
            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    Console.Write($"{matrizB[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método

        public void MaioresDez()
        {
            int contar = 0;

            for (int linha = 0; linha <= 3; linha++)
            {
                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    if (matrizB[linha, coluna] > 10)
                    {
                        contar++;
                    }//fim if
                }//fim coluna
            }//fim linha
            Console.WriteLine($"Há {contar} maiores que 10");
        }//fim método

        //61. Leia duas matrizes 3x3 e some os valores.
        public void PreencherMatrizC()
        {
            int soma = 0;
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.matrizC[linha, coluna] = Convert.ToInt32(Console.ReadLine());

                    soma += this.matrizC[linha, coluna] + this.matriz[linha, coluna];
                }//fim coluna
            }//fim linha
            Console.WriteLine($"A soma entre essas matrizes fica: {soma}");
        }// fim método

        public void MostrarMatrizC()
        {
            for (int linha = 0; linha <= 2; linha++)
            {
                for (int coluna = 0; coluna <= 2; coluna++)
                {
                    Console.Write($"{matrizC[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método

        //62. Multiplique duas matrizes 2x2.
        public void PreencherMat()
        {
            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.mat[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }//fim coluna
            }//fim linha
        }// fim método

        public void MostrarMat()
        {
            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.Write($"{mat[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método

        public void MultiplicaMatriz()
        {
            int multiplica = 0;
            for (int linha = 0; linha <= 1; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.matB[linha, coluna] = Convert.ToInt32(Console.ReadLine());

                    multiplica += this.mat[linha, coluna] * this.matB[linha, coluna];
                }//fim coluna
            }//fim linha
            Console.WriteLine($"A multiplicação entre essas matrizes fica: {multiplica}");
        }// fim método

        //63. Leia uma matriz 5x5 e troque a primeira linha com a última.
        public void PreencherMatD()
        {
            for (int linha = 0; linha <= 4; linha++)
            {
                for (int coluna = 0; coluna <= 4; coluna++)
                {
                    Console.Write($"matriz {linha}{coluna}: ");
                    this.matrizD[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                }//fim coluna
            }//fim linha
        }// fim método

        public void MostrarMatD()
        {
            for (int linha = 0; linha <= 4; linha++)
            {
                for (int coluna = 0; coluna <= 4; coluna++)
                {
                    Console.Write($"{matrizD[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método

        public void TrocaLinha()
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                int temp = this.matrizD[0, coluna]; 
                this.matrizD[0, coluna] = this.matrizD[4, coluna]; 
                this.matrizD[4, coluna] = temp; 
            }//fim for
        }//fim método

        public void MostrarTroca()
        {
            for (int linha = 0; linha <= 4; linha++)
            {
                for (int coluna = 0; coluna <= 4; coluna++)
                {
                    Console.Write($"{matrizD[linha, coluna]} ");
                }//fim coluna
                Console.WriteLine("");//pular linha
            }//fim linha
        }// fim método






    }//fim da classe
}//fim do projeto
