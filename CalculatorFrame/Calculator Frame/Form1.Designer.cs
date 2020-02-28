namespace Calculator_Frame
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
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.cbbxSymbol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNum1
            // 
            this.tbxNum1.Font = new System.Drawing.Font("宋体", 12F);
            this.tbxNum1.Location = new System.Drawing.Point(333, 99);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(146, 35);
            this.tbxNum1.TabIndex = 0;
            // 
            // tbxNum2
            // 
            this.tbxNum2.Font = new System.Drawing.Font("宋体", 12F);
            this.tbxNum2.Location = new System.Drawing.Point(333, 173);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(146, 35);
            this.tbxNum2.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("宋体", 12F);
            this.lblNum1.Location = new System.Drawing.Point(125, 102);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(202, 24);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "请输入第一个数：";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("宋体", 12F);
            this.lblNum2.Location = new System.Drawing.Point(125, 176);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(202, 24);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "请输入第二个数：";
            // 
            // cbbxSymbol
            // 
            this.cbbxSymbol.Font = new System.Drawing.Font("宋体", 12F);
            this.cbbxSymbol.FormattingEnabled = true;
            this.cbbxSymbol.Items.AddRange(new object[] {
            "＋",
            "-",
            "×",
            "÷"});
            this.cbbxSymbol.Location = new System.Drawing.Point(333, 246);
            this.cbbxSymbol.Name = "cbbxSymbol";
            this.cbbxSymbol.Size = new System.Drawing.Size(146, 32);
            this.cbbxSymbol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(173, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "请选择符号：";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(268, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 41);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResult.Location = new System.Drawing.Point(245, 380);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 24);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "结果：";
            // 
            // lblResultNum
            // 
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResultNum.Location = new System.Drawing.Point(333, 380);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(133, 30);
            this.lblResultNum.TabIndex = 8;
            //this.lblResultNum.Text = "        ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 490);
            this.Controls.Add(this.lblResultNum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbxSymbol);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.ComboBox cbbxSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultNum;
    }
}

