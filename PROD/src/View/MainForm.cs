using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;

class MainForm : Form
{
    Button button;
    PictureBox pictureBox;
    Model.BMP bmp;
    Model.Analysis analysis;
    Painter painter;
    List<DB> points = new List<DB>();
    
    public MainForm()
    {
        
        button      = new Button();
        pictureBox  = new PictureBox();
        bmp         = new Model.BMP();
        
        analysis    = new Model.Analysis(bmp);
        painter     = new Painter();

        ConfigureForm();
        ConfigureButton();
        ConfigurePictureBox();       
    }

    void ConfigureForm()
    {
        this.Width = 1200;
        this.Height = 780;
    }

    void ConfigureButton()
    {
        button.Click += delegate(object sender, EventArgs e) 
        { 
            //analysis.Run(sender, e, painter, pictureBox, points, bmp); 
            points = analysis.Run(1100, 550);
            pictureBox.Refresh();
        };  

        Controls.Add(button);
    }

    void ConfigurePictureBox()
    {
        pictureBox.Width = 1152;
        pictureBox.Height = 648;
        pictureBox.Dock = DockStyle.Fill;
        pictureBox.Image = (Image) bmp.Get();

        pictureBox.Paint += delegate(object sender, PaintEventArgs e)
        {
            painter.Run(sender, e, points);
        };

        Controls.Add(pictureBox);
    }
}