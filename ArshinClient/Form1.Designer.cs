namespace ArshinClient
{
    partial class Form1
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
            this.bLoad = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegnum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numVerificationYear = new System.Windows.Forms.NumericUpDown();
            this.cbExact = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVerificationYear)).BeginInit();
            this.SuspendLayout();
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(359, 70);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(116, 33);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Поиск";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // tbResults
            // 
            this.tbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResults.Location = new System.Drawing.Point(22, 119);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResults.Size = new System.Drawing.Size(728, 282);
            this.tbResults.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заводской номер";
            // 
            // tbRegnum
            // 
            this.tbRegnum.Location = new System.Drawing.Point(147, 47);
            this.tbRegnum.Name = "tbRegnum";
            this.tbRegnum.Size = new System.Drawing.Size(182, 20);
            this.tbRegnum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год поверки";
            // 
            // numVerificationYear
            // 
            this.numVerificationYear.Location = new System.Drawing.Point(147, 78);
            this.numVerificationYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numVerificationYear.Name = "numVerificationYear";
            this.numVerificationYear.Size = new System.Drawing.Size(75, 20);
            this.numVerificationYear.TabIndex = 5;
            // 
            // cbExact
            // 
            this.cbExact.AutoSize = true;
            this.cbExact.Checked = true;
            this.cbExact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExact.Location = new System.Drawing.Point(359, 46);
            this.cbExact.Name = "cbExact";
            this.cbExact.Size = new System.Drawing.Size(134, 17);
            this.cbExact.TabIndex = 6;
            this.cbExact.Text = "Точное соответствие";
            this.cbExact.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbExact);
            this.Controls.Add(this.numVerificationYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.bLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numVerificationYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numVerificationYear;
        private System.Windows.Forms.CheckBox cbExact;
    }
}

