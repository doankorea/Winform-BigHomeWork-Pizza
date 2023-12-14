﻿using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace fa_icon_demo.CustomControls
{
    class CircularPictureBox : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public CircularPictureBox()
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }


        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }


        public Color BorderColor2
        {
            get { return borderColor2; }
            set { borderColor2 = value; Invalidate(); }
        }


        public DashStyle BorderLineStyle
        {
            get { return borderLineStyle; }
            set { borderLineStyle = value; Invalidate(); }
        }


        public DashCap BorderCapStyle
        {
            get { return borderCapStyle; }
            set { borderCapStyle = value; Invalidate(); }
        }


        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; Invalidate(); }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize);
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1;

            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, borderSize))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.DashStyle = borderLineStyle;
                penBorder.DashCap = borderCapStyle;
                pathRegion.AddEllipse(rectContourSmooth);
                Region = new Region(pathRegion);
                graph.DrawEllipse(penSmooth, rectContourSmooth);
                if (borderSize > 0)
                    graph.DrawEllipse(penBorder, rectBorder);
            }
        }
    }
}
