using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            
            // 64 kareden dama tahtası oluşturulması
            Button[,] buttons = new Button[8, 8];

            int top=0;
            int left=0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
               
                left = 0;
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;

                    if((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);

                    left += 50;

                }

                top += 50;
            }
        }

        
    }
}
