namespace Clinic_System
{
    partial class ExpenditureForm
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonnelId = new System.Windows.Forms.TextBox();
            this.txtRecipt = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReciptUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateExpenditure = new System.Windows.Forms.Button();
            this.btnInsertExpenditure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(279, 171);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = ": تاریخ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = ": شماره فاکتور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = ": شماره پرسنلی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = ": مقدار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 44;
            this.label4.Text = ": بابت";
            // 
            // txtPersonnelId
            // 
            this.txtPersonnelId.Location = new System.Drawing.Point(22, 85);
            this.txtPersonnelId.Name = "txtPersonnelId";
            this.txtPersonnelId.Size = new System.Drawing.Size(100, 20);
            this.txtPersonnelId.TabIndex = 45;
            // 
            // txtRecipt
            // 
            this.txtRecipt.Location = new System.Drawing.Point(244, 82);
            this.txtRecipt.Name = "txtRecipt";
            this.txtRecipt.Size = new System.Drawing.Size(100, 20);
            this.txtRecipt.TabIndex = 46;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(244, 126);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(148, 20);
            this.txtType.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(65, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 48;
            // 
            // txtReciptUpdate
            // 
            this.txtReciptUpdate.Location = new System.Drawing.Point(279, 22);
            this.txtReciptUpdate.Name = "txtReciptUpdate";
            this.txtReciptUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtReciptUpdate.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = ": شماره فاکتور";
            // 
            // btnUpdateExpenditure
            // 
            this.btnUpdateExpenditure.Location = new System.Drawing.Point(12, 22);
            this.btnUpdateExpenditure.Name = "btnUpdateExpenditure";
            this.btnUpdateExpenditure.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateExpenditure.TabIndex = 52;
            this.btnUpdateExpenditure.Text = "تغییر هزینه";
            this.btnUpdateExpenditure.UseVisualStyleBackColor = true;
            this.btnUpdateExpenditure.Click += new System.EventHandler(this.btnUpdateExpenditure_Click);
            // 
            // btnInsertExpenditure
            // 
            this.btnInsertExpenditure.Location = new System.Drawing.Point(193, 208);
            this.btnInsertExpenditure.Name = "btnInsertExpenditure";
            this.btnInsertExpenditure.Size = new System.Drawing.Size(75, 23);
            this.btnInsertExpenditure.TabIndex = 51;
            this.btnInsertExpenditure.Text = "ثبت هزینه";
            this.btnInsertExpenditure.UseVisualStyleBackColor = true;
            this.btnInsertExpenditure.Click += new System.EventHandler(this.btnInsertExpenditure_Click);
            // 
            // ExpenditureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 254);
            this.Controls.Add(this.btnUpdateExpenditure);
            this.Controls.Add(this.btnInsertExpenditure);
            this.Controls.Add(this.txtReciptUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtRecipt);
            this.Controls.Add(this.txtPersonnelId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Name = "ExpenditureForm";
            this.Text = "ExpenditureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonnelId;
        private System.Windows.Forms.TextBox txtRecipt;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReciptUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateExpenditure;
        private System.Windows.Forms.Button btnInsertExpenditure;
    }
}