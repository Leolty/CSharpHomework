namespace CayleyTree
{
    partial class Form
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
            this.panel_draw = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_color = new System.Windows.Forms.Button();
            this.lbl_leftAValue = new System.Windows.Forms.Label();
            this.TB_leftAngle = new System.Windows.Forms.TrackBar();
            this.lbl_rightAValue = new System.Windows.Forms.Label();
            this.TB_rightAngle = new System.Windows.Forms.TrackBar();
            this.lbl_leftRValue = new System.Windows.Forms.Label();
            this.TB_leftRatio = new System.Windows.Forms.TrackBar();
            this.lbl_rightRValue = new System.Windows.Forms.Label();
            this.TB_rightRatio = new System.Windows.Forms.TrackBar();
            this.lbl_lengValue = new System.Windows.Forms.Label();
            this.TB_length = new System.Windows.Forms.TrackBar();
            this.NUD_depth = new System.Windows.Forms.NumericUpDown();
            this.btn_draw = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_leftAngle = new System.Windows.Forms.Label();
            this.lbl_rightAngle = new System.Windows.Forms.Label();
            this.lbl_leftRatio = new System.Windows.Forms.Label();
            this.lbl_rightRatio = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_depth = new System.Windows.Forms.Label();
            this.lbl_setting = new System.Windows.Forms.Label();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_leftAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_rightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_leftRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_rightRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_depth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_draw
            // 
            this.panel_draw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_draw.Location = new System.Drawing.Point(12, 12);
            this.panel_draw.Name = "panel_draw";
            this.panel_draw.Size = new System.Drawing.Size(623, 822);
            this.panel_draw.TabIndex = 0;
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.SystemColors.Control;
            this.panel_control.Controls.Add(this.btn_color);
            this.panel_control.Controls.Add(this.lbl_leftAValue);
            this.panel_control.Controls.Add(this.TB_leftAngle);
            this.panel_control.Controls.Add(this.lbl_rightAValue);
            this.panel_control.Controls.Add(this.TB_rightAngle);
            this.panel_control.Controls.Add(this.lbl_leftRValue);
            this.panel_control.Controls.Add(this.TB_leftRatio);
            this.panel_control.Controls.Add(this.lbl_rightRValue);
            this.panel_control.Controls.Add(this.TB_rightRatio);
            this.panel_control.Controls.Add(this.lbl_lengValue);
            this.panel_control.Controls.Add(this.TB_length);
            this.panel_control.Controls.Add(this.NUD_depth);
            this.panel_control.Controls.Add(this.btn_draw);
            this.panel_control.Controls.Add(this.lbl_color);
            this.panel_control.Controls.Add(this.lbl_leftAngle);
            this.panel_control.Controls.Add(this.lbl_rightAngle);
            this.panel_control.Controls.Add(this.lbl_leftRatio);
            this.panel_control.Controls.Add(this.lbl_rightRatio);
            this.panel_control.Controls.Add(this.lbl_length);
            this.panel_control.Controls.Add(this.lbl_depth);
            this.panel_control.Location = new System.Drawing.Point(641, 85);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(470, 748);
            this.panel_control.TabIndex = 1;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_color.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_color.ForeColor = System.Drawing.Color.Blue;
            this.btn_color.Location = new System.Drawing.Point(204, 512);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(202, 44);
            this.btn_color.TabIndex = 19;
            this.btn_color.Text = "点击选择颜色";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // lbl_leftAValue
            // 
            this.lbl_leftAValue.AutoSize = true;
            this.lbl_leftAValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftAValue.Location = new System.Drawing.Point(397, 447);
            this.lbl_leftAValue.Name = "lbl_leftAValue";
            this.lbl_leftAValue.Size = new System.Drawing.Size(51, 28);
            this.lbl_leftAValue.TabIndex = 18;
            this.lbl_leftAValue.Text = "20°";
            // 
            // TB_leftAngle
            // 
            this.TB_leftAngle.Location = new System.Drawing.Point(204, 437);
            this.TB_leftAngle.Maximum = 90;
            this.TB_leftAngle.Name = "TB_leftAngle";
            this.TB_leftAngle.Size = new System.Drawing.Size(187, 69);
            this.TB_leftAngle.TabIndex = 17;
            this.TB_leftAngle.Value = 20;
            this.TB_leftAngle.Scroll += new System.EventHandler(this.TB_leftAngle_Scroll);
            // 
            // lbl_rightAValue
            // 
            this.lbl_rightAValue.AutoSize = true;
            this.lbl_rightAValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightAValue.Location = new System.Drawing.Point(397, 372);
            this.lbl_rightAValue.Name = "lbl_rightAValue";
            this.lbl_rightAValue.Size = new System.Drawing.Size(51, 28);
            this.lbl_rightAValue.TabIndex = 16;
            this.lbl_rightAValue.Text = "30°";
            // 
            // TB_rightAngle
            // 
            this.TB_rightAngle.Location = new System.Drawing.Point(204, 362);
            this.TB_rightAngle.Maximum = 90;
            this.TB_rightAngle.Name = "TB_rightAngle";
            this.TB_rightAngle.Size = new System.Drawing.Size(187, 69);
            this.TB_rightAngle.TabIndex = 15;
            this.TB_rightAngle.Value = 30;
            this.TB_rightAngle.Scroll += new System.EventHandler(this.TB_rightAngle_Scroll);
            // 
            // lbl_leftRValue
            // 
            this.lbl_leftRValue.AutoSize = true;
            this.lbl_leftRValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leftRValue.Location = new System.Drawing.Point(397, 297);
            this.lbl_leftRValue.Name = "lbl_leftRValue";
            this.lbl_leftRValue.Size = new System.Drawing.Size(51, 28);
            this.lbl_leftRValue.TabIndex = 14;
            this.lbl_leftRValue.Text = "0.7";
            // 
            // TB_leftRatio
            // 
            this.TB_leftRatio.Location = new System.Drawing.Point(204, 287);
            this.TB_leftRatio.Maximum = 100;
            this.TB_leftRatio.Name = "TB_leftRatio";
            this.TB_leftRatio.Size = new System.Drawing.Size(187, 69);
            this.TB_leftRatio.TabIndex = 13;
            this.TB_leftRatio.Value = 70;
            this.TB_leftRatio.Scroll += new System.EventHandler(this.TB_leftRatio_Scroll);
            // 
            // lbl_rightRValue
            // 
            this.lbl_rightRValue.AutoSize = true;
            this.lbl_rightRValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightRValue.Location = new System.Drawing.Point(397, 218);
            this.lbl_rightRValue.Name = "lbl_rightRValue";
            this.lbl_rightRValue.Size = new System.Drawing.Size(51, 28);
            this.lbl_rightRValue.TabIndex = 12;
            this.lbl_rightRValue.Text = "0.6";
            // 
            // TB_rightRatio
            // 
            this.TB_rightRatio.LargeChange = 1;
            this.TB_rightRatio.Location = new System.Drawing.Point(204, 208);
            this.TB_rightRatio.Maximum = 100;
            this.TB_rightRatio.Name = "TB_rightRatio";
            this.TB_rightRatio.Size = new System.Drawing.Size(187, 69);
            this.TB_rightRatio.TabIndex = 11;
            this.TB_rightRatio.Value = 60;
            this.TB_rightRatio.Scroll += new System.EventHandler(this.TB_rightRatio_Scroll);
            // 
            // lbl_lengValue
            // 
            this.lbl_lengValue.AutoSize = true;
            this.lbl_lengValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lengValue.Location = new System.Drawing.Point(397, 137);
            this.lbl_lengValue.Name = "lbl_lengValue";
            this.lbl_lengValue.Size = new System.Drawing.Size(51, 28);
            this.lbl_lengValue.TabIndex = 10;
            this.lbl_lengValue.Text = "100";
            // 
            // TB_length
            // 
            this.TB_length.Location = new System.Drawing.Point(204, 127);
            this.TB_length.Maximum = 200;
            this.TB_length.Name = "TB_length";
            this.TB_length.Size = new System.Drawing.Size(187, 69);
            this.TB_length.TabIndex = 9;
            this.TB_length.Value = 100;
            this.TB_length.Scroll += new System.EventHandler(this.TB_length_Scroll);
            // 
            // NUD_depth
            // 
            this.NUD_depth.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_depth.Location = new System.Drawing.Point(247, 65);
            this.NUD_depth.Name = "NUD_depth";
            this.NUD_depth.Size = new System.Drawing.Size(99, 36);
            this.NUD_depth.TabIndex = 8;
            this.NUD_depth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_depth.ValueChanged += new System.EventHandler(this.NUD_depth_ValueChanged);
            // 
            // btn_draw
            // 
            this.btn_draw.Font = new System.Drawing.Font("方正粗黑宋简体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_draw.Location = new System.Drawing.Point(171, 629);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(134, 52);
            this.btn_draw.TabIndex = 7;
            this.btn_draw.Text = "绘图";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_color.Location = new System.Drawing.Point(47, 512);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(134, 31);
            this.lbl_color.TabIndex = 6;
            this.lbl_color.Text = "画笔颜色：";
            // 
            // lbl_leftAngle
            // 
            this.lbl_leftAngle.AutoSize = true;
            this.lbl_leftAngle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_leftAngle.Location = new System.Drawing.Point(47, 437);
            this.lbl_leftAngle.Name = "lbl_leftAngle";
            this.lbl_leftAngle.Size = new System.Drawing.Size(158, 31);
            this.lbl_leftAngle.TabIndex = 5;
            this.lbl_leftAngle.Text = "左分支角度：";
            // 
            // lbl_rightAngle
            // 
            this.lbl_rightAngle.AutoSize = true;
            this.lbl_rightAngle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rightAngle.Location = new System.Drawing.Point(46, 362);
            this.lbl_rightAngle.Name = "lbl_rightAngle";
            this.lbl_rightAngle.Size = new System.Drawing.Size(158, 31);
            this.lbl_rightAngle.TabIndex = 4;
            this.lbl_rightAngle.Text = "右分支角度：";
            // 
            // lbl_leftRatio
            // 
            this.lbl_leftRatio.AutoSize = true;
            this.lbl_leftRatio.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_leftRatio.Location = new System.Drawing.Point(47, 287);
            this.lbl_leftRatio.Name = "lbl_leftRatio";
            this.lbl_leftRatio.Size = new System.Drawing.Size(182, 31);
            this.lbl_leftRatio.TabIndex = 3;
            this.lbl_leftRatio.Text = "左分支长度比：";
            // 
            // lbl_rightRatio
            // 
            this.lbl_rightRatio.AutoSize = true;
            this.lbl_rightRatio.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_rightRatio.Location = new System.Drawing.Point(47, 208);
            this.lbl_rightRatio.Name = "lbl_rightRatio";
            this.lbl_rightRatio.Size = new System.Drawing.Size(182, 31);
            this.lbl_rightRatio.TabIndex = 2;
            this.lbl_rightRatio.Text = "右分支长度比：";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_length.Location = new System.Drawing.Point(47, 137);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(134, 31);
            this.lbl_length.TabIndex = 1;
            this.lbl_length.Text = "主干长度：";
            // 
            // lbl_depth
            // 
            this.lbl_depth.AutoSize = true;
            this.lbl_depth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_depth.Location = new System.Drawing.Point(47, 67);
            this.lbl_depth.Name = "lbl_depth";
            this.lbl_depth.Size = new System.Drawing.Size(134, 31);
            this.lbl_depth.TabIndex = 0;
            this.lbl_depth.Text = "递归深度：";
            // 
            // lbl_setting
            // 
            this.lbl_setting.AutoSize = true;
            this.lbl_setting.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_setting.Font = new System.Drawing.Font("方正粗黑宋简体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_setting.Location = new System.Drawing.Point(817, 22);
            this.lbl_setting.Name = "lbl_setting";
            this.lbl_setting.Size = new System.Drawing.Size(186, 49);
            this.lbl_setting.TabIndex = 2;
            this.lbl_setting.Text = "属性设置";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1115, 842);
            this.Controls.Add(this.lbl_setting);
            this.Controls.Add(this.panel_control);
            this.Controls.Add(this.panel_draw);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Cayley Tree";
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_leftAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_rightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_leftRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_rightRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_depth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_draw;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_leftAngle;
        private System.Windows.Forms.Label lbl_rightAngle;
        private System.Windows.Forms.Label lbl_leftRatio;
        private System.Windows.Forms.Label lbl_rightRatio;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_depth;
        private System.Windows.Forms.Label lbl_setting;
        private System.Windows.Forms.NumericUpDown NUD_depth;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Label lbl_leftAValue;
        private System.Windows.Forms.TrackBar TB_leftAngle;
        private System.Windows.Forms.Label lbl_rightAValue;
        private System.Windows.Forms.TrackBar TB_rightAngle;
        private System.Windows.Forms.Label lbl_leftRValue;
        private System.Windows.Forms.TrackBar TB_leftRatio;
        private System.Windows.Forms.Label lbl_rightRValue;
        private System.Windows.Forms.TrackBar TB_rightRatio;
        private System.Windows.Forms.Label lbl_lengValue;
        private System.Windows.Forms.TrackBar TB_length;
    }
}

