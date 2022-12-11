
namespace BFC_10000
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наборДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optdigitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mNISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tabHyperparameters = new System.Windows.Forms.TabPage();
            this.cbStrategy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEstimate_c = new System.Windows.Forms.Button();
            this.btnEstimate_Sigma = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPolynomial = new System.Windows.Forms.RadioButton();
            this.rbGaussian = new System.Windows.Forms.RadioButton();
            this.numSigma = new System.Windows.Forms.NumericUpDown();
            this.numDegree = new System.Windows.Forms.NumericUpDown();
            this.numConstant = new System.Windows.Forms.NumericUpDown();
            this.numCache = new System.Windows.Forms.NumericUpDown();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
            this.numComplexity = new System.Windows.Forms.NumericUpDown();
            this.tabSamples = new System.Windows.Forms.TabPage();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnClassify = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.lblSampleSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStandartErrorValue = new System.Windows.Forms.Label();
            this.lbErrorValue = new System.Windows.Forms.Label();
            this.lbF1Value = new System.Windows.Forms.Label();
            this.lbRecallValue = new System.Windows.Forms.Label();
            this.lbPrecisionValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbStandartError = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbF1 = new System.Windows.Forms.Label();
            this.lbRecall = new System.Windows.Forms.Label();
            this.lbPrecision = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTrain = new System.Windows.Forms.GroupBox();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            this.colTrainingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTrainingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.dgvTesting = new System.Windows.Forms.DataGridView();
            this.colTestingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTestingExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassification = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabHyperparameters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).BeginInit();
            this.tabSamples.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTrain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.groupBoxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabClassification.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наборДанныхToolStripMenuItem,
            this.алгоритмToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // наборДанныхToolStripMenuItem
            // 
            this.наборДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optdigitsToolStripMenuItem,
            this.mNISTToolStripMenuItem});
            this.наборДанныхToolStripMenuItem.Name = "наборДанныхToolStripMenuItem";
            this.наборДанныхToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.наборДанныхToolStripMenuItem.Text = "Набор данных";
            // 
            // optdigitsToolStripMenuItem
            // 
            this.optdigitsToolStripMenuItem.Name = "optdigitsToolStripMenuItem";
            this.optdigitsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.optdigitsToolStripMenuItem.Text = "Optdigits";
            this.optdigitsToolStripMenuItem.Click += new System.EventHandler(this.optdigitsToolStripMenuItem_Click);
            // 
            // mNISTToolStripMenuItem
            // 
            this.mNISTToolStripMenuItem.Name = "mNISTToolStripMenuItem";
            this.mNISTToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mNISTToolStripMenuItem.Text = "MNIST";
            this.mNISTToolStripMenuItem.Click += new System.EventHandler(this.mNISTToolStripMenuItem_Click);
            // 
            // алгоритмToolStripMenuItem
            // 
            this.алгоритмToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kNNToolStripMenuItem,
            this.sVMToolStripMenuItem,
            this.kmeansToolStripMenuItem});
            this.алгоритмToolStripMenuItem.Name = "алгоритмToolStripMenuItem";
            this.алгоритмToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.алгоритмToolStripMenuItem.Text = "Алгоритм";
            // 
            // kNNToolStripMenuItem
            // 
            this.kNNToolStripMenuItem.Name = "kNNToolStripMenuItem";
            this.kNNToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kNNToolStripMenuItem.Text = "K-NN";
            // 
            // sVMToolStripMenuItem
            // 
            this.sVMToolStripMenuItem.Name = "sVMToolStripMenuItem";
            this.sVMToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sVMToolStripMenuItem.Text = "SVM";
            // 
            // kmeansToolStripMenuItem
            // 
            this.kmeansToolStripMenuItem.Name = "kmeansToolStripMenuItem";
            this.kmeansToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kmeansToolStripMenuItem.Text = "K-means";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(759, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = false;
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(580, 17);
            this.lbStatus.Text = "Нажмите Настройки->Набор данных, чтобы выбрать данные";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(151, 16);
            this.progressBar.Visible = false;
            // 
            // tabHyperparameters
            // 
            this.tabHyperparameters.Controls.Add(this.groupBox2);
            this.tabHyperparameters.Controls.Add(this.groupBox1);
            this.tabHyperparameters.Location = new System.Drawing.Point(4, 24);
            this.tabHyperparameters.Name = "tabHyperparameters";
            this.tabHyperparameters.Padding = new System.Windows.Forms.Padding(3);
            this.tabHyperparameters.Size = new System.Drawing.Size(751, 423);
            this.tabHyperparameters.TabIndex = 2;
            this.tabHyperparameters.Text = "Гиперпараметры";
            this.tabHyperparameters.UseVisualStyleBackColor = true;
            // 
            // cbStrategy
            // 
            this.cbStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrategy.FormattingEnabled = true;
            this.cbStrategy.Location = new System.Drawing.Point(6, 371);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(185, 23);
            this.cbStrategy.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(212, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "k-NN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Степень:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(129, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbStrategy);
            this.groupBox1.Controls.Add(this.btnEstimate_c);
            this.groupBox1.Controls.Add(this.btnEstimate_Sigma);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbPolynomial);
            this.groupBox1.Controls.Add(this.rbGaussian);
            this.groupBox1.Controls.Add(this.numSigma);
            this.groupBox1.Controls.Add(this.numDegree);
            this.groupBox1.Controls.Add(this.numConstant);
            this.groupBox1.Controls.Add(this.numCache);
            this.groupBox1.Controls.Add(this.numTolerance);
            this.groupBox1.Controls.Add(this.numComplexity);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "kernel SVM";
            // 
            // btnEstimate_c
            // 
            this.btnEstimate_c.Enabled = false;
            this.btnEstimate_c.Location = new System.Drawing.Point(6, 209);
            this.btnEstimate_c.Name = "btnEstimate_c";
            this.btnEstimate_c.Size = new System.Drawing.Size(185, 23);
            this.btnEstimate_c.TabIndex = 33;
            this.btnEstimate_c.Text = "Оптимизировать C";
            this.btnEstimate_c.UseVisualStyleBackColor = true;
            this.btnEstimate_c.Click += new System.EventHandler(this.btnEstimate_c_Click);
            // 
            // btnEstimate_Sigma
            // 
            this.btnEstimate_Sigma.Enabled = false;
            this.btnEstimate_Sigma.Location = new System.Drawing.Point(6, 87);
            this.btnEstimate_Sigma.Name = "btnEstimate_Sigma";
            this.btnEstimate_Sigma.Size = new System.Drawing.Size(185, 23);
            this.btnEstimate_Sigma.TabIndex = 32;
            this.btnEstimate_Sigma.Text = "Оптимизировать сигму";
            this.btnEstimate_Sigma.UseVisualStyleBackColor = true;
            this.btnEstimate_Sigma.Click += new System.EventHandler(this.btnEstimate_Sigma_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ядерный метод:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Размер кэша:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Допуск:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "С-параметр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Константа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Степень:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Сигма:";
            // 
            // rbPolynomial
            // 
            this.rbPolynomial.AutoSize = true;
            this.rbPolynomial.Location = new System.Drawing.Point(9, 116);
            this.rbPolynomial.Name = "rbPolynomial";
            this.rbPolynomial.Size = new System.Drawing.Size(153, 19);
            this.rbPolynomial.TabIndex = 24;
            this.rbPolynomial.Text = "Полиномиальное ядро";
            this.rbPolynomial.UseVisualStyleBackColor = true;
            this.rbPolynomial.CheckedChanged += new System.EventHandler(this.rbPolynomial_CheckedChanged);
            // 
            // rbGaussian
            // 
            this.rbGaussian.AutoSize = true;
            this.rbGaussian.Checked = true;
            this.rbGaussian.Location = new System.Drawing.Point(9, 37);
            this.rbGaussian.Name = "rbGaussian";
            this.rbGaussian.Size = new System.Drawing.Size(91, 19);
            this.rbGaussian.TabIndex = 23;
            this.rbGaussian.TabStop = true;
            this.rbGaussian.Text = "Ядро Гаусса";
            this.rbGaussian.UseVisualStyleBackColor = true;
            this.rbGaussian.CheckedChanged += new System.EventHandler(this.rbGaussian_CheckedChanged);
            // 
            // numSigma
            // 
            this.numSigma.DecimalPlaces = 5;
            this.numSigma.Location = new System.Drawing.Point(129, 58);
            this.numSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numSigma.Name = "numSigma";
            this.numSigma.Size = new System.Drawing.Size(62, 23);
            this.numSigma.TabIndex = 22;
            this.numSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDegree
            // 
            this.numDegree.Enabled = false;
            this.numDegree.Location = new System.Drawing.Point(129, 140);
            this.numDegree.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numDegree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDegree.Name = "numDegree";
            this.numDegree.Size = new System.Drawing.Size(62, 23);
            this.numDegree.TabIndex = 21;
            this.numDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numConstant
            // 
            this.numConstant.DecimalPlaces = 5;
            this.numConstant.Enabled = false;
            this.numConstant.Location = new System.Drawing.Point(129, 169);
            this.numConstant.Name = "numConstant";
            this.numConstant.Size = new System.Drawing.Size(62, 23);
            this.numConstant.TabIndex = 20;
            this.numConstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numConstant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCache
            // 
            this.numCache.Location = new System.Drawing.Point(129, 296);
            this.numCache.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCache.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCache.Name = "numCache";
            this.numCache.Size = new System.Drawing.Size(62, 23);
            this.numCache.TabIndex = 19;
            this.numCache.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCache.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numTolerance
            // 
            this.numTolerance.DecimalPlaces = 5;
            this.numTolerance.Location = new System.Drawing.Point(129, 267);
            this.numTolerance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTolerance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(62, 23);
            this.numTolerance.TabIndex = 18;
            this.numTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTolerance.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numComplexity
            // 
            this.numComplexity.DecimalPlaces = 5;
            this.numComplexity.Location = new System.Drawing.Point(129, 238);
            this.numComplexity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numComplexity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.numComplexity.Name = "numComplexity";
            this.numComplexity.Size = new System.Drawing.Size(62, 23);
            this.numComplexity.TabIndex = 17;
            this.numComplexity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numComplexity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabSamples
            // 
            this.tabSamples.Controls.Add(this.groupBoxControl);
            this.tabSamples.Controls.Add(this.groupBoxStatistics);
            this.tabSamples.Controls.Add(this.splitContainer1);
            this.tabSamples.Location = new System.Drawing.Point(4, 24);
            this.tabSamples.Name = "tabSamples";
            this.tabSamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabSamples.Size = new System.Drawing.Size(751, 423);
            this.tabSamples.TabIndex = 0;
            this.tabSamples.Text = "Примеры";
            this.tabSamples.UseVisualStyleBackColor = true;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btnTrain);
            this.groupBoxControl.Controls.Add(this.btnClassify);
            this.groupBoxControl.Location = new System.Drawing.Point(560, 241);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(185, 176);
            this.groupBoxControl.TabIndex = 2;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Управление";
            // 
            // btnTrain
            // 
            this.btnTrain.Enabled = false;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTrain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrain.Location = new System.Drawing.Point(6, 22);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(171, 66);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Обучить";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnClassify
            // 
            this.btnClassify.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClassify.Enabled = false;
            this.btnClassify.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClassify.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClassify.Location = new System.Drawing.Point(6, 94);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(171, 76);
            this.btnClassify.TabIndex = 0;
            this.btnClassify.Text = "ТЕСТ";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Controls.Add(this.lblSampleSize);
            this.groupBoxStatistics.Controls.Add(this.label10);
            this.groupBoxStatistics.Controls.Add(this.lbStandartErrorValue);
            this.groupBoxStatistics.Controls.Add(this.lbErrorValue);
            this.groupBoxStatistics.Controls.Add(this.lbF1Value);
            this.groupBoxStatistics.Controls.Add(this.lbRecallValue);
            this.groupBoxStatistics.Controls.Add(this.lbPrecisionValue);
            this.groupBoxStatistics.Controls.Add(this.label9);
            this.groupBoxStatistics.Controls.Add(this.lbStandartError);
            this.groupBoxStatistics.Controls.Add(this.lbError);
            this.groupBoxStatistics.Controls.Add(this.lbF1);
            this.groupBoxStatistics.Controls.Add(this.lbRecall);
            this.groupBoxStatistics.Controls.Add(this.lbPrecision);
            this.groupBoxStatistics.Location = new System.Drawing.Point(560, 3);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(185, 235);
            this.groupBoxStatistics.TabIndex = 1;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Статистика";
            // 
            // lblSampleSize
            // 
            this.lblSampleSize.AutoSize = true;
            this.lblSampleSize.Location = new System.Drawing.Point(6, 41);
            this.lblSampleSize.Name = "lblSampleSize";
            this.lblSampleSize.Size = new System.Drawing.Size(72, 30);
            this.lblSampleSize.TabIndex = 14;
            this.lblSampleSize.Text = "трен-ая: 0 / \r\nтест-ая:  0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Размер выборки";
            // 
            // lbStandartErrorValue
            // 
            this.lbStandartErrorValue.AutoSize = true;
            this.lbStandartErrorValue.Location = new System.Drawing.Point(114, 208);
            this.lbStandartErrorValue.Name = "lbStandartErrorValue";
            this.lbStandartErrorValue.Size = new System.Drawing.Size(12, 15);
            this.lbStandartErrorValue.TabIndex = 12;
            this.lbStandartErrorValue.Text = "_";
            // 
            // lbErrorValue
            // 
            this.lbErrorValue.AutoSize = true;
            this.lbErrorValue.Location = new System.Drawing.Point(114, 183);
            this.lbErrorValue.Name = "lbErrorValue";
            this.lbErrorValue.Size = new System.Drawing.Size(12, 15);
            this.lbErrorValue.TabIndex = 11;
            this.lbErrorValue.Text = "_";
            // 
            // lbF1Value
            // 
            this.lbF1Value.AutoSize = true;
            this.lbF1Value.Location = new System.Drawing.Point(114, 156);
            this.lbF1Value.Name = "lbF1Value";
            this.lbF1Value.Size = new System.Drawing.Size(12, 15);
            this.lbF1Value.TabIndex = 10;
            this.lbF1Value.Text = "_";
            // 
            // lbRecallValue
            // 
            this.lbRecallValue.AutoSize = true;
            this.lbRecallValue.Location = new System.Drawing.Point(114, 130);
            this.lbRecallValue.Name = "lbRecallValue";
            this.lbRecallValue.Size = new System.Drawing.Size(12, 15);
            this.lbRecallValue.TabIndex = 9;
            this.lbRecallValue.Text = "_";
            // 
            // lbPrecisionValue
            // 
            this.lbPrecisionValue.AutoSize = true;
            this.lbPrecisionValue.Location = new System.Drawing.Point(114, 105);
            this.lbPrecisionValue.Name = "lbPrecisionValue";
            this.lbPrecisionValue.Size = new System.Drawing.Size(12, 15);
            this.lbPrecisionValue.TabIndex = 8;
            this.lbPrecisionValue.Text = "_";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Метрики качества модели";
            // 
            // lbStandartError
            // 
            this.lbStandartError.AutoSize = true;
            this.lbStandartError.Location = new System.Drawing.Point(6, 208);
            this.lbStandartError.Name = "lbStandartError";
            this.lbStandartError.Size = new System.Drawing.Size(73, 15);
            this.lbStandartError.TabIndex = 4;
            this.lbStandartError.Text = "Ст. ошибка:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(5, 183);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(56, 15);
            this.lbError.TabIndex = 3;
            this.lbError.Text = "Ошибка:";
            // 
            // lbF1
            // 
            this.lbF1.AutoSize = true;
            this.lbF1.Location = new System.Drawing.Point(6, 156);
            this.lbF1.Name = "lbF1";
            this.lbF1.Size = new System.Drawing.Size(55, 15);
            this.lbF1.TabIndex = 2;
            this.lbF1.Text = "Мера F1:";
            // 
            // lbRecall
            // 
            this.lbRecall.AutoSize = true;
            this.lbRecall.Location = new System.Drawing.Point(5, 130);
            this.lbRecall.Name = "lbRecall";
            this.lbRecall.Size = new System.Drawing.Size(58, 15);
            this.lbRecall.TabIndex = 1;
            this.lbRecall.Text = "Полнота:";
            // 
            // lbPrecision
            // 
            this.lbPrecision.AutoSize = true;
            this.lbPrecision.Location = new System.Drawing.Point(6, 105);
            this.lbPrecision.Name = "lbPrecision";
            this.lbPrecision.Size = new System.Drawing.Size(61, 15);
            this.lbPrecision.TabIndex = 0;
            this.lbPrecision.Text = "Точность:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTrain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTest);
            this.splitContainer1.Size = new System.Drawing.Size(551, 419);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxTrain
            // 
            this.groupBoxTrain.Controls.Add(this.dgvTraining);
            this.groupBoxTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTrain.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTrain.Name = "groupBoxTrain";
            this.groupBoxTrain.Size = new System.Drawing.Size(183, 419);
            this.groupBoxTrain.TabIndex = 0;
            this.groupBoxTrain.TabStop = false;
            this.groupBoxTrain.Text = "Тренировочная выборка";
            // 
            // dgvTraining
            // 
            this.dgvTraining.AllowUserToAddRows = false;
            this.dgvTraining.AllowUserToDeleteRows = false;
            this.dgvTraining.AllowUserToResizeColumns = false;
            this.dgvTraining.AllowUserToResizeRows = false;
            this.dgvTraining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTraining.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTraining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainingImage,
            this.colTrainingValue,
            this.colTrainingFeatures});
            this.dgvTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraining.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dgvTraining.Location = new System.Drawing.Point(3, 19);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.ReadOnly = true;
            this.dgvTraining.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTraining.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraining.RowTemplate.Height = 25;
            this.dgvTraining.Size = new System.Drawing.Size(177, 397);
            this.dgvTraining.TabIndex = 0;
            // 
            // colTrainingImage
            // 
            this.colTrainingImage.HeaderText = "Цифра";
            this.colTrainingImage.Name = "colTrainingImage";
            this.colTrainingImage.ReadOnly = true;
            this.colTrainingImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTrainingImage.ToolTipText = "Изображение из набора";
            // 
            // colTrainingValue
            // 
            this.colTrainingValue.HeaderText = "Значение";
            this.colTrainingValue.Name = "colTrainingValue";
            this.colTrainingValue.ReadOnly = true;
            this.colTrainingValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTrainingValue.ToolTipText = "Соответствующий класс";
            this.colTrainingValue.Width = 75;
            // 
            // colTrainingFeatures
            // 
            this.colTrainingFeatures.HeaderText = "Features (array)";
            this.colTrainingFeatures.Name = "colTrainingFeatures";
            this.colTrainingFeatures.ReadOnly = true;
            this.colTrainingFeatures.Visible = false;
            this.colTrainingFeatures.Width = 5;
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.dgvTesting);
            this.groupBoxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTest.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(364, 419);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Тестовая выборка";
            // 
            // dgvTesting
            // 
            this.dgvTesting.AllowUserToAddRows = false;
            this.dgvTesting.AllowUserToDeleteRows = false;
            this.dgvTesting.AllowUserToResizeColumns = false;
            this.dgvTesting.AllowUserToResizeRows = false;
            this.dgvTesting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTesting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTesting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestingImage,
            this.colTestingExpected,
            this.colTestingOutput,
            this.colTestingFeatures});
            this.dgvTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTesting.Location = new System.Drawing.Point(3, 19);
            this.dgvTesting.Name = "dgvTesting";
            this.dgvTesting.ReadOnly = true;
            this.dgvTesting.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTesting.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTesting.Size = new System.Drawing.Size(358, 397);
            this.dgvTesting.TabIndex = 0;
            // 
            // colTestingImage
            // 
            this.colTestingImage.HeaderText = "Цифра";
            this.colTestingImage.Name = "colTestingImage";
            this.colTestingImage.ReadOnly = true;
            this.colTestingImage.Width = 120;
            // 
            // colTestingExpected
            // 
            this.colTestingExpected.HeaderText = "Значение";
            this.colTestingExpected.Name = "colTestingExpected";
            this.colTestingExpected.ReadOnly = true;
            this.colTestingExpected.Width = 120;
            // 
            // colTestingOutput
            // 
            this.colTestingOutput.HeaderText = "Результат";
            this.colTestingOutput.Name = "colTestingOutput";
            this.colTestingOutput.ReadOnly = true;
            this.colTestingOutput.Width = 120;
            // 
            // colTestingFeatures
            // 
            this.colTestingFeatures.HeaderText = "Features (array)";
            this.colTestingFeatures.Name = "colTestingFeatures";
            this.colTestingFeatures.ReadOnly = true;
            this.colTestingFeatures.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSamples);
            this.tabControl1.Controls.Add(this.tabHyperparameters);
            this.tabControl1.Controls.Add(this.tabClassification);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 451);
            this.tabControl1.TabIndex = 2;
            // 
            // tabClassification
            // 
            this.tabClassification.Controls.Add(this.groupBox4);
            this.tabClassification.Location = new System.Drawing.Point(4, 24);
            this.tabClassification.Name = "tabClassification";
            this.tabClassification.Size = new System.Drawing.Size(751, 423);
            this.tabClassification.TabIndex = 3;
            this.tabClassification.Text = "Классификация";
            this.tabClassification.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 155);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Стратегия SMO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "(0 для отключения)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 497);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BFC 10000";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabHyperparameters.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).EndInit();
            this.tabSamples.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTrain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.groupBoxTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesting)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabClassification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наборДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмToolStripMenuItem;
        private System.Windows.Forms.TabPage tabHyperparameters;
        private System.Windows.Forms.TabPage tabSamples;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxTrain;
        private System.Windows.Forms.DataGridView dgvTraining;
        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.DataGridView dgvTesting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem optdigitsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn colTrainingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingFeatures;
        private System.Windows.Forms.ToolStripMenuItem kNNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sVMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmeansToolStripMenuItem;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.DataGridViewImageColumn colTestingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingFeatures;
        private System.Windows.Forms.ToolStripMenuItem mNISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.TabPage tabClassification;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPolynomial;
        private System.Windows.Forms.RadioButton rbGaussian;
        private System.Windows.Forms.NumericUpDown numSigma;
        private System.Windows.Forms.NumericUpDown numDegree;
        private System.Windows.Forms.NumericUpDown numConstant;
        private System.Windows.Forms.NumericUpDown numCache;
        private System.Windows.Forms.NumericUpDown numTolerance;
        private System.Windows.Forms.NumericUpDown numComplexity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbStrategy;
        private System.Windows.Forms.Button btnEstimate_c;
        private System.Windows.Forms.Button btnEstimate_Sigma;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbF1;
        private System.Windows.Forms.Label lbRecall;
        private System.Windows.Forms.Label lbPrecision;
        private System.Windows.Forms.Label lbStandartError;
        private System.Windows.Forms.Label lbStandartErrorValue;
        private System.Windows.Forms.Label lbErrorValue;
        private System.Windows.Forms.Label lbF1Value;
        private System.Windows.Forms.Label lbRecallValue;
        private System.Windows.Forms.Label lbPrecisionValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSampleSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}
