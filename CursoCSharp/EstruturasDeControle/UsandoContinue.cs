﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine($"Números pares entre 1 e {intervalo}!");

            for (int i = 0; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
