namespace ScottyApps.LoanCalc
{
    partial class LoanCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAvgLoanBaseAndInterests = new System.Windows.Forms.GroupBox();
            this.gbxAvgLoanBase = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMonthly = new System.Windows.Forms.RadioButton();
            this.rbtnQuarterly = new System.Windows.Forms.RadioButton();
            this.txtTotalLoanBase = new System.Windows.Forms.TextBox();
            this.txtYearInterestRate = new System.Windows.Forms.TextBox();
            this.cbxYears = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInterestsForLoanBaseAndInterests = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCyclePayForInterests = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInterestsForLoanBase = new System.Windows.Forms.TextBox();
            this.rtxtCyclePays = new System.Windows.Forms.RichTextBox();
            this.gbxAvgLoanBaseAndInterests.SuspendLayout();
            this.gbxAvgLoanBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAvgLoanBaseAndInterests
            // 
            this.gbxAvgLoanBaseAndInterests.Controls.Add(this.tableLayoutPanel2);
            this.gbxAvgLoanBaseAndInterests.Location = new System.Drawing.Point(12, 223);
            this.gbxAvgLoanBaseAndInterests.Name = "gbxAvgLoanBaseAndInterests";
            this.gbxAvgLoanBaseAndInterests.Size = new System.Drawing.Size(198, 188);
            this.gbxAvgLoanBaseAndInterests.TabIndex = 0;
            this.gbxAvgLoanBaseAndInterests.TabStop = false;
            this.gbxAvgLoanBaseAndInterests.Text = "等额本息";
            // 
            // gbxAvgLoanBase
            // 
            this.gbxAvgLoanBase.Controls.Add(this.tableLayoutPanel3);
            this.gbxAvgLoanBase.Location = new System.Drawing.Point(216, 12);
            this.gbxAvgLoanBase.Name = "gbxAvgLoanBase";
            this.gbxAvgLoanBase.Size = new System.Drawing.Size(423, 399);
            this.gbxAvgLoanBase.TabIndex = 1;
            this.gbxAvgLoanBase.TabStop = false;
            this.gbxAvgLoanBase.Text = "等额本金";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCalc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalLoanBase, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtYearInterestRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxYears, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 188);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "贷款年利率";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "按揭周期";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "贷款金额";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "贷款年限";
            // 
            // btnCalc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCalc, 2);
            this.btnCalc.Location = new System.Drawing.Point(3, 162);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(192, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnQuarterly);
            this.groupBox1.Controls.Add(this.rbtnMonthly);
            this.groupBox1.Location = new System.Drawing.Point(74, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择按揭周期";
            // 
            // rbtnMonthly
            // 
            this.rbtnMonthly.AutoSize = true;
            this.rbtnMonthly.Checked = true;
            this.rbtnMonthly.Location = new System.Drawing.Point(29, 24);
            this.rbtnMonthly.Name = "rbtnMonthly";
            this.rbtnMonthly.Size = new System.Drawing.Size(71, 16);
            this.rbtnMonthly.TabIndex = 0;
            this.rbtnMonthly.TabStop = true;
            this.rbtnMonthly.Text = "按月还贷";
            this.rbtnMonthly.UseVisualStyleBackColor = true;
            // 
            // rbtnQuarterly
            // 
            this.rbtnQuarterly.AutoSize = true;
            this.rbtnQuarterly.Location = new System.Drawing.Point(29, 46);
            this.rbtnQuarterly.Name = "rbtnQuarterly";
            this.rbtnQuarterly.Size = new System.Drawing.Size(71, 16);
            this.rbtnQuarterly.TabIndex = 1;
            this.rbtnQuarterly.Text = "按季还贷";
            this.rbtnQuarterly.UseVisualStyleBackColor = true;
            // 
            // txtTotalLoanBase
            // 
            this.txtTotalLoanBase.Location = new System.Drawing.Point(74, 3);
            this.txtTotalLoanBase.Name = "txtTotalLoanBase";
            this.txtTotalLoanBase.Size = new System.Drawing.Size(118, 21);
            this.txtTotalLoanBase.TabIndex = 4;
            // 
            // txtYearInterestRate
            // 
            this.txtYearInterestRate.Location = new System.Drawing.Point(74, 56);
            this.txtYearInterestRate.Name = "txtYearInterestRate";
            this.txtYearInterestRate.Size = new System.Drawing.Size(118, 21);
            this.txtYearInterestRate.TabIndex = 5;
            // 
            // cbxYears
            // 
            this.cbxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxYears.FormattingEnabled = true;
            this.cbxYears.Location = new System.Drawing.Point(74, 30);
            this.cbxYears.MaxDropDownItems = 30;
            this.cbxYears.Name = "cbxYears";
            this.cbxYears.Size = new System.Drawing.Size(121, 20);
            this.cbxYears.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInterestsForLoanBaseAndInterests, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCyclePayForInterests, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.16545F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.83455F));
            this.tableLayoutPanel3.Controls.Add(this.txtInterestsForLoanBase, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rtxtCyclePays, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.238606F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.76139F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(411, 373);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "实际支付利息";
            // 
            // txtInterestsForLoanBaseAndInterests
            // 
            this.txtInterestsForLoanBaseAndInterests.Enabled = false;
            this.txtInterestsForLoanBaseAndInterests.Location = new System.Drawing.Point(63, 3);
            this.txtInterestsForLoanBaseAndInterests.Name = "txtInterestsForLoanBaseAndInterests";
            this.txtInterestsForLoanBaseAndInterests.Size = new System.Drawing.Size(123, 21);
            this.txtInterestsForLoanBaseAndInterests.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "按揭金额";
            // 
            // txtCyclePayForInterests
            // 
            this.txtCyclePayForInterests.Enabled = false;
            this.txtCyclePayForInterests.Location = new System.Drawing.Point(63, 53);
            this.txtCyclePayForInterests.Name = "txtCyclePayForInterests";
            this.txtCyclePayForInterests.Size = new System.Drawing.Size(123, 21);
            this.txtCyclePayForInterests.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "实际支付利息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "按揭金额";
            // 
            // txtInterestsForLoanBase
            // 
            this.txtInterestsForLoanBase.Enabled = false;
            this.txtInterestsForLoanBase.Location = new System.Drawing.Point(52, 3);
            this.txtInterestsForLoanBase.Name = "txtInterestsForLoanBase";
            this.txtInterestsForLoanBase.Size = new System.Drawing.Size(281, 21);
            this.txtInterestsForLoanBase.TabIndex = 2;
            // 
            // rtxtCyclePays
            // 
            this.rtxtCyclePays.Location = new System.Drawing.Point(52, 30);
            this.rtxtCyclePays.Name = "rtxtCyclePays";
            this.rtxtCyclePays.Size = new System.Drawing.Size(356, 340);
            this.rtxtCyclePays.TabIndex = 4;
            this.rtxtCyclePays.Text = "";
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 439);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbxAvgLoanBase);
            this.Controls.Add(this.gbxAvgLoanBaseAndInterests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoanCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LoanCalculator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.LoanCalculator_Load);
            this.gbxAvgLoanBaseAndInterests.ResumeLayout(false);
            this.gbxAvgLoanBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAvgLoanBaseAndInterests;
        private System.Windows.Forms.GroupBox gbxAvgLoanBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnQuarterly;
        private System.Windows.Forms.RadioButton rbtnMonthly;
        private System.Windows.Forms.TextBox txtTotalLoanBase;
        private System.Windows.Forms.TextBox txtYearInterestRate;
        private System.Windows.Forms.ComboBox cbxYears;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterestsForLoanBaseAndInterests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCyclePayForInterests;
        private System.Windows.Forms.TextBox txtInterestsForLoanBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtCyclePays;
    }
}