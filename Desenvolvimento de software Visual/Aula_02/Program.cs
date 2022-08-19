using System

namespace Aula02{
    
    class Program{
        static void Main(string[] args)
        {
           
            Console.WriteLine("Escolha um exercicio entrer 1 e 6");
            Console.WriteLine("1 - Calculo de area");
            Console.WriteLine("2 - Conversor de moeda");
            Console.WriteLine("3 - Identificador de Idade");
            Console.WriteLine("4 - Sequencia Fibonnacci");
            Console.WriteLine("5 - ");
            Console.WriteLine("6 - ");

            double menu = Convert.ToDouble(Console.ReadLine()); 

            switch (menu){

                case 1:
                    Console.WriteLine("Escreva a Largura: ");
                    double largura = Convert.ToDouble(Console.ReadLine());   
                    Console.WriteLine("Escreva a Altura: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    double area = largura * altura;
                    Console.WriteLine("O valor da área é: " +area+ "m²");                
                break;
                
                case 2:
                    Console.WriteLine("Insira o valor em Reais:");
                    double real = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha uma opção de coversão!");
                    Console.WriteLine("1 - Dolar");
                    Console.WriteLine("2 - Euro");
                    Console.WriteLine("3 - Peso Argentino");
                    double opcao = Convert.ToDouble(Console.ReadLine());
                    double valor = 0;
                    switch(opcao){
                        case 1:
                            double dolar = 5.17;
                            valor = real * dolar;
                            System.Console.WriteLine("O valor convertido é de: U$ "+valor+ " Dolares");
                        break;
                        case 2:
                            double euro = 5.17;
                            valor = real * euro;
                            System.Console.WriteLine("O valor convertido é de: E$ "+euro+ " Euros");
                        break;

                        case 3:
                            double peso = 0.05;
                            valor = real * peso;
                            System.Console.WriteLine("O valor convertido é de: P$ " +peso+ " Pesos Argentinos");
                        break;

                        default:
                            System.Console.WriteLine("Opção invalida");
                        break;
                    }
                break;
                case 3:

                    System.Console.WriteLine("Informe a idade: ");
                    int idade = Convert.ToInt16(Console.ReadLine());

                    if (idade <= 13){
                        System.Console.WriteLine("A idade de "+ idade + " é uma criança!");
                    }else if(idade <= 18){
                        System.Console.WriteLine("A idade de "+ idade + " é um(a) aborrecente.");
                        }else if(idade <= 60){
                            System.Console.WriteLine("A idade de "+ idade + " é um(a) adulto.");
                        }else{
                            System.Console.WriteLine("A idade de "+ idade + " é um(a) Idoso.");
                        }
                break;
                case 4:

                    System.Console.WriteLine("Insira o valor:");
                    int rep = Convert.ToInt16(Console.ReadLine());
                    int[] cont = {0};
                    for (int i = 0; i <= rep; i++){
                        
                        if (cont[i] == 0){
                            System.Console.WriteLine(cont[i]);
                        }
                        cont[i] = cont[i-1]+cont[i-2]
                                               
                    }

                break;                

                case 5:
                break;
                
                default:
                break;
                    
            }
        }
    }
}
