using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GAME_CARO
{
    public partial class frMain : Form
    {
        private const int MAX_LINE_Y = 30;//số đường vẽ đứng
        private const int MAX_LINE_X = 30;//số đường vẽ ngang

        private const int CHESSBOARD_WIDTH = 560;// độ rộng của bàn cờ
        private const int CHESSBOARD_HIGHT = 560; //chiều cao của bàn cờ

        private const int CHESSMAN_PLAYER_A = 1;//mình gán 1 sẽ là giá trị quân cờ của người chơi 1
        private const int CHESSMAN_PLAYER_B = 2;//tương tự 2 sẽ là giá trị quân cờ của người chơi 2
        private const int DISTANCE_BETWEEN_TWO_LINES = 20;//khoảng cách giữa hai đường thẳng trên bàn cờ

        private Color CHESSBOARD_COLOR = ColorTranslator.FromHtml("#8D7B68");//màu của bàn cờ

        //
        Chessboard chessboard;
        private bool isPlayerA = true;//có pahir là lượt của người chơi A hay không
        static Boolean isPlayWithPC = true;//có phải chơi với máy hay không
        static Boolean isPlayerAWin = true;//có phải A chiến thắng
        private const int NUM_CHESSMAN_WIN = 4;
        //
        static Boolean isNextGame = true;
        Player playerA;//người chơi A,B
        Player playerB;
        //
        static int currRowPutChessmanPC;
        static int currCellPutChessmanPC;
        //
        //private int[] attackscore = new int[6] { 0, 1, 9, 81, 729, 59049 };//mảng điểm tấn công
        //private int[] defensescore = new int[6] { 0, 2, 18, 162, 1458, 118098 };//mảng điểm phòng ngự, phòng ngự được ưu tiên


        public frMain()
        {
            InitializeComponent();

        }

        private void frMain_Load(object sender, EventArgs e)
        {
            int cellChessBoard = CHESSBOARD_WIDTH / DISTANCE_BETWEEN_TWO_LINES;
            int rowChessBoard = CHESSBOARD_HIGHT / DISTANCE_BETWEEN_TWO_LINES;
            chessboard = new Chessboard(rowChessBoard, cellChessBoard);
            currRowPutChessmanPC = 0;
            currCellPutChessmanPC = 0;
            if (isPlayWithPC)
            {
                playerA = new Player(1, "PLAYER A");
                playerB = new Player(2, "AI");
            }
            else
            {
                playerA = new Player(1, "PLAYER A");
                playerB = new Player(2, "PLAYER B");
            }
            lbNamePlayerA.Text = playerA.Name;
            lbNamePlayerB.Text = playerB.Name;
        }

        private void pnCenter_Paint(object sender, PaintEventArgs e)
        {
            setColorChessboard();
            drawLineInChessboard(e);
            //chúng ta sẽ vẽ bàn cờ caro ở đây
        }
        private void drawLineInChessboard(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            for (int i = 0; i <= MAX_LINE_Y; i++)
            {
                e.Graphics.DrawLine(pen, i * DISTANCE_BETWEEN_TWO_LINES, 0, i * DISTANCE_BETWEEN_TWO_LINES, CHESSBOARD_HIGHT);
            }
            for (int j = 0; j <= MAX_LINE_X; j++)
            {
                e.Graphics.DrawLine(pen, 0, j * DISTANCE_BETWEEN_TWO_LINES, CHESSBOARD_WIDTH, j * DISTANCE_BETWEEN_TWO_LINES);
            }
        }
        private void setColorChessboard()
        {
            pnCenter.BackColor = CHESSBOARD_COLOR;// Hàm set màu cho bàn cờ (panel center)
        }

        private void pnCenter_MouseClick(object sender, MouseEventArgs e)
        {
            Chessman chessman = new Chessman();
            chessman.X = (e.X / DISTANCE_BETWEEN_TWO_LINES) * DISTANCE_BETWEEN_TWO_LINES;
            chessman.Y = (e.Y / DISTANCE_BETWEEN_TWO_LINES) * DISTANCE_BETWEEN_TWO_LINES;
            chessman.Width = DISTANCE_BETWEEN_TWO_LINES - 1;
            chessman.Height = DISTANCE_BETWEEN_TWO_LINES - 1;

            int rowPutChessman = chessman.Y / DISTANCE_BETWEEN_TWO_LINES;
            int cellPutChessman = chessman.X / DISTANCE_BETWEEN_TWO_LINES;

            Graphics g;
            g = pnCenter.CreateGraphics();

            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);

            if (!isDuplicatePutChessman(rowPutChessman, cellPutChessman))
            {
                return;//nếu trùng thì return luôn
            }
            if (isNextGame == false)//trò chơi có tiếp tục hay không
            {
                return;
            }
            if (isPlayWithPC)//nếu là chơi với máy
            {
                chessman.drawChessmanPlayerA(arg, chessman);//vẽ quân cờ
                chessboard.ObjChessbroad[rowPutChessman, cellPutChessman] = CHESSMAN_PLAYER_A;//khởi tạo quân cờ được vẽ trong mảng
                if (isGameOver() == false)
                {
                    string str = isPlayerAWin == true ? playerA.Name : playerB.Name;
                    MessageBox.Show("GAME OVER ! - " + str + " WIN");
                    isNextGame = false;
                    txt_Speed.Text = "";
                    return;
                }
                //để chơi được với máy chúng ta cần viết thuật toán (AI) cho máy có thể chơi cùng chúng ta
                //ở đây mình sử dụng giải thuật MiniMax áp dụng cho cờ caro mà mình đã tham khảo trên mạng

                assessMoves(4);

                chessman = new Chessman();
                chessman.Width = DISTANCE_BETWEEN_TWO_LINES - 1;
                chessman.Height = DISTANCE_BETWEEN_TWO_LINES - 1;
                chessman.Y = currRowPutChessmanPC * DISTANCE_BETWEEN_TWO_LINES;
                chessman.X = currCellPutChessmanPC * DISTANCE_BETWEEN_TWO_LINES;
                chessman.drawChessmanPlayerB(arg, chessman);
                chessboard.ObjChessbroad[currRowPutChessmanPC, currCellPutChessmanPC] = CHESSMAN_PLAYER_B;


                if (isGameOver() == false)
                {
                    string str = isPlayerAWin == true ? playerA.Name : playerB.Name;
                    MessageBox.Show("GAME OVER ! - " + str + " WIN");
                    isNextGame = false;
                    txt_Speed.Text = "";
                }
            }
            else
            {//người chơi với người thì đơn giản hơn
                if (isPlayerA)
                {
                    chessman.drawChessmanPlayerA(arg, chessman);
                    chessboard.ObjChessbroad[rowPutChessman, cellPutChessman] = CHESSMAN_PLAYER_A;
                    isPlayerA = false;
                }
                else if (!isPlayerA)
                {
                    chessman.drawChessmanPlayerB(arg, chessman);
                    chessboard.ObjChessbroad[rowPutChessman, cellPutChessman] = CHESSMAN_PLAYER_B;
                    isPlayerA = true;
                }
                if (isGameOver() == false)
                {
                    string str = isPlayerAWin == true ? playerA.Name : playerB.Name;
                    MessageBox.Show("GAME OVER ! - " + str + " WIN");
                    isNextGame = false;

                }
            }
        }
        private Boolean isDuplicatePutChessman(int rowPutChessman, int cellPutChessman)//hàm này sẽ kiểm tra xem hai quân cờ có đc đặt trùng lên nhau không
        {
            if (chessboard.ObjChessbroad[rowPutChessman, cellPutChessman].Equals(CHESSMAN_PLAYER_A)
                || chessboard.ObjChessbroad[rowPutChessman, cellPutChessman].Equals(CHESSMAN_PLAYER_B))
            {
                return false;
            }
            return true;
        }
        private Boolean isGameOver()//đây là hamg kiểm tra game đã kết thúc hay chưa
        {
            int countRow;
            int countCell;
            int countCrossLineRight;
            int countCrossLineLeft;
            for (int rowChessboard = 0; rowChessboard < chessboard.Row; rowChessboard++)//mình sẽ duyệt trong mảng bàn cờ hàng ngang, đường chéo ,cột dọc,
                                                                                        //nếu người chời nào đủ 5 quân xếp cùng một hàng thì game kết thúc
            {
                for (int cellChessboard = 0; cellChessboard < chessboard.Cell; cellChessboard++)
                {
                    countRow = 0;
                    countCell = 0;
                    countCrossLineRight = 0;
                    countCrossLineLeft = 0;

                    int minIRow = rowChessboard - NUM_CHESSMAN_WIN > 0 ? rowChessboard - NUM_CHESSMAN_WIN : 0;
                    int maxIRow = rowChessboard + NUM_CHESSMAN_WIN > chessboard.Row ? chessboard.Row : rowChessboard + NUM_CHESSMAN_WIN;

                    int minICell = cellChessboard - NUM_CHESSMAN_WIN > 0 ? cellChessboard - NUM_CHESSMAN_WIN : 0;
                    int maxICell = cellChessboard + NUM_CHESSMAN_WIN > chessboard.Cell ? chessboard.Cell : cellChessboard + NUM_CHESSMAN_WIN;
                    int objTem = chessboard.ObjChessbroad[rowChessboard, cellChessboard];
                    if (objTem == 0) continue;
                    for (int iRow = minIRow; iRow < maxIRow; iRow++)
                    {
                        for (int iCell = minICell; iCell < maxICell; iCell++)
                        {
                            //
                            if (chessboard.ObjChessbroad[iRow, iCell] == 0) continue;
                            //
                            if (chessboard.ObjChessbroad[iRow, iCell] != objTem) continue;
                            //
                            if (rowChessboard == iRow)
                            {
                                if (objTem == CHESSMAN_PLAYER_A)
                                {
                                    isPlayerAWin = true;
                                }
                                else
                                {
                                    isPlayerAWin = false;
                                }
                                if (countRow == 0)
                                {
                                    countRow++;
                                }
                                else if (countRow >= 1)
                                {
                                    if (chessboard.ObjChessbroad[iRow, iCell - 1] == chessboard.ObjChessbroad[iRow, iCell])
                                    {
                                        countRow++;
                                    }
                                    else
                                    {
                                        countRow = 0;
                                    }
                                }
                            }
                            //
                            if (cellChessboard == iCell)
                            {
                                if (objTem == CHESSMAN_PLAYER_A)
                                {
                                    isPlayerAWin = true;
                                }
                                else
                                {
                                    isPlayerAWin = false;
                                }
                                if (countCell == 0)
                                {
                                    countCell++;
                                }
                                else if (countCell >= 1)
                                {
                                    if (chessboard.ObjChessbroad[iRow - 1, iCell] == chessboard.ObjChessbroad[iRow, iCell])
                                    {
                                        countCell++;
                                    }
                                    else
                                    {
                                        countCell = 0;
                                    }
                                }
                            }
                            //
                            if (rowChessboard - iRow == cellChessboard - iCell)
                            {
                                if (objTem == CHESSMAN_PLAYER_A)
                                {
                                    isPlayerAWin = true;
                                }
                                else
                                {
                                    isPlayerAWin = false;
                                }
                                if (countCrossLineRight == 0)
                                {
                                    countCrossLineRight++;
                                }
                                else if (countCrossLineRight >= 1)
                                {
                                    if (chessboard.ObjChessbroad[iRow - 1, iCell - 1] == chessboard.ObjChessbroad[iRow, iCell])
                                    {
                                        countCrossLineRight++;
                                    }
                                    else
                                    {
                                        countCrossLineRight = 0;
                                    }
                                }
                            }
                            //
                            if (rowChessboard - iRow == -1 * (cellChessboard - iCell))
                            {
                                if (objTem == CHESSMAN_PLAYER_A)
                                {
                                    isPlayerAWin = true;
                                }
                                else
                                {
                                    isPlayerAWin = false;
                                }
                                if (countCrossLineLeft == 0)
                                {
                                    countCrossLineLeft++;
                                }
                                else if (countCrossLineLeft >= 1)
                                {
                                    if (chessboard.ObjChessbroad[iRow - 1, iCell + 1] == chessboard.ObjChessbroad[iRow, iCell])
                                    {
                                        countCrossLineLeft++;
                                    }
                                    else
                                    {
                                        countCrossLineLeft = 0;
                                    }
                                }
                            }
                        }
                    }
                    if (countRow == NUM_CHESSMAN_WIN + 1 || countCell == NUM_CHESSMAN_WIN + 1
                       || countCrossLineRight == NUM_CHESSMAN_WIN + 1 || countCrossLineLeft == NUM_CHESSMAN_WIN + 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void assessMoves(int depth)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Reset();
            sw.Start();

            long maxScore = long.MinValue;
            int bestMoveRow = -1;
            int bestMoveCell = -1;

            // Duyệt qua từng ô trống trên bàn cờ để đánh giá nước đi tốt nhất
            for (int rowChessboard = 0; rowChessboard < chessboard.Row; rowChessboard++)
            {
                for (int cellChessboard = 0; cellChessboard < chessboard.Cell; cellChessboard++)
                {
                    if (chessboard.ObjChessbroad[rowChessboard, cellChessboard] == 0)
                    {
                        // Đặt quân cờ của máy vào ô trống và đánh giá nước đi
                        chessboard.ObjChessbroad[rowChessboard, cellChessboard] = CHESSMAN_PLAYER_B;

                        // Gọi hàm minimaxAlphaBeta để đánh giá giá trị của nước đi
                        long score = minimaxAlphaBeta(chessboard, depth, long.MinValue, long.MaxValue, false);

                        // Hủy bỏ quân cờ đã đặt để trở lại trạng thái trước đó của bàn cờ
                        chessboard.ObjChessbroad[rowChessboard, cellChessboard] = 0;

                        // Cập nhật điểm tốt nhất nếu nước đi hiện tại có điểm cao hơn
                        if (score > maxScore)
                        {
                            maxScore = score;
                            bestMoveRow = rowChessboard;
                            bestMoveCell = cellChessboard;
                        }
                    }
                }
            }

            // Lưu trữ nước đi tốt nhất đã tìm được
            currRowPutChessmanPC = bestMoveRow;
            currCellPutChessmanPC = bestMoveCell;

            sw.Stop();
            txt_Speed.Text = sw.Elapsed.ToString();
        }

        private long minimaxAlphaBeta(Chessboard board, int depth, long alpha, long beta, bool maximizingPlayer)
        {
            // Kiểm tra điều kiện dừng của đệ quy
            if (depth == 0 || isTerminalNode(board))
            {
                return evaluate(board);
            }

            if (maximizingPlayer)
            {
                long maxEval = long.MinValue;

                // Duyệt qua các ô trống và đánh giá nước đi cho máy
                for (int row = 0; row < board.Row; row++)
                {
                    for (int cell = 0; cell < board.Cell; cell++)
                    {
                        if (board.ObjChessbroad[row, cell] == 0)
                        {
                            board.ObjChessbroad[row, cell] = CHESSMAN_PLAYER_B;

                            // Đệ quy gọi minimaxAlphaBeta cho nước đi tiếp theo của đối thủ
                            long eval = minimaxAlphaBeta(board, depth - 1, alpha, beta, false);

                            // Hủy bỏ quân cờ đã đặt để trở lại trạng thái trước đó của bàn cờ
                            board.ObjChessbroad[row, cell] = 0;

                            // Cập nhật giá trị lớn nhất
                            maxEval = Math.Max(maxEval, eval);
                            alpha = Math.Max(alpha, eval);

                            // Kiểm tra cắt tỉa Alpha-beta
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                }
                return maxEval;
            }
            else
            {
                long minEval = long.MaxValue;

                // Duyệt qua các ô trống và đánh giá nước đi cho đối thủ
                for (int row = 0; row < board.Row; row++)
                {
                    for (int cell = 0; cell < board.Cell; cell++)
                    {
                        if (board.ObjChessbroad[row, cell] == 0)
                        {
                            board.ObjChessbroad[row, cell] = CHESSMAN_PLAYER_A;

                            // Đệ quy gọi minimaxAlphaBeta cho nước đi tiếp theo của máy
                            long eval = minimaxAlphaBeta(board, depth - 1, alpha, beta, true);

                            // Hủy bỏ quân cờ đã đặt để trở lại trạng thái trước đó của bàn cờ
                            board.ObjChessbroad[row, cell] = 0;

                            // Cập nhật giá trị nhỏ nhất
                            minEval = Math.Min(minEval, eval);
                            beta = Math.Min(beta, eval);

                            // Kiểm tra cắt tỉa Alpha-beta
                            if (beta <= alpha)
                            {
                                break;
                            }
                        }
                    }
                }
                return minEval;
            }
        }


        private long evaluate(Chessboard board)
        {
            long totalScore = 0;

            // Đánh giá theo số lượng quân cờ của cả hai người chơi trong các đường hàng ngang, cột dọc và đường chéo
            totalScore += evaluateDirection(board, 1, 0); // Hàng ngang
            totalScore += evaluateDirection(board, 0, 1); // Cột dọc
            totalScore += evaluateDirection(board, 1, 1); // Đường chéo chính
            totalScore += evaluateDirection(board, 1, -1); // Đường chéo phụ

            return totalScore;
        }

        private bool isTerminalNode(Chessboard board)
        {
            return isGameOver() || isBoardFull(board);
        }

        private long evaluateDirection(Chessboard board, int rowDelta, int cellDelta)
        {
            // Hàm đánh giá số điểm cho mỗi hướng trên bàn cờ (hàng ngang, cột dọc, đường chéo chính, đường chéo phụ)
            long totalScore = 0;
            int numChessmanPlayerA, numChessmanPlayerB;

            // Duyệt qua từng ô trên bàn cờ
            for (int rowChessboard = 0; rowChessboard < board.Row; rowChessboard++)
            {
                for (int cellChessboard = 0; cellChessboard < board.Cell; cellChessboard++)
                {
                    numChessmanPlayerA = 0;
                    numChessmanPlayerB = 0;

                    // Duyệt qua số ô cờ cần đánh giá trong mỗi hướng
                    for (int i = 0; i < NUM_CHESSMAN_WIN; i++)
                    {
                        int row = rowChessboard + i * rowDelta;
                        int cell = cellChessboard + i * cellDelta;

                        // Kiểm tra xem ô cờ có nằm trong biên của bàn cờ không
                        if (row >= 0 && row < board.Row && cell >= 0 && cell < board.Cell)
                        {
                            // Đếm số lượng quân cờ của cả hai người chơi trong hướng này
                            if (board.ObjChessbroad[row, cell] == CHESSMAN_PLAYER_A)
                            {
                                numChessmanPlayerA++;
                            }
                            else if (board.ObjChessbroad[row, cell] == CHESSMAN_PLAYER_B)
                            {
                                numChessmanPlayerB++;
                            }
                        }
                    }

                    // Đánh giá điểm cho dãy các ô cờ trong một hướng
                    totalScore += evaluateLine(numChessmanPlayerA, numChessmanPlayerB);
                }
            }

            return totalScore;
        }


        private long evaluateLine(int numChessmanPlayerA, int numChessmanPlayerB)
        {
            long score = 0;

            // Thêm logic đánh giá cho từng dòng, cột, hoặc đường chéo
            // Giả sử bạn muốn tăng điểm nếu có quân cờ của máy và giảm điểm nếu có quân cờ của người chơi
            // Có thể điều chỉnh dựa trên chiến thuật và yêu cầu cụ thể của trò chơi
            score += evaluatePlayerScore(numChessmanPlayerA);
            score -= evaluatePlayerScore(numChessmanPlayerB);

            return score;
        }

        private long evaluatePlayerScore(int numChessman)
        {
            long score = 0;

            // Thêm logic đánh giá điểm cho số lượng quân cờ của người chơi
            // Có thể điều chỉnh dựa trên chiến thuật và yêu cầu cụ thể của trò chơi
            switch (numChessman)
            {
                case 1:
                    score += 10;
                    break;
                case 2:
                    score += 100;
                    break;
                case 3:
                    score += 1000;
                    break;
                case 4:
                    score += 10000;
                    break;
                case 5:
                    score += 100000;
                    break;
                default:
                    break;
            }

            return score;
        }

        private bool isBoardFull(Chessboard board)
        {
            for (int row = 0; row < board.Row; row++)
            {
                for (int cell = 0; cell < board.Cell; cell++)
                {
                    if (board.ObjChessbroad[row, cell] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            isPlayWithPC = false;
            resetGame(sender, e);
            txt_Speed.Text = "";
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            isPlayWithPC = true;
            resetGame(sender, e);

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            resetGame(sender, e);
            txt_Speed.Text = "";
        }
        private void resetGame(object sender, EventArgs e)
        {
            pnCenter.Invalidate();
            isNextGame = true;
            frMain_Load(sender, e);
            txt_Speed.Text = "";

        }
    }
}