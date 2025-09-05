using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI22M
{
    class ExerciciosModel
    {
        //área de variáveis
        private double area;
        private double IMC;
        //método construtor
        public ExerciciosModel() 
        {
            this.area = 0;
            this.IMC = 0;
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

    }//fim da classe
}//fim do projeto
