using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CursOOP
{
    public class SimvolChange
    {
        public int player;
       
            public void Game(object sender, System.Windows.Forms.Label label1) {
            
        switch (player)
            {
                case 1:
                sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    label1.Text = "Сейчас ходит второй игрок";
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    label1.Text = "Сейчас ходит первый игрок";
                    break;
            }
        }
    }
    }

