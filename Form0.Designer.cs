
namespace midTermWindowApp
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLotto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLotto649 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMoneyExchange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTempConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnIPValid = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(15, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLotto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLotto649);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 331);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // btnLotto
            // 
            this.btnLotto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLotto.BackgroundImage")));
            this.btnLotto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotto.Location = new System.Drawing.Point(81, 59);
            this.btnLotto.Name = "btnLotto";
            this.btnLotto.Size = new System.Drawing.Size(248, 184);
            this.btnLotto.TabIndex = 0;
            this.btnLotto.UseVisualStyleBackColor = true;
            this.btnLotto.Click += new System.EventHandler(this.btnLotto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lotto 649";
            // 
            // btnLotto649
            // 
            this.btnLotto649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLotto649.BackgroundImage")));
            this.btnLotto649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLotto649.Location = new System.Drawing.Point(402, 59);
            this.btnLotto649.Name = "btnLotto649";
            this.btnLotto649.Size = new System.Drawing.Size(254, 184);
            this.btnLotto649.TabIndex = 1;
            this.btnLotto649.UseVisualStyleBackColor = true;
            this.btnLotto649.Click += new System.EventHandler(this.btnLotto649_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lotto Max";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMoneyExchange);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnTempConvert);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(66, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 330);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversions";
            // 
            // btnMoneyExchange
            // 
            this.btnMoneyExchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMoneyExchange.BackgroundImage")));
            this.btnMoneyExchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoneyExchange.Location = new System.Drawing.Point(76, 63);
            this.btnMoneyExchange.Name = "btnMoneyExchange";
            this.btnMoneyExchange.Size = new System.Drawing.Size(224, 172);
            this.btnMoneyExchange.TabIndex = 0;
            this.btnMoneyExchange.UseVisualStyleBackColor = true;
            this.btnMoneyExchange.Click += new System.EventHandler(this.btnMoneyExchange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature Convert";
            // 
            // btnTempConvert
            // 
            this.btnTempConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTempConvert.BackgroundImage")));
            this.btnTempConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTempConvert.Location = new System.Drawing.Point(406, 63);
            this.btnTempConvert.Name = "btnTempConvert";
            this.btnTempConvert.Size = new System.Drawing.Size(216, 172);
            this.btnTempConvert.TabIndex = 1;
            this.btnTempConvert.UseVisualStyleBackColor = true;
            this.btnTempConvert.Click += new System.EventHandler(this.btnTempConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money Exchange";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculator);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(817, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.BackgroundImage")));
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.Location = new System.Drawing.Point(269, 52);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(286, 325);
            this.btnCalculator.TabIndex = 0;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnIPValid);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(817, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP v4 Validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnIPValid
            // 
            this.btnIPValid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIPValid.BackgroundImage")));
            this.btnIPValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIPValid.Location = new System.Drawing.Point(233, 106);
            this.btnIPValid.Name = "btnIPValid";
            this.btnIPValid.Size = new System.Drawing.Size(263, 228);
            this.btnIPValid.TabIndex = 0;
            this.btnIPValid.UseVisualStyleBackColor = true;
            this.btnIPValid.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(356, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 44);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form0";
            this.Text = "Dashboard Rameswari Bhoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLotto649;
        private System.Windows.Forms.Button btnLotto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTempConvert;
        private System.Windows.Forms.Button btnMoneyExchange;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnIPValid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

