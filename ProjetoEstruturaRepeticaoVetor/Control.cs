using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstruturaRepeticaoVetor
{
    class Control
    {
        Model modelo;
        private int opcao;
        public Control()
        {
            this.modelo = new Model();//Criando uma chave
            ConsultarOpcao = -1;
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; } 
        }//fim do método

        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Sair\n" +
                              "1. Média de notas 10 alunos\n" +
                              "2. Vetor Inverso\n" +
                              "3. Mostrar numeros pares\n" +
                              "4. Media 20 valores\n" +
                              "5. Quantidade de pares entre 15 numeros digitados\n" +
                              "6. Mostrar o maior número e sua posição entre 25 numeros digitados\n" +
                              "7. Mostrar o menor número e sua posição entre 30 números digitados\n" +
                              "8. Exibir o segundo maior valor de 50 numeros digitados\n" +
                              "9. Realizar a soma dos 10 valores digitados");

                           
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            do
            {
                Menu();//Mostrar o menu em tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(this.modelo.MediaNotas());
                        break;
                    case 2:
                        this.modelo.PreencherVetor();
                        this.modelo.MostrarVetor();
                        break;
                    case 3:
                        this.modelo.PreenchVet10();
                        Console.WriteLine("Os numeros pares são:");
                        this.modelo.RetornarPares();
                        break;
                    case 4:
                        this.modelo.PreenchVet20();
                        Console.WriteLine("A media é:" + (this.modelo.MediaVet20()));
                        break;
                    case 5:
                        this.modelo.PreenchVet15();
                        Console.WriteLine("A quantidade de numeros pares é: " + (this.modelo.ContarPares()));
                        break;
                    case 6:
                        this.modelo.MaiorDe25();
                        break;
                    case 7:
                        this.modelo.MenorDe30();
                        break;
                    case 8:
                        this.modelo.SegundoMaiorDe50();
                        break;
                    case 9:
                        this.modelo.SomarVet10();
                        Console.WriteLine(this.modelo.SomarVet10());
                        break;
                    default:
                        Console.WriteLine("Erro, escolha uma opção valida!");
                        break;
                }//fim do switch
            } while (ConsultarOpcao != 0);
        }//fim do método operacao




    }//fim da classe
}//fim do projeto
