using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_CARO
{
    public class Player // đây là lớp người chơi
    {
        private int id;//id của người chơi
        private string name;// tên của người chơi
        private int scores;// điểm của người chơi
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!value.Equals("")) this.name = value;//tên không được trống
            }
        }
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                if (value > 0) this.scores = value;//điểm phải lớn hơn 0
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value > 0) this.id = value;//id phải lớn hơn 0
            }
        }

        public Player(int id, string name)//hàm khởi tạo
        {
            this.Id = id;
            this.name = name;
        }
    }
}
