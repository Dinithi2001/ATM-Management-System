using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Management_System
{
    internal class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20; // Adjust this for more/less rounding

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90); // Top-left
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90); // Top-right
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90); // Bottom-right
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90); // Bottom-left
            path.CloseFigure();

            this.Region = new Region(path);

            // Draw border
            using (Pen pen = new Pen(Color.Black, 2)) // Adjust border color/width
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
