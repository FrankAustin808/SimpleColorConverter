using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialSlider
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private int Red;
        private int Green;
        private int Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void redSlider_EditValueChanged(object sender, EventArgs e)
        {
            Red = Convert.ToInt32(redSlider.Value);
            colorPanel.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void greenSlider_EditValueChanged(object sender, EventArgs e)
        {
            Green = Convert.ToInt32(greenSlider.Value);
            colorPanel.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void blueSlider_EditValueChanged(object sender, EventArgs e)
        {
            Blue = Convert.ToInt32(blueSlider.Value);
            colorPanel.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorOutLabel.Caption = $"{redSlider.Value.ToString()}, {greenSlider.Value.ToString()}, {blueSlider.Value.ToString()}";
            colorOutput.Start();
        }

        private void outputSelector_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void convertHexBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string hex = $" {redSlider.Value.ToString("X2")}, {greenSlider.Value.ToString("X2")}, {blueSlider.Value.ToString("X2")}";

            colorOutLabel.Caption = hex;
        }

        private void outputSelector_EditValueChanged(object sender, EventArgs e)
        {
            if (outputSelector.Caption == "RGB")
            {

            }
            else if (outputSelector.Caption == "HEX")
            {

            }
            else if (outputSelector.Caption == "")
            {

            }
        }

        private void colorOutput_Tick(object sender, EventArgs e)
        {
            colorOutLabel.Caption = $"{redSlider.Value.ToString()}, {greenSlider.Value.ToString()}, {blueSlider.Value.ToString()}";
        }
    }
}
