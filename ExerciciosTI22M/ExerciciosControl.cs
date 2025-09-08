using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI22M
{
    class ExerciciosControl
    {
        private int opcao;
        private ExerciciosModel modelo;//criando conexão com a classe modelo
        public ExerciciosControl() 
        {
            this.opcao = 0;
            this.modelo = new ExerciciosModel();//instanciando
        }//fim do método

        public int ModificarOpcao 
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }// fim do modificarOpcao

        public void MostrarMenu() 
        {
            Console.WriteLine("\nMenu" +
                              "\n0. Sair" +
                              "\n1. Exercício 1 " +
                              "\n2. Exercício 2 " +
                              "\n3. Exercício 3 " +
                              "\n4. Exercício 4 " +
                              "\n5. Exercício 5 " +
                              "\n6. Exercício 6 " +
                              "\n7. Exercício 7 " +
                              "\n8. Exercício 8 " +
                              "\n9. Exercício 9 " +
                              "\n10. Exercício 10 " +
                              "\n11. Exercício 11 " +
                              "\n12. Exercício 12 " +
                              "\n13. Exercício 13 " +
                              "\n14. Exercício 14 " +
                              "\n16. Exercício 16 " +
                              "\n17. Exercício 17 " +
                              "\n18. Exercício 18 " +
                              "\n19. Exercício 19 " +
                              "\n20. Exercício 20 " +
                              "\n21. Exercício 21 " +
                              "\n22. Exercício 22 " +
                              "\n23. Exercício 23 " +
                              "\n25. Exercício 25 " +
                              "\n28. Exercício 28 " +
                              "\n31. Exercício 31 " +
                              "\n32. Exercício 32 " +
                              "\n33. Exercício 33 " +
                              "\n35. Exercício 35 " +
                              "\n36. Exercício 36 " +
                              "\n37. Exercício 37 - Vetor" +
                              "\n38. Exercício 38 - Consultar Vetor" +
                              "\n39. Exercício 39 - Buscar Idade" +
                              "\n40. Exercício 40 - Preencher Números" +
                              "\n41. Exercício 41 - Ordem INversa" +
                              "\n42. Exercício 42 - Pares" +
                              "\n43. Exercício 43 - Média" +
                              "\n44. Exercício 44 - Nomes com A");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método mostrarMenu

        public void ExecutarMenu()
        {
            do
            {
                //chamar menu
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Console.WriteLine("Exercício 1");
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;

                    case 2:
                        Console.WriteLine("Exercício 2");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;

                    case 3:
                        Console.WriteLine("Exercício 3");
                        Console.WriteLine("Informe o valor em dólares: ");
                        double dolar = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a taxa de câmbio: ");
                        double taxaCambio = Convert.ToDouble(Console.ReadLine());

                        //mostrar resultado
                        double resultado = modelo.ConverterReais(dolar, taxaCambio);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos");
                        }
                        else
                        {
                            Console.WriteLine($"O valor U$$ {dolar} em Real é R$ {resultado}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exercício 4");
                        Console.WriteLine("Informe o tamanho do lado: ");
                        double lado = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.PerimetroQuadrado(lado);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Impossível calcular perímetro negativo!");
                        }
                        else
                        {
                            Console.WriteLine($"O perímetro é: {resultado}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exercício 5");
                        Console.WriteLine("Informe quantas horas quer converter: ");
                        double horas = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.HorasMinutos(horas);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe uma hora positiva!");
                        }
                        else
                        {
                            Console.WriteLine($"A quantidade em minutos é {resultado}");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exercício 6");
                        Console.WriteLine("Informe o número: ");
                        double numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.NumeroPorcentagem(numero);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"10% desse número é {resultado}");
                        }//fim if else
                        break;

                    case 7:
                        Console.WriteLine("Exercício 7");
                        Console.WriteLine("Informe um número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.NumeroPorc(numero);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"25% desse número é: {resultado}");
                        }
                        break;

                    case 8:
                        Console.WriteLine("Exercício 8");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //mostrar o resultado
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos");
                        }
                        else
                        {
                            Console.WriteLine($"A área do Losango é: " + modelo.AreaLosango(diagonalMaior, diagonalMenor));
                        }
                        break;

                    case 9:
                        Console.WriteLine("Exercício 9");
                        Console.WriteLine("Informe o valor do raio: ");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }
                        break;

                    case 10:
                        Console.WriteLine("Exercício 10");
                        Console.WriteLine("Informe o número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.NumeroAbsoluto(numero);
                        Console.WriteLine($"O valor absoluto de {numero} é {Math.Abs(numero)}");
                        break;

                    case 11:
                        Console.WriteLine("Exercício 11");
                        Console.WriteLine("Informe o KM: ");
                        double km = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.QuilometroMetro(km);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"A quantidade de metros dessa quilometragem é {resultado}");
                        }//fim if else
                        break;

                    case 12:
                        Console.WriteLine("Exercício 12");
                        Console.WriteLine("Informe um número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.QuintaPotencia(numero);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"A quinta potência de {numero} é: {Math.Pow(numero, 5)}");
                        }
                        break;

                    case 13:
                        Console.WriteLine("Exercício 13");
                        Console.WriteLine("Informe a distância: ");
                        double distancia = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a velocidade: ");
                        double velocidade = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.TempoViagem(distancia, velocidade);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um valor positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"O tempo de viagem será de: {resultado} horas");
                        }//fim if else
                        break;

                    case 14:
                        Console.WriteLine("Exercício 14");
                        Console.WriteLine("Informe a quilometragem: ");
                        km = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de litros: ");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ConsumoMedio(km, litros);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um valor positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"O consumo médio será de: {resultado} litros");
                        }//fim if else
                        break;

                    case 16:
                        Console.WriteLine("Exercício 16");
                        Console.WriteLine("Informe o seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        //mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;

                    case 17:
                        Console.WriteLine("Exercício 17");
                        Console.WriteLine("Informe o salário mensal: ");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.CalculoAnual(salario);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um saldo positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"O salário anual com esse valor é de: {resultado} reais");
                        }
                        break;

                    case 18:
                        Console.WriteLine("Exercício 18");
                        Console.WriteLine("Informe um número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.LogaritmoNatural(numero);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo");
                        }
                        else
                        {
                            Console.WriteLine($"O logaritmo natural de {numero} é: {resultado}");
                        }
                        break;

                    case 19:
                        Console.WriteLine("Exercício 19");
                        Console.WriteLine("Informe um número:");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ExibirSeno(numero);
                        Console.WriteLine($"O Seno de {numero} é: {resultado}");
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;

                    case 20:
                        Console.WriteLine("Exercício 20");
                        Console.WriteLine("Informe um número: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ExibirCosseno(numero);
                        Console.WriteLine($"O Cosseno de {numero} é: {resultado}");
                        break;

                    case 21:
                        Console.WriteLine("Exercício 21");
                        Console.WriteLine("Informe a medida da Base Maior: ");
                        double baseMaior = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a medida da Base Menor: ");
                        double baseMenor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.AreaTrapezio(baseMaior, baseMenor, altura);
                        if(resultado == -1) 
                        {
                            Console.WriteLine("Impossível fazer com número negativo");
                        }
                        else 
                        {
                            Console.WriteLine($"A área desse Losango é de {resultado}");
                        }
                        break;

                    case 22:
                        Console.WriteLine("Exercício 22");
                        Console.WriteLine("Informe quantos dias quer converter em segundos: ");
                        int dias = Convert.ToInt32(Console.ReadLine());

                        resultado = modelo.DiasSegundos(dias);
                        if(resultado == -1) 
                        {
                            Console.WriteLine("Informe um número positivo");
                        }
                        else 
                        {
                            Console.WriteLine($"Esse número de dias tem {resultado} segundos");
                        }
                        break;

                    case 23:
                        Console.WriteLine("Exercício 23");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        //mostrar
                        Console.WriteLine($"A soma dos dígitos é: {modelo.ContarLetras(num)}");
                        break;
                    
                    case 25:
                        Console.WriteLine("Exercício 24");
                        Console.WriteLine("Informe o valor do cateto 1: ");
                        double cat1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor do cateto 2: ");
                        double cat2 = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.HipTriang(cat1, cat2);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Informe um número positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"A hipotenusa desse triângulo é: {resultado}");
                        }
                        break;

                    case 28:
                        Console.WriteLine("Exercício 28");
                        Console.WriteLine("Informe um valor: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        resultado=modelo.RaizCubica(numero);
                        Console.WriteLine($"A Raiz Cúbica de {numero} é: {resultado}");
                        break;
                    
                    case 31:
                        Console.WriteLine("Exercício 31");
                        Console.WriteLine("Informe o valor do ângulo: ");
                        double graus = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.GrauRadiano(graus);
                        Console.WriteLine($"Esse valor convertido para radianos fica: {resultado}");
                        break;
                    
                    case 32:
                        Console.WriteLine("Exercício 32");
                        Console.WriteLine("Informe um valor: ");
                        double valorPorcentagem = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.ValorPorcentagem(valorPorcentagem);
                        Console.WriteLine($"O valor em porcentagem é de: {resultado}%");
                        break;

                    case 33:
                        Console.WriteLine("Exercício 33");
                        Console.WriteLine("Informe a primeira nota: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o peso da primeira nota: ");
                        double p1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a segunda nota: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o peso da segunda nota: ");
                        double p2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a terceira nota: ");
                        double n3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o peso da terceira nota: ");
                        double p3 = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.MediaPonderada(n1, n2, n3, p1, p2, p3);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Informe uma nota positiva!");
                        }
                        else
                        {
                            Console.WriteLine($"A média ponderada é de: {resultado}");
                        }
                        break;

                    case 35:
                        Console.WriteLine("Exercício 35");
                        Console.WriteLine("Informe o valor do saldo na conta: ");
                        double saldo = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.SaldoConta(saldo);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Informe um saldo positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"O saldo adiocionado a taxa fixa de rendimento fica: {resultado}");
                        }
                        break;

                    case 36:
                        Console.WriteLine("Exercício 36");
                        Console.WriteLine("Informe o valor da potência: ");
                        double potencia = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o tempo de uso: ");
                        double tempoUso = Convert.ToDouble(Console.ReadLine());

                        resultado = modelo.GastoEnergia(potencia, tempoUso);
                        if (resultado == -1)
                        {
                            Console.WriteLine("Informe um valor positivo!");
                        }
                        else
                        {
                            Console.WriteLine($"O gasto de energia com esses valores foi de: {resultado}");
                        }
                        break;

                    case 37:
                        Console.WriteLine("Exercício 37");
                        //mostrar
                        modelo.PreencherVetor();
                        break;
                    
                    case 38:
                        Console.WriteLine("Exercício 38");
                        modelo.ConsultarVetor();
                        break;

                    case 39:
                        Console.WriteLine("Exercício 39");
                        Console.WriteLine("Informe a idade que deseja procurar: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        modelo.BuscarIdade(idade);
                        break;

                    case 40:
                        Console.WriteLine("Exercício 40");
                        modelo.PreencherNumeros();
                        break;

                    case 41:
                        Console.WriteLine("Exercício 41");
                        modelo.PreencherNumeros();
                        modelo.OrdemInversa();
                        break;

                    case 42:
                        Console.WriteLine("Exercício 42");
                        modelo.NumerosPares();
                        modelo.BuscarPares();
                        break;

                    case 43:
                        Console.WriteLine("Exercício 43");
                        modelo.PreencherNumeros();
                        modelo.ExibirMedia();
                        break;

                    case 44:
                        Console.WriteLine("Exercício 44");
                        modelo.PreencherNomes();
                        modelo.NomesA();
                        break;




                }//fim do escolha
            }while(ModificarOpcao !=0);
        }//fim do método
    }//fim da classe
}// fim do projeto
