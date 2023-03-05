using Objetos_de_tela_teste.Models;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
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
            Ntc1.Enabled = false;
            I2min.Enabled = false;
            I2max.Enabled = false;
            Inc2.Enabled = false;
            Ntc2.Enabled = false;
            I3min.Enabled = false;
            I3max.Enabled = false;
            Inc3.Enabled = false;
            Ntc3.Enabled = false;
            I4min.Enabled = false;
            I4max.Enabled = false;
            Inc4.Enabled = false;
            Ntc4.Enabled = false;
            I5min.Enabled = false;
            I5max.Enabled = false;
            Inc5.Enabled = false;
            Ntc5.Enabled = false;

            USBCom.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(USBCom_OnDataReceived);
        }

        private void Port_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            //byte[] data = new byte[port.BytesToRead];
            //int readLength = port.Read(data, 0, data.Length);
            //OnLaserReportReceived(data);
        }

        public void USBCom_OnDataReceived(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            OnLaserReportReceived(args.data);
        }

        //private void ShowSerialPorts()
        //{
        //    serialPortName.Items.Clear();
        //    foreach (string portName in SerialPort.GetPortNames())
        //    {
        //        serialPortName.Items.Add(portName);
        //    }
        //}

        //private void CreateSerialPort()
        //{
        //    port = new SerialPort(serialPortName.Text);
        //    port.Encoding = ASCIIEncoding.ASCII;
        //    if (!baudRate.Text.Equals(string.Empty))
        //    {
        //        port.BaudRate = int.Parse(baudRate.Text);
        //    }
        //    else
        //    {
        //        baudRate.Text = port.BaudRate.ToString();
        //    }

        //    try
        //    {
        //        port.Open();
        //        port.DataReceived += Port_DataReceived;
        //        port.ErrorReceived += Port_ErrorReceived;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Invalid port name or unknown error.");
        //        port = null;
        //        open.Enabled = true;
        //        return;
        //    }

        //    serialPortName.Enabled = false;
        //    baudRate.Enabled = false;
        //    open.Enabled = false;
        //    close.Enabled = true;
        //    refresh.Enabled = false;
        //}

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

                //if(port.IsOpen) 
                //{
                //    port.Write(data, 0, data.Length);
                //}

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
                name1txt.Enabled = true;
                I1min.Enabled = true;
                I1max.Enabled = true;
                Inc1.Enabled = true;
                Ntc1.Enabled = true;
            }

            else
            {
                name1txt.Enabled = false;
                I1min.Enabled = false;
                I1max.Enabled = false;
                Inc1.Enabled = false;
                Ntc1.Enabled = false;
            }
        }

        private void checkLaser2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser2.Checked)
            {
                name2txt.Enabled = true;
                I2min.Enabled = true;
                I2max.Enabled = true;
                Inc2.Enabled = true;
                Ntc2.Enabled = true;
            }

            else
            {
                name2txt.Enabled = false;
                I2min.Enabled = false;
                I2max.Enabled = false;
                Inc2.Enabled = false;
                Ntc2.Enabled = false;
            }
        }

        private void checkLaser3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser3.Checked)
            {
                name3txt.Enabled = true;
                I3min.Enabled = true;
                I3max.Enabled = true;
                Inc3.Enabled = true;
                Ntc3.Enabled = true;
            }

            else
            {
                name3txt.Enabled = false;
                I3min.Enabled = false;
                I3max.Enabled = false;
                Inc3.Enabled = false;
                Ntc3.Enabled = false;
            }
        }

        private void checkLaser4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser4.Checked)
            {
                name4txt.Enabled = true;
                I4min.Enabled = true;
                I4max.Enabled = true;
                Inc4.Enabled = true;
                Ntc4.Enabled = true;
            }

            else
            {
                name4txt.Enabled = false;
                I4min.Enabled = false;
                I4max.Enabled = false;
                Inc4.Enabled = false;
                Ntc4.Enabled = false;
            }
        }

        private void checkLaser5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser5.Checked)
            {
                name5txt.Enabled = true;
                I5min.Enabled = true;
                I5max.Enabled = true;
                Inc5.Enabled = true;
                Ntc5.Enabled = true;
            }

            else
            {
                name5txt.Enabled = false;
                I5min.Enabled = false;
                I5max.Enabled = false;
                Inc5.Enabled = false;
                Ntc5.Enabled = false;
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(SendDataToAllLasers);
            Iniciar.Enabled = false;
            Parar.Enabled = true;
        }

        private void SendDataToAllLasers()
        {
            experiment.EraseData();// Erase Data of last experiment
            if (checkLaser1.Checked)
            {
                currentLaser = 0;
                LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
                laser1ConfigRequest.Name = name1txt.Text;
                laser1ConfigRequest.ID = 1;
                laser1ConfigRequest.MinPowerCurrent = Convert.ToByte(I1min.Text);
                laser1ConfigRequest.MaxPowerCurrent = Convert.ToByte(I1max.Text);
                laser1ConfigRequest.Increment = Convert.ToByte(Inc1.Text);
                laser1ConfigRequest.DesiredNtc = Convert.ToInt16(Ntc1.Text);
                var temp = laser1ConfigRequest.ConvertedTemperature;
                txtTempFinal1.Invoke((Action)delegate
                {

                    txtTempFinal1.Text = temp.ToString("0.0#");

                });

                experiment.lasers[0].Name = laser1ConfigRequest.Name;
                experiment.lasers[0].ID = 1; //It is the laser ID
                experiment.lasers[0].Current = laser1ConfigRequest.MinPowerCurrent; //min value of current
                experiment.lasers[0].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;//max value of current
                experiment.lasers[0].DesiredNTC = laser1ConfigRequest.DesiredNtc; //target temperature
                experiment.lasers[0].InitialRequest = laser1ConfigRequest;//Saving first request to storage on specified laser

                byte[] dataToSend = laser1ConfigRequest.GetByteArray();//Get byte array that represents config request that will be sent to laser
                SendUSBData(dataToSend);//Sending data to laser1
                experiment.lasers[0].ProcessFinishedEvent.WaitOne();//Lock program and wait for "singal" to continue
            }

            if (checkLaser2.Checked)
            {
                currentLaser = 1;
                LaserConfigRequest laser2ConfigRequest = new LaserConfigRequest();
                laser2ConfigRequest.Name = name2txt.Text;
                laser2ConfigRequest.ID = 2;
                laser2ConfigRequest.MinPowerCurrent = Convert.ToByte(I2min.Text);
                laser2ConfigRequest.MaxPowerCurrent = Convert.ToByte(I2max.Text);
                laser2ConfigRequest.Increment = Convert.ToByte(Inc2.Text);
                laser2ConfigRequest.DesiredNtc = Convert.ToInt16(Ntc2.Text);
                var temp = laser2ConfigRequest.ConvertedTemperature;
                txtTempFinal2.Invoke((Action)delegate
                {

                    txtTempFinal2.Text = temp.ToString("0.0#");

                });

                experiment.lasers[1].Name = laser2ConfigRequest.Name;
                experiment.lasers[1].ID = 2;
                experiment.lasers[1].Current = laser2ConfigRequest.MinPowerCurrent;
                experiment.lasers[1].DesiredCurrent = laser2ConfigRequest.MaxPowerCurrent;
                experiment.lasers[1].DesiredNTC = laser2ConfigRequest.DesiredNtc;
                experiment.lasers[1].InitialRequest = laser2ConfigRequest;

                byte[] dataToSend = laser2ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
                experiment.lasers[1].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser3.Checked)
            {
                currentLaser = 2;
                LaserConfigRequest laser3ConfigRequest = new LaserConfigRequest();
                laser3ConfigRequest.Name = name3txt.Text;
                laser3ConfigRequest.ID = 3;
                laser3ConfigRequest.MinPowerCurrent = Convert.ToByte(I3min.Text);
                laser3ConfigRequest.MaxPowerCurrent = Convert.ToByte(I3max.Text);
                laser3ConfigRequest.Increment = Convert.ToByte(Inc3.Text);
                laser3ConfigRequest.DesiredNtc = Convert.ToInt16(Ntc3.Text);
                var temp = laser3ConfigRequest.ConvertedTemperature;
                txtTempFinal3.Invoke((Action)delegate
                {

                    txtTempFinal3.Text = temp.ToString("0.0#");

                });

                experiment.lasers[2].Name = laser3ConfigRequest.Name;
                experiment.lasers[2].ID = 3;
                experiment.lasers[2].Current = laser3ConfigRequest.MinPowerCurrent;
                experiment.lasers[2].DesiredCurrent = laser3ConfigRequest.MaxPowerCurrent;
                experiment.lasers[2].DesiredNTC = laser3ConfigRequest.DesiredNtc;
                experiment.lasers[2].InitialRequest = laser3ConfigRequest;

                byte[] dataToSend = laser3ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
                experiment.lasers[2].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser4.Checked)
            {
                currentLaser = 3;
                LaserConfigRequest laser4ConfigRequest = new LaserConfigRequest();
                laser4ConfigRequest.Name = name4txt.Text;
                laser4ConfigRequest.ID = 4;
                laser4ConfigRequest.MinPowerCurrent = Convert.ToByte(I4min.Text);
                laser4ConfigRequest.MaxPowerCurrent = Convert.ToByte(I4max.Text);
                laser4ConfigRequest.Increment = Convert.ToByte(Inc4.Text);
                laser4ConfigRequest.DesiredNtc = Convert.ToInt16(Ntc4.Text);
                var temp = laser4ConfigRequest.ConvertedTemperature;
                txtTempFinal4.Invoke((Action)delegate
                {

                    txtTempFinal4.Text = temp.ToString("0.0#");

                });

                experiment.lasers[3].Name = laser4ConfigRequest.Name;
                experiment.lasers[3].ID = 4;
                experiment.lasers[3].Current = laser4ConfigRequest.MinPowerCurrent;
                experiment.lasers[3].DesiredCurrent = laser4ConfigRequest.MaxPowerCurrent;
                experiment.lasers[3].DesiredNTC = laser4ConfigRequest.DesiredNtc;
                experiment.lasers[3].InitialRequest = laser4ConfigRequest;

                byte[] dataToSend = laser4ConfigRequest.GetByteArray();
                SendUSBData(dataToSend);
                experiment.lasers[3].ProcessFinishedEvent.WaitOne();
            }

            if (checkLaser5.Checked)
            {
                currentLaser = 4;
                LaserConfigRequest laser5ConfigRequest = new LaserConfigRequest();
                laser5ConfigRequest.Name = name5txt.Text;
                laser5ConfigRequest.ID = 5;
                laser5ConfigRequest.MinPowerCurrent = Convert.ToByte(I5min.Text);
                laser5ConfigRequest.MaxPowerCurrent = Convert.ToByte(I5max.Text);
                laser5ConfigRequest.Increment = Convert.ToByte(Inc5.Text);
                laser5ConfigRequest.DesiredNtc = Convert.ToInt16(Ntc5.Text);
                var temp = laser5ConfigRequest.ConvertedTemperature;
                txtTempFinal5.Invoke((Action)delegate
                {
                    txtTempFinal5.Text = temp.ToString("0.0#");

                });

                experiment.lasers[4].Name = laser5ConfigRequest.Name;
                experiment.lasers[4].ID = 5;
                experiment.lasers[4].Current = laser5ConfigRequest.MinPowerCurrent;
                experiment.lasers[4].DesiredCurrent = laser5ConfigRequest.MaxPowerCurrent;
                experiment.lasers[4].DesiredNTC = laser5ConfigRequest.DesiredNtc;
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

            LaserConfigRequest finalConfigRequest = new LaserConfigRequest();
            SendUSBData(finalConfigRequest.GetByteArray());// sending last and empty message
            currentLaser = -1;// back to non existent laser
            MessageBox.Show("Finished All tests");
            txtTempFinal1.Invoke((Action)delegate
            {

                txtTempFinal1.Text = string.Empty;

            });
            txtTempFinal2.Invoke((Action)delegate
            {

                txtTempFinal2.Text = string.Empty;

            });
            txtTempFinal3.Invoke((Action)delegate
            {

                txtTempFinal3.Text = string.Empty;

            });
            txtTempFinal4.Invoke((Action)delegate
            {

                txtTempFinal4.Text = string.Empty;

            });
            txtTempFinal5.Invoke((Action)delegate
            {

                txtTempFinal5.Text = string.Empty;

            });
        }

        private void OnLaserReportReceived(byte[] data)
        {
            LaserReport report = new LaserReport();

            report.Parse(data);//fill the properties with received data from USB

            if(currentLaser >= 0 && currentLaser < experiment.lasers.Count)//Check if it is a valid laser
            {
                experiment.lasers[currentLaser].reports.Add(report);//Save report from usb
                experiment.lasers[currentLaser].Current += experiment.lasers[currentLaser].InitialRequest.Increment;//set current using last report + increment

                if (experiment.lasers[currentLaser].Current <= experiment.lasers[currentLaser].DesiredCurrent)//check if the program needs resent a new config with incremented value of current
                {
                    LaserConfigRequest updateRequest = new LaserConfigRequest();// new config that will be 

                    updateRequest = experiment.lasers[currentLaser].InitialRequest;//get all informations from first request
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
            System.Globalization.NumberFormatInfo nf
              = new System.Globalization.NumberFormatInfo()
              {
                  NumberGroupSeparator = "."
              };

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
                    var culture = CultureInfo.CreateSpecificCulture("en-US");

                    Thread.CurrentThread.CurrentCulture = culture;
                    Arq = File.AppendText(saveFileDialog1.FileName);
                    Arq.WriteLine(DateTime.Now);
                    Arq.WriteLine();
                    Arq.WriteLine("  Laser Id | NTC(Ω) | If(mA) | Sgn_in(mV) | Sgn_out(mV)");
                    Arq.WriteLine("-----------------------------------------------------");
                    Arq.WriteLine();

                    foreach (var laser in experiment.lasers)//getting all lasers
                    {
                        foreach(var report in laser.reports)//getting all reports for each laser
                        {
                            //Arq.WriteLine($"{laser.Name}   {laser.DesiredNTC:0.0#}    {report.Current:0.0#}    {report.Signal} {report.FinalSignal:0.0#}  ", nf);
                            Arq.WriteLine(String.Format("{0,-10} | {1,-6} | {2,6} | {3, 10} | {4, 10}",
                                laser.Name,
                                laser.DesiredNTC,
                                report.Current,
                                report.Signal,
                                report.FinalSignal,
                                nf));
                        }
                        Arq.WriteLine("----------------------------------------------------");
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
            OnLaserReportReceived(new byte[] {0x00, 0x01, 0x18, 0x01, 0x3a, 0x09, 0x01, 0x01});//Just to test   
        }

        private void btnIncrement_Click_1(object sender, EventArgs e)
        {
            OnLaserReportReceived(new byte[] { 0x00, 0x01, 0x18, 0x00, 0x3a, 0x09, 0x01, 0x01 });//Just to test   
        }

        //private void open_Click(object sender, EventArgs e)
        //{
        //    if (string.Empty.Equals(serialPortName.Text))
        //    {
        //        MessageBox.Show("Need a port name to Open.");
        //        return;
        //    }

        //    if (port == null)
        //    {
        //        CreateSerialPort();
        //    }
        //}

        //private void refresh_Click(object sender, EventArgs e)
        //{
        //    ShowSerialPorts();
        //}

        //private void CloseSerialPort()
        //{
        //    try
        //    {
        //        if (port != null && port.IsOpen)
        //        {
        //            port.Close();
        //        }
        //        port = null;
        //    }
        //    catch (IOException)
        //    {
        //        // don't need user to do anything
        //    }

        //    close.Enabled = false;
        //    open.Enabled = true;
        //    refresh.Enabled = true;
        //    serialPortName.Enabled = true;
        //    baudRate.Enabled = true;
        //}

        //private void close_Click(object sender, EventArgs e)
        //{
        //    CloseSerialPort();
        //}
    }
}
