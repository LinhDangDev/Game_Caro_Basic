using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO
{
    public class Chessboard // lớp bàn cờ
    {
        private int cell;//cột trên bàn cờ
        private int row;// hàng trên bàn cờ
        private int[,] objChessbroad;// mảng hai chiều của bàn cờ
        public int Cell
        {
            get
            {
                return this.cell;
            }
            set
            {
                if (value > 0) this.cell = value;
            }
        }
        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                if (value > 0) this.row = value;
            }
        }
        public int[,] ObjChessbroad
        {
            get
            {
                return this.objChessbroad;
            }
            set
            {
                this.objChessbroad = value;
            }
        }

        public Chessboard(int row, int cell)// khởi tạo bàn cờ
        {
            Cell = cell;
            Row = row;
            ObjChessbroad = new int[Row, Cell];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Cell; j++)
                {
                    ObjChessbroad[i, j] = 0;//ở đây mình sẽ cho các giá trị khởi tạo của mảng bàn cờ = 0
                }
            }
        }
        public Chessboard()
        {

        }
    }
}
