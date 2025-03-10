namespace HappyWorld
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.textCm = new System.Windows.Forms.TextBox();
            this.textM = new System.Windows.Forms.TextBox();
            this.textKm = new System.Windows.Forms.TextBox();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textFt = new System.Windows.Forms.TextBox();
            this.textYard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(143, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(453, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "公里";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(301, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "公尺";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(143, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "英吋";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(453, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(301, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "英尺";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(147, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCm
            // 
            this.textCm.Location = new System.Drawing.Point(147, 132);
            this.textCm.Name = "textCm";
            this.textCm.Size = new System.Drawing.Size(83, 25);
            this.textCm.TabIndex = 7;
            this.textCm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCm_KeyUp);
            // 
            // textM
            // 
            this.textM.Location = new System.Drawing.Point(305, 132);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(83, 25);
            this.textM.TabIndex = 8;
            // 
            // textKm
            // 
            this.textKm.Location = new System.Drawing.Point(457, 132);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(83, 25);
            this.textKm.TabIndex = 9;
            // 
            // textIn
            // 
            this.textIn.Location = new System.Drawing.Point(147, 222);
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(83, 25);
            this.textIn.TabIndex = 10;
            // 
            // textFt
            // 
            this.textFt.Location = new System.Drawing.Point(305, 222);
            this.textFt.Name = "textFt";
            this.textFt.Size = new System.Drawing.Size(83, 25);
            this.textFt.TabIndex = 11;
            // 
            // textYard
            // 
            this.textYard.Location = new System.Drawing.Point(457, 222);
            this.textYard.Name = "textYard";
            this.textYard.Size = new System.Drawing.Size(83, 25);
            this.textYard.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(143, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "說明文字";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(147, 311);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(393, 25);
            this.textInfo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textYard);
            this.Controls.Add(this.textFt);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.textCm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textCm;
        private System.Windows.Forms.TextBox textM;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textFt;
        private System.Windows.Forms.TextBox textYard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textInfo;
    }
}

