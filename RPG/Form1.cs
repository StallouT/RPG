using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        public static Random random = new Random();
        public Point point = new Point() { };
        public static Color color = Color.FromArgb(128, 128, 128);
        public static Color wall = Color.FromArgb(24, 24, 24);
        public static Color flor = Color.FromArgb(16, 16, 16);
        public static Color colorBackground = Color.FromArgb(8, 8, 8);

        public Form1()
        {
            InitializeComponent();
            Field.ColumnCount = 50;
            Field.RowCount = 50;
            //Point point = CreateStartPosition(Field);*/
            //CreateStartPosition(Field);
            //Point point = new Point() { };
            //List<int> pointList = new List<int>();

            int[] b = new int[4] { 0,0,0,0 };
            for (int i = 0; i < 14; i++)
            {
                b = CreateRoom(Field, b);
            }

            point = CreateStartPosition(Field, point);
        }

        public Point CreateStartPosition(DataGridView Field, Point point)       //Можно использовать для ТП
        {
            point = new Point()
            {
                X = random.Next(0, Convert.ToInt16(Field.ColumnCount)),
                Y = random.Next(0, Convert.ToInt16(Field.RowCount))
            };
            Console.WriteLine(point);
            Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
            return point;
        }


        public void Field_KeyDown(object sender, KeyEventArgs KeyDown)
        {
            //Field.Rows[point.Y].Cells[point.X].Style.BackColor = colorBackground;
            //switch(e.KeyValue)
            //Console.WriteLine(e.KeyCode);
            //Console.WriteLine(e.KeyData);
            //Console.WriteLine(e.KeyValue);
            Field.Rows[point.Y].Cells[point.X].Style.BackColor = colorBackground;


            switch (KeyDown.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    point.Y--;
                    Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
                    Console.WriteLine("Верх");
                    break;
                case Keys.D:
                case Keys.Right:
                    point.X++;
                    Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
                    Console.WriteLine("Право");
                    break;
                case Keys.A:
                case Keys.Left:
                    point.X--;
                    Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
                    Console.WriteLine("Лево");
                    break;
                case Keys.S:
                case Keys.Down:
                    point.Y++;
                    Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
                    Console.WriteLine("Низ");
                    break;

                default:
                    Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
                    Console.WriteLine("Позиция неизменна");
                    break;
            }
            //Field.Refresh();
        }

        public int[] CreateRoom(DataGridView Field, int[] b)
        {
            int[] a = new int[] { };
            
            Point roomPoint = new Point()
            {
                X = random.Next(0, Convert.ToInt16(Field.ColumnCount - 9)),
                Y = random.Next(0, Convert.ToInt16(Field.RowCount - 9))
                //X = random.Next(0, (random.Next((random.Next(b[0], b[2])), random.Next(b[2], Convert.ToInt16(Field.ColumnCount - 9))))),
                //Y = random.Next(0, (random.Next((random.Next(b[1], b[3])), random.Next(b[3], Convert.ToInt16(Field.RowCount - 9)))))
            };
            a = new int[] {     roomPoint.X,
                                roomPoint.Y,
                                random.Next(5, 10) + roomPoint.X,
                                random.Next(5, 10) + roomPoint.Y };
           
            b = new int[] { a[0],
                            a[1],
                            a[2],
                            a[3] };


            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);
            //Console.WriteLine(a[2]);
            //Console.WriteLine(a[3]);
            Field.Rows[a[1]].Cells[a[0]].Value = a[1] + "/" + a[0];
            Field.Rows[a[3]].Cells[a[2]].Value = a[3] + "/" + a[2];

            #region 1
            //a[0] = 10;
            //a[1] = 10;
            //a[2] = a[0] + 10;
            //a[3] = a[1] + 10;

            //while (a[0]!= a[2])
            //{
            //    Field.Rows[roomPoint.Y].Cells[a[0]].Style.BackColor = Color.AliceBlue;
            //    Field.Rows[a[3]].Cells[a[0]].Style.BackColor = Color.AntiqueWhite;
            //    a[0]++;
            //    //while(a[1] != a[3])
            //    //{
            //    //    Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Aqua;
            //    //    Field.Rows[a[3]].Cells[a[2]--].Style.BackColor = Color.Red;
            //    //    a[1]++;
            //    //}
            //}
            //while (a[1] != a[3])
            //{
            //    Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Aqua;
            //    Field.Rows[a[3]].Cells[a[2]--].Style.BackColor = Color.Red;
            //    a[1]++;
            //}

            //while (a[0] != a[2]+1)
            //{
            //    if (a[0] == roomPoint.X || a[0] == a[2])
            //    {
            //        while (a[1] != a[3])
            //        {
            //            Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Aqua;
            //            Field.Rows[a[1]].Cells[a[2]].Style.BackColor = Color.Aqua;
            //            a[1]++;
            //        }
            //    }
            //    else
            //    {
            //        while (a[1] != a[3]+1)
            //        {
            //            Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Sienna;
            //            Field.Rows[a[1]].Cells[a[2]].Style.BackColor = Color.Sienna;
            //            a[1]++;
            //        }
            //    }

            //    a[1] = roomPoint.Y;
            //    a[0]++;
            //}
            //a[0] = roomPoint.X;

            //while(a[0] != b[2] && a[2] != b[0]-1)
            //{
            //    Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Aqua;
            //    Field.Rows[a[3]].Cells[a[2]].Style.BackColor = Color.Aqua;
            //    a[0]++;
            //    a[2]--;
            //}
            ////a[0]--;
            //while(a[1] != b[3]+1)
            //{
            //    Field.Rows[a[1]].Cells[a[0]].Style.BackColor = Color.Wheat;
            //    a[1]++;
            //}
            #endregion



            while (a[0] != b[2])
            {
                Field.Rows[a[1]].Cells[a[0]].Style.BackColor = wall;              
                a[0]++;
            }
            while (a[1] != b[3])
            {
                Field.Rows[a[1]].Cells[a[0]].Style.BackColor = wall;
                a[1]++;
            }
            while (a[2] != b[0])
            {
                Field.Rows[a[1]].Cells[a[2]].Style.BackColor = wall;
                a[2]--;
            }
            while (a[3] != b[1])
            {
                Field.Rows[a[3]].Cells[a[2]].Style.BackColor = wall;
                a[3]--;
            }
            a = new int[] { b[0],
                            b[1],
                            b[2],
                            b[3] };

            a[1] += 1;
            a[0] += 1;
            int i = a[0];
            while (a[1] + 1 != a[3] + 1)
            {
                while (a[0] + 1 != a[2] + 1)
                {
                    Field.Rows[a[1]].Cells[a[0]].Style.BackColor = flor;
                    a[0]++;
                }
                a[0] = i;
                a[1]++;
            }

            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);
            Console.WriteLine(b[3]);

            return b;

            //b[1] += 1;
            //b[0] += 1;
            //int i = b[0];
            //Console.WriteLine(b[1] + "\n" + b[0]);

            //while (b[1] + 1 != b[3]+1)
            //{
            //    while (b[0] + 1 != b[2]+1)
            //    {
            //        Field.Rows[b[1]].Cells[b[0]].Style.BackColor = flor;
            //        b[0]++;
            //    }
            //    b[0] = i;
            //    b[1]++;
            //}

            //Console.WriteLine(b[1] + "\n" + b[0]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Field.KeyDown += Field_KeyDown;
        }
    }
}
