namespace OrderForm
{
    partial class AddItemOrderForm
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
            this.Item_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_num = new System.Windows.Forms.Label();
            this.button_sure = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // Item_comboBox
            // 
            this.Item_comboBox.FormattingEnabled = true;
            this.Item_comboBox.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Mask",
            "Pencil",
            "Cup",
            "Candy",
            "IPhone 11"});
            this.Item_comboBox.Location = new System.Drawing.Point(147, 58);
            this.Item_comboBox.Name = "Item_comboBox";
            this.Item_comboBox.Size = new System.Drawing.Size(198, 26);
            this.Item_comboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量：";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(522, 47);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 69);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(782, 59);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(17, 18);
            this.lbl_num.TabIndex = 4;
            this.lbl_num.Text = "0";
            // 
            // button_sure
            // 
            this.button_sure.Location = new System.Drawing.Point(470, 154);
            this.button_sure.Name = "button_sure";
            this.button_sure.Size = new System.Drawing.Size(115, 41);
            this.button_sure.TabIndex = 5;
            this.button_sure.Text = "添加";
            this.button_sure.UseVisualStyleBackColor = true;
            this.button_sure.Click += new System.EventHandler(this.button_sure_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(640, 154);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(111, 41);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddItemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 256);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_sure);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Item_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddItemOrderForm";
            this.Text = "AddItemOrder";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Item_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button button_sure;
        private System.Windows.Forms.Button button_cancel;
    }
}