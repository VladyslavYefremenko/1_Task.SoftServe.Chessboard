using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe.Chessboard
{
    abstract class Cell : ICell
    {
        private CellColors cellColor = CellColors.Empty;

        public CellColors CellColor { get { return cellColor; } }
    }
}
