using System;

namespace programaFabiana
{
    class Program
    {
        public static void Main(string[] args)
        {
            string cadena ="";
            int edad = 0;
            double altura = 0.0;
            
            Console.WriteLine("Hola, por favor ingresa tu edad:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
            if(edad > 21)
            {
                Console.WriteLine("Disculpe, la edad excede el límite permitido para la entrada a las instalaciones.");
            }
            else
            {
                Console.WriteLine("Bienvenido");
                
                Console.WriteLine("¿Cual es su altura? Por favor especifique en metros");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);
                
                if(altura < 1.65) 
                {
                Console.WriteLine("No tiene acceso a Montaña Rusa. Solo accesa a Gusanito y a Pista de Patinaje");    
                }
                else
                {
                    Console.WriteLine("Full acceso a todas las instalaciones");
                }
            }
        
        }
    }
}   
