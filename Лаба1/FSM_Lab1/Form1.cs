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
        FSM fsm; //создаем тут, чтоб можно было использовать в методах

        
        public Form1()
        { 
            InitializeComponent();
            fsm = new FSM();
            txt_StartState.Text = fsm.firstState.ToString();
        }

        private void NewW(FSM.Exits WSuccess)
        {
            txt_CurrentState.Text = fsm.activeState.ToString();

            if (WSuccess == FSM.Exits.w1)
            {
                w1.Checked = true;
                w2.Checked = false;
                w3.Checked = false;
                w4.Checked = false;
            }

            if (WSuccess == FSM.Exits.w2)
            {
                w1.Checked = false;
                w2.Checked = true;
                w3.Checked = false;
                w4.Checked = false;
            }

            if (WSuccess == FSM.Exits.w3)
            {
                w1.Checked = false;
                w2.Checked = false;
                w3.Checked = true;
                w4.Checked = false;
            }

            if (WSuccess == FSM.Exits.w4)
            {
                w1.Checked = false;
                w2.Checked = false;
                w3.Checked = false;
                w4.Checked = true;
            }

            if (WSuccess == FSM.Exits.No)
            {
                w1.Checked = false;
                w2.Checked = false;
                w3.Checked = false;
                w4.Checked = false;
            }

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
            
            w1.Checked = false;
            w2.Checked = false;
            w3.Checked = false;
            w4.Checked = false;

        }
    }
}
