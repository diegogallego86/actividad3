using System;

namespace actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int ActividadPerro = 0;
            double peso = 0.0;
            int etapadelperro = 0;
            int mesescachorro = 0;
            int tamañocachorro = 0;

            Console.WriteLine("Bienvenido, para saber cuanto debe comer su perro responda las siguientes preguntas");

            Console.WriteLine("¿en que etapa se encuentra su perro?");

                 Console.WriteLine("1 - Adulto");
                 Console.WriteLine("2 - Cachorro"); 
                 dato = Console.ReadLine();
                 etapadelperro = Convert.ToInt32(dato);

                 if(etapadelperro==1)
                {
                  Console.WriteLine("¿Cual es el peso de su perro en kilogramos?:");
                  dato = Console.ReadLine();
                  peso = Convert.ToDouble(dato);

                 Console.WriteLine("¿Como considera la actividad de su mascota?");
                 Console.WriteLine("1 - Actividad Alta");
                 Console.WriteLine("2 - Actividad Normal");
                 Console.WriteLine("3 - Actividad Baja");

                  dato = Console.ReadLine();
                  ActividadPerro = Convert.ToInt32(dato);


                 // Tamaño SS
                 if(peso <= 5 && peso >= 2)

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 y 85 gramos de alimento.");
                            break;
                    }

                // Tamaño S

                if(peso <= 10 && peso >= 5)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 170 gramos de alimento.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 y 145 gramos de alimento.");
                            break;
                    }

                }
                // Tamaño M
                if(peso <= 15 && peso >= 10)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190 y 255 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 y 225 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 y 195 gramos de alimento por día.");
                            break;
                    }

                }
                // Tamaño L
                if(peso <= 25 && peso >= 15)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 y 330 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 y 285 gramos de alimento por día.");
                            break;
                    }

                }
                // Tamaño XL
                if(peso <= 40 && peso >= 25)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 y 475 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 y 410 gramos de alimento por día.");
                            break;
                    }

                }
                // Tamaño XXL
                 if(peso <= 55 && peso >= 40)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 475 y 600 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 y 520 gramos de alimento por día.");
                            break;
                    }

                }
                // Tamaño XXXL
                 if(peso <= 70 && peso >= 55)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 y 720 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 820 y 895 gramos de alimento por día.");
                            break;
                    }

                }
                // Tamaño XXXXL
                  if(peso <= 90 && peso >= 70)
                {

                    switch (ActividadPerro) 
                    {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de alimento por día.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 720 y 870 gramos de alimento por día.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 620 y 750 gramos de alimento por día.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("¿cuantos meses tiene su cachorro?");
                dato = Console.ReadLine();
                mesescachorro = Convert.ToInt32(dato);

                Console.WriteLine("¿De que tamaño es su cachorro?");

                Console.WriteLine("opcion 1 - muy pequeño");
                Console.WriteLine("opcion 2 - pequeño");
                Console.WriteLine("opcion 3 - mediano");
                Console.WriteLine("opcion 4 - grande");
                Console.WriteLine("opcion 5 - muy grande");
                Console.WriteLine("opcion 6 - demasiado grande");

                dato = Console.ReadLine();
                tamañocachorro = Convert.ToInt32(dato);

                //cachorro 2 meses

                    if(mesescachorro==2)

                    switch (tamañocachorro) 
                    {
                        case 1:
                            Console.WriteLine("el peso ideal de su perro es 2 kg y debe comer 50 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("el peso ideal de su perro es de 5kg a 10kg y debe comer entre 95 y 155 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("el peso ideal de su perro es 17 kg y debe comer 215 gramos de comida.");
                            break;
                        case 4:
                            Console.WriteLine("el peso ideal de su perro es de 25kg a 32kg y debe comer de 270 a 300 gramos de comida.");
                            break;
                        case 5:
                            Console.WriteLine("el peso ideal de su perro es de 40kg a 60kg y debe comer de 355 a 450 gramos de comida.");
                            break;
                        case 6:
                            Console.WriteLine("el peso ideal de su perro es de 70kg a 90 kg y debe comer de 485 a 580 gramos de comida.");
                            break;
                    }

                //cachorro 3 meses

                     if(mesescachorro==3)

                    switch (tamañocachorro) 
                    {
                        case 1:
                            Console.WriteLine("el peso ideal de su 2kg perro es y debe comer gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("el peso ideal de su perro es de 5kg a 10kg y debe comer de 110 a 185 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("el peso ideal de su perro es 17 kg y debe comer de 265 gramos de comida.");
                            break;
                        case 4:
                            Console.WriteLine("el peso ideal de su perro es de 25kg a 32kg y debe comer de 350 a 400 gramos de comida.");
                            break;
                        case 5:
                            Console.WriteLine("el peso ideal de su perro es de 40kg a 60kg y debe comer de 475 a 605 gramos de comida.");
                            break;
                        case 6:
                            Console.WriteLine("el peso ideal de su perro es de 70kg a 90kg y debe comer 670 gramos de comida.");
                            break;
                    }

                    //cachorro 4 meses

                     if(mesescachorro==4)

                    switch (tamañocachorro) 
                    {
                        case 1:
                            Console.WriteLine("el peso ideal de su perro es 2kg y debe comer 60 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("el peso ideal de su perro es de 5kg a 10kg y debe comer de 115 a 195 gramos de comida");
                            break;
                        case 3:
                            Console.WriteLine("el peso ideal de su perro es 17kg y debe comer 285 gramos de comida.");
                            break;
                        case 4:
                            Console.WriteLine("el peso ideal de su perro es de 25kg a 32kg y debe comer de 375 a 445 gramos de comida.");
                            break;
                        case 5:
                            Console.WriteLine("el peso ideal de su perro es de 40kg a 60kg y debe comer de 525 a 685 gramos de comida.");
                            break;
                        case 6:
                            Console.WriteLine("el peso ideal de su perro es de 70kg a 90gk y debe comer 700 gramos de comida.");
                            break;
                    }

                     //cachorro 5 meses

                     if(mesescachorro==5)

                    switch (tamañocachorro) 
                    {
                        case 1:
                            Console.WriteLine("el peso ideal de su perro es 2kg y debe comer 60 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("el peso ideal de su perro es de 5kg a 10kg y debe comer gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("el peso ideal de su perro es 17kg y debe comer de 115 a 190 gramos de comida.");
                            break;
                        case 4:
                            Console.WriteLine("el peso ideal de su perro es de 25kg a 32kg y debe comer de 375 a 450 gramos de comida.");
                            break;
                        case 5:
                            Console.WriteLine("el peso ideal de su perro es de 40kg a 60kg y debe comer 625 gramos de comida.");
                            break;
                        case 6:
                            Console.WriteLine("el peso ideal de su perro es de 70kg a 90kg y debe comer 700 gramos de comida.");
                            break;
                    }

                     //cachorro 6 - 12 meses

                     if(tamañocachorro <= 12 && tamañocachorro >= 6)

                    switch (tamañocachorro) 
                    {
                        case 1:
                            Console.WriteLine("el peso ideal de su perro es 2kg y debe comer 55 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("el peso ideal de su perro es de 5kg a 10kg y debe comer de 110 a 185 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("el peso ideal de su perro es 17kg y debe comer 280 gramos de comida.");
                            break;
                        case 4:
                            Console.WriteLine("el peso ideal de su perro es de 25kg a 32kg y debe comer de 370 a 450 gramos de comida.");
                            break;
                        case 5:
                            Console.WriteLine("el peso ideal de su perro es de 40kg a 60kg y debe comer 600 gramos de comida.");
                            break;
                        case 6:
                            Console.WriteLine("el peso ideal de su perro es de 70kg a 90kg y debe comer 700 gramos de comida.");
                            break;
                    }
            }   
        }     
    }
}