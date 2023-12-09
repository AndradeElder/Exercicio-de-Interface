using System;

using Exercicio_de_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        bool sair = false;



        ArCondicionado arCondicionado = new ArCondicionado();
        Lampadas lampadas = new Lampadas();
        Computador computador = new Computador();

        lampadas.Desligar();
        computador.Desligar();
        arCondicionado.Desligar();

        while (sair == false)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("========== Status Dispositivos Eletronicos ==========");
            Console.WriteLine("================================================== \n");

            Console.WriteLine($"Lâmpada:");
            Console.WriteLine(lampadas.StatusDispositivo() + " \n");
            Console.WriteLine($"Arcondicionado:");
            Console.WriteLine(arCondicionado.StatusDispositivo() + " \n");
            Console.WriteLine($"Computador: ");
            Console.WriteLine(computador.StatusDispositivo() + " \n");

            Console.WriteLine("================================================== \n");

            Console.WriteLine("================ Menu ==============  \n");
            Console.WriteLine("Gostaria de controlar algum aparelho? \n");


            Console.WriteLine(" [1] Arcondicionado");
            Console.WriteLine(" [2] Lâmpadas");
            Console.WriteLine(" [3] Computador");
            Console.WriteLine(" [4] => SAIR");

            
            var opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {

                case 1:
                    var refazer = true;
                    while (refazer == true)
                    {
                        Console.Clear();
                        Console.WriteLine("================ Arcondicionado ==============  \n");

                        Console.WriteLine("[1] Ligar");
                        Console.WriteLine("[2] Desligar");
                        Console.WriteLine("[3] Menu");
                        var onOff = Convert.ToInt32(Console.ReadLine());
                        switch (onOff)
                        {
                            case 1:
                                arCondicionado.Ligar();
                                Console.WriteLine("================ Arcondicionado ==============  \n");
                                Console.WriteLine($"Dispositivo está: {arCondicionado.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                            break;

                            case 2:
                                arCondicionado.Desligar();
                                Console.WriteLine("================ Arcondicionado ==============  \n");
                                Console.WriteLine($"Dispositivo está: {arCondicionado.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                            break;

                            case 3:
                                refazer = false;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                Console.ReadKey();
                            break;
                        }
                    }
                break;


                case 2:
                    var refazer2 = true;
                    while (refazer2 == true)
                    {
                        Console.Clear();
                        Console.WriteLine("================ Lâmpadas ==============  \n");

                        Console.WriteLine("[1] Ligar");
                        Console.WriteLine("[2] Desligar");
                        Console.WriteLine("[3] Menu");
                        var onOff = Convert.ToInt32(Console.ReadLine());
                        switch (onOff)
                        {
                            case 1:
                                lampadas.Ligar();
                                Console.WriteLine("================ Arcondicionado ==============  \n");
                                Console.WriteLine($"Dispositivo está: {lampadas.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                            break;

                            case 2:
                                lampadas.Desligar();
                                Console.WriteLine("================ Arcondicionado ==============  \n");
                                Console.WriteLine($"Dispositivo está: {lampadas.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                            break;

                            case 3:
                                refazer2 = false;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                Console.ReadKey();
                            break;
                        }
                    }
                break;

                case 3:
                    var refazer3 = true;
                    while (refazer3 == true)
                    {
                        Console.Clear();
                        Console.WriteLine("================ Computador ==============  \n");

                        Console.WriteLine("[1] Ligar");
                        Console.WriteLine("[2] Desligar");
                        Console.WriteLine("[3] Menu");
                        var onOff = Convert.ToInt32(Console.ReadLine());
                        switch (onOff)
                        {
                            case 1:
                                computador.Ligar();
                                Console.WriteLine("================ Computador ==============  \n");
                                Console.WriteLine($"Dispositivo está: {computador.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                                break;

                            case 2:
                                computador.Desligar();
                                Console.WriteLine("================ Computador ==============  \n");
                                Console.WriteLine($"Dispositivo está: {computador.StatusDispositivo()} \n");
                                Console.WriteLine($"Digite enter continuar");
                                Console.ReadLine();
                                break;

                            case 3:
                                refazer3 = false;
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                                Console.ReadKey();
                            break;
                        }
                    }
                break;
                case 4:
                    sair = true;
                break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" DIGITE UM NUMERO VÁLIDO:");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PRESSIONE ENTER PARA PROSSEGUIR");
                    Console.ReadKey();
                break;

            }
        }
    }
}