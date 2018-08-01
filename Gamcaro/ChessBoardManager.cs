using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamcaro
{
    class ChessBoardManager
    {
        #region properties
        private Panel ChessBoard;

        #endregion
        #region Init
        public ChessBoardManager (Panel chessBoard)
        {
            this.ChessBoard = chessBoard; 
        }
        #endregion
        #region Method
             public void drawChessBoard()
        {
            Button OldBnt = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.CHESS_BOARD_WIDTH; i++)
            {
                for (int j = 0; j < Const.CHESS_BOARD_HEIGHT; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.CHESS_WIDTH,
                        Height = Const.CHESS_HEIGHT,
                        Location = new Point(OldBnt.Location.X + OldBnt.Width, OldBnt.Location.Y)
                    };
                    ChessBoard.Controls.Add(btn);
                    OldBnt = btn;
                }
                OldBnt.Location = new Point(0, OldBnt.Location.Y + Const.CHESS_HEIGHT);
                OldBnt.Width = 0;
                OldBnt.Height = 0;

            }
        }
        #endregion
    }
}
