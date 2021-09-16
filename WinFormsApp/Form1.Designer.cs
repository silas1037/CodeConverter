namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_chooseOutput = new System.Windows.Forms.Button();
            this.button_chooseDirectory = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.label_directory = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.textBox_file = new System.Windows.Forms.TextBox();
            this.textBox_directory = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_file = new System.Windows.Forms.Button();
            this.button_openDirectory = new System.Windows.Forms.Button();
            this.button_openOutput = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.checkBox_BOM = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_override = new System.Windows.Forms.CheckBox();
            this.checkBox_sameOutput = new System.Windows.Forms.CheckBox();
            this.checkBox_openOutput = new System.Windows.Forms.CheckBox();
            this.checkBox_recur = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_inpack = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button_chooseDirectory, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_file, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_directory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_output, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_file, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_directory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_file, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_openDirectory, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_chooseOutput, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_openOutput, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_output, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.53435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.9313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 181);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button_chooseOutput
            // 
            this.button_chooseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseOutput.AutoSize = true;
            this.button_chooseOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_chooseOutput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_chooseOutput.Location = new System.Drawing.Point(579, 93);
            this.button_chooseOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_chooseOutput.Name = "button_chooseOutput";
            this.button_chooseOutput.Size = new System.Drawing.Size(68, 30);
            this.button_chooseOutput.TabIndex = 9;
            this.button_chooseOutput.Text = "选择";
            this.button_chooseOutput.UseVisualStyleBackColor = false;
            this.button_chooseOutput.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_chooseDirectory
            // 
            this.button_chooseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseDirectory.AutoSize = true;
            this.button_chooseDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_chooseDirectory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_chooseDirectory.Location = new System.Drawing.Point(579, 46);
            this.button_chooseDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_chooseDirectory.Name = "button_chooseDirectory";
            this.button_chooseDirectory.Size = new System.Drawing.Size(68, 30);
            this.button_chooseDirectory.TabIndex = 8;
            this.button_chooseDirectory.Text = "选择";
            this.button_chooseDirectory.UseVisualStyleBackColor = false;
            this.button_chooseDirectory.Click += new System.EventHandler(this.button_directory_Click);
            // 
            // label_file
            // 
            this.label_file.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_file.AutoSize = true;
            this.label_file.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_file.Location = new System.Drawing.Point(2, 10);
            this.label_file.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(65, 20);
            this.label_file.TabIndex = 1;
            this.label_file.Text = "输入文件";
            this.label_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_directory
            // 
            this.label_directory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_directory.AutoSize = true;
            this.label_directory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_directory.Location = new System.Drawing.Point(2, 51);
            this.label_directory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_directory.Name = "label_directory";
            this.label_directory.Size = new System.Drawing.Size(79, 20);
            this.label_directory.TabIndex = 2;
            this.label_directory.Text = "输入文件夹";
            this.label_directory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_output
            // 
            this.label_output.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_output.AutoSize = true;
            this.label_output.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_output.Location = new System.Drawing.Point(2, 98);
            this.label_output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(79, 20);
            this.label_output.TabIndex = 3;
            this.label_output.Text = "输出文件夹";
            this.label_output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_file
            // 
            this.textBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_file.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_file.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_file.Location = new System.Drawing.Point(110, 7);
            this.textBox_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_file.Name = "textBox_file";
            this.textBox_file.Size = new System.Drawing.Size(465, 26);
            this.textBox_file.TabIndex = 4;
            // 
            // textBox_directory
            // 
            this.textBox_directory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_directory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_directory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_directory.Location = new System.Drawing.Point(110, 48);
            this.textBox_directory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_directory.Name = "textBox_directory";
            this.textBox_directory.Size = new System.Drawing.Size(465, 26);
            this.textBox_directory.TabIndex = 5;
            // 
            // textBox_output
            // 
            this.textBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_output.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_output.Location = new System.Drawing.Point(110, 95);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(465, 26);
            this.textBox_output.TabIndex = 6;
            // 
            // button_file
            // 
            this.button_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_file.AutoSize = true;
            this.button_file.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_file.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_file.Location = new System.Drawing.Point(579, 5);
            this.button_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(68, 30);
            this.button_file.TabIndex = 7;
            this.button_file.Text = "选择";
            this.button_file.UseVisualStyleBackColor = false;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // button_openDirectory
            // 
            this.button_openDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openDirectory.AutoSize = true;
            this.button_openDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_openDirectory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_openDirectory.Location = new System.Drawing.Point(651, 46);
            this.button_openDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_openDirectory.Name = "button_openDirectory";
            this.button_openDirectory.Size = new System.Drawing.Size(69, 30);
            this.button_openDirectory.TabIndex = 10;
            this.button_openDirectory.Text = "打开";
            this.button_openDirectory.UseVisualStyleBackColor = false;
            this.button_openDirectory.Click += new System.EventHandler(this.button_openDirectory_Click);
            // 
            // button_openOutput
            // 
            this.button_openOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_openOutput.AutoSize = true;
            this.button_openOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_openOutput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_openOutput.Location = new System.Drawing.Point(651, 93);
            this.button_openOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_openOutput.Name = "button_openOutput";
            this.button_openOutput.Size = new System.Drawing.Size(69, 30);
            this.button_openOutput.TabIndex = 11;
            this.button_openOutput.Text = "打开";
            this.button_openOutput.UseVisualStyleBackColor = false;
            this.button_openOutput.Click += new System.EventHandler(this.button_openOutput_Click);
            // 
            // button_convert
            // 
            this.button_convert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_convert.AutoSize = true;
            this.button_convert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_convert.Font = new System.Drawing.Font("微软雅黑", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_convert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_convert.Location = new System.Drawing.Point(651, 2);
            this.button_convert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(69, 35);
            this.button_convert.TabIndex = 0;
            this.button_convert.Text = "转换";
            this.button_convert.UseVisualStyleBackColor = false;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // checkBox_BOM
            // 
            this.checkBox_BOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_BOM.AutoSize = true;
            this.checkBox_BOM.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_BOM.Location = new System.Drawing.Point(294, 234);
            this.checkBox_BOM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_BOM.Name = "checkBox_BOM";
            this.checkBox_BOM.Size = new System.Drawing.Size(56, 24);
            this.checkBox_BOM.TabIndex = 2;
            this.checkBox_BOM.Text = "提取";
            this.checkBox_BOM.UseVisualStyleBackColor = true;
            this.checkBox_BOM.CheckedChanged += new System.EventHandler(this.checkBox_BOM_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox_override, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_sameOutput, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_recur, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_openOutput, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_convert, 5, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 264);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 39);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // checkBox_override
            // 
            this.checkBox_override.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_override.AutoSize = true;
            this.checkBox_override.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_override.Location = new System.Drawing.Point(318, 7);
            this.checkBox_override.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_override.Name = "checkBox_override";
            this.checkBox_override.Size = new System.Drawing.Size(98, 24);
            this.checkBox_override.TabIndex = 3;
            this.checkBox_override.Text = "覆盖原文件";
            this.checkBox_override.UseVisualStyleBackColor = true;
            this.checkBox_override.CheckedChanged += new System.EventHandler(this.checkBox_override_CheckedChanged);
            // 
            // checkBox_sameOutput
            // 
            this.checkBox_sameOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_sameOutput.AutoSize = true;
            this.checkBox_sameOutput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_sameOutput.Location = new System.Drawing.Point(420, 7);
            this.checkBox_sameOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_sameOutput.Name = "checkBox_sameOutput";
            this.checkBox_sameOutput.Size = new System.Drawing.Size(140, 24);
            this.checkBox_sameOutput.TabIndex = 4;
            this.checkBox_sameOutput.Text = "输出到相同文件夹";
            this.checkBox_sameOutput.UseVisualStyleBackColor = true;
            this.checkBox_sameOutput.CheckedChanged += new System.EventHandler(this.checkBox_sameOutput_CheckedChanged);
            // 
            // checkBox_openOutput
            // 
            this.checkBox_openOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_openOutput.AutoSize = true;
            this.checkBox_openOutput.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_openOutput.Location = new System.Drawing.Point(118, 7);
            this.checkBox_openOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_openOutput.Name = "checkBox_openOutput";
            this.checkBox_openOutput.Size = new System.Drawing.Size(196, 24);
            this.checkBox_openOutput.TabIndex = 5;
            this.checkBox_openOutput.Text = "转换成功后打开输出文件夹";
            this.checkBox_openOutput.UseVisualStyleBackColor = true;
            // 
            // checkBox_recur
            // 
            this.checkBox_recur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_recur.AutoSize = true;
            this.checkBox_recur.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_recur.Location = new System.Drawing.Point(2, 7);
            this.checkBox_recur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_recur.Name = "checkBox_recur";
            this.checkBox_recur.Size = new System.Drawing.Size(112, 24);
            this.checkBox_recur.TabIndex = 1;
            this.checkBox_recur.Text = "包含子文件夹";
            this.checkBox_recur.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "utf-8",
            "utf-8 BOM",
            "GBK",
            "Shift-Jis",
            "utf-16 LE"});
            this.comboBox1.Location = new System.Drawing.Point(16, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "GBK";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "utf-8",
            "utf-8 BOM",
            "GBK",
            "Shift-Jis",
            "utf-16 LE"});
            this.comboBox2.Location = new System.Drawing.Point(132, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 20);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "utf-8";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 21);
            this.textBox1.TabIndex = 6;
            // 
            // checkBox_inpack
            // 
            this.checkBox_inpack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_inpack.AutoSize = true;
            this.checkBox_inpack.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_inpack.Location = new System.Drawing.Point(533, 234);
            this.checkBox_inpack.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_inpack.Name = "checkBox_inpack";
            this.checkBox_inpack.Size = new System.Drawing.Size(56, 24);
            this.checkBox_inpack.TabIndex = 7;
            this.checkBox_inpack.Text = "回填";
            this.checkBox_inpack.UseVisualStyleBackColor = true;
            this.checkBox_inpack.CheckedChanged += new System.EventHandler(this.checkBox_inpack_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(747, 314);
            this.Controls.Add(this.checkBox_inpack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox_BOM);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "编码转换";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.Label label_directory;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_file;
        private System.Windows.Forms.TextBox textBox_directory;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_file;
        private System.Windows.Forms.Button button_chooseOutput;
        private System.Windows.Forms.Button button_chooseDirectory;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.CheckBox checkBox_BOM;
        private System.Windows.Forms.Button button_openDirectory;
        private System.Windows.Forms.Button button_openOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox_openOutput;
        private System.Windows.Forms.CheckBox checkBox_sameOutput;
        private System.Windows.Forms.CheckBox checkBox_override;
        private System.Windows.Forms.CheckBox checkBox_recur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox_inpack;
    }
}

