using Objetos_de_tela_teste.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Objetos_de_tela_teste
{
    public partial class MainScreen : Form
    {
        List<string> TempList = new List<string>();

        LaserInfo laserInfo1 = new LaserInfo();

        public MainScreen()
        {
            InitializeComponent();

            I1min.Enabled = false;
            I1max.Enabled = false;
            Inc1.Enabled = false;
            Temp1.Enabled = false;
            I2min.Enabled = false;
            I2max.Enabled = false;
            Inc2.Enabled = false;
            Temp2.Enabled = false;
            I3min.Enabled = false;
            I3max.Enabled = false;
            Inc3.Enabled = false;
            Temp3.Enabled = false;
            I4min.Enabled = false;
            I4max.Enabled = false;
            Inc4.Enabled = false;
            Temp4.Enabled = false;
            I5min.Enabled = false;
            I5max.Enabled = false;
            Inc5.Enabled = false;
            Temp5.Enabled = false;

            USBCom.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(USBCom_OnDataReceived);
        }

        public void USBCom_OnDataReceived(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            string bfRecebe = "Dados: ";

            foreach (byte mydata in args.data)
            {
                if (mydata.ToString().Length == 1)
                    bfRecebe += "00";

                if (mydata.ToString().Length == 2)
                    bfRecebe += "0";

                bfRecebe += mydata.ToString() + " ";
            }

            LaserReport report = new LaserReport();
            report.Parse(bfRecebe);

            laserInfo1.reports.Add(report);
            if(laserInfo1.DesiredCurrent > report.Current)
            {
                LaserConfigRequest updateRequest = new LaserConfigRequest();

                updateRequest = laserInfo1.InitialRequest;
                updateRequest.MinPowerCurrent = Convert.ToByte(report.Current + updateRequest.Increment);
                SendUSBData(updateRequest.GetByteArray());
            }
            else
            {
                MessageBox.Show("Finished Test");
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                USBCom.ProductId = 32;
                USBCom.VendorId = 1121;
                USBCom.CheckDevicePresent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dispositivo Desconectado...";
        }

        private void USBCom_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Dispositivo Conectado...";
        }

        private void SendUSBData(byte[] data)
        {
            try
            {
                if (this.USBCom.SpecifiedDevice != null)
                {
                    USBCom.SpecifiedDevice.SendData(data);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkLaser1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser1.Checked)
            {
                I1min.Enabled = true;
                I1max.Enabled = true;
                Inc1.Enabled = true;
                Temp1.Enabled = true;
            }

            else
            {
                I1min.Enabled = false;
                I1max.Enabled = false;
                Inc1.Enabled = false;
                Temp1.Enabled = false;
            }
        }

        private void checkLaser2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser2.Checked)
            {
                I2min.Enabled = true;
                I2max.Enabled = true;
                Inc2.Enabled = true;
                Temp2.Enabled = true;
            }

            else
            {
                I2min.Enabled = false;
                I2max.Enabled = false;
                Inc2.Enabled = false;
                Temp2.Enabled = false;
            }
        }

        private void checkLaser3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser3.Checked)
            {
                I3min.Enabled = true;
                I3max.Enabled = true;
                Inc3.Enabled = true;
                Temp3.Enabled = true;
            }

            else
            {
                I3min.Enabled = false;
                I3max.Enabled = false;
                Inc3.Enabled = false;
                Temp3.Enabled = false;
            }
        }

        private void checkLaser4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser4.Checked)
            {
                I4min.Enabled = true;
                I4max.Enabled = true;
                Inc4.Enabled = true;
                Temp4.Enabled = true;
            }

            else
            {
                I4min.Enabled = false;
                I4max.Enabled = false;
                Inc4.Enabled = false;
                Temp4.Enabled = false;
            }
        }

        private void checkLaser5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser5.Checked)
            {
                I5min.Enabled = true;
                I5max.Enabled = true;
                Inc5.Enabled = true;
                Temp5.Enabled = true;
            }

            else
            {
                I5min.Enabled = false;
                I5max.Enabled = false;
                Inc5.Enabled = false;
                Temp5.Enabled = false;
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            if (checkLaser1.Checked)
            {
                LaserConfigRequest laser1 = new LaserConfigRequest();
                laser1.ID = 1;
                laser1.MinPowerCurrent = Convert.ToByte(I1min.Text);
                laser1.MaxPowerCurrent = Convert.ToByte(I1max.Text);
                laser1.Increment = Convert.ToByte(Inc1.Text);
                laser1.DesiredTemperature = Convert.ToByte(Temp1.Text);

                laserInfo1.ID = 1;
                laserInfo1.DesiredCurrent = laser1.MaxPowerCurrent;
                laserInfo1.DesiredTemperature = laser1.DesiredTemperature;
                laserInfo1.InitialRequest = laser1;

                byte[] dataToSend = laser1.GetByteArray();
                SendUSBData(dataToSend);
            }
        }

        private void SalvarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextWriter Arq;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Arq = File.AppendText(saveFileDialog1.FileName);
                    Arq.WriteLine(DateTime.Now);
                    Arq.WriteLine();
                    Arq.WriteLine("Temp.(ºC)   " + "Corr.(mA)   " + "Sinal (mV)");
                    Arq.WriteLine();

                    for (int i = 0; i < TempList.Count; i++)
                        Arq.WriteLine(TempList[i]);

                    Arq.Close();
                }
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void SairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
