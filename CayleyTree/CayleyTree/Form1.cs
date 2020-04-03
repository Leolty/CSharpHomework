using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private Graphics graphics;

        int n = 10;//递归深度
        int leng = 100;//主干长度
        double per1 = 0.6;//右分支长度比
        double per2 = 0.7;//左分支长度比
        double th1 = 30 * Math.PI / 180;//右分支角度
        double th2 = 20 * Math.PI / 180;//做分支角度
        
        //递归作图
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        //画线
        void drawLine(double x0, double y0, double x1, double y1)
        {
            //将选择的颜色传递进来（默认为蓝色）
            Pen mypen = new Pen(btn_color.ForeColor);

            graphics.DrawLine(mypen
            , (int)x0, (int)y0, (int)x1, (int)y1);
        }

        //获取递归深度
        private void NUD_depth_ValueChanged(object sender, EventArgs e)
        {
            n = Int32.Parse(NUD_depth.Value.ToString());
        }

        //根据TrackBar的值改变Label的值，并获取主干长度
        private void TB_length_Scroll(object sender, EventArgs e)
        {
            lbl_lengValue.Text = TB_length.Value.ToString();
            leng = Int32.Parse(lbl_lengValue.Text);
        }

        //根据TrackBar的值改变Label的值，并获取右分支长度比
        private void TB_rightRatio_Scroll(object sender, EventArgs e)
        {
            double txt = Double.Parse(TB_rightRatio.Value.ToString());
            lbl_rightRValue.Text = (txt / 100).ToString();
            per1 = Double.Parse(lbl_rightRValue.Text);
        }

        //根据TrackBar的值改变Label的值，并获取左分支长度比
        private void TB_leftRatio_Scroll(object sender, EventArgs e)
        {
            double txt = Double.Parse(TB_leftRatio.Value.ToString());
            lbl_leftRValue.Text = (txt / 100).ToString();
            per2 = Double.Parse(lbl_leftRValue.Text);
        }

        //根据TrackBar的值改变Label的值，并获取右分支角度
        private void TB_rightAngle_Scroll(object sender, EventArgs e)
        {
            int txt = Int32.Parse(TB_rightAngle.Value.ToString());
            lbl_rightAValue.Text = txt.ToString() + "°";
            th1 = txt * Math.PI / 180;
        }

        //根据TrackBar的值改变Label的值，并获取左分支角度
        private void TB_leftAngle_Scroll(object sender, EventArgs e)
        {
            int txt = Int32.Parse(TB_leftAngle.Value.ToString());
            lbl_leftAValue.Text = txt.ToString() + "°";
            th2 = txt * Math.PI / 180;
        }

        //定义颜色窗口
        ColorDialog colorDialog = new ColorDialog();

        //点击按钮后，颜色窗口出现，并根据所选颜色改变按钮字的颜色
        private void btn_color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            //colorDialog.FullOpen = true;
            btn_color.ForeColor = colorDialog.Color;
        }

        //点击绘画
        private void btn_draw_Click(object sender, EventArgs e)
        {
            //每次绘图前，先创建一个与绘图Panel同宽高的白色填充矩形从而达到清空的效果
            Rectangle rect = new Rectangle(0, 0, panel_draw.Width, panel_draw.Height);
            using (Graphics g = panel_draw.CreateGraphics())
            {
                g.FillRectangle(Brushes.White,rect);
            }

            //绘图
            if (graphics == null)
            graphics = panel_draw.CreateGraphics();
            drawCayleyTree(n, 310, 710, leng, -Math.PI / 2);
        }
    }
}
