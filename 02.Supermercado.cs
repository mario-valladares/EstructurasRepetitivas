/** Un supermercado realiza una tómbola, en la cual tienen que sacar de una canasta una bolita 
la cual tiene un número grabado, los premios se dan bajo la siguiente tabla y solamente tienen 
derecho los clientes cuya compra supere los $30.

    BOLA		PREMIOS
---------------------------------------------------
|	1	|   1 shampoo                       |
|	2	|   1 paquete de 3 jabones de baño  |
|	3	|   1 pasta de dientes              |
|	4	|   1 bolsa de detergente           |
|	5	|   1 caja de cereal de chocolate   |
---------------------------------------------------

Notal: No se sabe la cantidad de clientes que llegará al supermercado.  **/

uusing System;
class supermercado {
    static void Main(string []args) {
		int sino=0;
				Console.WriteLine("|=====================================================================|");
                Console.WriteLine("| Para iniciar digite --> 1, para salir digite --> 0                  |");
			    Console.WriteLine("|=====================================================================|");
         sino = Convert.ToInt32(Console.ReadLine());
		 while (sino > 0) {
        Console.Write("Introduzca el monto total de su compra: ");
        double compra = Convert.ToDouble(Console.ReadLine());
        
        if (compra > 30){
           
                Random rnd = new Random();
                int tombola = rnd.Next(1,6); /* Genera un numero entre 1 y 5 */
                switch (tombola) {
                    case 1:
                        Console.WriteLine("Felicidades, usted se ha ganado 1 shampoo!!");
                    break;
                    case 2:
                        Console.WriteLine("Felicidades, usted de ha ganado 1 paquete de 3 jabones de baño!!");
                    break;
                    case 3:
                        Console.WriteLine("Felicidades, usted se ha ganado 1 pasta de dientes!!");
                    break;
                    case 4:
                        Console.WriteLine("Felicidades, usted se ha ganado 1 bolsa de detergente!!");
                    break;
                    case 5:
                        Console.WriteLine("Felicidades, usted se ha ganado 1 caja de cereal de chocolate!!");
                    break;
                }
			   
				
            }
        else
        {
            Console.WriteLine("Su compra no califica para la tombola ya que no es superior a $30.");
        }
		       Console.WriteLine("|=====================================================================|");
               Console.WriteLine("|Desea ingresar otra compra? digite --> 1, para salir digite --> 0    |");
			   Console.WriteLine("|=====================================================================|");
         sino = Convert.ToInt32(Console.ReadLine());
    }
}
}
