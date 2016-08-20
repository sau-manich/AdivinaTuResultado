using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinaTUresultado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numC;
            int resul;
            string nom;
            
            Console.WriteLine();
            Console.WriteLine("     BIENBENIDO AL JUEGO DE DONDE YO SOY EL QUE ADIVINA");
            Console.WriteLine("     DIME CUAL ES TU NOMBRE..??");
            nom = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("     AHORA SI "+nom+" EMPECEMOS");
            Console.WriteLine("");
            Console.WriteLine("     PIENSA EN UN NUMERO");
            Console.WriteLine("     NO LO ESCRIBAS SOLO PIENSA Y PULSA ENTER");
            Console.WriteLine("     LISTO..???");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("     AHORA MULTIPLICALO POR DOS");
            Console.WriteLine("     LISTO..???");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("     AHORA INTRODUCE UN NUMERO PAR, EL QUE QUIERAS");
            numC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("     AHORA SUMA EL NUMERO QUE INTRODUJISTE Y SUMALO CON LO QUE TENIAS MAS ANTES" );
            Console.WriteLine("     LISTO..???");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("     AHORA DIBIDELO TODO TU RESULTADO ENTRE DOS");
            Console.WriteLine("     LISTO..???");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("     AHORA RESTALO POR EL NUMERO QUE PENSASTE A PRINCIPIO");
            Console.WriteLine("     LISTO..???");
            Console.ReadKey();
            Console.WriteLine("     MIRA FIJAMENTE ALA CAMARA Y PULSA ENTER");
            Console.ReadKey();
            string opcion = string.Empty;
            Console.ReadKey();

            while (opcion != "1")
            {
                Console.WriteLine(" ______________________________________________________________________");
                Console.WriteLine("|                                                                      |");
                Console.WriteLine("|                QUIERES SABER CUANTO ES TURESULTADO..??               |");
                Console.WriteLine("|______________________________________________________________________|");
                Console.WriteLine("|                                                                      |");
                Console.WriteLine("|  1.-   SI DECEO VER MI RESULTADO                                     |");
                Console.WriteLine("|  2.-  NO ME DA MIEDO SABER QUE UNA                                   |");
                Console.WriteLine("|     COMPUTADORA ADIBINE MI RESULTADO                                 |");
                Console.WriteLine("|______________________________________________________________________|");
                Console.WriteLine();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        {
                            
                            resul = numC / 2;
                            Console.WriteLine("     TU RESULTADO ES ......{0}", resul);
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("     MIEDOSO  =P");
                        }
                        break;
                }
            }
        }
    }
}
