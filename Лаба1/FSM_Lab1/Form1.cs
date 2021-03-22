using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSM_Lab1
{
    public partial class Form1 : Form
    {
        FSM fsm; 

        
        public Form1()
        { 
            InitializeComponent();
            fsm = new FSM();
            txt_StartState.Text = fsm.firstState.ToString();
            txt_CurrentState.Text = fsm.activeState.ToString();
        }

        private void btn_z1_Click(object sender, EventArgs e)
        {
            NewW(fsm.Activity(FSM.Inputs.z1));
        }

        private void btn_z2_Click(object sender, EventArgs e)
        {
            NewW(fsm.Activity(FSM.Inputs.z2));
        }

        private void btn_z3_Click(object sender, EventArgs e)
        {
            NewW(fsm.Activity(FSM.Inputs.z3));
        }

        private void btn_z4_Click(object sender, EventArgs e)
        {
            NewW(fsm.Activity(FSM.Inputs.z4));
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            fsm.activeState = fsm.firstState;
            txt_CurrentState.Clear();
            txt_CurrentState.Text = fsm.activeState.ToString();

            pictureBox_w1.BackColor = DefaultBackColor;
            pictureBox_w2.BackColor = DefaultBackColor;
            pictureBox_w3.BackColor = DefaultBackColor;
            pictureBox_w4.BackColor = DefaultBackColor;

        }

        private void NewW(int WSuccess)
        {
            txt_CurrentState.Text = fsm.activeState.ToString();

            if (WSuccess == 1)
            {
                pictureBox_w1.BackColor = Color.Yellow;
                pictureBox_w2.BackColor = DefaultBackColor;
                pictureBox_w3.BackColor = DefaultBackColor;
                pictureBox_w4.BackColor = DefaultBackColor;
            }

            if (WSuccess == 2)
            {
                pictureBox_w1.BackColor = DefaultBackColor;
                pictureBox_w2.BackColor = Color.Yellow;
                pictureBox_w3.BackColor = DefaultBackColor;
                pictureBox_w4.BackColor = DefaultBackColor;

            }

            if (WSuccess == 3)
            {
                pictureBox_w1.BackColor = DefaultBackColor;
                pictureBox_w2.BackColor = DefaultBackColor;
                pictureBox_w3.BackColor = Color.Yellow;
                pictureBox_w4.BackColor = DefaultBackColor;

            }

            if (WSuccess == 4)
            {
                pictureBox_w1.BackColor = DefaultBackColor;
                pictureBox_w2.BackColor = DefaultBackColor;
                pictureBox_w3.BackColor = DefaultBackColor;
                pictureBox_w4.BackColor = Color.Yellow;

            }

            if (WSuccess == 0)
            {
                pictureBox_w1.BackColor = DefaultBackColor;
                pictureBox_w2.BackColor = DefaultBackColor;
                pictureBox_w3.BackColor = DefaultBackColor;
                pictureBox_w4.BackColor = DefaultBackColor;
            }

        }
    }
}
