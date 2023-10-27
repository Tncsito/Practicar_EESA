using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicar_EESA.Datos
{
    public class Datos
    {
        int[] a = { 5, 3, 4, 6, 1, 9, 8, 2 };
        
        public void Burbuja()
        {
            int n = a.Length;
            int tmp = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }

            Console.WriteLine("Burbuja");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public void seleccion()
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for( int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                int tmp = a[i];
                a[i] = a[min];
                a[min] = tmp;
            }
            Console.WriteLine("Seleccion");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        public void insercion()
        {
            for (int i = 0; i < a.Length; i++)
            {
                int tmp = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] > tmp)
                {
                    a[j + 1 ] = a[j];
                    j--;
                }
                a[j + 1 ] = tmp;
            }
            Console.WriteLine("Insercion");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
