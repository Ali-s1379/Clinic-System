namespace Clinic_System
{
    partial class SecretaryLoginForm
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
            this.btnLogoutSec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllDoctor = new System.Windows.Forms.Button();
            this.btnAllSecretary = new System.Windows.Forms.Button();
            this.btnAllclockingIn = new System.Windows.Forms.Button();
            this.btnAllExpenditure = new System.Windows.Forms.Button();
            this.btnAllCounselling = new System.Windows.Forms.Button();
            this.btnAllMedicalHistory = new System.Windows.Forms.Button();
            this.btnAllPatient = new System.Windows.Forms.Button();
            this.btnViewAllOrders = new System.Windows.Forms.Button();
            this.btnSecretary = new System.Windows.Forms.Button();
            this.txtDateClock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelClock = new System.Windows.Forms.Button();
            this.btnViewClock = new System.Windows.Forms.Button();
            this.txtIdClock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecipt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelExpenditure = new System.Windows.Forms.Button();
            this.btnViewExpenditure = new System.Windows.Forms.Button();
            this.btnClockingIn = new System.Windows.Forms.Button();
            this.btnExpenditure = new System.Windows.Forms.Button();
            this.btnMedicalHistory = new System.Windows.Forms.Button();
            this.txtDateCounselling = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCounselling = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelCounselling = new System.Windows.Forms.Button();
            this.btnViewCounselling = new System.Windows.Forms.Button();
            this.btnCounselling = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDelPatient = new System.Windows.Forms.Button();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogoutSec
            // 
            this.btnLogoutSec.Location = new System.Drawing.Point(12, 12);
            this.btnLogoutSec.Name = "btnLogoutSec";
            this.btnLogoutSec.Size = new System.Drawing.Size(105, 23);
            this.btnLogoutSec.TabIndex = 0;
            this.btnLogoutSec.Text = "خروج از سیستم";
            this.btnLogoutSec.UseVisualStyleBackColor = true;
            this.btnLogoutSec.Click += new System.EventHandler(this.btnLogoutSec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = ": مدیریت سیستم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = ": اطلاعات بیماران";
            // 
            // btnAllDoctor
            // 
            this.btnAllDoctor.Location = new System.Drawing.Point(473, 368);
            this.btnAllDoctor.Name = "btnAllDoctor";
            this.btnAllDoctor.Size = new System.Drawing.Size(141, 41);
            this.btnAllDoctor.TabIndex = 54;
            this.btnAllDoctor.Text = "مشاهده اطلاعات دکتر ها";
            this.btnAllDoctor.UseVisualStyleBackColor = true;
            this.btnAllDoctor.Click += new System.EventHandler(this.btnAllDoctor_Click);
            // 
            // btnAllSecretary
            // 
            this.btnAllSecretary.Location = new System.Drawing.Point(635, 368);
            this.btnAllSecretary.Name = "btnAllSecretary";
            this.btnAllSecretary.Size = new System.Drawing.Size(141, 41);
            this.btnAllSecretary.TabIndex = 53;
            this.btnAllSecretary.Text = "مشاهده اطلاعات منشی ها";
            this.btnAllSecretary.UseVisualStyleBackColor = true;
            this.btnAllSecretary.Click += new System.EventHandler(this.btnAllSecretary_Click);
            // 
            // btnAllclockingIn
            // 
            this.btnAllclockingIn.Location = new System.Drawing.Point(635, 274);
            this.btnAllclockingIn.Name = "btnAllclockingIn";
            this.btnAllclockingIn.Size = new System.Drawing.Size(141, 41);
            this.btnAllclockingIn.TabIndex = 52;
            this.btnAllclockingIn.Text = "مشاهده تمامی ورود و خروج ها";
            this.btnAllclockingIn.UseVisualStyleBackColor = true;
            this.btnAllclockingIn.Click += new System.EventHandler(this.btnAllclockingIn_Click);
            // 
            // btnAllExpenditure
            // 
            this.btnAllExpenditure.Location = new System.Drawing.Point(473, 274);
            this.btnAllExpenditure.Name = "btnAllExpenditure";
            this.btnAllExpenditure.Size = new System.Drawing.Size(141, 41);
            this.btnAllExpenditure.TabIndex = 51;
            this.btnAllExpenditure.Text = "مشاهده تمامی هزینه ها";
            this.btnAllExpenditure.UseVisualStyleBackColor = true;
            this.btnAllExpenditure.Click += new System.EventHandler(this.btnAllExpenditure_Click);
            // 
            // btnAllCounselling
            // 
            this.btnAllCounselling.Location = new System.Drawing.Point(206, 368);
            this.btnAllCounselling.Name = "btnAllCounselling";
            this.btnAllCounselling.Size = new System.Drawing.Size(121, 41);
            this.btnAllCounselling.TabIndex = 50;
            this.btnAllCounselling.Text = "مشاهده تمامی جلسات مشاوره";
            this.btnAllCounselling.UseVisualStyleBackColor = true;
            this.btnAllCounselling.Click += new System.EventHandler(this.btnAllCounselling_Click);
            // 
            // btnAllMedicalHistory
            // 
            this.btnAllMedicalHistory.Location = new System.Drawing.Point(206, 204);
            this.btnAllMedicalHistory.Name = "btnAllMedicalHistory";
            this.btnAllMedicalHistory.Size = new System.Drawing.Size(121, 41);
            this.btnAllMedicalHistory.TabIndex = 49;
            this.btnAllMedicalHistory.Text = "مشاهده تمامی سوابق";
            this.btnAllMedicalHistory.UseVisualStyleBackColor = true;
            this.btnAllMedicalHistory.Click += new System.EventHandler(this.btnAllMedicalHistory_Click);
            // 
            // btnAllPatient
            // 
            this.btnAllPatient.Location = new System.Drawing.Point(206, 157);
            this.btnAllPatient.Name = "btnAllPatient";
            this.btnAllPatient.Size = new System.Drawing.Size(121, 41);
            this.btnAllPatient.TabIndex = 48;
            this.btnAllPatient.Text = "مشاهده تمامی پرونده بیماران";
            this.btnAllPatient.UseVisualStyleBackColor = true;
            this.btnAllPatient.Click += new System.EventHandler(this.btnAllPatient_Click);
            // 
            // btnViewAllOrders
            // 
            this.btnViewAllOrders.Location = new System.Drawing.Point(473, 321);
            this.btnViewAllOrders.Name = "btnViewAllOrders";
            this.btnViewAllOrders.Size = new System.Drawing.Size(141, 41);
            this.btnViewAllOrders.TabIndex = 47;
            this.btnViewAllOrders.Text = "مشاهده تمامی سفارشات";
            this.btnViewAllOrders.UseVisualStyleBackColor = true;
            this.btnViewAllOrders.Click += new System.EventHandler(this.btnViewAllOrders_Click);
            // 
            // btnSecretary
            // 
            this.btnSecretary.Location = new System.Drawing.Point(635, 321);
            this.btnSecretary.Name = "btnSecretary";
            this.btnSecretary.Size = new System.Drawing.Size(141, 41);
            this.btnSecretary.TabIndex = 57;
            this.btnSecretary.Text = "تغییر اطلاعات منشی ها";
            this.btnSecretary.UseVisualStyleBackColor = true;
            this.btnSecretary.Click += new System.EventHandler(this.btnSecretary_Click);
            // 
            // txtDateClock
            // 
            this.txtDateClock.Location = new System.Drawing.Point(441, 72);
            this.txtDateClock.Name = "txtDateClock";
            this.txtDateClock.Size = new System.Drawing.Size(100, 20);
            this.txtDateClock.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = ": تاریخ ";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(88, 76);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(100, 20);
            this.txtPatientId.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = ": شناسه پرونده بیمار";
            // 
            // btnDelClock
            // 
            this.btnDelClock.Location = new System.Drawing.Point(490, 107);
            this.btnDelClock.Name = "btnDelClock";
            this.btnDelClock.Size = new System.Drawing.Size(121, 23);
            this.btnDelClock.TabIndex = 63;
            this.btnDelClock.Text = "حذف ورود و خروج";
            this.btnDelClock.UseVisualStyleBackColor = true;
            this.btnDelClock.Click += new System.EventHandler(this.btnDelClock_Click);
            // 
            // btnViewClock
            // 
            this.btnViewClock.Location = new System.Drawing.Point(635, 107);
            this.btnViewClock.Name = "btnViewClock";
            this.btnViewClock.Size = new System.Drawing.Size(121, 23);
            this.btnViewClock.TabIndex = 62;
            this.btnViewClock.Text = "مشاهده ورود و خروج";
            this.btnViewClock.UseVisualStyleBackColor = true;
            this.btnViewClock.Click += new System.EventHandler(this.btnViewClock_Click);
            // 
            // txtIdClock
            // 
            this.txtIdClock.Location = new System.Drawing.Point(600, 71);
            this.txtIdClock.Name = "txtIdClock";
            this.txtIdClock.Size = new System.Drawing.Size(100, 20);
            this.txtIdClock.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(701, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = ": شماره پرسنلی";
            // 
            // txtRecipt
            // 
            this.txtRecipt.Location = new System.Drawing.Point(600, 174);
            this.txtRecipt.Name = "txtRecipt";
            this.txtRecipt.Size = new System.Drawing.Size(100, 20);
            this.txtRecipt.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = ": شماره فاکتور";
            // 
            // btnDelExpenditure
            // 
            this.btnDelExpenditure.Location = new System.Drawing.Point(490, 204);
            this.btnDelExpenditure.Name = "btnDelExpenditure";
            this.btnDelExpenditure.Size = new System.Drawing.Size(121, 23);
            this.btnDelExpenditure.TabIndex = 71;
            this.btnDelExpenditure.Text = "حذف ورود و خروج";
            this.btnDelExpenditure.UseVisualStyleBackColor = true;
            this.btnDelExpenditure.Click += new System.EventHandler(this.btnDelExpenditure_Click);
            // 
            // btnViewExpenditure
            // 
            this.btnViewExpenditure.Location = new System.Drawing.Point(635, 204);
            this.btnViewExpenditure.Name = "btnViewExpenditure";
            this.btnViewExpenditure.Size = new System.Drawing.Size(121, 23);
            this.btnViewExpenditure.TabIndex = 70;
            this.btnViewExpenditure.Text = "مشاهده ورود و خروج";
            this.btnViewExpenditure.UseVisualStyleBackColor = true;
            this.btnViewExpenditure.Click += new System.EventHandler(this.btnViewExpenditure_Click);
            // 
            // btnClockingIn
            // 
            this.btnClockingIn.Location = new System.Drawing.Point(522, 137);
            this.btnClockingIn.Name = "btnClockingIn";
            this.btnClockingIn.Size = new System.Drawing.Size(206, 33);
            this.btnClockingIn.TabIndex = 72;
            this.btnClockingIn.Text = "ورود و خروج جدید و تغییر آن";
            this.btnClockingIn.UseVisualStyleBackColor = true;
            this.btnClockingIn.Click += new System.EventHandler(this.btnClockingIn_Click);
            // 
            // btnExpenditure
            // 
            this.btnExpenditure.Location = new System.Drawing.Point(522, 233);
            this.btnExpenditure.Name = "btnExpenditure";
            this.btnExpenditure.Size = new System.Drawing.Size(206, 33);
            this.btnExpenditure.TabIndex = 73;
            this.btnExpenditure.Text = "هزینه جدید و تغییر هزینه";
            this.btnExpenditure.UseVisualStyleBackColor = true;
            this.btnExpenditure.Click += new System.EventHandler(this.btnExpenditure_Click);
            // 
            // btnMedicalHistory
            // 
            this.btnMedicalHistory.Location = new System.Drawing.Point(67, 204);
            this.btnMedicalHistory.Name = "btnMedicalHistory";
            this.btnMedicalHistory.Size = new System.Drawing.Size(121, 41);
            this.btnMedicalHistory.TabIndex = 74;
            this.btnMedicalHistory.Text = "سابقه جدید و تغییر سابقه";
            this.btnMedicalHistory.UseVisualStyleBackColor = true;
            this.btnMedicalHistory.Click += new System.EventHandler(this.btnMedicalHistory_Click);
            // 
            // txtDateCounselling
            // 
            this.txtDateCounselling.Location = new System.Drawing.Point(258, 300);
            this.txtDateCounselling.Name = "txtDateCounselling";
            this.txtDateCounselling.Size = new System.Drawing.Size(100, 20);
            this.txtDateCounselling.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = ": تاریخ ";
            // 
            // txtIdCounselling
            // 
            this.txtIdCounselling.Location = new System.Drawing.Point(28, 303);
            this.txtIdCounselling.Name = "txtIdCounselling";
            this.txtIdCounselling.Size = new System.Drawing.Size(100, 20);
            this.txtIdCounselling.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = ": شناسه پرونده بیمار";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = ": اطلاعات جلسات مشاوره";
            // 
            // btnDelCounselling
            // 
            this.btnDelCounselling.Location = new System.Drawing.Point(67, 339);
            this.btnDelCounselling.Name = "btnDelCounselling";
            this.btnDelCounselling.Size = new System.Drawing.Size(121, 23);
            this.btnDelCounselling.TabIndex = 81;
            this.btnDelCounselling.Text = "حذف جلسه";
            this.btnDelCounselling.UseVisualStyleBackColor = true;
            this.btnDelCounselling.Click += new System.EventHandler(this.btnDelCounselling_Click);
            // 
            // btnViewCounselling
            // 
            this.btnViewCounselling.Location = new System.Drawing.Point(206, 339);
            this.btnViewCounselling.Name = "btnViewCounselling";
            this.btnViewCounselling.Size = new System.Drawing.Size(121, 23);
            this.btnViewCounselling.TabIndex = 80;
            this.btnViewCounselling.Text = "مشاهده جلسه";
            this.btnViewCounselling.UseVisualStyleBackColor = true;
            this.btnViewCounselling.Click += new System.EventHandler(this.btnViewCounselling_Click);
            // 
            // btnCounselling
            // 
            this.btnCounselling.Location = new System.Drawing.Point(67, 368);
            this.btnCounselling.Name = "btnCounselling";
            this.btnCounselling.Size = new System.Drawing.Size(121, 41);
            this.btnCounselling.TabIndex = 82;
            this.btnCounselling.Text = "جلسه جدید و تغییر اطلاعات جلسه";
            this.btnCounselling.UseVisualStyleBackColor = true;
            this.btnCounselling.Click += new System.EventHandler(this.btnCounselling_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(67, 157);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(121, 41);
            this.btnPatient.TabIndex = 83;
            this.btnPatient.Text = "پرونده جدید و تغییر پرونده";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDelPatient
            // 
            this.btnDelPatient.Location = new System.Drawing.Point(67, 117);
            this.btnDelPatient.Name = "btnDelPatient";
            this.btnDelPatient.Size = new System.Drawing.Size(121, 23);
            this.btnDelPatient.TabIndex = 85;
            this.btnDelPatient.Text = "حذف پرونده";
            this.btnDelPatient.UseVisualStyleBackColor = true;
            this.btnDelPatient.Click += new System.EventHandler(this.btnDelPatient_Click);
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(206, 117);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(121, 23);
            this.btnViewPatient.TabIndex = 84;
            this.btnViewPatient.Text = "مشاهده پرونده";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // SecretaryLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelPatient);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnCounselling);
            this.Controls.Add(this.btnDelCounselling);
            this.Controls.Add(this.btnViewCounselling);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDateCounselling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCounselling);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnMedicalHistory);
            this.Controls.Add(this.btnExpenditure);
            this.Controls.Add(this.btnClockingIn);
            this.Controls.Add(this.btnDelExpenditure);
            this.Controls.Add(this.btnViewExpenditure);
            this.Controls.Add(this.txtRecipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdClock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelClock);
            this.Controls.Add(this.btnViewClock);
            this.Controls.Add(this.txtDateClock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecretary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAllDoctor);
            this.Controls.Add(this.btnAllSecretary);
            this.Controls.Add(this.btnAllclockingIn);
            this.Controls.Add(this.btnAllExpenditure);
            this.Controls.Add(this.btnAllCounselling);
            this.Controls.Add(this.btnAllMedicalHistory);
            this.Controls.Add(this.btnAllPatient);
            this.Controls.Add(this.btnViewAllOrders);
            this.Controls.Add(this.btnLogoutSec);
            this.Name = "SecretaryLoginForm";
            this.Text = "SecretaryLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoutSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllDoctor;
        private System.Windows.Forms.Button btnAllSecretary;
        private System.Windows.Forms.Button btnAllclockingIn;
        private System.Windows.Forms.Button btnAllExpenditure;
        private System.Windows.Forms.Button btnAllCounselling;
        private System.Windows.Forms.Button btnAllMedicalHistory;
        private System.Windows.Forms.Button btnAllPatient;
        private System.Windows.Forms.Button btnViewAllOrders;
        private System.Windows.Forms.Button btnSecretary;
        private System.Windows.Forms.TextBox txtDateClock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelClock;
        private System.Windows.Forms.Button btnViewClock;
        private System.Windows.Forms.TextBox txtIdClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelExpenditure;
        private System.Windows.Forms.Button btnViewExpenditure;
        private System.Windows.Forms.Button btnClockingIn;
        private System.Windows.Forms.Button btnExpenditure;
        private System.Windows.Forms.Button btnMedicalHistory;
        private System.Windows.Forms.TextBox txtDateCounselling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCounselling;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelCounselling;
        private System.Windows.Forms.Button btnViewCounselling;
        private System.Windows.Forms.Button btnCounselling;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDelPatient;
        private System.Windows.Forms.Button btnViewPatient;
    }
}