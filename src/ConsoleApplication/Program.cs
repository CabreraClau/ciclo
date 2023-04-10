//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;



namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {

        public static void Main()
        {
            int Length = 12;
            for (int i = 0; i < Length; i++)
            {
                Train Train1 = new Train(i.ToString());
            }

            Train train1 = new Train("The las train to London");
            Train train2 = new Train("The las train to London");
            Train train3 = new Train("Runawat Train");
        }
    }
}

