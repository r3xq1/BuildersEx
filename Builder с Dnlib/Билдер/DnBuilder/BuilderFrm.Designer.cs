namespace DnBuilder
{
    partial class BuilderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderFrm));
            this.ConsoleTittleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.CheckBox();
            this.BuilderGo = new System.Windows.Forms.Button();
            this.ConsoleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsoleTittleBox
            // 
            this.ConsoleTittleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ConsoleTittleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTittleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleTittleBox.Location = new System.Drawing.Point(90, 40);
            this.ConsoleTittleBox.Name = "ConsoleTittleBox";
            this.ConsoleTittleBox.Size = new System.Drawing.Size(396, 20);
            this.ConsoleTittleBox.TabIndex = 0;
            this.ConsoleTittleBox.TabStop = false;
            this.ConsoleTittleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Tittle:";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.AutoSize = true;
            this.ConsoleBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsoleBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleBox.Location = new System.Drawing.Point(367, 17);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(119, 17);
            this.ConsoleBox.TabIndex = 2;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Text = "Use my console text";
            this.ConsoleBox.UseVisualStyleBackColor = true;
            this.ConsoleBox.CheckedChanged += new System.EventHandler(this.ConsoleBox_CheckedChanged);
            // 
            // BuilderGo
            // 
            this.BuilderGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BuilderGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuilderGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.BuilderGo.Location = new System.Drawing.Point(90, 97);
            this.BuilderGo.Name = "BuilderGo";
            this.BuilderGo.Size = new System.Drawing.Size(396, 27);
            this.BuilderGo.TabIndex = 3;
            this.BuilderGo.TabStop = false;
            this.BuilderGo.Text = "Compile";
            this.BuilderGo.UseVisualStyleBackColor = true;
            this.BuilderGo.Click += new System.EventHandler(this.BuilderGo_Click);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleTextBox.Enabled = false;
            this.ConsoleTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleTextBox.Location = new System.Drawing.Point(90, 67);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(396, 20);
            this.ConsoleTextBox.TabIndex = 4;
            this.ConsoleTextBox.TabStop = false;
            this.ConsoleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Console Text:";
            // 
            // BuilderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(507, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.BuilderGo);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsoleTittleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuilderFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DnBuilder Changer [Example For You] - use dnlib library";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsoleTittleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ConsoleBox;
        private System.Windows.Forms.Button BuilderGo;
        private System.Windows.Forms.TextBox ConsoleTextBox;
        private System.Windows.Forms.Label label2;
    }
}

