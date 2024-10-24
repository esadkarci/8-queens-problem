using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_queens
{
    internal class Program
    {
        class problem
        {

            

            
            static bool kontrol(int[,] tahta, int satır, int sutün)
            {

                // Aynı sıra da vezir var mı

                for (int x = 0; x < sutün; x++)
                    if (tahta[satır, x] == 1)
                        return false;

                // Üs çaprazda vezir var mı yok mu kontrol
                for (int x = satır, y = sutün; x >= 0 && y >= 0; x--, y--)
                    if (tahta[x, y] == 1)
                        return false;

                // alt çapraz da vezir kontrolu
                for (int x = satır, y = sutün; x < 8 && y >= 0;x++, y--)
                    if (tahta[x, y] == 1)
                        return false;

                // bu durumlar sağlanıyorsa veziri yerleştir
                return true;
            }

            
            // backtracking
            static bool vezir(int[,] tahta, int sutün)
            {

                // tahta yı yazdırma
                if (sutün == 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.Write(tahta[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    return true;
                }

                // her sırayavezir yerleştirmeyi deneme
                
                for (int i = 0; i < 8; i++)
                {
                    if (kontrol(tahta, i, sutün))
                    {
                        tahta[i, sutün] = 1; 
                        if (vezir(tahta, sutün + 1))
                            return true;

                        // veziri yerleştir olmazsa geri gel backtracking
                        
                        tahta[i, sutün] = 0;
                    }
                }

                
                return false;
            }

      
            public static void Main(string[] args)
            {
                int[,] tahta = new int[8, 8];
                if (!vezir(tahta, 0))
                    Console.WriteLine("çözüm bulunamadı");












                Console.Read();
            }
        }
    }
}
