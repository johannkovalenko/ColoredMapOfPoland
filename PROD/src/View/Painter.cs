using System.Windows.Forms;
using System.Drawing;
using System;
using System.Threading;
using System.Collections.Generic;

class Painter
{    
    public void Run(object sender, PaintEventArgs e, List<DB> points)
    {
        foreach (DB db in points)
            if (!db.isSmoothened)
                PaintDot(e, db);
    }

    void PaintDot(PaintEventArgs e, DB db)
    {
        SolidBrush brush = new SolidBrush(Color.Red);

        Rectangle rect = new Rectangle(db.X, db.Y, 1, 1); 

        e.Graphics.FillRectangle(brush, rect);
    }    
}