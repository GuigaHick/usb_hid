using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Objetos_de_tela_teste
{
    public partial class MainScreen : Form
    {
        string bfRecebe = string.Empty;

        /*Criando o método(função) Fdelegate que vai receber o parâmetro do tipo string 'a'*/
        public delegate void Fdelegate(string a);

        int qtde_data = 0;
        int q;
        int j;

        //Variável para a limpeza dos bytes que não serão utilizados no envio à USB
        byte clr_buffer;

        //Criação dos vetores com os parâmetros de configuração dos LASERS a serem enviados para o PIC via USB
        byte[] laser = new byte[32];

        List<string> TempList = new List<string>();

        string txtlist = string.Empty;

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
            //throw new NotImplementedException();
            string bfRecebe = "Dados: ";

            foreach (byte mydata in args.data)
            {
                if (mydata.ToString().Length == 1)
                    bfRecebe += "00";

                if (mydata.ToString().Length == 2)
                    bfRecebe += "0";

                bfRecebe += mydata.ToString() + " ";
            }

            this.BeginInvoke(new Fdelegate(Recebe_usb), new object[] { bfRecebe });//Maybe change to single call of method
        }

        public void Recebe_usb(string a)
        {
            label7.Text = a;
            string[] txtSplit;
            int adc0, adc4, v1;
            txtSplit = a.Split(' ');
            adc0 = (int)Convert.ToInt32(txtSplit[2]) << 8;
            adc0 += (int)Convert.ToInt32(txtSplit[3]);
            adc4 = (int)Convert.ToInt32(txtSplit[4]);
            v1 = (adc0 * 2048) / 1023;
            txtlist = "   " + string.Format("{0:00}", adc4) + "          "+ string.Format("{0:00}", laser[3]) + "         " + string.Format("{0:0000}", v1);
            TempList.Add(txtlist);
            qtde_data++;

            if (q<j)
            {
                q++;
                laser[3] = Convert.ToByte(laser[3] + laser[5]);
                Envia_USB();
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

        private void Envia_USB()
        {
            try
            {
                if (this.USBCom.SpecifiedDevice != null)
                {
                    USBCom.SpecifiedDevice.SendData(laser);
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
                laser[0] = 0x00;
                laser[1] = (byte)'L';
                laser[2] = (byte)'S';
                laser[3] = Convert.ToByte(I1min.Text);
                laser[4] = Convert.ToByte(I1max.Text);
                laser[5] = Convert.ToByte(Inc1.Text);
                laser[6] = Convert.ToByte(Temp1.Text);
                laser[7] = 0x01;
                laser[8] = 0x01;

                q = 0;
                j = (laser[4] - laser[3]) / laser[5];
    
                for (clr_buffer = 9; clr_buffer < 32; clr_buffer++) laser[clr_buffer] = 0;

                Envia_USB();             
            }

            if (checkLaser2.Checked)
            {
                laser[0] = 0x00;
                laser[1] = (byte)'L';
                laser[2] = (byte)'S';
                laser[3] = Convert.ToByte(I2min.Text);
                laser[4] = Convert.ToByte(I2max.Text);
                laser[5] = Convert.ToByte(Inc2.Text);
                laser[6] = Convert.ToByte(Temp2.Text);
                laser[7] = 0x02;
                laser[8] = 0x02;

                q = 0;
                j = (laser[4] - laser[3]) / laser[5];

                for (clr_buffer = 9; clr_buffer < 32; clr_buffer++) laser[clr_buffer] = 0;

                Envia_USB();
            }

            if (checkLaser3.Checked)
            {
                laser[0] = 0x00;
                laser[1] = (byte)'L';
                laser[2] = (byte)'S';
                laser[3] = Convert.ToByte(I3min.Text);
                laser[4] = Convert.ToByte(I3max.Text);
                laser[5] = Convert.ToByte(Inc3.Text);
                laser[6] = Convert.ToByte(Temp3.Text);
                laser[7] = 0x03;
                laser[8] = 0x03;

                q = 0;
                j = (laser[4] - laser[3]) / laser[5];

                for (clr_buffer = 9; clr_buffer < 32; clr_buffer++) laser[clr_buffer] = 0;

                Envia_USB();
            }

            if (checkLaser4.Checked)
            {
                laser[0] = 0x00;
                laser[1] = (byte)'L';
                laser[2] = (byte)'S';
                laser[3] = Convert.ToByte(I4min.Text);
                laser[4] = Convert.ToByte(I4max.Text);
                laser[5] = Convert.ToByte(Inc4.Text);
                laser[6] = Convert.ToByte(Temp4.Text);
                laser[7] = 0x04;
                laser[8] = 0x04;

                q = 0;
                j = (laser[4] - laser[3]) / laser[5];

                for (clr_buffer = 9; clr_buffer < 32; clr_buffer++) laser[clr_buffer] = 0;

                Envia_USB();
            }

            if (checkLaser5.Checked)
            {
                laser[0] = 0x00;
                laser[1] = (byte)'L';
                laser[2] = (byte)'S';
                laser[3] = Convert.ToByte(I5min.Text);
                laser[4] = Convert.ToByte(I5max.Text);
                laser[5] = Convert.ToByte(Inc5.Text);
                laser[6] = Convert.ToByte(Temp5.Text);
                laser[7] = 0x05;
                laser[8] = 0x05;

                q = 0;
                j = (laser[4] - laser[3]) / laser[5];

                for (clr_buffer = 9; clr_buffer < 32; clr_buffer++) laser[clr_buffer] = 0;

                Envia_USB();
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

                    for (int i = 0; i < qtde_data; i++)
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
