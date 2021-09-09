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

            /*Console.WriteLine("Ingrese el numero");
            double num = double.Parse(Console.ReadLine());
            string restult = (num > 0) ? " Es positivo" : " Es negativo";
            Console.WriteLine("el numero " + num + restult);*/

            //ejercicio 19 

            /*Console.WriteLine("Ingrese los tres valores");
            double Val1 = double.Parse(Console.ReadLine());
            double Val2 = double.Parse(Console.ReadLine());
            double Val3 = double.Parse(Console.ReadLine());

            if (Val1 > Val2 & Val1 > Val3) Console.Write("el numero mayor es " + Val1);
            else if (Val2 > Val3) Console.Write("el numero mayor es " + Val2);
            else Console.Write("el numero mayor es " + Val3);*/

            //ejercicio 20 

            /*int i = 0;
            double total = 0;
            int on = 1;

            while (on != 0)
            {
                Console.WriteLine("ingrese una nota");
                double not = double.Parse(Console.ReadLine());
                total = total + not;
                i++;
                Console.WriteLine("Ingrese cero para finalizar o otro numero para ingresar otra nota");
                on = int.Parse(Console.ReadLine());
            }

            double prome = total / i;
            string result = (prome >= 9) ? "El alumno tiene la beca" : "el alumno no llego al promedio";
            Console.WriteLine(result);*/

            // ejercicio 21

            /* Console.WriteLine("Ingrese su categoria 1 para tercera edad,2 para estudiantes , 3 para menores de edad, 4 para clientes regulares ");
             int cat = int.Parse(Console.ReadLine());
             double pasj = 375;
             if (cat == 1) pasj = pasj * 0.4;
             else if (cat == 2) pasj = pasj * 0.5;
             else if (cat == 3) pasj = pasj * 0.65;

             Console.WriteLine("el total a pagar es de $ " + pasj);*/

            // Ejercicio 22

            /* Console.Write("ingrese la cantidad ");
             double cant = double.Parse(Console.ReadLine());
             Console.WriteLine("ingrese el precio");
             double pre = double.Parse(Console.ReadLine());

             cant = cant / 2;
             cant = Math.Ceiling(cant); // Se forza el redondeo por si la cantidad es impar sino lo es lo deja como es 
             double Total = cant * pre;
             Console.WriteLine("El total a paga es de $ " + Total ); */

            //ejercicio 23 

            /*Console.Write("ingrese el precio de compra del producto ");
            double pc = double.Parse(Console.ReadLine());
            if (pc > 0)
                Console.Write("el precio a vender el producto es de $ " + pc * 1.3);
            else Console.Write("Ingrese un valor real");*/

            //ejercicio 24

            /* Console.WriteLine("Ingrese el numero");
             double num = double.Parse(Console.ReadLine());
             if (num % 2 == 0) Console.WriteLine("El numero es par");
             else Console.WriteLine("el numero es impar");*/

            //ejercicio 25

            /*Console.WriteLine("Ingrese si edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad > 18) Console.Write("Usted es mayor de edad");
            else Console.Write("Usted es menor de edad");*/

            //ejercicio 27

            /*Console.WriteLine("ingrese el numero");
            double num = double.Parse(Console.ReadLine());

            if (num > 0) Console.WriteLine("el numero es positivo");
            else if (num == 0) Console.WriteLine("El numero es 0");
            else Console.WriteLine("el numero es negativo");
            */

            //ejercicio 28

            /*Console.WriteLine("Ingrese los 3 numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 & num1 > num3) Console.WriteLine("El numero mayor es " + num1);
            else if (num2 > num3) Console.WriteLine("El numero mayor es " + num2);
            else Console.WriteLine("El numero mayor es " + num3);*/

            //ejercicio 29

            /*double aumento;
            Console.WriteLine("Ingrese su sueldo");
            double sueldo = double.Parse(Console.ReadLine());
            if (sueldo <= 1000) { aumento = sueldo * 1.15; }
            else { aumento = sueldo * 1.12; }
            Console.WriteLine("Su sueldo actual es de $ " + aumento);*/

            //ejercicio 30

            /*double total;
            Console.WriteLine("Ingrese la cantidad de personas");
            int cant = int.Parse(Console.ReadLine());
            if (cant < 8) total = cant * 45;
            else total = cant * 30;
            Console.Write("El total a pagar es de % " + total);*/

            // ejercicio 31
            // Este ejercicio es Determinar el numero mayor de 3 ya lo hice varias veces 

            //ejercicio 32 

            /*double total;
            Console.Write("Ingrese el valor");
            double Valo = double.Parse(Console.ReadLine());

            if (Valo < 500) total = Valo;
            else if (Valo > 501 & Valo < 1000) total = Valo * 0.95;
            else if (Valo > 1001 & Valo < 7000) total = Valo * 0.9;
            else if (Valo > 7001 & Valo < 15000) total = Valo * 0.85;
            else total = Valo * 0.8;

            Console.WriteLine("El total a pagar es de $ " + total);*/

            // ejercicio 33

            /*double resultado;
            Console.WriteLine("ingrese los dos numeros");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.Write(" 1 para sumarlos 2 para restarlos 3 para multiplicarlos 4 para dividirlos ");
            int ope = int.Parse(Console.ReadLine());

            if (ope == 1) resultado = num1 + num2;
            else if (ope == 2) resultado = num1 - num2;
            else if (ope == 3) resultado = num1 * num2;
            else  resultado = num1 / num2;

            Console.Write(" El resultado de la operacion deseada es " + resultado);*/

            //ejercicio 34

            /*Console.Write("Ingrese la categoria");
            int cate = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su sueldo");
            double Sueldo = double.Parse(Console.ReadLine());

            if (cate == 1) Sueldo = Sueldo * 1.15;
            else if (cate == 2) Sueldo = Sueldo * 1.1;
            else if (cate == 3) Sueldo = Sueldo * 1.08;
            else Sueldo = Sueldo * 1.07;

            Console.Write("El sueldo final es de $ " + Sueldo);*/

            //ejercicio 35 -_-

            // ejercicio 36 easy

            //ejercicio 37

            //ejercicio 38 

            /*Console.Write("ingrese la zona del 1 al 5 ");
            int zona = int.Parse(Console.ReadLine());
            Console.Write("ingrese la cantidad de m3");
            double consumo = double.Parse(Console.ReadLine());
            double total;
            string area;
            if (zona == 1) { total = consumo * 0.28; area = "Centro"; }
            else if  (zona == 2) {total = consumo * 0.3; area = "Norte"; }
            else if  (zona == 3) {total = consumo * 0.28; area = "Este"; }
            else if  (zona == 4) {total = consumo * 0.25; area = "Sur"; }
            else {total = consumo * 0.5; area = "Oeste"; }

            Console.Write("Zona Numero : " + zona);
            Console.Write("Ubicacion :" + area);
            Console.Write("Consumo" + consumo );
            Console.Write("Total a Pagar $ " + total );*/

            //Ejercicio 39

            /*Console.Write("Ingrese la temperatura del dia");
            double tempt = double.Parse(Console.ReadLine());
            string depo;
            if (tempt > 30) depo = "Natacion";
            else if (tempt > 20 & tempt <= 30) depo = "Tenis";
            else if (tempt > 0 & tempt <= 20) depo = "Golf";
            else  depo = "Ski";

            Console.Write("El deporte correcto para realizar es " + depo);*/

            //ejercicio 40

            /*Console.WriteLine("ingrese las tres notas");
            double not1 = double.Parse(Console.ReadLine());
            double not2 = double.Parse(Console.ReadLine());
            double not3 = double.Parse(Console.ReadLine());

            Console.Write("El promedio es de " + ((not1 + not2 + not3) / 3));*/

            //ejercicio 41 Geometria -_-


            //ejercicio 42 

            /*Console.WriteLine("Ingrese los dos valores");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double total = num1 + num2;

            if (total < 20) total = total + 10;
            Console.Write("El total es " + total);*/

            //ejercicio 43 

            /*Console.WriteLine("Ingrese los tres numeros ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > 0) num1 = Math.Pow(num1, 2);
            else num1 = Math.Pow(num1, 3);
            if (num2 > 0) num2 = Math.Pow(num2, 2);
            else num2 = Math.Pow(num2, 3);
            if (num3 > 0) num3 = Math.Pow(num3, 2);
            else num3 = Math.Pow(num3, 3);

            Console.WriteLine("El resultado " + num1);
            Console.WriteLine("El resultado " + num2);
            Console.WriteLine("El resultado " + num3);*/

            // ejercicio 44

            /*int inicio = 1;

            while (inicio != 0)
            {
                Console.WriteLine("Ingrese el nombre ");
                string Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la estatura ");
                double estatura = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad ");
                int edad = int.Parse(Console.ReadLine());

                if (estatura < 1.75 || edad < 16) Console.WriteLine(Nombre + " No Fue aceptado");
                else Console.WriteLine(Nombre + " Fue aceptado");

                Console.Write("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            }
            */

            // ejercicio 45

            /* int inicio = 1;
            double desc;

            while (inicio != 0)
            {
                Console.WriteLine("Ingrese el valor del producto");
                double valor = double.Parse(Console.ReadLine());

                if (valor >= 5000) desc = valor * 0.2;
                else if (valor < 5000 & valor >= 1000) desc = valor * 0.15;
                else desc = valor;

                Console.WriteLine("el descuento es de $ " + desc);

                Console.Write("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            
            }
            */

            //ejercicio 46

            /*int inicio = 1;

            while (inicio != 0)
            {
                Console.WriteLine("Ingrese el numero que desee calcular s cuadrado");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num, 2) + " Es el cuadrado");

                Console.Write("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            }
            */

            //ejercicio 47

            /* int inicio = 1;
            string medio;
            Console.Write("Ingrese el valor de la hora de trabajo ");
            double valo = double.Parse(Console.ReadLine());
            while (inicio != 0)
            {
                Console.Write("Ingrese la cantidad de horas trabajadas ");
                double cant = double.Parse(Console.ReadLine());
                double total = valo * cant;
                if (total >= 5000) medio = "cheque";
                else medio = "efectivo";
                Console.Write("El total es de $ " + total + " se emitira " + medio);

                Console.WriteLine("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            }
            */

            //ejerccicio 48

            /*Console.WriteLine("Ingrese su sueldo");
            double sueldo = double.Parse(Console.ReadLine());

            if (sueldo <= 3000) sueldo *= 0.96; // forma corta para no escribir sueldo = sueldo * 0.96
            else sueldo -= 120;

            Console.WriteLine("el sueldo a cobrar es de $ " + sueldo);
            */

            //ejercicio 49 

            /*Console.WriteLine("ingrese el consumo del mes");
            double consumo = double.Parse(Console.ReadLine());
            double total = 0;
            if (consumo > 180) total = 30 + (consumo - 180) * 0.2;
            else total = 20;

            Console.WriteLine("El total es " + total);
            */

            //ejercicio 50

            /*Console.WriteLine("Ingrese los 3 valores");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double total = num1;

            if (num1 > 10) total = num1 * num2;

            if (total < 50) total += num3;

            Console.WriteLine("el resultado " + total);*/

            //ejercicio 51

            /*Console.WriteLine("Ingrese las tres notas");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double prome = (num1 + num2 + num3) / 3;

            if (prome > 17) Console.WriteLine("Felicitaciones");*/

            //ejercicio 52

            /*Console.WriteLine("Ingrese su sueldo");
            double sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el impuesto que paga");
            double imp = double.Parse(Console.ReadLine());

            if (imp > 200) Console.WriteLine("Paga demasiado ");*/

            //ejercicio 53

            /*for (int i=1; i<3; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine(); 
                Console.WriteLine("Ingrese la cantidad de zapatos q confecciono");
                double cant = double.Parse(Console.ReadLine());
                Console.WriteLine(nombre + " Su sueldo es de $ " + cant * 80);
            }
            */

            //ejercicio 54 

            /*Console.WriteLine("Ingrese el numero");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado de " + num + " " + (Math.Pow(num, 2)) + " El cubo de " + num + " " + (Math.Pow(num, 3)) + " La mitad de " + num + " " + num/2 );
            */

            //ejercicio 55

            /*int inicio = 1;
            double ventas = 0;

            while (inicio !> 0)
            {
                Console.WriteLine("Ingrese la edad del vendedor");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese lo vendido contado");
                double contado = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese lo vendido a credito");
                double credito = double.Parse(Console.ReadLine());
                if (edad < 30) ventas += contado + credito;

                Console.WriteLine("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());

            }
            */

            //ejercicio 56 

            /*int count = 0;
            for (int i = 1; i == 20; i++) 
            {
                Console.WriteLine("Ingrese el sueldo del vendedor");
                double sueldo = double.Parse(Console.ReadLine());
                if (sueldo > 3000) count++;
            }
            */

            //ejercicio 57

            /*int inicio = 1;
            double suma = 0;
            int cant = 0;

            while (inicio !> 0)
            {
                Console.WriteLine("Ingrese la nota");
                double nota = double.Parse(Console.ReadLine());
                suma += nota;
                cant++;
                Console.WriteLine("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El promedio es de " + suma/cant);
            */

            //ejercicio 58

            /*int inicio = 1;
            double total = 0;

            while (inicio !> 0)
            {
                Console.WriteLine("Ingrese el monto de dla venta");
                double monto = double.Parse(Console.ReadLine());
                if (monto <= 1000) total += monto * 0.1;
                else if (monto > 1001 & monto <= 5000) total += monto * 0.15;
                else total += 1000;
                
                Console.WriteLine("Para finalizar ingrese 0 otro numero para continuar");
                inicio = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El total a pagar de comicion es de $ " + total);
            */

            //ejercicio 59

            /* int inicio = 1;
             double total = 0;
             int cant = 0;

             while (inicio! > 0)
             {
                 Console.WriteLine("Ingrese el monto de la venta");
                 double monto = double.Parse(Console.ReadLine());
                 total += monto;
                 cant++;

                 Console.WriteLine("Para finalizar ingrese 0 otro numero para continuar");
                 inicio = int.Parse(Console.ReadLine());
             }

             Console.WriteLine("Comieron la cantidad de " + cant + " Personas ");
             Console.WriteLine("Se recaudo $ " + total);
             */

            //ejercicio 60

            /*Console.WriteLine("Ingrese los tres valores");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double result = 0;
            if (num1 < 10) result += num1 + num2 + num3;
            if (result < 50) result *= 50;
            if (num1 >= 10) result += (num2 * 5) + num3;

            Console.WriteLine("ElResultado " + result);
            */

            //ejercicio 61

            /*Console.WriteLine("Ingrese la cantidad de horas");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese le valor de las horas");
            double valor = double.Parse(Console.ReadLine());
            double total = horas * valor;
            double horasex = 0;
            if (horas > 40)
            {
                total = valor * 40;
                horasex = horas - 40;
                horasex *= (valor * 1.5);
            }

            Console.WriteLine("El sueldo es de $ " + (total + horasex));
            */

            //ejercicio 62 

            /*Console.WriteLine("Ingrese el monto");
            double mont = double.Parse(Console.ReadLine());
            double total = 0;
            if (mont > 100) total = mont * 0.9;
            else total = mont * 0.98;
            Console.WriteLine("El total es de $ " + total);*/

            //ejercicio 63

            /*Console.WriteLine("Ingrese el valor");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad");
            double cant = double.Parse(Console.ReadLine());
            double total = (valor * cant) * 1.19;

            if (total > 13000) total *= 0.95;

            Console.WriteLine("El total es de $ " + total); */

            //ejercicio 64 geometria

            //ejercicio 65

            /*Console.WriteLine("Ingrese los tres valores");

            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 < num2 & num1 < num3) Console.WriteLine("El numero menor es " + num1);
            else if (num2 < num3) Console.WriteLine("El numero menor es " + num2);
            else Console.WriteLine("El numero menor es " + num3);*/

            //ejercicio 66

            /*double total = 0;
            double notamayor = 0;
            double notamenor = 500;
            double nota1 = 0; double nota2 = 0; double nota3 = 0; double nota4 = 0; double nota5 = 0;
            string alumno1 = "";string alumno2 = ""; string alumno3 = ""; string alumno4 = ""; string alumno5 = "";

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota");
                double nota = double.Parse(Console.ReadLine());
                if (i == 1) {alumno1 = nombre; nota1 = nota; }
                else if (i == 2) { alumno2 = nombre; nota2 = nota; }
                else if (i == 3) { alumno3 = nombre; nota3 = nota; }
                else if (i == 4) { alumno4 = nombre; nota4 = nota; }
                else { alumno5 = nombre; nota5 = nota; }

                total += nota;
                if (nota > notamayor) notamayor = nota;
                if (nota < notamenor) notamenor = nota;
            }

            Console.WriteLine("Alumno " + alumno1 + " su nota fue de " + nota1);
            Console.WriteLine("Alumno " + alumno2 + " su nota fue de " + nota2);
            Console.WriteLine("Alumno " + alumno3 + " su nota fue de " + nota3);
            Console.WriteLine("Alumno " + alumno4 + " su nota fue de " + nota4);
            Console.WriteLine("Alumno " + alumno5 + " su nota fue de " + nota5);
            Console.WriteLine("La nota mayor fue " + notamayor);
            Console.WriteLine("La nota menor fue " + notamenor);
            Console.WriteLine("El promedio fue de " + total / 5);
            */

            //ejercicio 67

            /*Console.WriteLine("Ingrese la cantidad del prestamo");
            double cred = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de interes");
            double tasa = double.Parse(Console.ReadLine());
            tasa /= 100;
            Console.WriteLine("Ingrese la cantidad de meses");
            double meses = double.Parse(Console.ReadLine());

            // acumuladores
            double totalCred = (cred * tasa) + cred;
            double CredDividido = totalCred / meses;
            // fin acumuladores

            
            for (double i = 1; i <= meses; i++)
            {
                Console.WriteLine("El monto a pagar el mes " + i + " es de $ " + CredDividido );
                totalCred -= CredDividido;
                Console.WriteLine("El restante a pagar es de $ " + totalCred);
                Console.WriteLine(" ");
            }
            //ESTA SIMPLE EL EJERCICIO REQUIERE MAS PERO SOLO ES CUESTION DE AGREGAR VARIABLES Y MOSTRAR MAS DATOS
            */

            //ejercicio 68

            /*Console.WriteLine("Ingrese el numero deseado");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + num + " = " + i * num);
            } */

            //ejercicio 69 

           /* int cat = 1;
            double total = 0, monto = 0;
            
            while (cat !< 4)
            {
                Console.WriteLine("ingrese la categoria de combustible, 1 , 2 , 3 o ingrese 4 para finalizar");
                cat = int.Parse(Console.ReadLine());
               if (cat !< 4)
                {
                    Console.WriteLine("Ingrese la cantidad de galones");
                    double gal = double.Parse(Console.ReadLine());

                    if (cat == 1) monto = (gal * 3.785) * 50;
                    else if (cat == 2) monto = (gal * 3.785) * 55;
                    else monto = (gal * 3.785) * 60;
                    total += monto;
                }
                
            }
            Console.WriteLine("El total vendido es de $" + total);
            */

            //ejercicio 70

        }
    }
}
