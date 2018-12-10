namespace Task4
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainPB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPB
            // 
            this.MainPB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPB.Location = new System.Drawing.Point(0, 0);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(382, 353);
            this.MainPB.TabIndex = 0;
            this.MainPB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.MainPB);
            this.Name = "MainForm";
            this.Text = "Доменная печь";
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MainPB;
        private System.Windows.Forms.Timer timer1;
    }
}

