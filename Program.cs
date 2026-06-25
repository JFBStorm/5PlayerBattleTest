using _5PlayerBattleTest.PlayerClass;
using System;
using System.Collections;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _5PlayerBattleTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(new Form1());
        }
    }
}