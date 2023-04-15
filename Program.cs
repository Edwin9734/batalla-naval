int[,] tablero = new int[5, 5];
 
void paso1_crear_tablero()
{

    for(int i=0; i<tablero.GetLength(0);i++)
    {
        for(int j=0; j < tablero.GetLength(1);j++)
        {
            tablero[i, j]=0;
        }
    }

}



void paso2_colocar_barcos()
{

    //se ponen los barcos pos fija
    tablero[4, 3] = 1;
    tablero[1, 3] = 1;
    tablero[2, 4] = 1;
    tablero[4, 4] = 1;
   

}

void paso3_imprimir_tablero()
{
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int j = 0; j < tablero.GetLength(1);j++)
        {
            String caracter_imprimir;


            switch (tablero[i, j])
            {
                case 0:
                    caracter_imprimir = "X";
                    break;
                case 1:
                    caracter_imprimir = "X";
                    break;
                case 2:
                    caracter_imprimir = "*";
                    break;
                case -1:
                    caracter_imprimir = "-";
                    break;
                default:
                    caracter_imprimir = "-";
                    break;
            }
            Console.Write("\t"+ caracter_imprimir + "");
        }
        Console.WriteLine();
    }


}



void paso4_ingreso_cordenadas()
{
    int fila, columna = 0;
   // Console.Clear();
    do
   {


        for (int i = 0; i < 5; i++)
        {

            try
            {


                Console.WriteLine("\n\t\tIngrese la fila:");
                fila = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\t\tIngrese la Columna:");
                columna = Convert.ToInt32(Console.ReadLine());


                if (tablero[fila, columna] == 1)
                {
                    Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep();
                    Console.WriteLine("Barco destruido");
                    System.Threading.Thread.Sleep(2000);
                    tablero[fila, columna] = 2;//le dio
                }
                else
                {
                    tablero[fila, columna] = -1;//falló
                }

                Console.Clear();
                paso3_imprimir_tablero();
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un numero entre 0 y 4 ");
            }



        }



        Console.WriteLine("Fin del juego");









    } while (true);



}


Console.WriteLine("\tJUGUEMOS MATA BARCOS TIENES 5 INTENTOS ");


paso1_crear_tablero();
paso2_colocar_barcos();
paso3_imprimir_tablero();
paso4_ingreso_cordenadas();







