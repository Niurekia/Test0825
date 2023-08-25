namespace Test0825
{
    partial class Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Conn_Btn = new System.Windows.Forms.Button();
            this.Led01_On = new System.Windows.Forms.Button();
            this.Led01_Off = new System.Windows.Forms.Button();
            this.Led02_On = new System.Windows.Forms.Button();
            this.Led02_Off = new System.Windows.Forms.Button();
            this.Message_Box = new System.Windows.Forms.TextBox();
            this.justLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.Location = new System.Drawing.Point(100, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "COM1";
            // 
            // Conn_Btn
            // 
            this.Conn_Btn.BackColor = System.Drawing.Color.White;
            this.Conn_Btn.ForeColor = System.Drawing.Color.Black;
            this.Conn_Btn.Location = new System.Drawing.Point(231, 51);
            this.Conn_Btn.Name = "Conn_Btn";
            this.Conn_Btn.Size = new System.Drawing.Size(75, 25);
            this.Conn_Btn.TabIndex = 1;
            this.Conn_Btn.Text = "연결";
            this.Conn_Btn.UseVisualStyleBackColor = false;
            this.Conn_Btn.Click += new System.EventHandler(this.Conn_Btn_Click);
            // 
            // Led01_On
            // 
            this.Led01_On.BackColor = System.Drawing.Color.White;
            this.Led01_On.Location = new System.Drawing.Point(100, 107);
            this.Led01_On.Name = "Led01_On";
            this.Led01_On.Size = new System.Drawing.Size(100, 100);
            this.Led01_On.TabIndex = 2;
            this.Led01_On.Text = "Led01_On";
            this.Led01_On.UseVisualStyleBackColor = false;
            this.Led01_On.Click += new System.EventHandler(this.Btn_Led01_On);
            // 
            // Led01_Off
            // 
            this.Led01_Off.BackColor = System.Drawing.Color.White;
            this.Led01_Off.Location = new System.Drawing.Point(206, 107);
            this.Led01_Off.Name = "Led01_Off";
            this.Led01_Off.Size = new System.Drawing.Size(100, 100);
            this.Led01_Off.TabIndex = 3;
            this.Led01_Off.Text = "Led01_Off";
            this.Led01_Off.UseVisualStyleBackColor = false;
            this.Led01_Off.Click += new System.EventHandler(this.Btn_Led01_Off);
            // 
            // Led02_On
            // 
            this.Led02_On.BackColor = System.Drawing.Color.White;
            this.Led02_On.Location = new System.Drawing.Point(312, 107);
            this.Led02_On.Name = "Led02_On";
            this.Led02_On.Size = new System.Drawing.Size(100, 100);
            this.Led02_On.TabIndex = 4;
            this.Led02_On.Text = "Led02_On";
            this.Led02_On.UseVisualStyleBackColor = false;
            this.Led02_On.Click += new System.EventHandler(this.Btn_Led02_On);
            // 
            // Led02_Off
            // 
            this.Led02_Off.BackColor = System.Drawing.Color.White;
            this.Led02_Off.Location = new System.Drawing.Point(418, 107);
            this.Led02_Off.Name = "Led02_Off";
            this.Led02_Off.Size = new System.Drawing.Size(100, 100);
            this.Led02_Off.TabIndex = 5;
            this.Led02_Off.Text = "Led02_Off";
            this.Led02_Off.UseVisualStyleBackColor = false;
            this.Led02_Off.Click += new System.EventHandler(this.Btn_Led02_Off);
            // 
            // Message_Box
            // 
            this.Message_Box.BackColor = System.Drawing.SystemColors.Control;
            this.Message_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message_Box.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Message_Box.Location = new System.Drawing.Point(182, 252);
            this.Message_Box.Name = "Message_Box";
            this.Message_Box.ReadOnly = true;
            this.Message_Box.Size = new System.Drawing.Size(336, 19);
            this.Message_Box.TabIndex = 6;
            this.Message_Box.TextChanged += new System.EventHandler(this.Message_Box_TextChanged);
            // 
            // justLabel
            // 
            this.justLabel.AutoSize = true;
            this.justLabel.Font = new System.Drawing.Font("Curlz MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justLabel.Location = new System.Drawing.Point(95, 244);
            this.justLabel.Name = "justLabel";
            this.justLabel.Size = new System.Drawing.Size(81, 28);
            this.justLabel.TabIndex = 7;
            this.justLabel.Text = "Message:";
            this.justLabel.Click += new System.EventHandler(this.justLabel_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.justLabel);
            this.Controls.Add(this.Message_Box);
            this.Controls.Add(this.Led02_Off);
            this.Controls.Add(this.Led02_On);
            this.Controls.Add(this.Led01_Off);
            this.Controls.Add(this.Led01_On);
            this.Controls.Add(this.Conn_Btn);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Conn_Btn;
        private System.Windows.Forms.Button Led01_On;
        private System.Windows.Forms.Button Led01_Off;
        private System.Windows.Forms.Button Led02_On;
        private System.Windows.Forms.Button Led02_Off;
        private System.Windows.Forms.TextBox Message_Box;
        private System.Windows.Forms.Label justLabel;
    }
}

