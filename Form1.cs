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
        Color curColor = Color.Blue;
        public List<Color> getAllColors()
        {
            List<Color> l = new List<Color>();
            foreach(var colorValue in Enum.GetValues(typeof(KnownColor)))
                 l.Add(Color.FromKnownColor((KnownColor)colorValue));
            return l;
        }
        List<Color> Kolorki = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            Kolorki = getAllColors();
            this.comboBox1.DataSource = Kolorki;
            this.Load += (o, e) => {this.RandomNumOutLabel.Text = "";};
            this.Paint += (o, e) => {/*Tu będzie kod rysowania różnych rzeczy!*/};
            this.splitContainer1.Panel1.Paint += (o, e) =>
            {
                using(Pen p = new Pen(curColor))
                {
                    e.Graphics.DrawRectangle(p, 5, 10, 105, 30);
                    e.Graphics.DrawRectangle(p, 175, 10, 105, 30);
                }
            };
            this.splitContainer1.Panel2.Paint += (o, e) =>
            {
                using(Pen p = new Pen(curColor))
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curColor = (Color)((ComboBox)sender).SelectedItem;
            this.Refresh();
        }
    }
}
