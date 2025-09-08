using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        //método construtor
        public ExerciciosModel() 
        {
            this.area = 0;
            this.IMC = 0;
            this.idade = new int[10];// de 0 a 9
            this.numeros = new int[10];
            this.nomes = new string[10];
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

            int media = (int)soma / 10; 

            Console.WriteLine($"A média dos números é: {media}");
        }

        //44. Leia 10 nomes e exiba os que começam com "A"
        public void PreencherNomes()
        {
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine($"{i+1} º nome: {nomes[i]}");
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



    }//fim da classe
}//fim do projeto
