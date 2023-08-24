
public class MiPrimerPrograma 
{
    static void Main(string[] args)
    {
        /*Enunciado: Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. 
        Imprimir en pantalla el resultado de cada operación.*/
        //1or definir el nombre de la clase
        //2do Declaracion de mis variables  (Datos de entrada)
        //Quemar codico: Poner valores directamente a las variales sin pedirlos desde la consola 

        int num1, num2, suma, resta, producto, cociente;
          
        //3ro pedir los valores por pantalla
        Console.Write("Ingrese su primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());  //solo recibe datos de tipo string

        Console.Write("Ingrese su segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());


        suma = num1 + num2; 
        resta = num1 - num2;
        producto = num1 * num2;
        cociente = num1 / num2;

        Console.Write("La suma es: " + suma);
        Console.Write("\n");
        Console.Write("La resta es: " + resta);
        Console.Write("\n");
        Console.Write("El producto es: " + producto);
        Console.Write("\n");
        Console.Write("El cociente es: " + cociente);



    }

}