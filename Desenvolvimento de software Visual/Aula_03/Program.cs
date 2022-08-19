using System;

namespace Aula_03
{
    class Program
    {
        static double calculaMedia(double[] numeros){
                       
            double soma = 0;
            for (int i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            }
            
            return soma / numeros.Length;;
        }

        static double calcularMediana(double[] numeros){

            Array.Sort(numeros);
            int meio = numeros.Length / 2;
           
           if ((numeros.Length % 2) == 0){
            return (numeros[meio] + numeros[meio-1]) /2 ;
           }else{
            return numeros[meio];
           }
        
        }
        static double calculaModa(double[] numeros){
            
            double[] repeticoes = new double[numeros.Length];

            for (int i = 0; i < numeros.Length; i++){

                double atual = numeros[i];
                int cont = 0;
                
                for (int j = 0; j < numeros.Length; j++){
                    if (numeros[j] == atual){
                        cont++;
                    }
                }

                repeticoes[i] = cont;
            }

            int maior = 0;
            for (int i = 1; i < repeticoes.Length; i++)
            {
                if(repeticoes[i] > repeticoes[i-1]){
                    maior = i;
                }
            }
            return numeros[maior];
        }

        static void Main(string[] args){
        
            double[] numeros = {2, 7, 0, 7, 8, 9, 6, 8};

            Console.WriteLine("A média é: "+calculaMedia(numeros));
            Console.WriteLine("A mediana é: "+calcularMediana(numeros));
            Console.WriteLine("A Moda é: "+ calculaModa(numeros));

        }            
    }
}
