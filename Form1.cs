using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradCalc
{
    interface IRectangle<Rectangle> { };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += (o, e) => {this.RandomNumOutLabel.Text = "";};
            this.splitContainer1.Panel1.Paint += (o, e) =>
            {
                using(Pen p = new Pen(Color.Blue))
                {
                    e.Graphics.DrawRectangle(p, 5, 10, 105, 30);
                    e.Graphics.DrawRectangle(p, 175, 10, 105, 30);
                }
            };
            this.splitContainer1.Panel2.Paint += (o, e) =>
            {
                using(Pen p = new Pen(Color.Blue))
                {
                    e.Graphics.DrawRectangle(p, 5, 10, 105, 30);
                    e.Graphics.DrawRectangle(p, 175, 10, 105, 30);
                }
            };
        }

        private void RandomNumberButton_Click(object sender, EventArgs e)
        {
            RandomNumOutLabel.Text = new Random().Next(0, 0b_1111111111111111).ToString();
        }
    }
}
