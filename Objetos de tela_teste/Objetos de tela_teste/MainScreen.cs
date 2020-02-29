using Objetos_de_tela_teste.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetos_de_tela_teste
{
    public partial class MainScreen : Form
    {
        Experiment experiment = new Experiment(5);//it represents a experiment

        private int currentLaser = -1; //means no active laser

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
            OnLaserReportReceived(args.data);
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
            experiment.EraseData();// Erase Data of last experiment
            if (checkLaser1.Checked)
            {
                currentLaser = 0;
                LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
                laser1ConfigRequest.ID = 1;
                laser1ConfigRequest.MinPowerCurrent = Convert.ToByte(I1min.Text);
                laser1ConfigRequest.MaxPowerCurrent = Convert.ToByte(I1max.Text);
                laser1ConfigRequest.Increment = Convert.ToByte(Inc1.Text);
                laser1ConfigRequest.DesiredTemperature = Convert.ToByte(Temp1.Text);

                experiment.lasers[0].ID = 1; //It is the laser ID
                experiment.lasers[0].Current = laser1ConfigRequest.MinPowerCurrent; //min value of current
                experiment.lasers[0].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;//max value of current
                experiment.lasers[0].DesiredTemperature = laser1ConfigRequest.DesiredTemperature; //target temperature
                experiment.lasers[0].InitialRequest = laser1ConfigRequest;//Saving first request to storage on specified laser

                byte[] dataToSend = laser1ConfigRequest.GetByteArray();//Get byte array that represents config request that will be sent to laser
                SendUSBData(dataToSend);//Sending data to laser1
                experiment.lasers[0].ProcessFinishedEvent.WaitOne();//Lock program and wait for "singal" to continue
            }

            if (checkLaser2.Checked)
            {
                currentLaser = 1;
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
                experiment.lasers[1].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser3.Checked)
            {
                currentLaser = 2;
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
                experiment.lasers[2].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser4.Checked)
            {
                currentLaser = 3;
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
                experiment.lasers[3].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser5.Checked)
            {
                currentLaser = 4;
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
                experiment.lasers[4].ProcessFinishedEvent.WaitOne();
            }


            Iniciar.Invoke(new Action(() =>
            {
                Iniciar.Enabled = true;
            }));

            Parar.Invoke(new Action(() =>
            {
                Parar.Enabled = false;
            }));

            btnIncrement.Invoke(new Action(() =>
            {
                btnIncrement.Enabled = false;
            }));

            currentLaser = -1;
            MessageBox.Show("Finished All tests");
        }

        private void OnLaserReportReceived(byte[] data)
        {
            LaserReport report = new LaserReport();

            //Just to Check, if you are using the real hardware, please comment the following 3 lines
            //report.Current = experiment.lasers[currentLaser].Current;
            //report.Temperature = experiment.lasers[currentLaser].DesiredTemperature;
            //report.Signal = 0;

            //Uncomment this line if you are using the real hardware
            report.Parse(data);//fill the properties with received data from USB

            if(currentLaser >= 0 && currentLaser < experiment.lasers.Count)//Check if it is a valid laser
            {
                experiment.lasers[currentLaser].reports.Add(report);//Save 
                experiment.lasers[currentLaser].Current += experiment.lasers[currentLaser].InitialRequest.Increment;//set current using last report + increment

                if (experiment.lasers[currentLaser].Current <= experiment.lasers[currentLaser].DesiredCurrent)//check if the program needs resent a new config with incremented value of current
                {
                    LaserConfigRequest updateRequest = new LaserConfigRequest();// new config that will be 

                    updateRequest = experiment.lasers[currentLaser].InitialRequest;//get all informations from first request
                    //updateRequest.MinPowerCurrent = Convert.ToByte(experiment.lasers[currentLaser].Current);//update just the min value
                    updateRequest.MinPowerCurrent = Convert.ToByte(experiment.lasers[currentLaser].Current);//update just the min value
                    SendUSBData(updateRequest.GetByteArray());// sending updated config
                }
                else
                {
                    experiment.lasers[currentLaser].ProcessFinishedEvent.Set();// Unlock the current laser process
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
                    Arq.WriteLine("Laser ID    Temp.(ºC)   " + "Corr.(mA)   " + "Sinal (mV)");
                    Arq.WriteLine();

                    foreach (var laser in experiment.lasers)//getting all lasers
                    {
                        foreach(var report in laser.reports)//getting all reports for each laser
                        {
                            Arq.WriteLine(laser.ID + "              " + report.Temperature + "         " + report.Current + "           " + report.Signal);
                        }
                        Arq.WriteLine("------------------------------------------------------");
                    }

                    Arq.Close();
                }
                MessageBox.Show("Dados Salvos com sucesso!");
                experiment.EraseData(); //Erase Previus Data
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
            OnLaserReportReceived(new byte[] {0x00, 0x00, 0x00, 0x18, 0x05, 0x3a, 0x09, 0x00, 0x00});//Just to test   
        }
    }
}
