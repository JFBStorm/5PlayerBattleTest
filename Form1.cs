using System.Media;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _5PlayerBattleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            PlayGame start = new PlayGame();
            start.InitializeGame();
            InitializeComponent();
        }
    }
}
