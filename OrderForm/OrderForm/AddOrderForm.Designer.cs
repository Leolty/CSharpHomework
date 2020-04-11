namespace OrderForm
{
    partial class AddOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_sure = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入客户名称：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(219, 55);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(218, 28);
            this.textBox_name.TabIndex = 1;
            // 
            // button_sure
            // 
            this.button_sure.Location = new System.Drawing.Point(126, 148);
            this.button_sure.Name = "button_sure";
            this.button_sure.Size = new System.Drawing.Size(87, 38);
            this.button_sure.TabIndex = 2;
            this.button_sure.Text = "确定";
            this.button_sure.UseVisualStyleBackColor = true;
            this.button_sure.Click += new System.EventHandler(this.button_sure_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(297, 148);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 38);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 226);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_sure);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "AddOrderForm";
            this.Text = "添加订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_sure;
        private System.Windows.Forms.Button button_cancel;
    }
}