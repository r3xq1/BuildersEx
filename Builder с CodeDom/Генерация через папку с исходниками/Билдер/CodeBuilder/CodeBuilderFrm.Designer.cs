namespace CodeBuilder
{
    partial class CodeBuilderFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeBuilderFrm));
            this.CompileBuild = new System.Windows.Forms.Button();
            this.AssVerText = new System.Windows.Forms.Label();
            this.AssVerTextBox = new System.Windows.Forms.TextBox();
            this.AssGuidText = new System.Windows.Forms.Label();
            this.AssGuidTextBox = new System.Windows.Forms.TextBox();
            this.AssCompanyText = new System.Windows.Forms.Label();
            this.AssCompanyTextBox = new System.Windows.Forms.TextBox();
            this.AssFVText = new System.Windows.Forms.Label();
            this.AssFileVerTextBox = new System.Windows.Forms.TextBox();
            this.AssCopyText = new System.Windows.Forms.Label();
            this.AssCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.AssProdText = new System.Windows.Forms.Label();
            this.AssProductTextBox = new System.Windows.Forms.TextBox();
            this.AssDescText = new System.Windows.Forms.Label();
            this.AssDescriptTextBox = new System.Windows.Forms.TextBox();
            this.AssTitleText = new System.Windows.Forms.Label();
            this.AssTitleTextBox = new System.Windows.Forms.TextBox();
            this.GenAss = new System.Windows.Forms.Button();
            this.IcoViewer = new System.Windows.Forms.PictureBox();
            this.NameOutput = new System.Windows.Forms.TextBox();
            this.BuildText = new System.Windows.Forms.Label();
            this.SelectIcon = new System.Windows.Forms.Button();
            this.IcoPath = new System.Windows.Forms.TextBox();
            this.IconText = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessLblText = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ErrorBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // CompileBuild
            // 
            this.CompileBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.CompileBuild.FlatAppearance.BorderSize = 0;
            this.CompileBuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CompileBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompileBuild.ForeColor = System.Drawing.SystemColors.Control;
            this.CompileBuild.Location = new System.Drawing.Point(179, 463);
            this.CompileBuild.Name = "CompileBuild";
            this.CompileBuild.Size = new System.Drawing.Size(307, 30);
            this.CompileBuild.TabIndex = 0;
            this.CompileBuild.TabStop = false;
            this.CompileBuild.Text = "Compile Build";
            this.CompileBuild.UseVisualStyleBackColor = false;
            this.CompileBuild.Click += new System.EventHandler(this.CompileBuild_Click);
            // 
            // AssVerText
            // 
            this.AssVerText.AutoSize = true;
            this.AssVerText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssVerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssVerText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssVerText.Location = new System.Drawing.Point(40, 387);
            this.AssVerText.Name = "AssVerText";
            this.AssVerText.Size = new System.Drawing.Size(111, 14);
            this.AssVerText.TabIndex = 141;
            this.AssVerText.Text = "AssemblyVersion:";
            // 
            // AssVerTextBox
            // 
            this.AssVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssVerTextBox.Location = new System.Drawing.Point(179, 384);
            this.AssVerTextBox.MaxLength = 7;
            this.AssVerTextBox.Name = "AssVerTextBox";
            this.AssVerTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssVerTextBox.TabIndex = 140;
            this.AssVerTextBox.TabStop = false;
            this.AssVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssGuidText
            // 
            this.AssGuidText.AutoSize = true;
            this.AssGuidText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssGuidText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssGuidText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssGuidText.Location = new System.Drawing.Point(40, 440);
            this.AssGuidText.Name = "AssGuidText";
            this.AssGuidText.Size = new System.Drawing.Size(95, 14);
            this.AssGuidText.TabIndex = 139;
            this.AssGuidText.Text = "AssemblyGuid:";
            // 
            // AssGuidTextBox
            // 
            this.AssGuidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssGuidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssGuidTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssGuidTextBox.Location = new System.Drawing.Point(179, 437);
            this.AssGuidTextBox.MaxLength = 7;
            this.AssGuidTextBox.Name = "AssGuidTextBox";
            this.AssGuidTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssGuidTextBox.TabIndex = 138;
            this.AssGuidTextBox.TabStop = false;
            this.AssGuidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssCompanyText
            // 
            this.AssCompanyText.AutoSize = true;
            this.AssCompanyText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssCompanyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssCompanyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssCompanyText.Location = new System.Drawing.Point(40, 306);
            this.AssCompanyText.Name = "AssCompanyText";
            this.AssCompanyText.Size = new System.Drawing.Size(123, 14);
            this.AssCompanyText.TabIndex = 137;
            this.AssCompanyText.Text = "AssemblyCompany:";
            // 
            // AssCompanyTextBox
            // 
            this.AssCompanyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssCompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCompanyTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssCompanyTextBox.Location = new System.Drawing.Point(179, 304);
            this.AssCompanyTextBox.MaxLength = 100;
            this.AssCompanyTextBox.Name = "AssCompanyTextBox";
            this.AssCompanyTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssCompanyTextBox.TabIndex = 136;
            this.AssCompanyTextBox.TabStop = false;
            this.AssCompanyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssFVText
            // 
            this.AssFVText.AutoSize = true;
            this.AssFVText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssFVText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssFVText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssFVText.Location = new System.Drawing.Point(40, 413);
            this.AssFVText.Name = "AssFVText";
            this.AssFVText.Size = new System.Drawing.Size(132, 14);
            this.AssFVText.TabIndex = 135;
            this.AssFVText.Text = "AssemblyFileVersion:";
            // 
            // AssFileVerTextBox
            // 
            this.AssFileVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssFileVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssFileVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssFileVerTextBox.Location = new System.Drawing.Point(179, 410);
            this.AssFileVerTextBox.MaxLength = 7;
            this.AssFileVerTextBox.Name = "AssFileVerTextBox";
            this.AssFileVerTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssFileVerTextBox.TabIndex = 134;
            this.AssFileVerTextBox.TabStop = false;
            this.AssFileVerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssCopyText
            // 
            this.AssCopyText.AutoSize = true;
            this.AssCopyText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssCopyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssCopyText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssCopyText.Location = new System.Drawing.Point(40, 360);
            this.AssCopyText.Name = "AssCopyText";
            this.AssCopyText.Size = new System.Drawing.Size(126, 14);
            this.AssCopyText.TabIndex = 133;
            this.AssCopyText.Text = "AssemblyCopyright:";
            // 
            // AssCopyrightTextBox
            // 
            this.AssCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssCopyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCopyrightTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssCopyrightTextBox.Location = new System.Drawing.Point(179, 357);
            this.AssCopyrightTextBox.MaxLength = 100;
            this.AssCopyrightTextBox.Name = "AssCopyrightTextBox";
            this.AssCopyrightTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssCopyrightTextBox.TabIndex = 132;
            this.AssCopyrightTextBox.TabStop = false;
            this.AssCopyrightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssProdText
            // 
            this.AssProdText.AutoSize = true;
            this.AssProdText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssProdText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssProdText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssProdText.Location = new System.Drawing.Point(40, 333);
            this.AssProdText.Name = "AssProdText";
            this.AssProdText.Size = new System.Drawing.Size(112, 14);
            this.AssProdText.TabIndex = 131;
            this.AssProdText.Text = "AssemblyProduct:";
            // 
            // AssProductTextBox
            // 
            this.AssProductTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssProductTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssProductTextBox.Location = new System.Drawing.Point(179, 330);
            this.AssProductTextBox.MaxLength = 100;
            this.AssProductTextBox.Name = "AssProductTextBox";
            this.AssProductTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssProductTextBox.TabIndex = 130;
            this.AssProductTextBox.TabStop = false;
            this.AssProductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssDescText
            // 
            this.AssDescText.AutoSize = true;
            this.AssDescText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssDescText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssDescText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssDescText.Location = new System.Drawing.Point(40, 281);
            this.AssDescText.Name = "AssDescText";
            this.AssDescText.Size = new System.Drawing.Size(132, 14);
            this.AssDescText.TabIndex = 129;
            this.AssDescText.Text = "AssemblyDescription:";
            // 
            // AssDescriptTextBox
            // 
            this.AssDescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssDescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssDescriptTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssDescriptTextBox.Location = new System.Drawing.Point(179, 278);
            this.AssDescriptTextBox.MaxLength = 100;
            this.AssDescriptTextBox.Name = "AssDescriptTextBox";
            this.AssDescriptTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssDescriptTextBox.TabIndex = 128;
            this.AssDescriptTextBox.TabStop = false;
            this.AssDescriptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AssTitleText
            // 
            this.AssTitleText.AutoSize = true;
            this.AssTitleText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.AssTitleText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssTitleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AssTitleText.Location = new System.Drawing.Point(40, 254);
            this.AssTitleText.Name = "AssTitleText";
            this.AssTitleText.Size = new System.Drawing.Size(94, 14);
            this.AssTitleText.TabIndex = 127;
            this.AssTitleText.Text = "AssemblyTitle:";
            // 
            // AssTitleTextBox
            // 
            this.AssTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssTitleTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AssTitleTextBox.Location = new System.Drawing.Point(179, 251);
            this.AssTitleTextBox.MaxLength = 100;
            this.AssTitleTextBox.Name = "AssTitleTextBox";
            this.AssTitleTextBox.Size = new System.Drawing.Size(307, 20);
            this.AssTitleTextBox.TabIndex = 126;
            this.AssTitleTextBox.TabStop = false;
            this.AssTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenAss
            // 
            this.GenAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.GenAss.FlatAppearance.BorderSize = 0;
            this.GenAss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GenAss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.GenAss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenAss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GenAss.Location = new System.Drawing.Point(179, 222);
            this.GenAss.Name = "GenAss";
            this.GenAss.Size = new System.Drawing.Size(307, 23);
            this.GenAss.TabIndex = 125;
            this.GenAss.TabStop = false;
            this.GenAss.Text = "Генерировать свойства для билд файла";
            this.GenAss.UseVisualStyleBackColor = false;
            this.GenAss.Click += new System.EventHandler(this.GenAss_Click);
            // 
            // IcoViewer
            // 
            this.IcoViewer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IcoViewer.Location = new System.Drawing.Point(369, 47);
            this.IcoViewer.Name = "IcoViewer";
            this.IcoViewer.Size = new System.Drawing.Size(117, 58);
            this.IcoViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcoViewer.TabIndex = 147;
            this.IcoViewer.TabStop = false;
            // 
            // NameOutput
            // 
            this.NameOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.NameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameOutput.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.NameOutput.Location = new System.Drawing.Point(139, 58);
            this.NameOutput.MaxLength = 50;
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.Size = new System.Drawing.Size(219, 20);
            this.NameOutput.TabIndex = 146;
            this.NameOutput.TabStop = false;
            this.NameOutput.Text = "Build123";
            // 
            // BuildText
            // 
            this.BuildText.AutoSize = true;
            this.BuildText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.BuildText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuildText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuildText.Location = new System.Drawing.Point(37, 59);
            this.BuildText.Name = "BuildText";
            this.BuildText.Size = new System.Drawing.Size(78, 14);
            this.BuildText.TabIndex = 145;
            this.BuildText.Text = "Имя файла:";
            // 
            // SelectIcon
            // 
            this.SelectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.SelectIcon.FlatAppearance.BorderSize = 0;
            this.SelectIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectIcon.ForeColor = System.Drawing.Color.White;
            this.SelectIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectIcon.Location = new System.Drawing.Point(412, 22);
            this.SelectIcon.Name = "SelectIcon";
            this.SelectIcon.Size = new System.Drawing.Size(74, 19);
            this.SelectIcon.TabIndex = 144;
            this.SelectIcon.TabStop = false;
            this.SelectIcon.Text = "....";
            this.SelectIcon.UseVisualStyleBackColor = false;
            this.SelectIcon.Click += new System.EventHandler(this.SelectIcon_Click);
            // 
            // IcoPath
            // 
            this.IcoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.IcoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoPath.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.IcoPath.Location = new System.Drawing.Point(139, 21);
            this.IcoPath.MaxLength = 99999;
            this.IcoPath.Name = "IcoPath";
            this.IcoPath.ReadOnly = true;
            this.IcoPath.Size = new System.Drawing.Size(264, 20);
            this.IcoPath.TabIndex = 143;
            this.IcoPath.TabStop = false;
            // 
            // IconText
            // 
            this.IconText.AutoSize = true;
            this.IconText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.IconText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IconText.Location = new System.Drawing.Point(37, 23);
            this.IconText.Name = "IconText";
            this.IconText.Size = new System.Drawing.Size(96, 14);
            this.IconText.TabIndex = 142;
            this.IconText.Text = "Путь к иконке:";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.MessageTextBox.Location = new System.Drawing.Point(139, 111);
            this.MessageTextBox.MaxLength = 99999;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(347, 20);
            this.MessageTextBox.TabIndex = 148;
            this.MessageTextBox.TabStop = false;
            // 
            // MessLblText
            // 
            this.MessLblText.AutoSize = true;
            this.MessLblText.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.MessLblText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessLblText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessLblText.Location = new System.Drawing.Point(20, 113);
            this.MessLblText.Name = "MessLblText";
            this.MessLblText.Size = new System.Drawing.Size(113, 14);
            this.MessLblText.TabIndex = 149;
            this.MessLblText.Text = "Текст сообщения: ";
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LogBox.Location = new System.Drawing.Point(518, 37);
            this.LogBox.MaxLength = 9999999;
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LogBox.Size = new System.Drawing.Size(440, 456);
            this.LogBox.TabIndex = 150;
            this.LogBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(515, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 151;
            this.label1.Text = "ЛОГ:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(23, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(261, 17);
            this.checkBox1.TabIndex = 152;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Тестовый вариант вкл\\выкл bool переменных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorBox.Location = new System.Drawing.Point(179, 499);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(280, 17);
            this.ErrorBox.TabIndex = 153;
            this.ErrorBox.TabStop = false;
            this.ErrorBox.Text = "Compiler Show Error (Показать ошибки при сборке)";
            this.ErrorBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(23, 180);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(188, 17);
            this.checkBox2.TabIndex = 154;
            this.checkBox2.TabStop = false;
            this.checkBox2.Text = "Тип выходных данных: Windows";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CodeBuilderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(970, 543);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.MessLblText);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.IcoViewer);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.BuildText);
            this.Controls.Add(this.SelectIcon);
            this.Controls.Add(this.IcoPath);
            this.Controls.Add(this.IconText);
            this.Controls.Add(this.AssVerText);
            this.Controls.Add(this.AssVerTextBox);
            this.Controls.Add(this.AssGuidText);
            this.Controls.Add(this.AssGuidTextBox);
            this.Controls.Add(this.AssCompanyText);
            this.Controls.Add(this.AssCompanyTextBox);
            this.Controls.Add(this.AssFVText);
            this.Controls.Add(this.AssFileVerTextBox);
            this.Controls.Add(this.AssCopyText);
            this.Controls.Add(this.AssCopyrightTextBox);
            this.Controls.Add(this.AssProdText);
            this.Controls.Add(this.AssProductTextBox);
            this.Controls.Add(this.AssDescText);
            this.Controls.Add(this.AssDescriptTextBox);
            this.Controls.Add(this.AssTitleText);
            this.Controls.Add(this.AssTitleTextBox);
            this.Controls.Add(this.GenAss);
            this.Controls.Add(this.CompileBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeBuilderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeBuilder [For You] - Use CodeDom compiler";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CompileBuild;
        private System.Windows.Forms.Label AssVerText;
        private System.Windows.Forms.TextBox AssVerTextBox;
        private System.Windows.Forms.Label AssGuidText;
        private System.Windows.Forms.TextBox AssGuidTextBox;
        private System.Windows.Forms.Label AssCompanyText;
        private System.Windows.Forms.TextBox AssCompanyTextBox;
        private System.Windows.Forms.Label AssFVText;
        private System.Windows.Forms.TextBox AssFileVerTextBox;
        private System.Windows.Forms.Label AssCopyText;
        private System.Windows.Forms.TextBox AssCopyrightTextBox;
        private System.Windows.Forms.Label AssProdText;
        private System.Windows.Forms.TextBox AssProductTextBox;
        private System.Windows.Forms.Label AssDescText;
        private System.Windows.Forms.TextBox AssDescriptTextBox;
        private System.Windows.Forms.Label AssTitleText;
        private System.Windows.Forms.TextBox AssTitleTextBox;
        private System.Windows.Forms.Button GenAss;
        private System.Windows.Forms.PictureBox IcoViewer;
        private System.Windows.Forms.TextBox NameOutput;
        private System.Windows.Forms.Label BuildText;
        private System.Windows.Forms.Button SelectIcon;
        private System.Windows.Forms.TextBox IcoPath;
        private System.Windows.Forms.Label IconText;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label MessLblText;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ErrorBox;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

