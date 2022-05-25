using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr23_24
{
    public partial class colorForm : Form
    {
        Color colorResult;
        private void updateColor()
        {
            colorResult = Color.FromArgb(scrol_red.Value, scroll_green.Value, scroll_blue.Value);
            picResultColor.BackColor = colorResult;
        }
        public colorForm()
        {
            InitializeComponent();
            scrol_red.Tag = numeric_red;
            scroll_green.Tag = numeric_green;
            scroll_blue.Tag = numeric_blue;
            numeric_red.Tag = scrol_red;
            numeric_green.Tag = scroll_green;
            numeric_blue.Tag = scroll_blue;
            
        }

        private void colorForm_Load(object sender, EventArgs e)
        {

        }

        private void scrol_red_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scrollBar.Tag;
            numeric.Value = scrollBar.Value;
            updateColor();
        }

        private void scroll_green_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scrollBar.Tag;
            numeric.Value = scrollBar.Value;
            updateColor();
        }

        private void scroll_blue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numeric = (NumericUpDown)scrollBar.Tag;
            numeric.Value = scrollBar.Value;
            updateColor();
        }

        private void numeric_red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numeric.Tag;
            scrollBar.Value = (int)numeric.Value;
            
        }

        private void numeric_green_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numeric.Tag;
            scrollBar.Value = (int)numeric.Value;
            
        }

        private void numeric_blue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numeric.Tag;
            scrollBar.Value = (int)numeric.Value;
            
        }

        private void btn_OtherColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                scrol_red.Value = colorDialog.Color.R;
                scroll_green.Value = colorDialog.Color.G;
                scroll_blue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                updateColor();
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if(main != null)
            {
                Color color = main.currentPen.Color;
                main.currentPen.Color = colorResult;
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
