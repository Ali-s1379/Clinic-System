namespace Clinic_System
{
    partial class DoctorLoginForm
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
            this.btnLogoutDoc = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnViewAllOrders = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.txtBoxOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderIdOrders = new System.Windows.Forms.Label();
            this.btnAllPatient = new System.Windows.Forms.Button();
            this.btnMedicalHistory = new System.Windows.Forms.Button();
            this.btnAllMedicalHistory = new System.Windows.Forms.Button();
            this.btnAllCounselling = new System.Windows.Forms.Button();
            this.btnCounselling = new System.Windows.Forms.Button();
            this.btnAllExpenditure = new System.Windows.Forms.Button();
            this.btnAllclockingIn = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelHistory = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnAllSecretary = new System.Windows.Forms.Button();
            this.btnAllDoctor = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogoutDoc
            // 
            this.btnLogoutDoc.Location = new System.Drawing.Point(12, 12);
            this.btnLogoutDoc.Name = "btnLogoutDoc";
            this.btnLogoutDoc.Size = new System.Drawing.Size(105, 23);
            this.btnLogoutDoc.TabIndex = 1;
            this.btnLogoutDoc.Text = "خروج از سیستم";
            this.btnLogoutDoc.UseVisualStyleBackColor = true;
            this.btnLogoutDoc.Click += new System.EventHandler(this.btnLogoutDoc_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(77, 70);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(91, 25);
            this.lblOrders.TabIndex = 2;
            this.lblOrders.Text = ": سفارشات";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(62, 268);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(121, 50);
            this.btnNewOrder.TabIndex = 3;
            this.btnNewOrder.Text = "درخواست جدید و تغییر سفارش";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(62, 169);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(121, 23);
            this.btnViewOrder.TabIndex = 5;
            this.btnViewOrder.Text = "مشاهده سفارش";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnViewAllOrders
            // 
            this.btnViewAllOrders.Location = new System.Drawing.Point(62, 344);
            this.btnViewAllOrders.Name = "btnViewAllOrders";
            this.btnViewAllOrders.Size = new System.Drawing.Size(121, 41);
            this.btnViewAllOrders.TabIndex = 6;
            this.btnViewAllOrders.Text = "مشاهده تمامی سفارشات";
            this.btnViewAllOrders.UseVisualStyleBackColor = true;
            this.btnViewAllOrders.Click += new System.EventHandler(this.btnViewAllOrders_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Location = new System.Drawing.Point(62, 211);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(121, 23);
            this.btnDelOrder.TabIndex = 7;
            this.btnDelOrder.Text = "حذف سفارش";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // txtBoxOrderId
            // 
            this.txtBoxOrderId.Location = new System.Drawing.Point(34, 124);
            this.txtBoxOrderId.Name = "txtBoxOrderId";
            this.txtBoxOrderId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOrderId.TabIndex = 14;
            // 
            // lblOrderIdOrders
            // 
            this.lblOrderIdOrders.AutoSize = true;
            this.lblOrderIdOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIdOrders.Location = new System.Drawing.Point(140, 128);
            this.lblOrderIdOrders.Name = "lblOrderIdOrders";
            this.lblOrderIdOrders.Size = new System.Drawing.Size(68, 16);
            this.lblOrderIdOrders.TabIndex = 15;
            this.lblOrderIdOrders.Text = ": کد سفارش";
            // 
            // btnAllPatient
            // 
            this.btnAllPatient.Location = new System.Drawing.Point(647, 128);
            this.btnAllPatient.Name = "btnAllPatient";
            this.btnAllPatient.Size = new System.Drawing.Size(121, 41);
            this.btnAllPatient.TabIndex = 16;
            this.btnAllPatient.Text = "مشاهده پرونده بیماران";
            this.btnAllPatient.UseVisualStyleBackColor = true;
            this.btnAllPatient.Click += new System.EventHandler(this.btnAllPatient_Click);
            // 
            // btnMedicalHistory
            // 
            this.btnMedicalHistory.Location = new System.Drawing.Point(313, 294);
            this.btnMedicalHistory.Name = "btnMedicalHistory";
            this.btnMedicalHistory.Size = new System.Drawing.Size(121, 50);
            this.btnMedicalHistory.TabIndex = 17;
            this.btnMedicalHistory.Text = "سابقه جدید و تغییر سابقه";
            this.btnMedicalHistory.UseVisualStyleBackColor = true;
            this.btnMedicalHistory.Click += new System.EventHandler(this.btnMedicalHistory_Click);
            // 
            // btnAllMedicalHistory
            // 
            this.btnAllMedicalHistory.Location = new System.Drawing.Point(313, 361);
            this.btnAllMedicalHistory.Name = "btnAllMedicalHistory";
            this.btnAllMedicalHistory.Size = new System.Drawing.Size(121, 41);
            this.btnAllMedicalHistory.TabIndex = 18;
            this.btnAllMedicalHistory.Text = "مشاهده تمامی سوابق";
            this.btnAllMedicalHistory.UseVisualStyleBackColor = true;
            this.btnAllMedicalHistory.Click += new System.EventHandler(this.btnAllMedicalHistory_Click);
            // 
            // btnAllCounselling
            // 
            this.btnAllCounselling.Location = new System.Drawing.Point(520, 128);
            this.btnAllCounselling.Name = "btnAllCounselling";
            this.btnAllCounselling.Size = new System.Drawing.Size(121, 41);
            this.btnAllCounselling.TabIndex = 19;
            this.btnAllCounselling.Text = "مشاهده جلسات مشاوره";
            this.btnAllCounselling.UseVisualStyleBackColor = true;
            this.btnAllCounselling.Click += new System.EventHandler(this.btnAllCounselling_Click);
            // 
            // btnCounselling
            // 
            this.btnCounselling.Location = new System.Drawing.Point(596, 194);
            this.btnCounselling.Name = "btnCounselling";
            this.btnCounselling.Size = new System.Drawing.Size(121, 23);
            this.btnCounselling.TabIndex = 20;
            this.btnCounselling.Text = "تجویز دارو";
            this.btnCounselling.UseVisualStyleBackColor = true;
            this.btnCounselling.Click += new System.EventHandler(this.btnCounselling_Click);
            // 
            // btnAllExpenditure
            // 
            this.btnAllExpenditure.Location = new System.Drawing.Point(582, 282);
            this.btnAllExpenditure.Name = "btnAllExpenditure";
            this.btnAllExpenditure.Size = new System.Drawing.Size(121, 41);
            this.btnAllExpenditure.TabIndex = 21;
            this.btnAllExpenditure.Text = "مشاهده هزینه ها";
            this.btnAllExpenditure.UseVisualStyleBackColor = true;
            this.btnAllExpenditure.Click += new System.EventHandler(this.btnAllExpenditure_Click);
            // 
            // btnAllclockingIn
            // 
            this.btnAllclockingIn.Location = new System.Drawing.Point(657, 329);
            this.btnAllclockingIn.Name = "btnAllclockingIn";
            this.btnAllclockingIn.Size = new System.Drawing.Size(121, 41);
            this.btnAllclockingIn.TabIndex = 22;
            this.btnAllclockingIn.Text = "مشاهده ورود و خروج";
            this.btnAllclockingIn.UseVisualStyleBackColor = true;
            this.btnAllclockingIn.Click += new System.EventHandler(this.btnAllclockingIn_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(281, 160);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = ": تاریخ ";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(281, 124);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(100, 20);
            this.txtPatientId.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = ": شناسه پرونده بیمار";
            // 
            // btnDelHistory
            // 
            this.btnDelHistory.Location = new System.Drawing.Point(313, 246);
            this.btnDelHistory.Name = "btnDelHistory";
            this.btnDelHistory.Size = new System.Drawing.Size(121, 23);
            this.btnDelHistory.TabIndex = 40;
            this.btnDelHistory.Text = "حذف سابقه";
            this.btnDelHistory.UseVisualStyleBackColor = true;
            this.btnDelHistory.Click += new System.EventHandler(this.btnDelHistory_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(313, 204);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(121, 23);
            this.btnViewHistory.TabIndex = 39;
            this.btnViewHistory.Text = "مشاهده سابقه";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // btnAllSecretary
            // 
            this.btnAllSecretary.Location = new System.Drawing.Point(647, 376);
            this.btnAllSecretary.Name = "btnAllSecretary";
            this.btnAllSecretary.Size = new System.Drawing.Size(141, 41);
            this.btnAllSecretary.TabIndex = 41;
            this.btnAllSecretary.Text = "مشاهده اطلاعات منشی ها";
            this.btnAllSecretary.UseVisualStyleBackColor = true;
            this.btnAllSecretary.Click += new System.EventHandler(this.btnAllSecretary_Click);
            // 
            // btnAllDoctor
            // 
            this.btnAllDoctor.Location = new System.Drawing.Point(500, 376);
            this.btnAllDoctor.Name = "btnAllDoctor";
            this.btnAllDoctor.Size = new System.Drawing.Size(141, 41);
            this.btnAllDoctor.TabIndex = 42;
            this.btnAllDoctor.Text = "مشاهده اطلاعات دکتر ها";
            this.btnAllDoctor.UseVisualStyleBackColor = true;
            this.btnAllDoctor.Click += new System.EventHandler(this.btnAllDoctor_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(510, 329);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(121, 41);
            this.btnDoctor.TabIndex = 43;
            this.btnDoctor.Text = "تغییر اطلاعات دکتر ها";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = ": سوابق بیماران";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = ": اطلاعات بیماران";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = ": مدیریت سیستم";
            // 
            // DoctorLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnAllDoctor);
            this.Controls.Add(this.btnAllSecretary);
            this.Controls.Add(this.btnDelHistory);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllclockingIn);
            this.Controls.Add(this.btnAllExpenditure);
            this.Controls.Add(this.btnCounselling);
            this.Controls.Add(this.btnAllCounselling);
            this.Controls.Add(this.btnAllMedicalHistory);
            this.Controls.Add(this.btnMedicalHistory);
            this.Controls.Add(this.btnAllPatient);
            this.Controls.Add(this.lblOrderIdOrders);
            this.Controls.Add(this.txtBoxOrderId);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnViewAllOrders);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnLogoutDoc);
            this.Name = "DoctorLoginForm";
            this.Text = "DoctorLoginForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoctorLoginForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutDoc;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnViewAllOrders;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.TextBox txtBoxOrderId;
        private System.Windows.Forms.Label lblOrderIdOrders;
        private System.Windows.Forms.Button btnAllPatient;
        private System.Windows.Forms.Button btnMedicalHistory;
        private System.Windows.Forms.Button btnAllMedicalHistory;
        private System.Windows.Forms.Button btnAllCounselling;
        private System.Windows.Forms.Button btnCounselling;
        private System.Windows.Forms.Button btnAllExpenditure;
        private System.Windows.Forms.Button btnAllclockingIn;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelHistory;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnAllSecretary;
        private System.Windows.Forms.Button btnAllDoctor;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}