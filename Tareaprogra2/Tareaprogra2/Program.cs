using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaprogra2
{
    class Program
    {
        static int usuario = 0;
        static float salir = 60;
        static float dinero1 = 0;
        static float cuenta = 0;
        static float retiro = 0;
        static float cuentaretiro = 0;
        static float retirointento = 0;
        static float moneda1 = 0;
        static float moneda2 = 0;
        static float moneda3 = 0;
        static float moneda4 = 0;
        static float moneda5 = 0;
        static float moneda6 = 0;
        static float totalmoneda5 = 0;
        static float totalmoneda10 = 0;
        static float totalmoneda25 = 0;
        static float totalmoneda50 = 0;
        static float totalmoneda100 = 0;
        static float totalmoneda500 = 0;
        static float monedas = 0;
        static float cambiomoneda = 543;
        static float dolar1 = 0;
        static float dolar2 = 0;
        static float totaldolar1 = 0;
        static float totaldolar2 = 0;
        static float monedaretirar = 0;
        static float contador = 1;
        static float totalmonedas5 = 0;
        static float totalmonedas10 = 0;
        static float totalmonedas25 = 0;
        static float totalmonedas50 = 0;
        static float totalmonedas100 = 0;
        static float totalmonedas500 = 0;
        static float monedasjuntas = 0;
        static float monedascantidad = 0;
        static float contador2 = 1;
        static float totaldolar11 = 0;
        static float totalbilletes = 0;
        static float cont1 = 0;
        static float cont2 = 0;
        static float cont3 = 0;
        static float cont4 = 0;
        static float resul1 = 0;
        static float resul2 = 0;
        static float resul3 = 0;
        static float resul4 = 0;
        static float cuenta1 = 0;
        static float moneditas = 0;




        static void depositar_dinero(float dinero1)
        {

            cuenta = cuenta + dinero1 + moneditas;

        }
        static void Retirar_Dinero()
        {

            if (cuenta > 0 | monedasjuntas > 0)
            {
                Console.Clear();

                Console.WriteLine("Estado actual de la cuenta=  " + cuenta);

                Console.WriteLine("Digite la cantidad de plata que desea retirar");
                retiro = float.Parse(Console.ReadLine());

                if (cuenta < retiro)
                {
                    Console.WriteLine("La cantidad de plata que desea retirar supera el monto de su cuenta");
                    Console.WriteLine("\nVuelva a ingresar el monto a retirar");

                    retiro = float.Parse(Console.ReadLine());
                    retirointento = cuenta - retiro;
                }
                else { }
                Console.WriteLine("       Menu de Billetes");


                Console.WriteLine("Billetes de 20000");
                Console.WriteLine("Billetes de 10000");
                Console.WriteLine("Billetes de 5000");
                Console.WriteLine("Billetes de 2000");
                Console.WriteLine("\n----------------------------------------------------------------------");

                Console.WriteLine("\nIngrese #0 para terminar");
                Console.WriteLine("\nIngrese el numero 1 para comensar a imgresar billetes");
                monedaretirar = float.Parse(Console.ReadLine());

                for (contador2 = 1; contador2 <= 50 && monedaretirar != 0; contador2++)
                {

                    Console.WriteLine("\nIngrese #0 para terminar");
                    Console.WriteLine("Ingrese el monto del Billete");
                    monedaretirar = float.Parse(Console.ReadLine());
                    if (monedaretirar == 20000 | monedaretirar == 10000 | monedaretirar == 5000 | monedaretirar == 2000)
                    {
                        if (monedaretirar == 20000)
                        {
                            cont4++;
                            moneda1 = moneda1 + monedaretirar;

                        }
                        else { }
                        if (monedaretirar == 10000)
                        {
                            cont1++;
                            moneda2 = moneda2 + monedaretirar;
                        }
                        else { }
                        if (monedaretirar == 5000)
                        {
                            cont2++;
                            moneda3 = moneda3 + monedaretirar;
                        }
                        else { }
                        if (monedaretirar == 2000)
                        {
                            cont3++;
                            moneda4 = moneda4 + monedaretirar;
                        }
                        else { }


                    }

                    else
                    {
                        Console.WriteLine("El billete ingresado no es correcto ingreselo denuevo");
                    }
                }

                totalbilletes = moneda1 + moneda2 + moneda3 + moneda4;
                retirointento = cuenta - retiro;
                if (retiro == totalbilletes)
                {
                    cuentaretiro = cuenta - retiro;
                    Console.WriteLine("\n----------------------------------------------------------------------");
                    Console.WriteLine("\n\nLa cuenta que quedo despues del retiro fue= " + cuentaretiro);
                    Console.WriteLine("su retiro es= " + retiro);
                    Console.WriteLine("\n----------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("\n----------------------------------------------------------------------");
                    Console.WriteLine("\n\nEl monto que ingreso no es igual al del retiro,vuelva a intentarlo ");
                    Console.WriteLine("\n----------------------------------------------------------------------");




                }
            }

            else
            {
                Console.WriteLine("no se pueda mostrar nada en esta opcion por que la cuenta no tiene saldo o plata");
            }
            totalbilletes = moneda1 + moneda2 + moneda3 + moneda4;
            Console.ReadKey();
        }

        static void Recibir_Monedas(float monedas)
        {

            for (contador = 1; contador <= 50 && monedas != 0; contador++)
            {
                Console.WriteLine("\nDigite el #0 para salir");
                Console.WriteLine("Digite el monto de la moneda");
                monedas = float.Parse(Console.ReadLine());


                if (monedas == 5 | monedas == 10 | monedas == 25 | monedas == 50 | monedas == 100 | monedas == 500)
                {

                    if (monedas == 5)
                    {
                        totalmoneda5++;
                        totalmonedas5 = totalmonedas5 + monedas;

                    }
                    else { }
                    if (monedas == 10)
                    {
                        totalmoneda10++;
                        totalmonedas10 = totalmonedas10 + monedas;
                    }
                    else { }
                    if (monedas == 25)
                    {
                        totalmoneda25++;
                        totalmonedas25 = totalmonedas25 + monedas;
                    }
                    else { }
                    if (monedas == 50)
                    {
                        totalmoneda50++;
                        totalmonedas50 = totalmonedas50 + monedas;
                    }
                    else { }
                    if (monedas == 100)
                    {
                        totalmoneda100++;
                        totalmonedas100 = totalmonedas100 + monedas;
                    }
                    else { }
                    if (monedas == 500)
                    {
                        totalmoneda500++;
                        totalmonedas500 = totalmonedas500 + monedas;
                    }
                    else { }
                }

                else
                {
                    Console.WriteLine("La moneda ingresada no es correcta intentelo denuevo");
                }
            }

            monedascantidad = totalmoneda5 + totalmoneda10 + totalmoneda25 + totalmoneda50 + totalmoneda100 + totalmoneda500;
            monedasjuntas = totalmonedas5 + totalmonedas10 + totalmonedas25 + totalmonedas50 + totalmonedas100 + totalmonedas500;
            moneditas = moneditas + monedasjuntas;

        }


        static void Indicar_Tipodecambio(float dolar2)
        {

            if (dolar2 == 1)
            {
                Console.WriteLine("\nDigite la cantidad de colones");
                float dolass = float.Parse(Console.ReadLine());
                totaldolar1 = dolass / cambiomoneda;

                Console.WriteLine("\nMoneda esta a=" + cambiomoneda);
                Console.WriteLine("Colones=" + totaldolar1);
                Console.WriteLine("\n\n");
                DateTime fecha = DateTime.Now;
                Console.WriteLine(fecha.ToLongDateString());
                Console.WriteLine(fecha.ToShortTimeString());

            }
            else
            {

            }
            if (dolar2 == 2)
            {
                Console.WriteLine("\nDigite la cantidad de  Dolares");
                float dolass = float.Parse(Console.ReadLine());
                totaldolar11 = dolass * cambiomoneda;
                Console.WriteLine("Moneda esta a=" + cambiomoneda);
                Console.WriteLine("Dolares=" + totaldolar11);
                Console.WriteLine("\n\n");
                DateTime fecha = DateTime.Now;
                Console.WriteLine(fecha.ToLongDateString());
                Console.WriteLine(fecha.ToShortTimeString());



            }
            else
            {

            }
            if (dolar2 != 1 && dolar2 != 2)
            {
                Console.WriteLine("No es un numero valido, Toque enter para volver al menu principal");
            }
            else
            {


            }


            Console.ReadKey();
        }



        static int Main()
        {


            do
            {

                Console.Clear();
                Console.WriteLine("1.Deposito de Dinero");
                Console.WriteLine("2.Retiro Dinero");
                Console.WriteLine("3.Recivo de Moneda");
                Console.WriteLine("4.Consulta Tipo de Cambio");

                Console.WriteLine("5.Salir");
                Console.WriteLine("Seleccione una opcion valida");
                usuario = int.Parse(Console.ReadLine());

                switch (usuario)
                {
                    case 1:
                        {

                            Console.Clear();
                            Console.WriteLine("Cuenta actual= " + cuenta);
                            Console.WriteLine("Ingrese la cantidad de colones a depositar ");
                            dinero1 = float.Parse(Console.ReadLine());
                            depositar_dinero(dinero1);
                            Console.WriteLine("\nNuevo deposito= " + dinero1);
                            cuenta = cuenta;
                            Console.WriteLine("Cuenta actual= " + cuenta);

                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {

                            Retirar_Dinero();
                            monedasjuntas = monedasjuntas + monedas;
                        }

                        break;
                    case 3:

                        {

                            Console.Clear();
                            Console.WriteLine("  Menu de Monedas");
                            Console.WriteLine("   Moneda de 5");

                            Console.WriteLine("   Moneda de 10");

                            Console.WriteLine("   Moneda de 25");

                            Console.WriteLine("   Moneda de 50");

                            Console.WriteLine("   Moneda de 100");

                            Console.WriteLine("   Moneda de 500");
                            Console.WriteLine("----------------------------------------------------------------------");

                            Console.WriteLine("\n            Digite el montos de las monedas que desee");
                            Console.WriteLine("Digite el #0 para salir");
                            Console.WriteLine("Ingrese el #1 para comensar a imgresar  Monedas");
                            monedas = float.Parse(Console.ReadLine());

                            Recibir_Monedas(monedas);

                            Console.WriteLine("\n\n\n----------------------------------------------------------------------");
                            Console.WriteLine("                          RESULTADOS");
                            Console.WriteLine("                       CANTIDAD           TOTAL                    ");


                            Console.WriteLine("Monedas de cinco          " + totalmoneda5 + "                " + totalmonedas5);

                            Console.WriteLine("Monedas de diez           " + totalmoneda10 + "                " + totalmonedas10);

                            Console.WriteLine("Monedas de veintecinco    " + totalmoneda25 + "                " + totalmonedas25);

                            Console.WriteLine("Monedas de cincuentas     " + totalmoneda50 + "                " + totalmonedas50);

                            Console.WriteLine("Monedas de cien           " + totalmoneda100 + "                " + totalmonedas100);

                            Console.WriteLine("Monedas de quinentos      " + totalmoneda500 + "                " + totalmonedas500);
                            Console.WriteLine("----------------------------------------------------------------------");
                            Console.WriteLine("Cantidad de todas las monedas=" + monedascantidad);

                            Console.WriteLine("Suma de todas las monedas=" + monedasjuntas);

                            Console.ReadKey();


                        }
                        break;
                    case 4:
                        {

                            Console.Clear();
                            Console.WriteLine("Digite 1 para cambiar de colones a DOLARES");
                            Console.WriteLine("Digite 2 para cambiar de dolares a COLONES");
                            dolar2 = float.Parse(Console.ReadLine());
                            Indicar_Tipodecambio(dolar2);
                        }

                        break;
                    case 5:
                        {
                            //SALIR DEL PROGRAMA
                        }
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Seleccione una opción válida...");
                            Console.ReadKey();
                            break;
                        }



                }


            } while (usuario != 5);
            return 5;
            Console.ReadKey();
        }
    }
}