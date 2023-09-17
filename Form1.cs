using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajedrezproyecto
{
  
    public partial class Form1 : Form
    {
        public Image Ajedrezpiezas;

        public int[,] map = new int[8, 8]
        {

        {15,14,13,12,11,13,14,15},
        {16,16,16,16,16,16,16,16},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0},
        {26,26,26,26,26,26,26,26},
        {25,24,23,22,21,23,24,25},

        };
        public Form1()
        {
            InitializeComponent();

           Ajedrezpiezas = new Bitmap("C:\\Users\\jeffr\\Downloads\\chess.png");
    

            //button1. BackgroundImage = part;

            Init();
        }
        public void Init()
        {


            CreateMap();
        }
        public void CreateMap()
        {
            for(int i=0; i < 8; i++)
            {
                for(int j=0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Size= new Size(50,50);   
                    button.Location = new Point(j*50,i*50);

                    switch (map[i,j]/10)
                    {
                        case 1:
                            Image part= new Bitmap(50,50);  
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(Ajedrezpiezas, new Rectangle (0, 0, 50, 50), 0 + 150 * (map[i,j]%10-1), 0, 150, 150, GraphicsUnit.Pixel);
                            button.BackgroundImage = part;
                        break;

                        case 2:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(Ajedrezpiezas, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10-1), 150, 150, 150, GraphicsUnit.Pixel);
                            button.BackgroundImage = part1;
                            break;
                    }
                    butt.Click += new EventHandler(OnFigurePress); //inicio miguel
                    this.Controls.Add(button);  //prueba 
                }
            }
        }
        public void OnFigurePress(object sneder, EventArgs e)
        {
           Button pressedButton = sender as Button;
           pressedButton.BackColor= Color. Red;
        }
    }
}
