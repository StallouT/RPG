using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    class RPG
    {
        public static Random random = new Random();
        public static Point point = new Point() { };
        public static Color color = Color.FromArgb(128, 128, 128);

        public void CreateStartPosition(DataGridView Field)
        {
            point = new Point()
            {
                X = RPG.random.Next(0, Convert.ToInt16(Field.ColumnCount)),
                Y = RPG.random.Next(0, Convert.ToInt16(Field.RowCount))
            };
            Console.WriteLine(point);
            Field.Rows[point.Y].Cells[point.X].Style.BackColor = color;
        }

        //public static void Move()
        //{
        //    point.X
        //}

        //public void KeyDown(KeyEventArgs KeyDown, DataGridView Field)
        //{
        //    switch (KeyDown.KeyCode)
        //    {
        //        case Keys.W:
        //        case Keys.Up:
        //            Field.Rows[point.Y--].Cells[point.X].Style.BackColor = color;
        //            Console.WriteLine("Верх");
        //            break;
        //        case Keys.D:
        //        case Keys.Right:
        //            Field.Rows[point.Y].Cells[point.X++].Style.BackColor = color;
        //            Console.WriteLine("Право");
        //            break;
        //        case Keys.A:
        //        case Keys.Left:
        //            Field.Rows[point.Y].Cells[point.X--].Style.BackColor = color;
        //            Console.WriteLine("Лево");
        //            break;
        //        case Keys.S:
        //        case Keys.Down:
        //            Console.WriteLine("Низ");
        //            Field.Rows[point.Y++].Cells[point.X].Style.BackColor = color;
        //            break;
        //    }
        //}
    }
}
