namespace StubWinFrms
{
    partial class StubFrm
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
            this.ShowConsoleBtn = new System.Windows.Forms.Button();
            this.ShowMessageBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowConsoleBtn
            // 
            this.ShowConsoleBtn.Location = new System.Drawing.Point(12, 12);
            this.ShowConsoleBtn.Name = "ShowConsoleBtn";
            this.ShowConsoleBtn.Size = new System.Drawing.Size(215, 30);
            this.ShowConsoleBtn.TabIndex = 0;
            this.ShowConsoleBtn.TabStop = false;
            this.ShowConsoleBtn.Text = "Open Console";
            this.ShowConsoleBtn.UseVisualStyleBackColor = true;
            this.ShowConsoleBtn.Click += new System.EventHandler(this.ShowConsoleBtn_Click);
            // 
            // ShowMessageBoxBtn
            // 
            this.ShowMessageBoxBtn.Location = new System.Drawing.Point(12, 48);
            this.ShowMessageBoxBtn.Name = "ShowMessageBoxBtn";
            this.ShowMessageBoxBtn.Size = new System.Drawing.Size(215, 30);
            this.ShowMessageBoxBtn.TabIndex = 1;
            this.ShowMessageBoxBtn.TabStop = false;
            this.ShowMessageBoxBtn.Text = "Show Message";
            this.ShowMessageBoxBtn.UseVisualStyleBackColor = true;
            this.ShowMessageBoxBtn.Click += new System.EventHandler(this.ShowMessageBoxBtn_Click);
            // 
            // StubFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 130);
            this.Controls.Add(this.ShowMessageBoxBtn);
            this.Controls.Add(this.ShowConsoleBtn);
            this.Name = "StubFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stub";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowConsoleBtn;
        private System.Windows.Forms.Button ShowMessageBoxBtn;
    }
}

