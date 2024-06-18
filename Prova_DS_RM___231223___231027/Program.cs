using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_DS_RM___231223___231027
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double saldo = 0;
            string iniciar = "s";

            while (iniciar == "s")
            {
                Console.Clear();
                Console.WriteLine("O que você deseja: ");
                Console.WriteLine("Efetuar Depósito (D)");
                Console.WriteLine("Efetuar Saque (S)");
                Console.WriteLine("Efetuar Pagamento (P)");
                Console.WriteLine("Consultar Saldo (C)");
                string Deseja = Console.ReadLine().ToUpper();

                switch (Deseja)
                {
                    case "D":
                        saldo = Deposito(saldo);
                        break;

                    case "S":
                        saldo = Saque(saldo);
                        break;

                    case "P":
                        saldo = Pagamento(saldo);
                        break;

                    case "C":
                        saldo = Saldo(saldo);
                        break;
                }

                Console.WriteLine("Deseja realizar outra operação? (S/N): ");
                iniciar = Console.ReadLine().ToLower();


            }


            Console.ReadKey();
        }

        static double Deposito(double saldo)
        {

            Console.Clear();

            Console.WriteLine("Insira o valor que deseja depositar: ");
            double depositar = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor depositado: R$" + depositar);

            saldo = saldo + depositar;
            return saldo;
        }

        static double Saque(double saldo)
        {
            Console.Clear();

            Console.WriteLine("Insira o valor que deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());

            if (saldo < saque)
            {
                Console.WriteLine("Valor da conta insuficiente!");
            }
            else
            {
                saldo = saldo - saque;
                Console.WriteLine("Valor sacado: R$" + saque);
                Console.WriteLine("Saque realizado com sucesso!");

            }

            return saldo;
        }

        static double Pagamento(double saldo)
        {
            Console.Clear();

            Console.WriteLine("Insira o valor que deseja pagar: ");
            double pagamento = double.Parse(Console.ReadLine());


            if (saldo < pagamento)
            {
                Console.WriteLine("Valor da conta insuficiente!");
            }
            else
            {
                saldo = saldo - pagamento;
                Console.WriteLine("Valor pago: R$" + pagamento);
                Console.WriteLine("Pagamento realizado com sucesso!");
            }

            return saldo;
        }

        static double Saldo(double saldo)
        {
            Console.Clear();

            Console.WriteLine("Saldo atual: " + saldo);

            return saldo;

        }
    }
}
