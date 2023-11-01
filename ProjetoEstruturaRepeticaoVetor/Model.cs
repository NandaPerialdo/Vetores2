using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Model
    {   //declarar o vetor
        public double[] notas;//Declaração de um vetor
        public int[] vetor;
        public int i;
        private double soma;
        public double[] vetor10;
        public double[] vetor20;
        public double[] vetor15;
        public int contar;
        public double[] vetor25;
        public double[] vetor30;
        public double[] vetor50;


        public Model()
        {   //instanciar vetor
            notas = new double[10];
            vetor = new int[5];//Instanciar = Existir 
            i = 0;
            ConsultarSoma = 0;
            vetor10 = new double[10];
            vetor20 = new double[20];
            vetor15 = new double[15];
            contar = 0;
            vetor25 = new double[25];
            vetor30 = new double[30];
            vetor50 = new double[50];
            
        }//fim do construtor

        public double ConsultarSoma
        {
            get { return soma; }
            set { this.soma = value; }
        }//fim do get set

        //Guardar 10 notas de 10 alunos diferentes
        public double MediaNotas()
        {
            for(i=0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine(i + 1 + "ª Nota: ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    if ((notas[i] < 0) || (notas[i] > 10))
                    {
                        Console.WriteLine("Digite uma nota entre 0 e 10");
                    }//fim da validação
                } while ((notas[i] < 0) || (notas[i] > 10));
                ConsultarSoma += notas[i];
            }//fim do for
            return ConsultarSoma / i;
        }//fim método

        //Ler um vetor de 5 posições e mostrar em ordem inversa
        public void PreencherVetor()
        {
            for(i=0;i < 5; i++)
            {
                Console.Write((i+1) + "ª Posição: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());//Preenchendo o vetor
            }//fim do for
        }//fim do método

        public void MostrarVetor()
        {
            Console.WriteLine("Entrei na mostrar");
            for(i=4; i >= 0; i--)
            {
                Console.WriteLine(i+1 + "ª Posição: " + vetor[i]);
            }//fim do for
        }//fim do mostrar

        //--- Leia um vetor de 10 elementos e mostre apenas os números pares.

        //metodo que preenche o vetor, usando o contador i para passar as posiçoes do vetor
        public void PreenchVet10()
        {
            for (i=0; i<10; i++)
            {
                Console.WriteLine("insira o " + (i + 1) + "° numero");
                vetor10[i] = Convert.ToInt32(Console.ReadLine());
            }//fim do for
        }//fim do metodo preencher

        //metodo que retorna numeros pares

        public void RetornarPares()
        {
            for (i=0; i<10; i++)
            {
                if (vetor10[i] % 2 == 0)
                {
                    Console.WriteLine(vetor10[i]);
                }//fim do if
            }// fim do for
        }

        //---- Leia um vetor de 20 elementos e calcule a média dos valores.
        
        //metodo para preencher vetor de 20 posiçoes
        public void PreenchVet20 ()
        {
            for(i=0; i <20; i++)
            {
                Console.WriteLine("Insira o" + (i + 1) + "° valor");
                vetor20[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //metodo para calcular a media dos 20 valores
        public double MediaVet20()
        {
            for (i = 0; i < 20; i++)
            {
                ConsultarSoma += vetor20[i];//acumula os valores do vetor a partir de uma soma, guardando na variavel consultar soma
            }//fim do for
        return ConsultarSoma / i;//divir o valor acumulado pela quantidade de posiçoes, contida em i, após dar todas as "voltas" determinadas no "for" (20 nesse caso)
        }// fim do metodo

        //---- Leia um vetor de 15 elementos e conte quantos números são pares.

        //metodo para preencher o vetor com 15 valores
        public void PreenchVet15()
        {
            for(i=0; i <15; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "° numero");
                vetor15[i] = Convert.ToInt32(Console.ReadLine());
            }//fim do for
        }//fim do metodo

        public double ContarPares()
        {
            for (i = 0; i < 15; i++)
            {
                if (vetor15[i] % 2 == 0)
                {
                    contar = i + 1;
                }//fim do if
            }// fim do for
            return contar;
        }

        //---Leia um vetor de 25 elementos e mostre o maior valor e sua posição.

        //metodo para preencher vetor de 25 posiçoes e retornar o maior numero e sua posicao
        public void MaiorDe25()
        {
            int posicao = 0;
            double maior = 0;
            for (i = 0; i < 25; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "° valor");
                vetor25[i] = Convert.ToInt32(Console.ReadLine());

                if (vetor25[i] > maior)
                {
                    maior = vetor25[i];
                    posicao = i + 1;
                }
            }//fim do for
            Console.WriteLine("O maior numero digitado é: " + maior + "sua posiçao é: " + posicao);
        }//fim do metodo

        //---Leia um vetor de 30 elementos e mostre o menor valor e sua posição.

        public void MenorDe30()
        {
            int posicao = 0;
            double menor = 0;
            for (i = 0; i <30; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "° numero:");
                vetor30[i] = Convert.ToInt32(Console.ReadLine());
                
                if (i == 0)
                {
                    menor = vetor30[i];
                }
                if (vetor30[i] < menor)

                {
                    menor = vetor30[i];
                    posicao = i + 1;
                }//fim do if
            }// fim do for
            Console.WriteLine("O menor numero digitado é " + menor + " sua posicao é: " + posicao);

        }

        //--- Leia um vetor de 50 elementos e encontre o segundo maior valor

        public void SegundoMaiorDe50()
        {
            double maior = 0;
            int posicao = 0;
            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "° valor");
                vetor50[i] = Convert.ToInt32(Console.ReadLine());

                if (vetor50[i] > maior)
                {
                    maior = vetor50[i];
                    posicao = i;
                }//fim do if
            }//fim do for

            vetor50[posicao] = 0;//substituinda a posiçao onde estava o maior numero, por zero

            //realizar o metodo para descobrir o maior novamente, desse vez ira retornar o segundo maior,
            //pois o primeiro maior já nao existe mais, foi substituido por zero

            double segMaior = 0;
            for (i = 0; i < 50; i++)
            { 
                if (vetor50[i] > segMaior)
                {
                    segMaior = vetor50[i];
                }//fim do if
            }//fim do for
            Console.WriteLine("O segundo maior numero digitado é: " + segMaior);            
        }//fim do metodo

        //Leia um vetor de 10 elementos e mostre a soma dos valores
       
        public double SomarVet10()
        {
            double soma = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira o " + (i + 1) + "° valor");
                vetor10[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + vetor10[i];
            }
            return soma;

        }// fim do metodo




    }//fim da classe
}//fim do projeto