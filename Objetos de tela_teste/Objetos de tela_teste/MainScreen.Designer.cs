namespace Objetos_de_tela_teste
{
    partial class MainScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkLaser1 = new System.Windows.Forms.CheckBox();
            this.checkLaser2 = new System.Windows.Forms.CheckBox();
            this.checkLaser3 = new System.Windows.Forms.CheckBox();
            this.checkLaser4 = new System.Windows.Forms.CheckBox();
            this.checkLaser5 = new System.Windows.Forms.CheckBox();
            this.I1min = new System.Windows.Forms.MaskedTextBox();
            this.I1max = new System.Windows.Forms.MaskedTextBox();
            this.Inc1 = new System.Windows.Forms.MaskedTextBox();
            this.Ntc1 = new System.Windows.Forms.MaskedTextBox();
            this.I2min = new System.Windows.Forms.MaskedTextBox();
            this.I2max = new System.Windows.Forms.MaskedTextBox();
            this.Inc2 = new System.Windows.Forms.MaskedTextBox();
            this.Ntc2 = new System.Windows.Forms.MaskedTextBox();
            this.I3min = new System.Windows.Forms.MaskedTextBox();
            this.I3max = new System.Windows.Forms.MaskedTextBox();
            this.Inc3 = new System.Windows.Forms.MaskedTextBox();
            this.Ntc3 = new System.Windows.Forms.MaskedTextBox();
            this.I4min = new System.Windows.Forms.MaskedTextBox();
            this.I4max = new System.Windows.Forms.MaskedTextBox();
            this.Inc4 = new System.Windows.Forms.MaskedTextBox();
            this.Ntc4 = new System.Windows.Forms.MaskedTextBox();
            this.I5min = new System.Windows.Forms.MaskedTextBox();
            this.I5max = new System.Windows.Forms.MaskedTextBox();
            this.Inc5 = new System.Windows.Forms.MaskedTextBox();
            this.Ntc5 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.USBCom = new UsbLibrary.UsbHidPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name5txt = new System.Windows.Forms.MaskedTextBox();
            this.name4txt = new System.Windows.Forms.MaskedTextBox();
            this.name3txt = new System.Windows.Forms.MaskedTextBox();
            this.name2txt = new System.Windows.Forms.MaskedTextBox();
            this.name1txt = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTempFinal1 = new System.Windows.Forms.TextBox();
            this.txtTempFinal2 = new System.Windows.Forms.TextBox();
            this.txtTempFinal3 = new System.Windows.Forms.TextBox();
            this.txtTempFinal4 = new System.Windows.Forms.TextBox();
            this.txtTempFinal5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.toolStripSeparator1,
            this.SalvarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // SalvarToolStripMenuItem
            // 
            this.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem";
            this.SalvarToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.SalvarToolStripMenuItem.Text = "Salvar";
            this.SalvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "I mín. ( mA )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "I máx. ( mA )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inc. ( mA )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NTC. ( Ω )";
            // 
            // checkLaser1
            // 
            this.checkLaser1.AutoSize = true;
            this.checkLaser1.Location = new System.Drawing.Point(16, 257);
            this.checkLaser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLaser1.Name = "checkLaser1";
            this.checkLaser1.Size = new System.Drawing.Size(22, 21);
            this.checkLaser1.TabIndex = 30;
            this.checkLaser1.UseVisualStyleBackColor = true;
            this.checkLaser1.CheckedChanged += new System.EventHandler(this.checkLaser1_CheckedChanged);
            // 
            // checkLaser2
            // 
            this.checkLaser2.AutoSize = true;
            this.checkLaser2.Location = new System.Drawing.Point(16, 300);
            this.checkLaser2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLaser2.Name = "checkLaser2";
            this.checkLaser2.Size = new System.Drawing.Size(22, 21);
            this.checkLaser2.TabIndex = 31;
            this.checkLaser2.UseVisualStyleBackColor = true;
            this.checkLaser2.CheckedChanged += new System.EventHandler(this.checkLaser2_CheckedChanged);
            // 
            // checkLaser3
            // 
            this.checkLaser3.AutoSize = true;
            this.checkLaser3.Location = new System.Drawing.Point(16, 342);
            this.checkLaser3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLaser3.Name = "checkLaser3";
            this.checkLaser3.Size = new System.Drawing.Size(22, 21);
            this.checkLaser3.TabIndex = 32;
            this.checkLaser3.UseVisualStyleBackColor = true;
            this.checkLaser3.CheckedChanged += new System.EventHandler(this.checkLaser3_CheckedChanged);
            // 
            // checkLaser4
            // 
            this.checkLaser4.AutoSize = true;
            this.checkLaser4.Location = new System.Drawing.Point(16, 382);
            this.checkLaser4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLaser4.Name = "checkLaser4";
            this.checkLaser4.Size = new System.Drawing.Size(22, 21);
            this.checkLaser4.TabIndex = 33;
            this.checkLaser4.UseVisualStyleBackColor = true;
            this.checkLaser4.CheckedChanged += new System.EventHandler(this.checkLaser4_CheckedChanged);
            // 
            // checkLaser5
            // 
            this.checkLaser5.AutoSize = true;
            this.checkLaser5.Location = new System.Drawing.Point(16, 422);
            this.checkLaser5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLaser5.Name = "checkLaser5";
            this.checkLaser5.Size = new System.Drawing.Size(22, 21);
            this.checkLaser5.TabIndex = 34;
            this.checkLaser5.UseVisualStyleBackColor = true;
            this.checkLaser5.CheckedChanged += new System.EventHandler(this.checkLaser5_CheckedChanged);
            // 
            // I1min
            // 
            this.I1min.HidePromptOnLeave = true;
            this.I1min.Location = new System.Drawing.Point(358, 257);
            this.I1min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I1min.Mask = "000";
            this.I1min.Name = "I1min";
            this.I1min.Size = new System.Drawing.Size(75, 26);
            this.I1min.TabIndex = 35;
            this.I1min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I1min.ValidatingType = typeof(int);
            // 
            // I1max
            // 
            this.I1max.HidePromptOnLeave = true;
            this.I1max.Location = new System.Drawing.Point(477, 257);
            this.I1max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I1max.Mask = "000";
            this.I1max.Name = "I1max";
            this.I1max.Size = new System.Drawing.Size(73, 26);
            this.I1max.TabIndex = 36;
            this.I1max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I1max.ValidatingType = typeof(int);
            // 
            // Inc1
            // 
            this.Inc1.HidePromptOnLeave = true;
            this.Inc1.Location = new System.Drawing.Point(590, 255);
            this.Inc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inc1.Mask = "000";
            this.Inc1.Name = "Inc1";
            this.Inc1.Size = new System.Drawing.Size(76, 26);
            this.Inc1.TabIndex = 37;
            this.Inc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.Inc1, "Increment Should be");
            this.Inc1.ValidatingType = typeof(int);
            // 
            // Temp1
            // 
            this.Ntc1.HidePromptOnLeave = true;
            this.Ntc1.Location = new System.Drawing.Point(699, 257);
            this.Ntc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntc1.Mask = "00000";
            this.Ntc1.Name = "Temp1";
            this.Ntc1.Size = new System.Drawing.Size(78, 26);
            this.Ntc1.TabIndex = 38;
            this.Ntc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.Ntc1, "Valores Permitidos de 4000 a 10000");
            this.Ntc1.ValidatingType = typeof(int);
            // 
            // I2min
            // 
            this.I2min.HidePromptOnLeave = true;
            this.I2min.Location = new System.Drawing.Point(358, 299);
            this.I2min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I2min.Mask = "000";
            this.I2min.Name = "I2min";
            this.I2min.Size = new System.Drawing.Size(75, 26);
            this.I2min.TabIndex = 39;
            this.I2min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I2min.ValidatingType = typeof(int);
            // 
            // I2max
            // 
            this.I2max.HidePromptOnLeave = true;
            this.I2max.Location = new System.Drawing.Point(477, 297);
            this.I2max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I2max.Mask = "000";
            this.I2max.Name = "I2max";
            this.I2max.Size = new System.Drawing.Size(73, 26);
            this.I2max.TabIndex = 40;
            this.I2max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I2max.ValidatingType = typeof(int);
            // 
            // Inc2
            // 
            this.Inc2.HidePromptOnLeave = true;
            this.Inc2.Location = new System.Drawing.Point(590, 295);
            this.Inc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inc2.Mask = "000";
            this.Inc2.Name = "Inc2";
            this.Inc2.Size = new System.Drawing.Size(76, 26);
            this.Inc2.TabIndex = 41;
            this.Inc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc2.ValidatingType = typeof(int);
            // 
            // Temp2
            // 
            this.Ntc2.HidePromptOnLeave = true;
            this.Ntc2.Location = new System.Drawing.Point(699, 297);
            this.Ntc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntc2.Mask = "000";
            this.Ntc2.Name = "Temp2";
            this.Ntc2.Size = new System.Drawing.Size(78, 26);
            this.Ntc2.TabIndex = 42;
            this.Ntc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ntc2.ValidatingType = typeof(int);
            // 
            // I3min
            // 
            this.I3min.HidePromptOnLeave = true;
            this.I3min.Location = new System.Drawing.Point(358, 339);
            this.I3min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I3min.Mask = "000";
            this.I3min.Name = "I3min";
            this.I3min.Size = new System.Drawing.Size(75, 26);
            this.I3min.TabIndex = 43;
            this.I3min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I3min.ValidatingType = typeof(int);
            // 
            // I3max
            // 
            this.I3max.HidePromptOnLeave = true;
            this.I3max.Location = new System.Drawing.Point(477, 337);
            this.I3max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I3max.Mask = "000";
            this.I3max.Name = "I3max";
            this.I3max.Size = new System.Drawing.Size(73, 26);
            this.I3max.TabIndex = 44;
            this.I3max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I3max.ValidatingType = typeof(int);
            // 
            // Inc3
            // 
            this.Inc3.HidePromptOnLeave = true;
            this.Inc3.Location = new System.Drawing.Point(590, 335);
            this.Inc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inc3.Mask = "000";
            this.Inc3.Name = "Inc3";
            this.Inc3.Size = new System.Drawing.Size(76, 26);
            this.Inc3.TabIndex = 45;
            this.Inc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc3.ValidatingType = typeof(int);
            // 
            // Temp3
            // 
            this.Ntc3.HidePromptOnLeave = true;
            this.Ntc3.Location = new System.Drawing.Point(699, 337);
            this.Ntc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntc3.Mask = "000";
            this.Ntc3.Name = "Temp3";
            this.Ntc3.Size = new System.Drawing.Size(78, 26);
            this.Ntc3.TabIndex = 46;
            this.Ntc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ntc3.ValidatingType = typeof(int);
            // 
            // I4min
            // 
            this.I4min.HidePromptOnLeave = true;
            this.I4min.Location = new System.Drawing.Point(358, 379);
            this.I4min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I4min.Mask = "000";
            this.I4min.Name = "I4min";
            this.I4min.Size = new System.Drawing.Size(75, 26);
            this.I4min.TabIndex = 47;
            this.I4min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I4min.ValidatingType = typeof(int);
            // 
            // I4max
            // 
            this.I4max.HidePromptOnLeave = true;
            this.I4max.Location = new System.Drawing.Point(477, 377);
            this.I4max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I4max.Mask = "000";
            this.I4max.Name = "I4max";
            this.I4max.Size = new System.Drawing.Size(73, 26);
            this.I4max.TabIndex = 48;
            this.I4max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I4max.ValidatingType = typeof(int);
            // 
            // Inc4
            // 
            this.Inc4.HidePromptOnLeave = true;
            this.Inc4.Location = new System.Drawing.Point(590, 375);
            this.Inc4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inc4.Mask = "000";
            this.Inc4.Name = "Inc4";
            this.Inc4.Size = new System.Drawing.Size(76, 26);
            this.Inc4.TabIndex = 49;
            this.Inc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc4.ValidatingType = typeof(int);
            // 
            // Temp4
            // 
            this.Ntc4.HidePromptOnLeave = true;
            this.Ntc4.Location = new System.Drawing.Point(699, 377);
            this.Ntc4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntc4.Mask = "000";
            this.Ntc4.Name = "Temp4";
            this.Ntc4.Size = new System.Drawing.Size(78, 26);
            this.Ntc4.TabIndex = 50;
            this.Ntc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ntc4.ValidatingType = typeof(int);
            // 
            // I5min
            // 
            this.I5min.HidePromptOnLeave = true;
            this.I5min.Location = new System.Drawing.Point(358, 419);
            this.I5min.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I5min.Mask = "000";
            this.I5min.Name = "I5min";
            this.I5min.Size = new System.Drawing.Size(75, 26);
            this.I5min.TabIndex = 51;
            this.I5min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I5min.ValidatingType = typeof(int);
            // 
            // I5max
            // 
            this.I5max.HidePromptOnLeave = true;
            this.I5max.Location = new System.Drawing.Point(477, 417);
            this.I5max.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.I5max.Mask = "000";
            this.I5max.Name = "I5max";
            this.I5max.Size = new System.Drawing.Size(73, 26);
            this.I5max.TabIndex = 52;
            this.I5max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I5max.ValidatingType = typeof(int);
            // 
            // Inc5
            // 
            this.Inc5.HidePromptOnLeave = true;
            this.Inc5.Location = new System.Drawing.Point(590, 415);
            this.Inc5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inc5.Mask = "000";
            this.Inc5.Name = "Inc5";
            this.Inc5.Size = new System.Drawing.Size(76, 26);
            this.Inc5.TabIndex = 53;
            this.Inc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc5.ValidatingType = typeof(int);
            // 
            // Temp5
            // 
            this.Ntc5.HidePromptOnLeave = true;
            this.Ntc5.Location = new System.Drawing.Point(699, 417);
            this.Ntc5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntc5.Mask = "000";
            this.Ntc5.Name = "Temp5";
            this.Ntc5.Size = new System.Drawing.Size(78, 26);
            this.Ntc5.TabIndex = 54;
            this.Ntc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ntc5.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 37);
            this.label5.TabIndex = 55;
            this.label5.Text = "Configuração dos Lasers";
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(957, 257);
            this.Iniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(112, 35);
            this.Iniciar.TabIndex = 65;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Parar
            // 
            this.Parar.Enabled = false;
            this.Parar.Location = new System.Drawing.Point(957, 339);
            this.Parar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(112, 35);
            this.Parar.TabIndex = 66;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(270, 666);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(298, 23);
            this.progressBar1.TabIndex = 67;
            // 
            // USBCom
            // 
            this.USBCom.ProductId = 0;
            this.USBCom.VendorId = 0;
            this.USBCom.OnSpecifiedDeviceArrived += new System.EventHandler(this.USBCom_OnSpecifiedDeviceArrived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 796);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1152, 32);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Salvar Arquivo";
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(16, 481);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(75, 23);
            this.btnIncrement.TabIndex = 69;
            this.btnIncrement.Text = "button1";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Nome do Laser";
            // 
            // name5txt
            // 
            this.name5txt.Enabled = false;
            this.name5txt.HidePromptOnLeave = true;
            this.name5txt.Location = new System.Drawing.Point(54, 417);
            this.name5txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name5txt.Name = "name5txt";
            this.name5txt.Size = new System.Drawing.Size(268, 26);
            this.name5txt.TabIndex = 71;
            this.name5txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name5txt.ValidatingType = typeof(int);
            // 
            // name4txt
            // 
            this.name4txt.Enabled = false;
            this.name4txt.HidePromptOnLeave = true;
            this.name4txt.Location = new System.Drawing.Point(54, 381);
            this.name4txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name4txt.Name = "name4txt";
            this.name4txt.Size = new System.Drawing.Size(268, 26);
            this.name4txt.TabIndex = 72;
            this.name4txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name4txt.ValidatingType = typeof(int);
            // 
            // name3txt
            // 
            this.name3txt.Enabled = false;
            this.name3txt.HidePromptOnLeave = true;
            this.name3txt.Location = new System.Drawing.Point(54, 335);
            this.name3txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name3txt.Name = "name3txt";
            this.name3txt.Size = new System.Drawing.Size(268, 26);
            this.name3txt.TabIndex = 73;
            this.name3txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name3txt.ValidatingType = typeof(int);
            // 
            // name2txt
            // 
            this.name2txt.Enabled = false;
            this.name2txt.HidePromptOnLeave = true;
            this.name2txt.Location = new System.Drawing.Point(54, 296);
            this.name2txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name2txt.Name = "name2txt";
            this.name2txt.Size = new System.Drawing.Size(268, 26);
            this.name2txt.TabIndex = 74;
            this.name2txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name2txt.ValidatingType = typeof(int);
            // 
            // name1txt
            // 
            this.name1txt.Enabled = false;
            this.name1txt.HidePromptOnLeave = true;
            this.name1txt.Location = new System.Drawing.Point(54, 257);
            this.name1txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name1txt.Name = "name1txt";
            this.name1txt.Size = new System.Drawing.Size(268, 26);
            this.name1txt.TabIndex = 75;
            this.name1txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name1txt.ValidatingType = typeof(int);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Range de Valores";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(784, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 77;
            this.button1.Text = "I";
            this.toolTip1.SetToolTip(this.button1, "Range de Valores: 4000 Ω-10000Ω");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(732, 101);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 76;
            this.numericUpDown1.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTempFinal1
            // 
            this.txtTempFinal1.Enabled = false;
            this.txtTempFinal1.Location = new System.Drawing.Point(794, 254);
            this.txtTempFinal1.Name = "txtTempFinal1";
            this.txtTempFinal1.Size = new System.Drawing.Size(100, 26);
            this.txtTempFinal1.TabIndex = 78;
            // 
            // txtTempFinal2
            // 
            this.txtTempFinal2.Enabled = false;
            this.txtTempFinal2.Location = new System.Drawing.Point(794, 300);
            this.txtTempFinal2.Name = "txtTempFinal2";
            this.txtTempFinal2.Size = new System.Drawing.Size(100, 26);
            this.txtTempFinal2.TabIndex = 79;
            // 
            // txtTempFinal3
            // 
            this.txtTempFinal3.Enabled = false;
            this.txtTempFinal3.Location = new System.Drawing.Point(794, 348);
            this.txtTempFinal3.Name = "txtTempFinal3";
            this.txtTempFinal3.Size = new System.Drawing.Size(100, 26);
            this.txtTempFinal3.TabIndex = 80;
            // 
            // txtTempFinal4
            // 
            this.txtTempFinal4.Enabled = false;
            this.txtTempFinal4.Location = new System.Drawing.Point(794, 382);
            this.txtTempFinal4.Name = "txtTempFinal4";
            this.txtTempFinal4.Size = new System.Drawing.Size(100, 26);
            this.txtTempFinal4.TabIndex = 81;
            // 
            // txtTempFinal5
            // 
            this.txtTempFinal5.Enabled = false;
            this.txtTempFinal5.Location = new System.Drawing.Point(794, 422);
            this.txtTempFinal5.Name = "txtTempFinal5";
            this.txtTempFinal5.Size = new System.Drawing.Size(100, 26);
            this.txtTempFinal5.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Temp(C°)";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 828);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTempFinal5);
            this.Controls.Add(this.txtTempFinal4);
            this.Controls.Add(this.txtTempFinal3);
            this.Controls.Add(this.txtTempFinal2);
            this.Controls.Add(this.txtTempFinal1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.name1txt);
            this.Controls.Add(this.name2txt);
            this.Controls.Add(this.name3txt);
            this.Controls.Add(this.name4txt);
            this.Controls.Add(this.name5txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ntc5);
            this.Controls.Add(this.Inc5);
            this.Controls.Add(this.I5max);
            this.Controls.Add(this.I5min);
            this.Controls.Add(this.Ntc4);
            this.Controls.Add(this.Inc4);
            this.Controls.Add(this.I4max);
            this.Controls.Add(this.I4min);
            this.Controls.Add(this.Ntc3);
            this.Controls.Add(this.Inc3);
            this.Controls.Add(this.I3max);
            this.Controls.Add(this.I3min);
            this.Controls.Add(this.Ntc2);
            this.Controls.Add(this.Inc2);
            this.Controls.Add(this.I2max);
            this.Controls.Add(this.I2min);
            this.Controls.Add(this.Ntc1);
            this.Controls.Add(this.Inc1);
            this.Controls.Add(this.I1max);
            this.Controls.Add(this.I1min);
            this.Controls.Add(this.checkLaser5);
            this.Controls.Add(this.checkLaser4);
            this.Controls.Add(this.checkLaser3);
            this.Controls.Add(this.checkLaser2);
            this.Controls.Add(this.checkLaser1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MCA Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;

        public bool TextBox1 { get; private set; }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkLaser1;
        private System.Windows.Forms.CheckBox checkLaser2;
        private System.Windows.Forms.CheckBox checkLaser3;
        private System.Windows.Forms.CheckBox checkLaser4;
        private System.Windows.Forms.CheckBox checkLaser5;
        private System.Windows.Forms.MaskedTextBox I1min;
        private System.Windows.Forms.MaskedTextBox I1max;
        private System.Windows.Forms.MaskedTextBox Inc1;
        private System.Windows.Forms.MaskedTextBox Ntc1;
        private System.Windows.Forms.MaskedTextBox I2min;
        private System.Windows.Forms.MaskedTextBox I2max;
        private System.Windows.Forms.MaskedTextBox Inc2;
        private System.Windows.Forms.MaskedTextBox Ntc2;
        private System.Windows.Forms.MaskedTextBox I3min;
        private System.Windows.Forms.MaskedTextBox I3max;
        private System.Windows.Forms.MaskedTextBox Inc3;
        private System.Windows.Forms.MaskedTextBox Ntc3;
        private System.Windows.Forms.MaskedTextBox I4min;
        private System.Windows.Forms.MaskedTextBox I4max;
        private System.Windows.Forms.MaskedTextBox Inc4;
        private System.Windows.Forms.MaskedTextBox Ntc4;
        private System.Windows.Forms.MaskedTextBox I5min;
        private System.Windows.Forms.MaskedTextBox I5max;
        private System.Windows.Forms.MaskedTextBox Inc5;
        private System.Windows.Forms.MaskedTextBox Ntc5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private UsbLibrary.UsbHidPort USBCom;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox name5txt;
        private System.Windows.Forms.MaskedTextBox name4txt;
        private System.Windows.Forms.MaskedTextBox name3txt;
        private System.Windows.Forms.MaskedTextBox name2txt;
        private System.Windows.Forms.MaskedTextBox name1txt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTempFinal1;
        private System.Windows.Forms.TextBox txtTempFinal2;
        private System.Windows.Forms.TextBox txtTempFinal3;
        private System.Windows.Forms.TextBox txtTempFinal4;
        private System.Windows.Forms.TextBox txtTempFinal5;
        private System.Windows.Forms.Label label7;
    }
}

