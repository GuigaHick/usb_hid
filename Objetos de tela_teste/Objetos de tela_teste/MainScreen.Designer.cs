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
            this.Temp1 = new System.Windows.Forms.MaskedTextBox();
            this.I2min = new System.Windows.Forms.MaskedTextBox();
            this.I2max = new System.Windows.Forms.MaskedTextBox();
            this.Inc2 = new System.Windows.Forms.MaskedTextBox();
            this.Temp2 = new System.Windows.Forms.MaskedTextBox();
            this.I3min = new System.Windows.Forms.MaskedTextBox();
            this.I3max = new System.Windows.Forms.MaskedTextBox();
            this.Inc3 = new System.Windows.Forms.MaskedTextBox();
            this.Temp3 = new System.Windows.Forms.MaskedTextBox();
            this.I4min = new System.Windows.Forms.MaskedTextBox();
            this.I4max = new System.Windows.Forms.MaskedTextBox();
            this.Inc4 = new System.Windows.Forms.MaskedTextBox();
            this.Temp4 = new System.Windows.Forms.MaskedTextBox();
            this.I5min = new System.Windows.Forms.MaskedTextBox();
            this.I5max = new System.Windows.Forms.MaskedTextBox();
            this.Inc5 = new System.Windows.Forms.MaskedTextBox();
            this.Temp5 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Parar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.USBCom = new UsbLibrary.UsbHidPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
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
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // SalvarToolStripMenuItem
            // 
            this.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem";
            this.SalvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalvarToolStripMenuItem.Text = "Salvar";
            this.SalvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "I mín. ( mA )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "I máx. ( mA )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inc. ( mA )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temp. ( ºC )";
            // 
            // checkLaser1
            // 
            this.checkLaser1.AutoSize = true;
            this.checkLaser1.Location = new System.Drawing.Point(11, 167);
            this.checkLaser1.Name = "checkLaser1";
            this.checkLaser1.Size = new System.Drawing.Size(70, 17);
            this.checkLaser1.TabIndex = 30;
            this.checkLaser1.Text = "LASER 1";
            this.checkLaser1.UseVisualStyleBackColor = true;
            this.checkLaser1.CheckedChanged += new System.EventHandler(this.checkLaser1_CheckedChanged);
            // 
            // checkLaser2
            // 
            this.checkLaser2.AutoSize = true;
            this.checkLaser2.Location = new System.Drawing.Point(11, 195);
            this.checkLaser2.Name = "checkLaser2";
            this.checkLaser2.Size = new System.Drawing.Size(70, 17);
            this.checkLaser2.TabIndex = 31;
            this.checkLaser2.Text = "LASER 2";
            this.checkLaser2.UseVisualStyleBackColor = true;
            this.checkLaser2.CheckedChanged += new System.EventHandler(this.checkLaser2_CheckedChanged);
            // 
            // checkLaser3
            // 
            this.checkLaser3.AutoSize = true;
            this.checkLaser3.Location = new System.Drawing.Point(11, 222);
            this.checkLaser3.Name = "checkLaser3";
            this.checkLaser3.Size = new System.Drawing.Size(70, 17);
            this.checkLaser3.TabIndex = 32;
            this.checkLaser3.Text = "LASER 3";
            this.checkLaser3.UseVisualStyleBackColor = true;
            this.checkLaser3.CheckedChanged += new System.EventHandler(this.checkLaser3_CheckedChanged);
            // 
            // checkLaser4
            // 
            this.checkLaser4.AutoSize = true;
            this.checkLaser4.Location = new System.Drawing.Point(11, 248);
            this.checkLaser4.Name = "checkLaser4";
            this.checkLaser4.Size = new System.Drawing.Size(70, 17);
            this.checkLaser4.TabIndex = 33;
            this.checkLaser4.Text = "LASER 4";
            this.checkLaser4.UseVisualStyleBackColor = true;
            this.checkLaser4.CheckedChanged += new System.EventHandler(this.checkLaser4_CheckedChanged);
            // 
            // checkLaser5
            // 
            this.checkLaser5.AutoSize = true;
            this.checkLaser5.Location = new System.Drawing.Point(11, 274);
            this.checkLaser5.Name = "checkLaser5";
            this.checkLaser5.Size = new System.Drawing.Size(70, 17);
            this.checkLaser5.TabIndex = 34;
            this.checkLaser5.Text = "LASER 5";
            this.checkLaser5.UseVisualStyleBackColor = true;
            this.checkLaser5.CheckedChanged += new System.EventHandler(this.checkLaser5_CheckedChanged);
            // 
            // I1min
            // 
            this.I1min.HidePromptOnLeave = true;
            this.I1min.Location = new System.Drawing.Point(87, 167);
            this.I1min.Mask = "000";
            this.I1min.Name = "I1min";
            this.I1min.Size = new System.Drawing.Size(80, 20);
            this.I1min.TabIndex = 35;
            this.I1min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I1min.ValidatingType = typeof(int);
            // 
            // I1max
            // 
            this.I1max.HidePromptOnLeave = true;
            this.I1max.Location = new System.Drawing.Point(193, 167);
            this.I1max.Mask = "000";
            this.I1max.Name = "I1max";
            this.I1max.Size = new System.Drawing.Size(80, 20);
            this.I1max.TabIndex = 36;
            this.I1max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I1max.ValidatingType = typeof(int);
            // 
            // Inc1
            // 
            this.Inc1.HidePromptOnLeave = true;
            this.Inc1.Location = new System.Drawing.Point(299, 167);
            this.Inc1.Mask = "000";
            this.Inc1.Name = "Inc1";
            this.Inc1.Size = new System.Drawing.Size(80, 20);
            this.Inc1.TabIndex = 37;
            this.Inc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc1.ValidatingType = typeof(int);
            // 
            // Temp1
            // 
            this.Temp1.HidePromptOnLeave = true;
            this.Temp1.Location = new System.Drawing.Point(405, 167);
            this.Temp1.Mask = "000";
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(80, 20);
            this.Temp1.TabIndex = 38;
            this.Temp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temp1.ValidatingType = typeof(int);
            // 
            // I2min
            // 
            this.I2min.HidePromptOnLeave = true;
            this.I2min.Location = new System.Drawing.Point(87, 193);
            this.I2min.Mask = "000";
            this.I2min.Name = "I2min";
            this.I2min.Size = new System.Drawing.Size(80, 20);
            this.I2min.TabIndex = 39;
            this.I2min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I2min.ValidatingType = typeof(int);
            // 
            // I2max
            // 
            this.I2max.HidePromptOnLeave = true;
            this.I2max.Location = new System.Drawing.Point(193, 193);
            this.I2max.Mask = "000";
            this.I2max.Name = "I2max";
            this.I2max.Size = new System.Drawing.Size(80, 20);
            this.I2max.TabIndex = 40;
            this.I2max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I2max.ValidatingType = typeof(int);
            // 
            // Inc2
            // 
            this.Inc2.HidePromptOnLeave = true;
            this.Inc2.Location = new System.Drawing.Point(299, 193);
            this.Inc2.Mask = "000";
            this.Inc2.Name = "Inc2";
            this.Inc2.Size = new System.Drawing.Size(80, 20);
            this.Inc2.TabIndex = 41;
            this.Inc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc2.ValidatingType = typeof(int);
            // 
            // Temp2
            // 
            this.Temp2.HidePromptOnLeave = true;
            this.Temp2.Location = new System.Drawing.Point(405, 193);
            this.Temp2.Mask = "000";
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(80, 20);
            this.Temp2.TabIndex = 42;
            this.Temp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temp2.ValidatingType = typeof(int);
            // 
            // I3min
            // 
            this.I3min.HidePromptOnLeave = true;
            this.I3min.Location = new System.Drawing.Point(87, 219);
            this.I3min.Mask = "000";
            this.I3min.Name = "I3min";
            this.I3min.Size = new System.Drawing.Size(80, 20);
            this.I3min.TabIndex = 43;
            this.I3min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I3min.ValidatingType = typeof(int);
            // 
            // I3max
            // 
            this.I3max.HidePromptOnLeave = true;
            this.I3max.Location = new System.Drawing.Point(193, 219);
            this.I3max.Mask = "000";
            this.I3max.Name = "I3max";
            this.I3max.Size = new System.Drawing.Size(80, 20);
            this.I3max.TabIndex = 44;
            this.I3max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I3max.ValidatingType = typeof(int);
            // 
            // Inc3
            // 
            this.Inc3.HidePromptOnLeave = true;
            this.Inc3.Location = new System.Drawing.Point(299, 219);
            this.Inc3.Mask = "000";
            this.Inc3.Name = "Inc3";
            this.Inc3.Size = new System.Drawing.Size(80, 20);
            this.Inc3.TabIndex = 45;
            this.Inc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc3.ValidatingType = typeof(int);
            // 
            // Temp3
            // 
            this.Temp3.HidePromptOnLeave = true;
            this.Temp3.Location = new System.Drawing.Point(405, 219);
            this.Temp3.Mask = "000";
            this.Temp3.Name = "Temp3";
            this.Temp3.Size = new System.Drawing.Size(80, 20);
            this.Temp3.TabIndex = 46;
            this.Temp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temp3.ValidatingType = typeof(int);
            // 
            // I4min
            // 
            this.I4min.HidePromptOnLeave = true;
            this.I4min.Location = new System.Drawing.Point(87, 245);
            this.I4min.Mask = "000";
            this.I4min.Name = "I4min";
            this.I4min.Size = new System.Drawing.Size(80, 20);
            this.I4min.TabIndex = 47;
            this.I4min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I4min.ValidatingType = typeof(int);
            // 
            // I4max
            // 
            this.I4max.HidePromptOnLeave = true;
            this.I4max.Location = new System.Drawing.Point(193, 245);
            this.I4max.Mask = "000";
            this.I4max.Name = "I4max";
            this.I4max.Size = new System.Drawing.Size(80, 20);
            this.I4max.TabIndex = 48;
            this.I4max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I4max.ValidatingType = typeof(int);
            // 
            // Inc4
            // 
            this.Inc4.HidePromptOnLeave = true;
            this.Inc4.Location = new System.Drawing.Point(299, 245);
            this.Inc4.Mask = "000";
            this.Inc4.Name = "Inc4";
            this.Inc4.Size = new System.Drawing.Size(80, 20);
            this.Inc4.TabIndex = 49;
            this.Inc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc4.ValidatingType = typeof(int);
            // 
            // Temp4
            // 
            this.Temp4.HidePromptOnLeave = true;
            this.Temp4.Location = new System.Drawing.Point(405, 245);
            this.Temp4.Mask = "000";
            this.Temp4.Name = "Temp4";
            this.Temp4.Size = new System.Drawing.Size(80, 20);
            this.Temp4.TabIndex = 50;
            this.Temp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temp4.ValidatingType = typeof(int);
            // 
            // I5min
            // 
            this.I5min.HidePromptOnLeave = true;
            this.I5min.Location = new System.Drawing.Point(87, 271);
            this.I5min.Mask = "000";
            this.I5min.Name = "I5min";
            this.I5min.Size = new System.Drawing.Size(80, 20);
            this.I5min.TabIndex = 51;
            this.I5min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I5min.ValidatingType = typeof(int);
            // 
            // I5max
            // 
            this.I5max.HidePromptOnLeave = true;
            this.I5max.Location = new System.Drawing.Point(193, 271);
            this.I5max.Mask = "000";
            this.I5max.Name = "I5max";
            this.I5max.Size = new System.Drawing.Size(80, 20);
            this.I5max.TabIndex = 52;
            this.I5max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.I5max.ValidatingType = typeof(int);
            // 
            // Inc5
            // 
            this.Inc5.HidePromptOnLeave = true;
            this.Inc5.Location = new System.Drawing.Point(299, 271);
            this.Inc5.Mask = "000";
            this.Inc5.Name = "Inc5";
            this.Inc5.Size = new System.Drawing.Size(80, 20);
            this.Inc5.TabIndex = 53;
            this.Inc5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Inc5.ValidatingType = typeof(int);
            // 
            // Temp5
            // 
            this.Temp5.HidePromptOnLeave = true;
            this.Temp5.Location = new System.Drawing.Point(405, 271);
            this.Temp5.Mask = "000";
            this.Temp5.Name = "Temp5";
            this.Temp5.Size = new System.Drawing.Size(80, 20);
            this.Temp5.TabIndex = 54;
            this.Temp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Temp5.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "Configuração dos Lasers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ativação das Células";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(144, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 35);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "1";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(180, 379);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(20, 35);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(216, 379);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(20, 35);
            this.checkBox3.TabIndex = 59;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(252, 379);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(20, 35);
            this.checkBox4.TabIndex = 60;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(288, 379);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(20, 35);
            this.checkBox5.TabIndex = 64;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(324, 379);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(20, 35);
            this.checkBox6.TabIndex = 63;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(360, 379);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(20, 35);
            this.checkBox7.TabIndex = 62;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(396, 379);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(20, 35);
            this.checkBox8.TabIndex = 61;
            this.checkBox8.Text = "8";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(545, 167);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(75, 23);
            this.Iniciar.TabIndex = 65;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(545, 216);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(75, 23);
            this.Parar.TabIndex = 66;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(199, 15);
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog1.Title = "Salvar Arquivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Dados: 000 000 000 000 000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 538);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Temp5);
            this.Controls.Add(this.Inc5);
            this.Controls.Add(this.I5max);
            this.Controls.Add(this.I5min);
            this.Controls.Add(this.Temp4);
            this.Controls.Add(this.Inc4);
            this.Controls.Add(this.I4max);
            this.Controls.Add(this.I4min);
            this.Controls.Add(this.Temp3);
            this.Controls.Add(this.Inc3);
            this.Controls.Add(this.I3max);
            this.Controls.Add(this.I3min);
            this.Controls.Add(this.Temp2);
            this.Controls.Add(this.Inc2);
            this.Controls.Add(this.I2max);
            this.Controls.Add(this.I2min);
            this.Controls.Add(this.Temp1);
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
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MCA Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox Temp1;
        private System.Windows.Forms.MaskedTextBox I2min;
        private System.Windows.Forms.MaskedTextBox I2max;
        private System.Windows.Forms.MaskedTextBox Inc2;
        private System.Windows.Forms.MaskedTextBox Temp2;
        private System.Windows.Forms.MaskedTextBox I3min;
        private System.Windows.Forms.MaskedTextBox I3max;
        private System.Windows.Forms.MaskedTextBox Inc3;
        private System.Windows.Forms.MaskedTextBox Temp3;
        private System.Windows.Forms.MaskedTextBox I4min;
        private System.Windows.Forms.MaskedTextBox I4max;
        private System.Windows.Forms.MaskedTextBox Inc4;
        private System.Windows.Forms.MaskedTextBox Temp4;
        private System.Windows.Forms.MaskedTextBox I5min;
        private System.Windows.Forms.MaskedTextBox I5max;
        private System.Windows.Forms.MaskedTextBox Inc5;
        private System.Windows.Forms.MaskedTextBox Temp5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private UsbLibrary.UsbHidPort USBCom;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label7;
    }
}

