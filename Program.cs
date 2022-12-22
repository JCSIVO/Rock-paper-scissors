// Elaboración en C# del mítico juego de las tres en raya por JCSIVO (12-2022)

using System;

public class Program 
{
    public static void Main() {
        // Creación de las variables que se van a utilizar en el programa 
        var rnd = new Random();
        int maquina = rnd.Next(1,3);
        int usuario = 0;
        int ordenador = 0;
        int empate = 0;
        int valor = 0;
        string option = "";
        string optionm = "";
        int res = 1; 
        int partidas = 0;

        // Bucle para jugar indefinidamente hasta que el valor de res cambie a 0
        while(res == 1){
        Console.WriteLine(" ¡Bienvenido al juego de Piedra, Papel o Tijera !");
        Console.WriteLine("Debes de elegir una de estas opciones");
        Console.WriteLine("1. Roca");
        Console.WriteLine("2. Papel");
        Console.WriteLine("3. Tijeras");
        Console.WriteLine("");
        Console.WriteLine("Ingresa la opción elegida");
        int z = Convert.ToInt32(Console.ReadLine());

        // Asignación a cada numero una opción determinada diferente (Roca, Papel, Tijera)  
         if (z == 1) {
            option = "Roca";
        } else if (z == 2)  {
            option = "Papel";
        }else{
           option = "Tijeras";
        }
        if (maquina == 1) {
            optionm = "Roca";
        } else if (maquina == 2)  {
            optionm = "Papel";
        }else{
           optionm = "Tijeras";
        }
        //Console.WriteLine("la opcion de la máquina es: " + maquina + " " + optionm);

        Console.WriteLine("El usuario ha elegido: " + z + " - " + option  + " Y la máquina ha escogido: " + maquina + " - " + optionm);
        
        // Se convierte el valor del usuario a Int y se le asigna a una variable 
        valor = Convert.ToInt32(z);

            // Se comparan los valores introducidos por el usuario y la maquina 
            // para determinar si hay un empate, gana el usuario o la máquina.
            switch(z){
                case 1:
                    if(valor == maquina){
                        Console.WriteLine("Empate, habeis elegido: " + option  );
                        empate = empate + 1;
                        Console.WriteLine("¿Quieres seguir probando suerte? 1:Si 0: No");
                        res = Convert.ToInt32(Console.ReadLine());
                    } 
                    break;
                case 2:
                    if ((valor == 1 && maquina == 3) || (valor == 2 && maquina == 1) || (valor == 3 && maquina == 2)) {
                        Console.WriteLine("Gana, el Usuario: " + option  );
                        usuario = usuario + 1;
                        Console.WriteLine("El usuario gana un punto: " + usuario);
                        Console.WriteLine("¿Quieres seguir probando suerte? 1:Si 0: No");
                        res = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 3:
                    if ((valor == 3 && maquina == 1) || (valor == 1 && maquina == 2) || (valor == 2 && maquina == 3)) {
                        Console.WriteLine("Gana, la maquina: " + optionm  );
                        ordenador = ordenador + 1;
                        Console.WriteLine("El ordenador gana un punto: " + ordenador); 
                        Console.WriteLine("¿Quieres seguir probando suerte? 1:Si 0: No");
                        res = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                Console.ReadKey();
                    
            }
            partidas++;
        }
        // Se Muestran los resultados finales de las partidas y los puntos obtenidos
        Console.WriteLine("Se han jugado un total de: " + partidas + " partidas");
        Console.WriteLine("El usuario a ganado: " + usuario + " partidas");
        Console.WriteLine("La maquina a ganado: " + ordenador + " partidas");
        Console.WriteLine("Habeis empatado en: " + empate + " partidas");
    }
}