namespace Clinic_System
{
    partial class AllOrdersForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxPersonnelIdDoctor = new System.Windows.Forms.TextBox();
            this.cmbBoxProductType = new System.Windows.Forms.ComboBox();
            this.lblProductTypeOrders = new System.Windows.Forms.Label();
            this.lblPersonnelIdOrders = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chPId,
            this.chName,
            this.chType,
            this.chNumber,
            this.chDate,
            this.chPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 345);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "کد سفارش";
            this.chId.Width = 90;
            // 
            // chPId
            // 
            this.chPId.Text = "شماره پرسنل";
            this.chPId.Width = 90;
            // 
            // chName
            // 
            this.chName.Text = "نام کالا";
            this.chName.Width = 120;
            // 
            // chType
            // 
            this.chType.Text = "نوع کالا";
            this.chType.Width = 90;
            // 
            // chNumber
            // 
            this.chNumber.Text = "تعداد کالا";
            this.chNumber.Width = 90;
            // 
            // chDate
            // 
            this.chDate.Text = "تاریخ سفارش";
            this.chDate.Width = 90;
            // 
            // chPrice
            // 
            this.chPrice.Text = "قیمت";
            this.chPrice.Width = 90;
            // 
            // txtBoxPersonnelIdDoctor
            // 
            this.txtBoxPersonnelIdDoctor.Location = new System.Drawing.Point(565, 31);
            this.txtBoxPersonnelIdDoctor.Name = "txtBoxPersonnelIdDoctor";
            this.txtBoxPersonnelIdDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPersonnelIdDoctor.TabIndex = 18;
            // 
            // cmbBoxProductType
            // 
            this.cmbBoxProductType.FormattingEnabled = true;
            this.cmbBoxProductType.Items.AddRange(new object[] {
            "اداری",
            "پزشکی"});
            this.cmbBoxProductType.Location = new System.Drawing.Point(315, 32);
            this.cmbBoxProductType.Name = "cmbBoxProductType";
            this.cmbBoxProductType.Size = new System.Drawing.Size(99, 21);
            this.cmbBoxProductType.TabIndex = 17;
            // 
            // lblProductTypeOrders
            // 
            this.lblProductTypeOrders.AutoSize = true;
            this.lblProductTypeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTypeOrders.Location = new System.Drawing.Point(455, 35);
            this.lblProductTypeOrders.Name = "lblProductTypeOrders";
            this.lblProductTypeOrders.Size = new System.Drawing.Size(54, 16);
            this.lblProductTypeOrders.TabIndex = 16;
            this.lblProductTypeOrders.Text = ": نوع کالا";
            // 
            // lblPersonnelIdOrders
            // 
            this.lblPersonnelIdOrders.AutoSize = true;
            this.lblPersonnelIdOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnelIdOrders.Location = new System.Drawing.Point(671, 32);
            this.lblPersonnelIdOrders.Name = "lblPersonnelIdOrders";
            this.lblPersonnelIdOrders.Size = new System.Drawing.Size(84, 16);
            this.lblPersonnelIdOrders.TabIndex = 15;
            this.lblPersonnelIdOrders.Text = ": شماره پرسنلی";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "فیلتر";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxPersonnelIdDoctor);
            this.Controls.Add(this.cmbBoxProductType);
            this.Controls.Add(this.lblProductTypeOrders);
            this.Controls.Add(this.lblPersonnelIdOrders);
            this.Controls.Add(this.listView1);
            this.Name = "AllOrdersForm";
            this.Text = "AllOrdersForm";
            this.Load += new System.EventHandler(this.AllOrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chPId;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.TextBox txtBoxPersonnelIdDoctor;
        private System.Windows.Forms.ComboBox cmbBoxProductType;
        private System.Windows.Forms.Label lblProductTypeOrders;
        private System.Windows.Forms.Label lblPersonnelIdOrders;
        private System.Windows.Forms.Button button1;
    }
}