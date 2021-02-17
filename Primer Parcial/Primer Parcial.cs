using System;


namespace Primer_Parcial
{

    //Imanol Montero Encarnacion 2019-7920

    class Program
    {
        static void Main(string[] args)
        {
            int Retiro, Transaccion, NumeroC;
            int V1 = 1000, V2 = 500, V3 = 200, V4 = 100;
            int c1, c2, c3, c4;
            int limiteR = 20000, LimiteT = 10000;


            Console.Write("Bienvenido Al Cajero de FDP INVERSMENTS, Porfavor Seleccione Banco De Preferencia: \n");

            Console.WriteLine("1- FDP INVERSMENTS \n" +
                "2- BANCO BANRESERVAS \n" +
                "3- BANCO POPULAR \n" +
                "4- SALIR");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == 1 || B == 2 || B == 3)
            {

                Console.WriteLine("BIENVENIDO");
                Console.WriteLine("Elejir Una Opcion. \n" +
                   "1- Transaccion. \n" +
                   "2- Retiro. \n" +
                   "3- Salir. \n");

                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingresar Cantidad Del Deposito, No Exceder El Limite De ${0} DOP:", LimiteT);
                    Transaccion = Convert.ToInt32(Console.ReadLine()); 

                    {
                        if (Transaccion <= 10000)
                        {
                            Console.WriteLine("Ingresar Numero De Cuenta:");
                            NumeroC = Convert.ToInt32(Console.ReadLine());
                            if (NumeroC > 960205400)
                            {
                                Console.WriteLine("Numero de cuenta invalido");

                            }
                            Console.WriteLine("Deposito Confirmado");
                            
                        }
                        else if (Transaccion > 10000)
                        {
                            Console.WriteLine("Limite De Deposito Excedido");
                        }
                    }

                }
                else if (opcion == 2)
                {

                  {
                        Console.WriteLine("Ingresar La Cantidad a Retirar, No Exceder El Limite De ${0} DOP:", limiteR);
                    Retiro = Convert.ToInt32(Console.ReadLine());
                   if (Retiro <= 20000)
                 {
                        {
                        c1 = Retiro / V1;
                        Retiro = Retiro - (V1 * c1);
                        Console.WriteLine("Se Retiro La Cantidad De {0} Billetes De ${1}", c1, V1);

                    }
                    if (Retiro >= 500)
                    {
                        c2 = Retiro / V2;
                        Retiro = Retiro - (V2 * c2);
                        Console.WriteLine("Se Retiro La Cantidad De {0} Billetes De ${1}", c2, V2);

                    }
                    if (Retiro >= 200) 
                    {
                        c3 = Retiro / V3;
                        Retiro = Retiro - (c3 * V3);
                        Console.WriteLine("Se Retiro La Cantidad De {0} Billetes De ${1}", c3, V3);


                    }
                    if (Retiro >= 100) 
                    {
                        c4 = Retiro / V4;
                        Retiro = Retiro - (c4 * V4);
                        Console.WriteLine("Se Retiro La Cantidad De {0} Billetes De ${1}", c4, V4);
                    }

                    Console.WriteLine("Retiro Confirmado.");
                    
            
                    Console.WriteLine("Gracias Por Usar Nuestros Servicios.");
                 }
                  else if (Retiro > 20000)
                        {
                            Console.WriteLine("Limite De Retiro Excedido.");
                        }

                        
                   }
                
                
                
                
                
                }


                else if (opcion == 3)
                {
                    Console.WriteLine("Gracias Por Usar Nuestro Servicio.");
                }


            }
            if (B == 4)
                Console.WriteLine("Gracias Por Usar Nuestro Servicio");










        }
    }
}