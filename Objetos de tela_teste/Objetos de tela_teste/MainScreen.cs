using Objetos_de_tela_teste.Models;
using Objetos_de_tela_teste.Utils;
using System;
using System.Collections.Generic;
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

        OperationMode operationMode = OperationMode.Current;

        public MainScreen()
        {
            InitializeComponent();

            #region Current Componentes Initialization
            I1min.Enabled = false;
            I1max.Enabled = false;
            CbInc1.Enabled = false;
            Ntc1.Enabled = false;
            I2min.Enabled = false;
            I2max.Enabled = false;
            CbInc2.Enabled = false;
            Ntc2.Enabled = false;
            I3min.Enabled = false;
            I3max.Enabled = false;
            CbInc3.Enabled = false;
            Ntc3.Enabled = false;
            I4min.Enabled = false;
            I4max.Enabled = false;
            CbInc4.Enabled = false;
            Ntc4.Enabled = false;
            I5min.Enabled = false;
            I5max.Enabled = false;
            CbInc5.Enabled = false;
            Ntc5.Enabled = false;

            var currentIncrementOptions = new float[] { 0.5f, 1, 5 };

            this.CbInc1.DataSource = currentIncrementOptions.Clone();
            this.CbInc2.DataSource = currentIncrementOptions.Clone();
            this.CbInc3.DataSource = currentIncrementOptions.Clone();
            this.CbInc4.DataSource = currentIncrementOptions.Clone();
            this.CbInc5.DataSource = currentIncrementOptions.Clone();

            #endregion

            #region Tempeature Components Initialization
            Ntc1Min.Enabled = false;
            Ntc1max.Enabled = false;
            cbNtc1Inc.Enabled = false;
            Iop1.Enabled = false;
            Ntc2Min.Enabled = false;
            Ntc2max.Enabled = false;
            cbNtc2Inc.Enabled = false;
            Iop2.Enabled = false;
            Ntc3Min.Enabled = false;
            Ntc3max.Enabled = false;
            cbNtc3Inc.Enabled = false;
            Iop3.Enabled = false;
            Ntc4Min.Enabled = false;
            Ntc4max.Enabled = false;
            cbNtc4Inc.Enabled = false;
            Iop4.Enabled = false;
            Ntc5Min.Enabled = false;
            Ntc5max.Enabled = false;
            cbNtc5Inc.Enabled = false;

            Iop5.Enabled = false;
            var ntcIncrementOptions = new int[] { 20, 40, 60, 80, 100, 180, 380, 600,800, 1000 };
            this.cbNtc1Inc.DataSource = ntcIncrementOptions.Clone();
            this.cbNtc2Inc.DataSource = ntcIncrementOptions.Clone();
            this.cbNtc3Inc.DataSource = ntcIncrementOptions.Clone();
            this.cbNtc4Inc.DataSource = ntcIncrementOptions.Clone();
            this.cbNtc5Inc.DataSource = ntcIncrementOptions.Clone();

            gbTemperatura.Enabled = false;

            #endregion


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
                name1txt.Enabled = true;
                I1min.Enabled = true;
                I1max.Enabled = true;
                CbInc1.Enabled = true;
                Ntc1.Enabled = true;
                ValidateInputs();
            }

            else
            {
                name1txt.Enabled = false;
                I1min.Enabled = false;
                I1max.Enabled = false;
                CbInc1.Enabled = false;
                Ntc1.Enabled = false;
                ValidateInputs();
            }
        }

        private void checkLaser2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser2.Checked)
            {
                name2txt.Enabled = true;
                I2min.Enabled = true;
                I2max.Enabled = true;
                CbInc2.Enabled = true;
                Ntc2.Enabled = true;
                ValidateInputs();
            }

            else
            {
                name2txt.Enabled = false;
                I2min.Enabled = false;
                I2max.Enabled = false;
                CbInc2.Enabled = false;
                Ntc2.Enabled = false;
                ValidateInputs();
            }
        }

        private void checkLaser3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser3.Checked)
            {
                name3txt.Enabled = true;
                I3min.Enabled = true;
                I3max.Enabled = true;
                CbInc3.Enabled = true;
                Ntc3.Enabled = true;
                ValidateInputs();
            }

            else
            {
                name3txt.Enabled = false;
                I3min.Enabled = false;
                I3max.Enabled = false;
                CbInc3.Enabled = false;
                Ntc3.Enabled = false;
                ValidateInputs();
            }
        }

        private void checkLaser4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser4.Checked)
            {
                name4txt.Enabled = true;
                I4min.Enabled = true;
                I4max.Enabled = true;
                CbInc4.Enabled = true;
                Ntc4.Enabled = true;
                ValidateInputs();
            }

            else
            {
                name4txt.Enabled = false;
                I4min.Enabled = false;
                I4max.Enabled = false;
                CbInc4.Enabled = false;   
                Ntc4.Enabled = false;
                ValidateInputs();
            }
        }

        private void checkLaser5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLaser5.Checked)
            {
                name5txt.Enabled = true;
                I5min.Enabled = true;
                I5max.Enabled = true;
                CbInc5.Enabled = true;
                Ntc5.Enabled = true;
                ValidateInputs();
            }

            else
            {
                name5txt.Enabled = false;
                I5min.Enabled = false;
                I5max.Enabled = false;
                CbInc5.Enabled = false;
                Ntc5.Enabled = false;
                ValidateInputs();
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
            experiment.Run();
            if (this.operationMode == OperationMode.Current)
            { 
                if (checkLaser1.Checked)
                {
                    currentLaser = 0;

                    LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
                    laser1ConfigRequest.Name = name1txt.Text;
                    laser1ConfigRequest.ID = 1;
                    laser1ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I1min.Text);
                    laser1ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I1max.Text);

                    CbInc1.Invoke((Action)delegate
                    {
                        laser1ConfigRequest.Increment = ConversionUtils.GetConvertedTemperatureFromFloatString(CbInc1.SelectedValue.ToString());
                    });

                    laser1ConfigRequest.NTC = Convert.ToInt16(Ntc1.Text);
                    var temp = laser1ConfigRequest.ConvertedTemperature;
                    txtTempFinal1.Invoke((Action)delegate
                    {

                        txtTempFinal1.Text = temp.ToString("0.0#");

                    });

                    experiment.lasers[0].Name = laser1ConfigRequest.Name;
                    experiment.lasers[0].ID = 1; //It is the laser ID
                    experiment.lasers[0].Current = laser1ConfigRequest.MinPowerCurrent; //min value of current
                    experiment.lasers[0].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;//max value of current
                    experiment.lasers[0].NTC = laser1ConfigRequest.NTC; //target temperature
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
                    laser2ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I2min.Text);
                    laser2ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I2max.Text);
                    laser2ConfigRequest.NTC = Convert.ToInt16(Ntc2.Text);
                    var temp = laser2ConfigRequest.ConvertedTemperature;

                    CbInc2.Invoke((Action)delegate
                    {
                        laser2ConfigRequest.Increment = ConversionUtils.GetConvertedTemperatureFromFloatString(CbInc2.SelectedValue.ToString());
                    });

                    txtTempFinal2.Invoke((Action)delegate
                    {

                        txtTempFinal2.Text = temp.ToString("0.0#");

                    });

                    experiment.lasers[1].Name = laser2ConfigRequest.Name;
                    experiment.lasers[1].ID = 2;
                    experiment.lasers[1].Current = laser2ConfigRequest.MinPowerCurrent;
                    experiment.lasers[1].DesiredCurrent = laser2ConfigRequest.MaxPowerCurrent;
                    experiment.lasers[1].NTC = laser2ConfigRequest.NTC;
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
                    laser3ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I3min.Text);
                    laser3ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I3max.Text);
                    laser3ConfigRequest.NTC = Convert.ToInt16(Ntc3.Text);
                    var temp = laser3ConfigRequest.ConvertedTemperature;

                    CbInc3.Invoke((Action)delegate
                    {
                        laser3ConfigRequest.Increment = ConversionUtils.GetConvertedTemperatureFromFloatString(CbInc3.SelectedValue.ToString());
                    });
                    txtTempFinal3.Invoke((Action)delegate
                    {

                        txtTempFinal3.Text = temp.ToString("0.0#");

                    });

                    experiment.lasers[2].Name = laser3ConfigRequest.Name;
                    experiment.lasers[2].ID = 3;
                    experiment.lasers[2].Current = laser3ConfigRequest.MinPowerCurrent;
                    experiment.lasers[2].DesiredCurrent = laser3ConfigRequest.MaxPowerCurrent;
                    experiment.lasers[2].NTC = laser3ConfigRequest.NTC;
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
                    laser4ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I4min.Text);
                    laser4ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I4max.Text);
                    laser4ConfigRequest.NTC = Convert.ToInt16(Ntc4.Text);
                    var temp = laser4ConfigRequest.ConvertedTemperature;

                    CbInc4.Invoke((Action)delegate
                    {
                        laser4ConfigRequest.Increment = ConversionUtils.GetConvertedTemperatureFromFloatString(CbInc4.SelectedValue.ToString());
                    });
                    txtTempFinal4.Invoke((Action)delegate
                    {

                        txtTempFinal4.Text = temp.ToString("0.0#");

                    });

                    experiment.lasers[3].Name = laser4ConfigRequest.Name;
                    experiment.lasers[3].ID = 4;
                    experiment.lasers[3].Current = laser4ConfigRequest.MinPowerCurrent;
                    experiment.lasers[3].DesiredCurrent = laser4ConfigRequest.MaxPowerCurrent;
                    experiment.lasers[3].NTC = laser4ConfigRequest.NTC;
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
                    laser5ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I5min.Text);
                    laser5ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(I5max.Text);
                    laser5ConfigRequest.NTC = Convert.ToInt16(Ntc5.Text);
                    var temp = laser5ConfigRequest.ConvertedTemperature;

                    CbInc5.Invoke((Action)delegate
                    {
                        laser5ConfigRequest.Increment = ConversionUtils.GetConvertedTemperatureFromFloatString(CbInc5.SelectedValue.ToString());
                    });

                    txtTempFinal5.Invoke((Action)delegate
                    {
                        txtTempFinal5.Text = temp.ToString("0.0#");

                    });

                    experiment.lasers[4].Name = laser5ConfigRequest.Name;
                    experiment.lasers[4].ID = 5;
                    experiment.lasers[4].Current = laser5ConfigRequest.MinPowerCurrent;
                    experiment.lasers[4].DesiredCurrent = laser5ConfigRequest.MaxPowerCurrent;
                    experiment.lasers[4].NTC = laser5ConfigRequest.NTC;
                    experiment.lasers[4].InitialRequest = laser5ConfigRequest;

                    byte[] dataToSend = laser5ConfigRequest.GetByteArray();
                    SendUSBData(dataToSend);
                    experiment.lasers[4].ProcessFinishedEvent.WaitOne();
                }


               

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
            else
            {
                //TO BE TESTED!! DO NOT MIX OPERATION MODE!!!!!!
                if (checkLaser1Temp.Checked)
                {
                    currentLaser = 0;
                    #region Uncomment if needed
                    //LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
                    //laser1ConfigRequest.Name = tname1txt.Text;
                    //laser1ConfigRequest.ID = 1;
                    //laser1ConfigRequest.MinNtc = Convert.ToInt16(Ntc1Min.Text);
                    //laser1ConfigRequest.MaxNtc = Convert.ToInt16(Ntc1max.Text);
                    //laser1ConfigRequest.NTC = Convert.ToInt16(Ntc1Min.Text);
                    //laser1ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(Iop1.Text);
                    //laser1ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(Iop1.Text);

                    //cbNtc1Inc.Invoke((Action)delegate
                    //{
                    //    laser1ConfigRequest.NtcIncrement = Convert.ToInt16(cbNtc1Inc.SelectedValue.ToString());
                    //});

                    //var temp = laser1ConfigRequest.ConvertedTemperature;

                    //experiment.lasers[0].Name = laser1ConfigRequest.Name;
                    //experiment.lasers[0].ID = 1; //It is the laser ID
                    //experiment.lasers[0].Current = laser1ConfigRequest.MinPowerCurrent; //min value of current
                    //experiment.lasers[0].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;//max value of current
                    //experiment.lasers[0].NTC = laser1ConfigRequest.NTC; //target temperature
                    //experiment.lasers[0].InitialRequest = laser1ConfigRequest;//Saving first request to storage on specified laser

                    //byte[] dataToSend = laser1ConfigRequest.GetByteArray();//Get byte array that represents config request that will be sent to laser
                    //SendUSBData(dataToSend);//Sending data to laser1
                    //experiment.lasers[0].ProcessFinishedEvent.WaitOne();//Lock program and wait for "singal" to continue
                    #endregion

                    SendInitialDataToLaser(currentLaser, tname1txt, Ntc1Min, Ntc1max, Iop1, cbNtc1Inc);
                }
                if (checkLaser2Temp.Checked)
                {
                    currentLaser = 1;
                 
                    SendInitialDataToLaser(currentLaser, tname2txt, Ntc2Min, Ntc2max, Iop2, cbNtc2Inc);
                }
                if (checkLaser3Temp.Checked)
                {
                    currentLaser = 2;

                    SendInitialDataToLaser(currentLaser, tname3txt, Ntc3Min, Ntc3max, Iop3, cbNtc3Inc);
                }
                if (checkLaser4Temp.Checked)
                {
                    currentLaser = 3;

                    SendInitialDataToLaser(currentLaser, tname4txt, Ntc4Min, Ntc4max, Iop4, cbNtc4Inc);
                }
                if (checkLaser5Temp.Checked)
                {
                    currentLaser = 4;

                    SendInitialDataToLaser(currentLaser, tname5txt, Ntc5Min, Ntc5max, Iop5, cbNtc5Inc);
                }
            }

            FinishExperiment();

        }

        private void OnLaserReportReceived(byte[] data)
        {
            LaserReport report = new LaserReport();

            report.Parse(data);//fill the properties with received data from USB
            if (operationMode == OperationMode.Current)
            {
                if (currentLaser >= 0 && currentLaser < experiment.lasers.Count)//Check if it is a valid laser
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
            else
            {
                if (currentLaser >= 0 && currentLaser < experiment.lasers.Count)//Check if it is a valid laser
                {
                    experiment.lasers[currentLaser].reports.Add(report);//Save report from usb
                    experiment.lasers[currentLaser].NTC += experiment.lasers[currentLaser].InitialRequest.NtcIncrement;//set current using last report + Ntc increment

                    if (experiment.lasers[currentLaser].NTC <= experiment.lasers[currentLaser].InitialRequest.MaxNtc)//check if the program needs resent a new config with incremented value of Ntc current
                    {
                        LaserConfigRequest updateRequest = new LaserConfigRequest();// new config that will be 

                        updateRequest = experiment.lasers[currentLaser].InitialRequest;//get all informations from first request
                        updateRequest.NTC = Convert.ToInt16(experiment.lasers[currentLaser].NTC);//update just the NTC value
                        SendUSBData(updateRequest.GetByteArray());// sending updated config
                    }
                    else
                    {
                        experiment.lasers[currentLaser].ProcessFinishedEvent.Set();// Unlock the current laser process
                    }
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
                                report.NTCreal,
                                report.Current,
                                report.SgnIn,
                                report.SgnOut,
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
            OnLaserReportReceived(new byte[] { 0x00, 0x01, 0x18, 0x00, 0x3a, 0x09, 0x01, 0x01, 0x00 });//Just to test   
        }

        private void Parar_Click(object sender, EventArgs e)
        {
            experiment.EraseData();
            experiment.Stop();
        }

        private void ValidateInputs()
        {
            List<bool> activeValidations = new List<bool>();

            if(operationMode == OperationMode.Current)
            {
                if (checkLaser1.Checked) 
                { 
                    var validateResult = FieldsValidationUtils.ValidateLaserFields(name1txt, I1min, I1max, CbInc1, Ntc1, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if(checkLaser2.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateLaserFields(name2txt, I2min, I2max, CbInc2, Ntc2, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser3.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateLaserFields(name3txt, I3min, I3max, CbInc3, Ntc3, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser4.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateLaserFields(name4txt, I4min, I4max, CbInc4, Ntc4, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser5.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateLaserFields(name5txt, I5min, I5max, CbInc5, Ntc5, errorProvider1);
                    activeValidations.Add(validateResult);
                }
            }
            else
            {
                if (checkLaser1Temp.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateTempeatureLaserFields(tname1txt, Ntc1Min, Ntc1max, cbNtc1Inc, Iop1, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser2Temp.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateTempeatureLaserFields(tname2txt, Ntc2Min, Ntc2max, cbNtc2Inc, Iop2, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser3Temp.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateTempeatureLaserFields(tname3txt, Ntc3Min, Ntc3max, cbNtc3Inc, Iop3, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser4Temp.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateTempeatureLaserFields(tname4txt, Ntc4Min, Ntc4max, cbNtc4Inc, Iop4, errorProvider1);
                    activeValidations.Add(validateResult);
                }
                if (checkLaser5Temp.Checked)
                {
                    var validateResult = FieldsValidationUtils.ValidateTempeatureLaserFields(tname5txt, Ntc5Min, Ntc5max, cbNtc5Inc, Iop5, errorProvider1);
                    activeValidations.Add(validateResult);
                }
            }

            var finResult = activeValidations.Contains(false);
            var result = !finResult && activeValidations.Count > 0;

            Iniciar.Enabled = result;

        }

        private void SwitchOperationMode()
        {
            this.operationMode = rbCorrente.Checked ? OperationMode.Current : OperationMode.Temperature;
            if (this.operationMode == OperationMode.Temperature)
            {
                checkLaser1.Checked = false;
                checkLaser2.Checked = false;
                checkLaser3.Checked = false;
                checkLaser4.Checked = false;
                checkLaser5.Checked = false;
            }
            else
            {
                checkLaser1Temp.Checked = false;
                checkLaser2Temp.Checked = false;
                checkLaser3Temp.Checked = false;
                checkLaser4Temp.Checked = false;
                checkLaser5Temp.Checked = false;
            }
        }

        private void rbTemperatura_CheckedChanged(object sender, EventArgs e)
        {
            this.gbTemperatura.Enabled = rbTemperatura.Checked;
            this.gbCorrente.Enabled = rbCorrente.Checked;
            SwitchOperationMode();
        }

        private void rbCorrente_CheckedChanged(object sender, EventArgs e)
        {
            this.gbCorrente.Enabled = rbCorrente.Checked;
            this.gbTemperatura.Enabled = rbTemperatura.Checked;
            SwitchOperationMode();
        }

        private void checkLaser1Temp_CheckedChanged(object sender, EventArgs e)
        {
            tname1txt.Enabled = checkLaser1Temp.Checked;
            Ntc1Min.Enabled = checkLaser1Temp.Checked;
            Ntc1max.Enabled = checkLaser1Temp.Checked;
            cbNtc1Inc.Enabled = checkLaser1Temp.Checked;
            Iop1.Enabled = checkLaser1Temp.Checked;
            ValidateInputs();
        }

        private void checkLaser2Temp_CheckedChanged(object sender, EventArgs e)
        {
            tname2txt.Enabled = checkLaser2Temp.Checked;
            Ntc2Min.Enabled = checkLaser2Temp.Checked;
            Ntc2max.Enabled = checkLaser2Temp.Checked;
            cbNtc2Inc.Enabled = checkLaser2Temp.Checked;
            Iop2.Enabled = checkLaser2Temp.Checked;
            ValidateInputs();
        }

        private void checkLaser3Temp_CheckedChanged(object sender, EventArgs e)
        {
            tname3txt.Enabled = checkLaser3Temp.Checked;
            Ntc3Min.Enabled = checkLaser3Temp.Checked;
            Ntc3max.Enabled = checkLaser3Temp.Checked;
            cbNtc3Inc.Enabled = checkLaser3Temp.Checked;
            Iop3.Enabled = checkLaser3Temp.Checked;
            ValidateInputs();
        }

        private void checkLaser4Temp_CheckedChanged(object sender, EventArgs e)
        {
            tname4txt.Enabled = checkLaser4Temp.Checked;
            Ntc4Min.Enabled = checkLaser4Temp.Checked;
            Ntc4max.Enabled = checkLaser4Temp.Checked;
            cbNtc4Inc.Enabled = checkLaser4Temp.Checked;
            Iop4.Enabled = checkLaser4Temp.Checked;
            ValidateInputs();
        }

        private void checkLaser5Temp_CheckedChanged(object sender, EventArgs e)
        {
            tname5txt.Enabled = checkLaser5Temp.Checked;
            Ntc5Min.Enabled = checkLaser5Temp.Checked;
            Ntc5max.Enabled = checkLaser5Temp.Checked;
            cbNtc5Inc.Enabled = checkLaser5Temp.Checked;
            Iop5.Enabled = checkLaser5Temp.Checked;
            ValidateInputs();
        }

        private void Input_ValueChanged(object sender, EventArgs e)
        {
            ValidateInputs();
            if(this.operationMode == OperationMode.Temperature)
            {
                UpdateDependetFields();
            }
        }

        private void cbNtc1Inc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Ntc1max.Text))
            {
                var ntcTemperature = Convert.ToInt16(Ntc1max.Text);
                var temperatureValue = ConversionUtils.ConvertNtcToTemperatureValue(ntcTemperature);
                this.txtTemp1Max.Text = temperatureValue.ToString();
            }
            else
            {
                txtTemp1Max.Text = string.Empty;
            }
        }

        private void UpdateDependetFields()
        {
            UpdateTemperatureField(Ntc1max, txtTemp1Max);
            UpdateTemperatureField(Ntc2max, txtTemp2Max);
            UpdateTemperatureField(Ntc3max, txtTemp3Max);
            UpdateTemperatureField(Ntc4max, txtTemp4Max);
            UpdateTemperatureField(Ntc5max, txtTemp5Max);
            UpdateTemperatureField(Ntc1Min, txtTemp1Min);
            UpdateTemperatureField(Ntc2Min, txtTemp2Min);
            UpdateTemperatureField(Ntc3Min, txtTemp3Min);
            UpdateTemperatureField(Ntc4Min, txtTemp4Min);
            UpdateTemperatureField(Ntc5Min, txtTemp5Min);
        }

        private void UpdateTemperatureField(Control control, Control dependetControl)
        {
            if (!string.IsNullOrEmpty(control.Text))
            {
                var ntcTemperature = Convert.ToInt64(control.Text);
                var temperatureValue = ConversionUtils.ConvertNtcToTemperatureValue(ntcTemperature);
                dependetControl.Text = temperatureValue.ToString("0.0#");
            }
            else
            {
                dependetControl.Text = string.Empty;
            }
        }

        private void FinishExperiment()
        {
            LaserConfigRequest finalConfigRequest = new LaserConfigRequest();
            SendUSBData(finalConfigRequest.GetByteArray());// sending last and empty message
            currentLaser = -1;// back to non existent laser
            MessageBox.Show("Finished All tests");
            Iniciar.Invoke(new Action(() =>
            {
                Iniciar.Enabled = true;
            }));

            Parar.Invoke(new Action(() =>
            {
                Parar.Enabled = false;
            }));
        }

        //Attempt to parametrize
        private void SendInitialDataToLaser(int laserIndex, Control laserName, Control ntcMin, Control ntcMax, Control Iop, ComboBox ntcIncrement)
        {
            LaserConfigRequest laser1ConfigRequest = new LaserConfigRequest();
            laser1ConfigRequest.Name = laserName.Text;
            laser1ConfigRequest.ID = laserIndex+ 1;
            laser1ConfigRequest.MinNtc = Convert.ToInt16(ntcMin.Text);
            laser1ConfigRequest.MaxNtc = Convert.ToInt16(ntcMax.Text);
            laser1ConfigRequest.NTC = Convert.ToInt16(ntcMin.Text);
            laser1ConfigRequest.MinPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(Iop.Text);
            laser1ConfigRequest.MaxPowerCurrent = ConversionUtils.GetConvertedTemperatureFromString(Iop.Text);

            cbNtc1Inc.Invoke((Action)delegate
            {
                laser1ConfigRequest.NtcIncrement = Convert.ToInt16(ntcIncrement.SelectedValue.ToString());
            });

            var temp = laser1ConfigRequest.ConvertedTemperature;

            experiment.lasers[laserIndex].Name = laser1ConfigRequest.Name;
            experiment.lasers[laserIndex].ID = laserIndex + 1; //It is the laser ID
            experiment.lasers[laserIndex].Current = laser1ConfigRequest.MinPowerCurrent; //min value of current
            experiment.lasers[laserIndex].DesiredCurrent = laser1ConfigRequest.MaxPowerCurrent;//max value of current
            experiment.lasers[laserIndex].NTC = laser1ConfigRequest.NTC; //target temperature
            experiment.lasers[laserIndex].InitialRequest = laser1ConfigRequest;//Saving first request to storage on specified laser

            byte[] dataToSend = laser1ConfigRequest.GetByteArray();//Get byte array that represents config request that will be sent to laser
            SendUSBData(dataToSend);//Sending data to laser1
            experiment.lasers[laserIndex].ProcessFinishedEvent.WaitOne();//Lock program and wait for "singal" to continue
        }
    }
}
