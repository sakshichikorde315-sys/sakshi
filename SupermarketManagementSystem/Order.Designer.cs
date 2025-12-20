namespace SupermarketManagementSystem
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.OrderId = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.supermarketDBDataSet3 = new SupermarketManagementSystem.SupermarketDBDataSet3();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new SupermarketManagementSystem.SupermarketDBDataSet3TableAdapters.OrdersTableAdapter();
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.supermarketDBDataSet4 = new SupermarketManagementSystem.SupermarketDBDataSet4();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new SupermarketManagementSystem.SupermarketDBDataSet4TableAdapters.OrdersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.supermarketDBDataSet5 = new SupermarketManagementSystem.SupermarketDBDataSet5();
            this.ordersTableAdapter2 = new SupermarketManagementSystem.SupermarketDBDataSet5TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(158, 201);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(333, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(527, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OrderId
            // 
            this.OrderId.AutoSize = true;
            this.OrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderId.Location = new System.Drawing.Point(289, 35);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(57, 15);
            this.OrderId.TabIndex = 3;
            this.OrderId.Text = "OrderID";
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSize = true;
            this.CustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerId.Location = new System.Drawing.Point(289, 70);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(82, 15);
            this.CustomerId.TabIndex = 4;
            this.CustomerId.Text = "CustomerID";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.Location = new System.Drawing.Point(289, 109);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(70, 15);
            this.ProductId.TabIndex = 5;
            this.ProductId.Text = "ProductID";
            this.ProductId.Click += new System.EventHandler(this.ProductId_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(377, 30);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtOrderId.TabIndex = 6;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(377, 104);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 7;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(377, 65);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 8;
            // 
            // supermarketDBDataSet3
            // 
            this.supermarketDBDataSet3.DataSetName = "SupermarketDBDataSet3";
            this.supermarketDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.supermarketDBDataSet3;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(289, 147);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(59, 15);
            this.Quantity.TabIndex = 9;
            this.Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(377, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 11;
            // 
            // supermarketDBDataSet4
            // 
            this.supermarketDBDataSet4.DataSetName = "SupermarketDBDataSet4";
            this.supermarketDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.supermarketDBDataSet4;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(158, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 169);
            this.dataGridView1.TabIndex = 12;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.supermarketDBDataSet5;
            // 
            // supermarketDBDataSet5
            // 
            this.supermarketDBDataSet5.DataSetName = "SupermarketDBDataSet5";
            this.supermarketDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(773, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermarketDBDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label OrderId;
        private System.Windows.Forms.Label CustomerId;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private SupermarketDBDataSet3 supermarketDBDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SupermarketDBDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private SupermarketDBDataSet4 supermarketDBDataSet4;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private SupermarketDBDataSet4TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SupermarketDBDataSet5 supermarketDBDataSet5;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private SupermarketDBDataSet5TableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}