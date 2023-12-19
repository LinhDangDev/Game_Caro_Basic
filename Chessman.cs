using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_CARO
{
    public class Chessman// đây là lớp quân cờ
    {
        private int x;// tọa dộ x của quân cờ trên bàn cờ
        private int y;// tọa dộ y của quân cờ trên bàn cờ
        private int width;// chiều rộng của quân cờ
        private int height;// chiều cao của quân cờ

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value > 0) this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value > 0) this.y = value;
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0) this.width = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0) this.height = value;
            }
        }

        //public void drawChessmanPlayerA(PaintEventArgs e, Chessman chessman)//  hàm này sẽ vẽ quân cờ màu đỏ trên bàn cờ - vẽ hình tròn
        //{
        //    Pen pen = new Pen(Color.Red, (float)1.6);
        //    e.Graphics.DrawEllipse(pen,
        //                           chessman.X,
        //                           chessman.Y,
        //                           chessman.Width, chessman.Height);
        //}
        //public void drawChessmanPlayerB(PaintEventArgs e, Chessman chessman) // hàm này sẽ vẽ quân cờ màu xanh trên bàn cờ - vẽ chữ x
        //{
        //    Pen pen = new Pen(Color.Blue, (float)1.6);
        //    e.Graphics.DrawLine(pen,
        //                        chessman.X,
        //                        chessman.Y,
        //                        chessman.X + chessman.Width,
        //                        chessman.Y + chessman.Height);
        //    e.Graphics.DrawLine(pen,
        //                        chessman.X + chessman.Width,
        //                        chessman.Y,
        //                        chessman.X,
        //                        chessman.Y + chessman.Height);
        //}
        private Image imageX = Image.FromFile(@"D:\Code\AI\GAME_CARO\GAME_CARO\Game_Caro_Basic\img\x.png");
        private Image imageO = Image.FromFile(@"D:\Code\AI\GAME_CARO\GAME_CARO\Game_Caro_Basic\img\o.png");

        public void drawChessmanPlayerA(PaintEventArgs e, Chessman chessman)
        {
            e.Graphics.DrawImage(imageO, chessman.X, chessman.Y, chessman.Width, chessman.Height);
        }

        public void drawChessmanPlayerB(PaintEventArgs e, Chessman chessman)
        {
            e.Graphics.DrawImage(imageX, chessman.X, chessman.Y, chessman.Width, chessman.Height);
        }

    }
}
