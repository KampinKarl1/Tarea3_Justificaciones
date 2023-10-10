using System;
using System.Collections.Generic;

public class C 
{
    public static void Main()
    {
        string message = "Sistemas Informáticos";
      //Resultado en decimal (Bytes - Codigos de la tabla ASCII)
       string decResult = "";
        for   (int i = 0; i < message.Length;i++)
        {
          //pone el codigo del caracter de la tabla ASCII en el resultado (mas un espacio por legibilidad)
            decResult += (int) message[i] + " ";
        }
        
        Console.WriteLine(decResult);


      //HEX
        int [ ] result = new int[message.Length];  
        
        for (int i = 0; i < message.Length; i++)
        {
            result[i] = (int) message[i];
        }
        //Para convertir de decimal a hexadecimal 
          //dividir el numero por 16 y empujar el restante a la pila
          //volver a dividir el resultado por 16, repetiendo el paso de antes
          //al tener un resultado de zero:
              //mientras hay numeros en la pila, desapilar los al resultado
        
        //convert to hex
        string hexResult = "";
        
        for (int i = 0; i < result.Length; i++)
        {
            //cur num to op 
            int current = result[i];
            
            //get remainders which are hex numbers
            Stack <int> nums = new Stack<int>();
            
            while (current > 0)
            {
                //the first remainders are the last ones in the hex numbers
                nums.Push(current%16);
                //make sure to update the number 
                current /= 16;
            }
            
            while (nums.Count > 0)
                hexResult += nums.Pop();
            
            //readability
            hexResult+=" ";
        }
        
        Console.WriteLine (hexResult);
    }
}
