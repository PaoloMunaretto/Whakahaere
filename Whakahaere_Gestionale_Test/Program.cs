/* ========================================
 *
 * Copyright Paolo Munaretto - 06/112020
 * All Rights Reserved
 * UNPUBLISHED, LICENSED SOFTWARE.
 *
 * CONFIDENTIAL AND PROPRIETARY INFORMATION
 * WHICH IS THE PROPERTY OF your company.
 * 
 * Programmer       : Paolo Munaretto
 * Dated build      : 06/11/2020
 * Progect name     : Whakahaere
 * Project scope    : Example management software for a hotel
 * Informations     : https://www.youtube.com/watch?v=kLcZ8ZVTYBg
 *
 * =======================================*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whakahaere
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Whakahaere());
        }
    }
}
