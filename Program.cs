using System;

namespace TPFinal_Carles
{
    class Program
    {
        static void Main(string[] args)
        {
          // Hacer un programa que permita ingresar una lista de números que corta
          // cuando se ingresa un cero. A partir de dichos datos informar:
          // a. El mayor de los números pares.
          // b. La cantidad de números impares.
          // c. El menor de los números primos.

          // Nota: evaluar el uso de una función que analice si un número dado es 
          // primo o no y que devuelva true o false según corresponda.
		  
           int num,contimpar=0,mayorpar=0,menorprim=0;
           bool banpri=true;
           
          // Pedimos e ingresamos números.
          
           Console.WriteLine("Ingrese número: ");
           num=int.Parse(Console.ReadLine());
           
           // Dentro del while está resuelto,primero si
           // el número es par o impar, luego el mayor par,
           // el contador de impares y por último la función
           // de números primos con el menor ellos.

           while( num!=0 )
             {
             if(num%2 == 0)
                {
                 if (num>mayorpar)   // asignamos el mayor par.
                 mayorpar=num;
                }
             else
               contimpar++;     // contamos los impares.
             
             if(primo(num))     // usamos la función 'primo'              
               {
                if(banpri)
                 {                   // usamos la bandera para asignar el 
                 	menorprim=num;   // primer número primo a la variable menorprim.
                    banpri=false;
                 }
                else if (num < menorprim)     // acá asignamos el menor primo final a menorprim.
                  menorprim=num;
               }
               
               Console.WriteLine("Ingrese número: ");  // pedimos nuevamente número.
               num=int.Parse(Console.ReadLine());
             }  
             
            Console.WriteLine("*********************************************");

            if(mayorpar!=0)
              Console.WriteLine("El mayor de los números pares es: "+mayorpar);
            else
              Console.WriteLine("No hay números pares"); 

            Console.WriteLine("*********************************************");

            if(contimpar!=0)
              Console.WriteLine("La cantidad de números impares es: "+contimpar);
            else
              Console.WriteLine("No hay números impares");

            Console.WriteLine("*********************************************");

            if(menorprim!=0)
              Console.WriteLine("El menor de los números primos es: "+menorprim);
            else
               Console.WriteLine("No hay números primos");

            Console.WriteLine("*********************************************");
		}
		
		static bool primo( int n)
		{
			int con=0;
			
			for (int x=1; x <= n; x++)
			  if (n % x == 0)
			    con++;
			
			if(con == 2)
			  return true;
			else
			  return false;
		}
    }
}
