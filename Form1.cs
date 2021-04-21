using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace S7NETTEST
{
    public partial class Form1 : Form
    {
        public Plc plc = null;

        private bool debug = true;


        public Form1()
        {
            InitializeComponent();
            controlPanel.Visible = false;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ipLabel.Text)) throw new Exception("Nie podano adresu IP");
                CpuType plcType = CpuType.S71200;
                string cpuIP = ipLabel.Text;

                plc = new Plc(plcType, cpuIP, 0, 0);

                if (!plc.IsConnected) throw new Exception("Nie udało się połączyć z urządzeniem");

                MessageBox.Show(this, "Udało się połączyć z urządzeniem", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                controlPanel.Visible = true;

            } catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(debug) controlPanel.Visible = true;
            }
        }

        private void onVar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.0", 1);
                    stateVar1.Text = "Stan: " + (string)plc.Read("M0.0");
                }
                else
                {
                    stateVar1.Text = "Stan: 1";
                }
            } catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void offVar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.0", 0);
                    stateVar1.Text = "Stan: " + (string)plc.Read("M0.0");
                }
                else
                {
                    stateVar1.Text = "Stan: 0";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onVar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.1", 1);
                    stateVar2.Text = "Stan: " + (string)plc.Read("M0.1");
                }
                else
                {
                    stateVar2.Text = "Stan: 1";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void offVar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.1", 0);
                    stateVar2.Text = "Stan: " + (string)plc.Read("M0.1");
                }
                else
                {
                    stateVar2.Text = "Stan: 0";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onVar3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!debug)
                {
                    plc.Write("M0.2", 1);
                    stateVar3.Text = "Stan: " + (string)plc.Read("M0.2");
                }
                else
                {
                    stateVar3.Text = "Stan: 1";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void offVar3_Click(object sender, EventArgs e)
        { 
            try
            {
                if (!debug)
                {
                    plc.Write("M0.2", 0);
                    stateVar3.Text = "Stan: " + (string)plc.Read("M0.2");
                } else
                {
                    stateVar3.Text = "Stan: 0";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
