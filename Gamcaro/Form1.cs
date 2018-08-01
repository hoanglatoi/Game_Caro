using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamcaro
{
    public partial class Form1 : Form

    {
        ChessBoardManager chessboard;
        public Form1()
        {
            InitializeComponent();
            chessboard = new ChessBoardManager(palChessBoard);
            chessboard.drawChessBoard();
        }

       
    }

}
