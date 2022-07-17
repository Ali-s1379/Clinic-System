namespace Clinic_System
{
    partial class OrdersForm
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
            this.lblPersonnelIdOrders = new System.Windows.Forms.Label();
            this.lblOrderIdOrders = new System.Windows.Forms.Label();
            this.lblProductNameOrders = new System.Windows.Forms.Label();
            this.lblProductTypeOrders = new System.Windows.Forms.Label();
            this.lblProductNumberOrders = new System.Windows.Forms.Label();
            this.lblOrderDateOrders = new System.Windows.Forms.Label();
            this.lblOrderPriceOrders = new System.Windows.Forms.Label();
            this.btnInsertOrders = new System.Windows.Forms.Button();
            this.cmbBoxProductType = new System.Windows.Forms.ComboBox();
            this.txtBoxOrderId = new System.Windows.Forms.TextBox();
            this.txtBoxPersonnelIdDoctor = new System.Windows.Forms.TextBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductNumber = new System.Windows.Forms.TextBox();
            this.txtBoxOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.txtBoxOrderIdUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonnelIdOrders
            // 
            this.lblPersonnelIdOrders.AutoSize = true;
            this.lblPersonnelIdOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnelIdOrders.Location = new System.Drawing.Point(233, 105);
            this.lblPersonnelIdOrders.Name = "lblPersonnelIdOrders";
            this.lblPersonnelIdOrders.Size = new System.Drawing.Size(84, 16);
            this.lblPersonnelIdOrders.TabIndex = 4;
            this.lblPersonnelIdOrders.Text = ": شماره پرسنلی";
            // 
            // lblOrderIdOrders
            // 
            this.lblOrderIdOrders.AutoSize = true;
            this.lblOrderIdOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdOrders.Location = new System.Drawing.Point(526, 105);
            this.lblOrderIdOrders.Name = "lblOrderIdOrders";
            this.lblOrderIdOrders.Size = new System.Drawing.Size(68, 16);
            this.lblOrderIdOrders.TabIndex = 5;
            this.lblOrderIdOrders.Text = ": کد سفارش";
            // 
            // lblProductNameOrders
            // 
            this.lblProductNameOrders.AutoSize = true;
            this.lblProductNameOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNameOrders.Location = new System.Drawing.Point(544, 161);
            this.lblProductNameOrders.Name = "lblProductNameOrders";
            this.lblProductNameOrders.Size = new System.Drawing.Size(50, 16);
            this.lblProductNameOrders.TabIndex = 6;
            this.lblProductNameOrders.Text = ": نام کالا";
            // 
            // lblProductTypeOrders
            // 
            this.lblProductTypeOrders.AutoSize = true;
            this.lblProductTypeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeOrders.Location = new System.Drawing.Point(263, 161);
            this.lblProductTypeOrders.Name = "lblProductTypeOrders";
            this.lblProductTypeOrders.Size = new System.Drawing.Size(54, 16);
            this.lblProductTypeOrders.TabIndex = 7;
            this.lblProductTypeOrders.Text = ": نوع کالا";
            this.lblProductTypeOrders.Click += new System.EventHandler(this.lblProductTypeOrders_Click);
            // 
            // lblProductNumberOrders
            // 
            this.lblProductNumberOrders.AutoSize = true;
            this.lblProductNumberOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductNumberOrders.Location = new System.Drawing.Point(64, 161);
            this.lblProductNumberOrders.Name = "lblProductNumberOrders";
            this.lblProductNumberOrders.Size = new System.Drawing.Size(59, 16);
            this.lblProductNumberOrders.TabIndex = 8;
            this.lblProductNumberOrders.Text = ": تعداد کالا";
            // 
            // lblOrderDateOrders
            // 
            this.lblOrderDateOrders.AutoSize = true;
            this.lblOrderDateOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDateOrders.Location = new System.Drawing.Point(511, 211);
            this.lblOrderDateOrders.Name = "lblOrderDateOrders";
            this.lblOrderDateOrders.Size = new System.Drawing.Size(83, 16);
            this.lblOrderDateOrders.TabIndex = 9;
            this.lblOrderDateOrders.Text = ": تاریخ سفارش";
            // 
            // lblOrderPriceOrders
            // 
            this.lblOrderPriceOrders.AutoSize = true;
            this.lblOrderPriceOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPriceOrders.Location = new System.Drawing.Point(263, 211);
            this.lblOrderPriceOrders.Name = "lblOrderPriceOrders";
            this.lblOrderPriceOrders.Size = new System.Drawing.Size(38, 16);
            this.lblOrderPriceOrders.TabIndex = 10;
            this.lblOrderPriceOrders.Text = ": قیمت";
            // 
            // btnInsertOrders
            // 
            this.btnInsertOrders.Location = new System.Drawing.Point(273, 263);
            this.btnInsertOrders.Name = "btnInsertOrders";
            this.btnInsertOrders.Size = new System.Drawing.Size(75, 23);
            this.btnInsertOrders.TabIndex = 11;
            this.btnInsertOrders.Text = "ثبت سفارش";
            this.btnInsertOrders.UseVisualStyleBackColor = true;
            this.btnInsertOrders.Click += new System.EventHandler(this.btnInsertOrders_Click);
            // 
            // cmbBoxProductType
            // 
            this.cmbBoxProductType.FormattingEnabled = true;
            this.cmbBoxProductType.Items.AddRange(new object[] {
            "اداری",
            "پزشکی"});
            this.cmbBoxProductType.Location = new System.Drawing.Point(129, 155);
            this.cmbBoxProductType.Name = "cmbBoxProductType";
            this.cmbBoxProductType.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxProductType.TabIndex = 12;
            // 
            // txtBoxOrderId
            // 
            this.txtBoxOrderId.Location = new System.Drawing.Point(420, 104);
            this.txtBoxOrderId.Name = "txtBoxOrderId";
            this.txtBoxOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderId.TabIndex = 13;
            // 
            // txtBoxPersonnelIdDoctor
            // 
            this.txtBoxPersonnelIdDoctor.Location = new System.Drawing.Point(127, 104);
            this.txtBoxPersonnelIdDoctor.Name = "txtBoxPersonnelIdDoctor";
            this.txtBoxPersonnelIdDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPersonnelIdDoctor.TabIndex = 14;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(339, 156);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(181, 20);
            this.txtBoxProductName.TabIndex = 15;
            // 
            // txtBoxProductNumber
            // 
            this.txtBoxProductNumber.Location = new System.Drawing.Point(11, 157);
            this.txtBoxProductNumber.Name = "txtBoxProductNumber";
            this.txtBoxProductNumber.Size = new System.Drawing.Size(47, 20);
            this.txtBoxProductNumber.TabIndex = 16;
            // 
            // txtBoxOrderDate
            // 
            this.txtBoxOrderDate.Location = new System.Drawing.Point(405, 207);
            this.txtBoxOrderDate.Name = "txtBoxOrderDate";
            this.txtBoxOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderDate.TabIndex = 17;
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(157, 207);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(100, 20);
            this.txtOrderPrice.TabIndex = 18;
            // 
            // txtBoxOrderIdUpdate
            // 
            this.txtBoxOrderIdUpdate.Location = new System.Drawing.Point(367, 36);
            this.txtBoxOrderIdUpdate.Name = "txtBoxOrderIdUpdate";
            this.txtBoxOrderIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderIdUpdate.TabIndex = 20;
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOrder.Location = new System.Drawing.Point(473, 36);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(121, 16);
            this.lblUpdateOrder.TabIndex = 19;
            this.lblUpdateOrder.Text = ": کد سفارش برای تغییر";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(67, 36);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(121, 23);
            this.btnEditOrder.TabIndex = 21;
            this.btnEditOrder.Text = "تغییر سفارش";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 308);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.txtBoxOrderIdUpdate);
            this.Controls.Add(this.lblUpdateOrder);
            this.Controls.Add(this.txtOrderPrice);
            this.Controls.Add(this.txtBoxOrderDate);
            this.Controls.Add(this.txtBoxProductNumber);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxPersonnelIdDoctor);
            this.Controls.Add(this.txtBoxOrderId);
            this.Controls.Add(this.cmbBoxProductType);
            this.Controls.Add(this.btnInsertOrders);
            this.Controls.Add(this.lblOrderPriceOrders);
            this.Controls.Add(this.lblOrderDateOrders);
            this.Controls.Add(this.lblProductNumberOrders);
            this.Controls.Add(this.lblProductTypeOrders);
            this.Controls.Add(this.lblProductNameOrders);
            this.Controls.Add(this.lblOrderIdOrders);
            this.Controls.Add(this.lblPersonnelIdOrders);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonnelIdOrders;
        private System.Windows.Forms.Label lblOrderIdOrders;
        private System.Windows.Forms.Label lblProductNameOrders;
        private System.Windows.Forms.Label lblProductTypeOrders;
        private System.Windows.Forms.Label lblProductNumberOrders;
        private System.Windows.Forms.Label lblOrderDateOrders;
        private System.Windows.Forms.Label lblOrderPriceOrders;
        private System.Windows.Forms.Button btnInsertOrders;
        private System.Windows.Forms.ComboBox cmbBoxProductType;
        private System.Windows.Forms.TextBox txtBoxOrderId;
        private System.Windows.Forms.TextBox txtBoxPersonnelIdDoctor;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.TextBox txtBoxProductNumber;
        private System.Windows.Forms.TextBox txtBoxOrderDate;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtBoxOrderIdUpdate;
        private System.Windows.Forms.Label lblUpdateOrder;
        private System.Windows.Forms.Button btnEditOrder;
    }
}