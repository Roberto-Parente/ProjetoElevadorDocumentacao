using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///Classe com 6 metodos (inicializar, entrar, sair, subir, descer, menu)
/// </summary>
namespace ProjetoElevador.Models
{
    public class Elevador
    {
        public int AndarAtual { get; set; }
        public int CapacidadePessoas { get; set; }
        public int QtdAndares { get; set; }
        public int QtdPessoas { get;  set; }
        public string Opcao { get; set; }

        /// <summary>
        /// Começar com elevador vazio e no térreo.
        /// </summary>
        public void Inicializar()
        {
            
            this.AndarAtual = 0;
            this.QtdPessoas = 0;
            //Display 1
            Console.WriteLine("Andar Atual: {0}", this.AndarAtual);
            Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
            Console.WriteLine("Capacidade de Pessoas: {0}", this.CapacidadePessoas);
            Console.WriteLine("Andares + (Térreo = 0): {0}", this.QtdAndares);
        }
        /// <summary>
        ///Somar +1 quando entrar no elevador 
        /// </summary>
        public void Entrar()
        {

            if (this.QtdPessoas < this.CapacidadePessoas)
            {
                
                this.QtdPessoas += 1;
                //Display 2
                Console.WriteLine("Andar Atual: {0}", this.AndarAtual);
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Capacidade de Pessoas: {0}", this.CapacidadePessoas);
                Console.WriteLine("Andares + (Térreo = 0): {0}", this.QtdAndares);


            }
            else
            {
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Elevador Cheio!, Está na capacidade máxima: {0}", this.CapacidadePessoas);


            }

        }

        /// <summary>
        /// Somar -1 quando sair no elevador
        /// </summary>
        public void Sair()
        {

            if (this.QtdPessoas > 0)
            {
                
                this.QtdPessoas -= 1;
                //Display 3
                Console.WriteLine("Andar Atual: {0}", this.AndarAtual);
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Capacidade de Pessoas: {0}", this.CapacidadePessoas);
                Console.WriteLine("Andares + (Térreo = 0): {0}", this.QtdAndares);

            }
            else
            {
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Elevador Está vazio!");
            }
        }
        /// <summary>
        /// Somar +1 andar quando solicita subida do elevador
        /// </summary>
        public void Subir()

        {

            if (this.AndarAtual < this.QtdAndares)
            {

                
                this.AndarAtual += 1;
                // Display 4
                Console.WriteLine("Andar Atual: {0}", this.AndarAtual);
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Capacidade de Pessoas: {0}", this.CapacidadePessoas);
                Console.WriteLine("Andares + (Térreo = 0): {0}", this.QtdAndares);


            }
            else
            {

                Console.WriteLine("Opção Inválida, este é o último andar! ({0})", this.QtdAndares);


            }

        }

        /// <summary>
        /// Somar -1 andar quando solicita descida do elevador
        /// </summary>
        public void Descer()
        {
            if (this.AndarAtual > 0)
            {

                this.AndarAtual -= 1;
                //Display 5
                Console.WriteLine("Andar Atual: {0}", this.AndarAtual);
                Console.WriteLine("Quantidade de Pessoas: {0}", this.QtdPessoas);
                Console.WriteLine("Capacidade de Pessoas: {0}", this.CapacidadePessoas);
                Console.WriteLine("Andares + (Térreo = 0): {0}", this.QtdAndares);


            }
            else
            {

                Console.WriteLine("Opção Inválida, este é o térreo! (0)");

            }

        }

        /// <summary>
        /// Lista com 6 opções de escolha para o usuário.
        /// </summary>
        public void Menu()
        {

            Console.WriteLine(@"
========================
PROJETO FINAL - ELEVADOR
========================");
            Console.Write("Escolha Quantos Andares: ");
            this.QtdAndares = int.Parse(Console.ReadLine());
            Console.Write("Escolha a Capacidade de Pessoas: ");
            this.CapacidadePessoas = int.Parse(Console.ReadLine());

            bool continuar = true;

            do
            {
                //MENU DE OPÇOES
                Console.WriteLine(@"
=============
IHM ELEVADOR
=============

1. Inicializar.
2. Entrar.
3. Sair.
4. Subir.
5. Descer.
6. Sair do programa.
");

                Console.Write("Escolha a opção: ");

                this.Opcao = Console.ReadLine();

                Console.Clear();

                switch (this.Opcao)
                {
                    case "1":
                        this.Inicializar();
                        break;

                    case "2":
                        this.Entrar();
                        break;

                    case "3":
                        this.Sair();
                        break;

                    case "4":
                        this.Subir();
                        break;

                    case "5":
                        this.Descer();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida, escolher entre 1~6.");
                        break;


                }             


            }

            while (continuar);

        }
    }
}