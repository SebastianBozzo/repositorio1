using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Gato
    {
        public string[,] matriz;

        public Gato()
        {
            matriz = new string[3, 3];
            matriz[0, 0] = "1";
            matriz[0, 1] = "2";
            matriz[0, 2] = "3";
            matriz[1, 0] = "4";
            matriz[1, 1] = "5";
            matriz[1, 2] = "6";
            matriz[2, 0] = "7";
            matriz[2, 1] = "8";
            matriz[2, 2] = "9";

         




        }
        public void Imprimir() {
            for (int j = 0; j < 3; j++)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(" " + matriz[j, i] + " ");
                    if (i < 2)
                    {
                        Console.Write("|");
                    }


                }
                Console.WriteLine("");
                if (j < 2)
                {
                    Console.WriteLine("-----------");
                }

            }

            Console.ReadLine();
        
        }
        public void marcar (int Njugador , int lugar){
            String marca;
            if (Njugador ==1 )
	{
		 marca = "X";
	}
            else{
            marca = "O";           
            }

            if (lugar == 1 || lugar == 2 || lugar == 3 || lugar == 4 || lugar == 5 || lugar == 6 || lugar == 7 || lugar == 8 || lugar == 9)
            {
                if (lugar == 1)
                {
                    
                }
                if (lugar == 2)
                {

                }
                if (lugar == 3)
                {

                }
                if (lugar == 4)
                {

                }
                if (lugar ==5)
                {

                }
                if (lugar == 6)
                {

                }
                if (lugar == 7)
                {

                }
                if (lugar == 8)
                {

                }
                if (lugar == 9)
                {

                }
            }
            else {
                Console.WriteLine("Lugar no Valido , Repita");
            }

        
        }
    }
}