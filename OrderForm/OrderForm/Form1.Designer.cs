namespace OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_query = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.queryCategoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_revise = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_query);
            this.panel1.Controls.Add(this.queryTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.queryCategoryBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_deleteItem);
            this.panel1.Controls.Add(this.btn_addItem);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_revise);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1891, 128);
            this.panel1.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(812, 26);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(154, 36);
            this.btn_query.TabIndex = 9;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(452, 30);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(299, 28);
            this.queryTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "查询内容：";
            // 
            // queryCategoryBox
            // 
            this.queryCategoryBox.FormattingEnabled = true;
            this.queryCategoryBox.Items.AddRange(new object[] {
            "客户姓名",
            "商品名称"});
            this.queryCategoryBox.Location = new System.Drawing.Point(169, 32);
            this.queryCategoryBox.Name = "queryCategoryBox";
            this.queryCategoryBox.Size = new System.Drawing.Size(121, 26);
            this.queryCategoryBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "查询方式：";
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(851, 85);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(145, 37);
            this.btn_deleteItem.TabIndex = 4;
            this.btn_deleteItem.Text = "删除商品";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(641, 85);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(145, 37);
            this.btn_addItem.TabIndex = 3;
            this.btn_addItem.Text = "添加商品";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(441, 85);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 37);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除订单";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_revise
            // 
            this.btn_revise.Location = new System.Drawing.Point(232, 85);
            this.btn_revise.Name = "btn_revise";
            this.btn_revise.Size = new System.Drawing.Size(145, 37);
            this.btn_revise.TabIndex = 1;
            this.btn_revise.Text = "修改订单";
            this.btn_revise.UseVisualStyleBackColor = true;
            this.btn_revise.Click += new System.EventHandler(this.btn_revise_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(42, 85);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(145, 37);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加订单";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 128);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.orderDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.orderItemDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1891, 897);
            this.splitContainer1.SplitterDistance = 855;
            this.splitContainer1.TabIndex = 1;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 30;
            this.orderDataGridView.Size = new System.Drawing.Size(855, 897);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.SelectionChanged += new System.EventHandler(this.orderDataGridView_SelectionChanged);
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.orderItemDataGridView.DataSource = this.orderItemBindingSource;
            this.orderItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowTemplate.Height = 30;
            this.orderItemDataGridView.Size = new System.Drawing.Size(1032, 897);
            this.orderItemDataGridView.TabIndex = 0;
            this.orderItemDataGridView.SelectionChanged += new System.EventHandler(this.orderItemDataGridView_SelectionChanged);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(OrderApp.OrderItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 1025);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "订单";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_revise;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox queryCategoryBox;
        private System.Windows.Forms.Label label1;
    }
}

