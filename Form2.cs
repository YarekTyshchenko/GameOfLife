using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication4
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            GridBar.Value = form1.getScale();
            RuleBox.Text = form1.getRule();
            int speed = form1.getSpeed();
            SimSpeedLabel.Text = calcFPS(speed).ToString();
            SimSpeed.Value = calcFPS(speed);
            wrapCheckbox.Checked = form1.getWarp();
            GridCheckbox.Checked = form1.getGrid();
        }

        private void setValues()
        {
            form1.setScale(GridBar.Value);
            form1.setRule(RuleBox.Text);
            form1.setSpeed(calcInterval(SimSpeed.Value));
            form1.setWarp(wrapCheckbox.Checked);
            form1.setGrid(GridCheckbox.Checked);
        }

        private int calcFPS(int speed)
        {
            return (int)Math.Round(1000f / speed);
        }

        private int calcInterval(int speed)
        {
            return (int)Math.Round(1000f / speed);
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            setValues();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GridBar_ValueChanged(object sender, EventArgs e)
        {
            GridSizeLabel.Text = GridBar.Value.ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            setValues();
        }

        private void SimSpeed_ValueChanged(object sender, EventArgs e)
        {
            SimSpeedLabel.Text = SimSpeed.Value.ToString();
        }
    }
}
