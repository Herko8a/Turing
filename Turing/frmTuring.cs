using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing
{
    public partial class frmTuring : Form
    {
        TuringMachine mt;
        public frmTuring()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtTape.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the tape");
                return;
            }


            btnStart.Enabled = false;
            txtTape.Enabled = false;
            txtSourceCode.Enabled = false;

            mt = new TuringMachine();
            mt.Tape = txtTape.Text;
            mt.SourceCode = txtSourceCode.Text;
            mt.PeriodCompleted += Mt_PeriodCompleted;
            mt.EndMachine += Mt_EndMachine;
            mt.Start();
        }

        private void Mt_PeriodCompleted()
        {
            lblEstado.Text = "State: " + mt.CurrentState.Trim();
            lblLapso.Text = "Lapse: " + mt.TimeElapsed.ToString().Trim();
            lblPuntero.Text = "Point: " + mt.CurrentPosition.ToString().Trim();
            txtTape.Text = mt.Tape;
            Application.DoEvents();
        }

        private void Mt_EndMachine()
        {
            btnStart.Enabled = true;
            txtTape.Enabled = true;
            txtSourceCode.Enabled = true;
            txtTape.Text = txtTape.Text.Trim();
        }

    }
}
