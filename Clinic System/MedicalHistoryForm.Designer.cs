namespace Clinic_System
{
    partial class MedicalHistoryForm
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
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientIdUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlness = new System.Windows.Forms.TextBox();
            this.txtMedication = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateHistory = new System.Windows.Forms.Button();
            this.btnInsertHistory = new System.Windows.Forms.Button();
            this.txtDateUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(391, 90);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(100, 20);
            this.txtPatientId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = ": شناسه پرونده بیمار";
            // 
            // txtPatientIdUpdate
            // 
            this.txtPatientIdUpdate.Location = new System.Drawing.Point(333, 30);
            this.txtPatientIdUpdate.Name = "txtPatientIdUpdate";
            this.txtPatientIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtPatientIdUpdate.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = ": شناسه پرونده بیمار برای تغییر";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(174, 90);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = ": تاریخ ";
            // 
            // txtIlness
            // 
            this.txtIlness.Location = new System.Drawing.Point(333, 144);
            this.txtIlness.Name = "txtIlness";
            this.txtIlness.Size = new System.Drawing.Size(158, 20);
            this.txtIlness.TabIndex = 37;
            // 
            // txtMedication
            // 
            this.txtMedication.Location = new System.Drawing.Point(42, 144);
            this.txtMedication.Name = "txtMedication";
            this.txtMedication.Size = new System.Drawing.Size(188, 20);
            this.txtMedication.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = ":تشخیص بیماری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = ": دازوی مصرفی";
            // 
            // btnUpdateHistory
            // 
            this.btnUpdateHistory.Location = new System.Drawing.Point(23, 27);
            this.btnUpdateHistory.Name = "btnUpdateHistory";
            this.btnUpdateHistory.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateHistory.TabIndex = 42;
            this.btnUpdateHistory.Text = "تغییر سابقه";
            this.btnUpdateHistory.UseVisualStyleBackColor = true;
            this.btnUpdateHistory.Click += new System.EventHandler(this.btnUpdateHistory_Click);
            // 
            // btnInsertHistory
            // 
            this.btnInsertHistory.Location = new System.Drawing.Point(252, 201);
            this.btnInsertHistory.Name = "btnInsertHistory";
            this.btnInsertHistory.Size = new System.Drawing.Size(75, 23);
            this.btnInsertHistory.TabIndex = 41;
            this.btnInsertHistory.Text = "ثبت سابقه";
            this.btnInsertHistory.UseVisualStyleBackColor = true;
            this.btnInsertHistory.Click += new System.EventHandler(this.btnInsertHistory_Click);
            // 
            // txtDateUpdate
            // 
            this.txtDateUpdate.Location = new System.Drawing.Point(156, 30);
            this.txtDateUpdate.Name = "txtDateUpdate";
            this.txtDateUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtDateUpdate.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = ": تاریخ ";
            // 
            // MedicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 253);
            this.Controls.Add(this.txtDateUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateHistory);
            this.Controls.Add(this.btnInsertHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedication);
            this.Controls.Add(this.txtIlness);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatientIdUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.label1);
            this.Name = "MedicalHistoryForm";
            this.Text = "MedicalHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientIdUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIlness;
        private System.Windows.Forms.TextBox txtMedication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateHistory;
        private System.Windows.Forms.Button btnInsertHistory;
        private System.Windows.Forms.TextBox txtDateUpdate;
        private System.Windows.Forms.Label label6;
    }
}