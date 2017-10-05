using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParticleNetwork1
{
    public partial class Form1 : Form
    {
        Random rr;
        Point[] dots;
        int w;
        int min, max;
        int R, G, B;
        int[] dx, dy;
        int speed = 1;

        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            if (data.ShowDialog() != DialogResult.OK)
                Environment.Exit(0);
            DoubleBuffered = true;
            BackColor = Color.FromArgb(255, 30, 30, 30);
            Width = Convert.ToInt32(data.Width.Value);
            Height = Convert.ToInt32(data.Height.Value);
            max = Convert.ToInt32(data.Maximum.Value);
            min = Convert.ToInt32(data.Minimum.Value);
            w = Convert.ToInt32(data.Size.Value);
            R = Convert.ToInt32(data.R.Value);
            G = Convert.ToInt32(data.G.Value);
            B = Convert.ToInt32(data.B.Value);
            dots = new Point[Convert.ToInt32(data.Dots.Value) + 1];
            rr = new Random();
            start();
        }

        void start()
        {
            dx = new int[dots.Length];
            dy = new int[dots.Length];
            for (int i = 0; i < dots.Length; ++i)
            {
                dots[i].X = rr.Next(0, Width - 20);
                dots[i].Y = rr.Next(0, Height - 43);
                dx[i] = (rr.Next(-1, 1) == -1 ? -speed : speed);
            }
            for (int i = 0; i < dots.Length; ++i)
                dy[i] = (rr.Next(-1, 1) == 1 ? -speed : speed);
        }

        void add(int x, int y)
        {
            Point[] arr = new Point[dots.Length + 1];
            for (int i = 0; i < dots.Length; ++i)
                arr[i] = dots[i];
            arr[dots.Length] = new Point(x, y);
            dots = arr;
            int[] X = new int[dx.Length + 1];
            int[] Y = new int[dy.Length + 1];
            dx.CopyTo(X, 0);
            dy.CopyTo(Y, 0);
            X[dx.Length] = 0;
            Y[dy.Length] = 0;
            dx = X;
            dy = Y;
        }

        //void remove(int x, int y)
        //{
        //    if (dots.Length == 0)
        //        return;
        //    bool removed = false;
        //    var index = new List<int>();
        //    for (int i = 0; i < dots.Length; ++i)
        //    {
        //        if (new Rectangle(dots[i], new Size(5, 5)).Contains(x, y))
        //        {
        //            removed = true;
        //            index.Add(i);
        //        }
        //    }
        //    if (!removed)
        //        return;
        //    var arr = new List<Point>();
        //    var X = new List<int>();
        //    var Y = new List<int>();
        //    for (int i = 0; i < dots.Length; ++i)
        //    {
        //        if (index.Contains(i))
        //            continue;
        //        arr.Add(dots[i]);
        //        X.Add(dx[i]);
        //        Y.Add(dy[i]);
        //    }
        //    dots = arr.ToArray();
        //    dx = X.ToArray();
        //    dy = Y.ToArray();
        //}

        void update(int i)
        {
            if (dots[i].X >= Width - 20 || dots[i].X <= 0)
                dx[i] = -dx[i];
            if (dots[i].Y >= Height - 43 || dots[i].Y <= 0)
                dy[i] = -dy[i];
        }

        int opacity(int i, int j)
        {
            int op = Convert.ToInt32(max - Math.Abs(Math.Sqrt(Math.Abs(Convert.ToInt32(Math.Sqrt(Math.Pow(dots[i].X - dots[j].X, 2) + (dots[i].Y - dots[j].Y)*(dots[i].Y - dots[j].Y)))))) * 2);
            return (op >= min ? op : 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 1; i < dots.Length; ++i)
            {
                update(i);
                for (int j = 0; j < dots.Length; ++j)
                {
                    var pen = new Pen(Color.FromArgb(opacity(i, j), R, G, B), 1);
                    g.FillEllipse(Brushes.White, dots[i].X, dots[i].Y, w, w);
                    g.DrawLine(pen, dots[i], dots[j]);
                }
                dots[i].X += dx[i];
                dots[i].Y += dy[i];
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            dots[0].X = e.X;
            dots[0].Y = e.Y;
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.Cancel) return;
            BackColor = cd.Color;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.Cancel) return;
            R = cd.Color.R;
            G = cd.Color.G;
            B = cd.Color.B;
        }

        private void toolStripTextBoxCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dots = new Point[int.Parse(toolStripTextBoxCount.Text)];
                start();
            }
            catch
            { }
        }

        private void toolStripTextBoxSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                w = int.Parse(toolStripTextBoxSize.Text);
            }
            catch
            { }
        }

        private void toolStripTextBoxMaximum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                max = int.Parse(toolStripTextBoxMaximum.Text);
            }
            catch
            { }
        }

        private void toolStripTextBoxMinimum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                min = int.Parse(toolStripTextBoxMinimum.Text);
            }
            catch
            { }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                add(e.X, e.Y);
            //else if (e.Button == MouseButtons.Right)
            //    remove(e.X, e.Y);
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 5;
            start();
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 3;
            start();
        }

        private void lowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 1;
            start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}