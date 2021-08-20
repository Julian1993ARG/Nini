using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // ejercio 1

            /*int total, capital;
            double interes;
            Console.WriteLine("¡ingrese el monto a invertir!");
            capital = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el interes");
            interes = double.Parse(Console.ReadLine());
            interes = interes / 100;
            Console.WriteLine("el interes ganado por mes es de $ " + capital * interes);*/

            //ejercicio 2
            /*double venta1, venta2, venta3, sueldobase, sueldofinal, comision;


            Console.WriteLine("Ingrese su sueldo basico $ ");
            sueldobase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Venta 1 $ ");
            venta1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Venta 2 $ ");
            venta2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese Venta 3 $ ");
            venta3 = double.Parse(Console.ReadLine());

            comision = (venta1 + venta2 + venta3) * 0.10;

            sueldofinal = sueldobase + comision;

            Console.WriteLine("El sueldo final a cobrar es de $ " + sueldofinal);

            Console.ReadLine();*/

            //ejecrcicio 3 

            /*double total;
            Console.WriteLine("Ingrese el total de la compra");
            total = double.Parse(Console.ReadLine());
            total = total * 0.85;
            Console.Write("El total a pagar es de $ " + total);*/

            //ejercicio 4 

            /*double not1, not2, not3, notfm, exf, tf;
            Console.Write("ingrese las 3 notas de los parciales ");
            not1 = double.Parse(Console.ReadLine());
            not2 = double.Parse(Console.ReadLine());
            not3 = double.Parse(Console.ReadLine());
            Console.Write("ingrese la nota del examen final ");
            exf = double.Parse(Console.ReadLine());
            Console.Write("ingrese la nota del trabajo final ");
            tf = double.Parse(Console.ReadLine());
            notfm = ((not1 + not2 + not3) / 3) * 0.55 ;
            exf = exf * 0.3;
            tf = tf * 0.15;

            Console.Write("la nota es de " + (notfm + exf + tf));*/

            //ejecrcicio 5

            /*double TC, pesos;
            Console.Write("Ingrese el monto ");
            pesos = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tipo de cambio ");
            TC = double.Parse(Console.ReadLine());

            Console.Write("El total en dolares es de U$D " + (pesos / TC)); */

            //ejercicio 6 

            /*double Sal;
            Console.Write("ingrese si salario ");
            Sal = double.Parse(Console.ReadLine());
            Console.Write("su salario con el incremeto quedo en $ " + (Sal * 1.25));
            */

            //ejercicio 7 

            /*double pre, gin, trau, ped;

            Console.Write("Ingrese el presupuesto anual ");
            pre = double.Parse(Console.ReadLine());
            gin = pre * 0.4;
            trau = pre * 0.3;
            ped = pre * 0.3;

            Console.WriteLine("el presupuesto al area de ginecologia es de $ " + gin);
            Console.WriteLine("el presupuesto al area de traumatologia es de $ " + trau);
            Console.WriteLine("el presupuesto al area de pediatria es de $ " + ped);
            */

            //ejercicio 8

            /*double pc;
            Console.Write("ingrese el precio de compra del producto ");
            pc = double.Parse(Console.ReadLine());
            Console.Write("el precio a vender el producto es de $ " + pc * 1.3);*/

            //ejercicio 9 

            /*double t1, t2, t3;
            Console.Write("ingrese el tiempo del lunes ");
            t1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el tiempo del miercoles ");
            t2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el tiempo del viernes ");
            t3 = double.Parse(Console.ReadLine());

            Console.Write("el tiempo promedio es de " + ((t1+t2+t3)/3));*/

            //ejercicio 10

            /*double total, acc1, acc2, acc3;

            Console.Write("ingrese la catidad invertida acc1 ");
            acc1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese la catidad invertida acc2 ");
            acc2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese la catidad invertida acc3 ");
            acc3 = double.Parse(Console.ReadLine());
            total = acc1 + acc2 + acc3;
            Console.Write(" acc1 " + ((acc1 * 100) / total) + "%");
            Console.Write(" acc2 " + ((acc2 * 100) / total) + "%");
            Console.Write(" acc3 " + ((acc3 * 100) / total) + "%");*/

            //ejercicio 11

            /*double dias, total;

            Console.Write("ingrese la cantidad de dias ");
            dias = double.Parse(Console.ReadLine());
            total = dias * 86400;
            Console.Write("la catidad de " + dias +" dias tiene " + total + " segundos");*/

            //ejercicio 12 

            /*double rad, altura,pi;

            Console.Write("ingrese el radio");
            rad = double.Parse(Console.ReadLine());
            Console.Write("ingrese la altura");
            altura = double.Parse(Console.ReadLine());
            pi = 3.1415;

            Console.Write("el volumen es de " + ( pi * (rad*rad) * altura ));
            Console.Write("el volumen es de " + (2 * pi * rad * altura));*/

            //ejercicio 13 

            /*double vel, total;
            Console.WriteLine("Ingrese la velocidad");
            vel = double.Parse(Console.ReadLine());
            total = 417 / vel;

            total = Math.Round(total,2); // Para que solo muestre 2 decimales

            Console.Write("El tiempo necesario es " + total );*/

            //ejercicio 14

            /*double gal, total;
            Console.Write("Ingrese la cantidad de Galones ");
            gal = double.Parse(Console.ReadLine());
            total = gal * 31.037;
            total = Math.Round(total, 2);
            Console.Write("El total es de $ " + total);*/

            //ejercicio 15 

            /* double not;
             Console.Write("Ingrese la nota ");
             not = double.Parse(Console.ReadLine());

             if (not >= 8) {
                 Console.WriteLine("Aprovado");
             }
             else { Console.WriteLine("Desaprovado"); }*/

            /*
            Console.Write("Ingrese la nota ");
            double nota = double.Parse(Console.ReadLine());
            string resultado = (nota >= 8) ? "Aprovado" : "Desaprovado"; // FORMA CORTA DEL IF
            Console.Write(resultado);
            */

            //ejercicio 16

            /*Console.Write("ingrese el numero");
            double num = double.Parse(Console.ReadLine());
            num = num % 2;
            string result = (num == 0) ? "Es par el numero" : "Es impar el numero";
            Console.WriteLine(result);*/

            //ejercicio 17 

            /*Console.Write("Ingrese el sueldo ");
            double Sueldo = Double.Parse(Console.ReadLine());
            Sueldo = Sueldo * 1.15;
            Math.Round(Sueldo, 2);
            if (Sueldo > 1000) Console.Write(Sueldo) ;*/

            //ejercicio 18

            Console.WriteLine("Ingrese el numero");
            double num = double.Parse(Console.ReadLine());
            string restult = (num > 0) ? " Es positivo" : " Es negativo";
            Console.WriteLine("el numero " + num + restult);


        }
    }
}
