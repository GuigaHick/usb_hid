using Objetos_de_tela_teste.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetos_de_tela_teste
{
    public partial class MainScreen : Form
    {
        List<string> TempList = new List<string>();

        Experiment experiment = new Experiment(5);

        private int currentLaser = 0;

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

            OnLaserReportReceived(bfRecebe);
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
            Task.Factory.StartNew(SendDataToAllLasers);
            Iniciar.Enabled = false;
            Parar.Enabled = true;
            btnIncrement.Enabled = true;
        }

        private void SendDataToAllLasers()
        {
            if (checkLaser1.Checked)
            {
                LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
                laser1ConfigRequest.ID = 1;
                laser1ConfigRequest.MinPowerCurrent = Convert.ToByte(I1min.Text);
                laser1ConfigRequest.MaxPowerCurrent = Convert.ToByte(I1max.Text);
                laser1ConfigRequest.Increment = Convert.ToByte(Inc1.Text);
                laser1ConfigRequest.DesiredTemperature = Convert.ToByte(Temp1.Text);

                experiment.lasers[0].ID = 1;
                experiment.lasers[0].Current = laser1ConfigRequest.MinPowerCurrent;
                experiment.lasers[0].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;
                experiment.lasers[0].DesiredTemperature = laser1ConfigRequest.DesiredTemperature;
                experiment.lasers[0].InitialRequest = laser1ConfigRequest;

                byte[] dataToSend = laser1ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
            }

            experiment.lasers[0].ProcessFinishedEvent.WaitOne();

            if (checkLaser2.Checked)
            {
                LaserConfigRequest laser2ConfigRequest = new LaserConfigRequest();
                laser2ConfigRequest.ID = 2;
                laser2ConfigRequest.MinPowerCurrent = Convert.ToByte(I2min.Text);
                laser2ConfigRequest.MaxPowerCurrent = Convert.ToByte(I2max.Text);
                laser2ConfigRequest.Increment = Convert.ToByte(Inc2.Text);
                laser2ConfigRequest.DesiredTemperature = Convert.ToByte(Temp2.Text);

                experiment.lasers[1].ID = 2;
                experiment.lasers[1].Current = laser2ConfigRequest.MinPowerCurrent;
                experiment.lasers[1].DesiredCurrent = laser2ConfigRequest.MaxPowerCurrent;
                experiment.lasers[1].DesiredTemperature = laser2ConfigRequest.DesiredTemperature;
                experiment.lasers[1].InitialRequest = laser2ConfigRequest;

                byte[] dataToSend = laser2ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
            }

            experiment.lasers[1].ProcessFinishedEvent.WaitOne();

            if (checkLaser3.Checked)
            {
                LaserConfigRequest laser3ConfigRequest = new LaserConfigRequest();
                laser3ConfigRequest.ID = 3;
                laser3ConfigRequest.MinPowerCurrent = Convert.ToByte(I3min.Text);
                laser3ConfigRequest.MaxPowerCurrent = Convert.ToByte(I3max.Text);
                laser3ConfigRequest.Increment = Convert.ToByte(Inc3.Text);
                laser3ConfigRequest.DesiredTemperature = Convert.ToByte(Temp3.Text);

                experiment.lasers[2].ID = 3;
                experiment.lasers[2].Current = laser3ConfigRequest.MinPowerCurrent;
                experiment.lasers[2].DesiredCurrent = laser3ConfigRequest.MaxPowerCurrent;
                experiment.lasers[2].DesiredTemperature = laser3ConfigRequest.DesiredTemperature;
                experiment.lasers[2].InitialRequest = laser3ConfigRequest;

                byte[] dataToSend = laser3ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
            }

            experiment.lasers[2].ProcessFinishedEvent.WaitOne();

            if (checkLaser4.Checked)
            {
                LaserConfigRequest laser4ConfigRequest = new LaserConfigRequest();
                laser4ConfigRequest.ID = 4;
                laser4ConfigRequest.MinPowerCurrent = Convert.ToByte(I4min.Text);
                laser4ConfigRequest.MaxPowerCurrent = Convert.ToByte(I4max.Text);
                laser4ConfigRequest.Increment = Convert.ToByte(Inc4.Text);
                laser4ConfigRequest.DesiredTemperature = Convert.ToByte(Temp4.Text);

                experiment.lasers[3].ID = 4;
                experiment.lasers[3].Current = laser4ConfigRequest.MinPowerCurrent;
                experiment.lasers[3].DesiredCurrent = laser4ConfigRequest.MaxPowerCurrent;
                experiment.lasers[3].DesiredTemperature = laser4ConfigRequest.DesiredTemperature;
                experiment.lasers[3].InitialRequest = laser4ConfigRequest;

                byte[] dataToSend = laser4ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
            }

            experiment.lasers[3].ProcessFinishedEvent.WaitOne();

            if (checkLaser5.Checked)
            {
                LaserConfigRequest laser5ConfigRequest = new LaserConfigRequest();
                laser5ConfigRequest.ID = 5;
                laser5ConfigRequest.MinPowerCurrent = Convert.ToByte(I5min.Text);
                laser5ConfigRequest.MaxPowerCurrent = Convert.ToByte(I5max.Text);
                laser5ConfigRequest.Increment = Convert.ToByte(Inc5.Text);
                laser5ConfigRequest.DesiredTemperature = Convert.ToByte(Temp5.Text);

                experiment.lasers[4].ID = 5;
                experiment.lasers[4].Current = laser5ConfigRequest.MinPowerCurrent;
                experiment.lasers[4].DesiredCurrent = laser5ConfigRequest.MaxPowerCurrent;
                experiment.lasers[4].DesiredTemperature = laser5ConfigRequest.DesiredTemperature;
                experiment.lasers[4].InitialRequest = laser5ConfigRequest;

                byte[] dataToSend = laser5ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
            }

            experiment.lasers[4].ProcessFinishedEvent.WaitOne();
        }

        private void OnLaserReportReceived(string data)
        {
            LaserReport report = new LaserReport();

            experiment.lasers[currentLaser].Current += experiment.lasers[currentLaser].InitialRequest.Increment;
            experiment.lasers[currentLaser].reports.Add(report);
            if (experiment.lasers[currentLaser].Current < experiment.lasers[currentLaser].DesiredCurrent)
            {
                LaserConfigRequest updateRequest = new LaserConfigRequest();

                updateRequest = experiment.lasers[currentLaser].InitialRequest;
                updateRequest.MinPowerCurrent = Convert.ToByte(experiment.lasers[currentLaser].Current + experiment.lasers[currentLaser].InitialRequest.Increment);
                SendUSBData(updateRequest.GetByteArray());
            }
            else
            {
                MessageBox.Show("Finished Test with Laser:" + (currentLaser + 1));
                experiment.lasers[currentLaser].ProcessFinishedEvent.Set();
                currentLaser++;
                if(currentLaser >= experiment.lasers.Count)
                {
                    Iniciar.Enabled = true;
                    Parar.Enabled = false;
                    btnIncrement.Enabled = false;
                    currentLaser = 0;
                    MessageBox.Show("Finished All tests");
                }
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

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            OnLaserReportReceived("");
        }
    }
}
