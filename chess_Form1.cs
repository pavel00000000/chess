using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess
{
    public partial class chess_Form1 : Form
    {
        private const int tileSize = 60; // Размер клетки

        public chess_Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;  // Для плавного рендеринга
            this.Size = new Size(tileSize * 8 + 16, tileSize * 8 + 39);  // Настроить размер формы, чтобы соответствовать доске
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawChessboard(e.Graphics);
        }

        private void DrawChessboard(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Brush brush = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black;
                    g.FillRectangle(brush, i * tileSize, j * tileSize, tileSize, tileSize);
                }
            }
        }


    }
}
