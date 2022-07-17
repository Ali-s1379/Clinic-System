namespace Clinic_System
{
    partial class SecretaryForm
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
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelSecretary = new System.Windows.Forms.Button();
            this.btnEditSecretary = new System.Windows.Forms.Button();
            this.btnInsertSecretary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassUpdate = new System.Windows.Forms.TextBox();
            this.txtIdUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(210, 145);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(100, 20);
            this.txtFamilyName.TabIndex = 47;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(20, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 46;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(406, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = ": شماره تماس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = ": نام خانوادگی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = ": نام";
            // 
            // btnDelSecretary
            // 
            this.btnDelSecretary.Location = new System.Drawing.Point(188, 62);
            this.btnDelSecretary.Name = "btnDelSecretary";
            this.btnDelSecretary.Size = new System.Drawing.Size(78, 23);
            this.btnDelSecretary.TabIndex = 41;
            this.btnDelSecretary.Text = "حذف";
            this.btnDelSecretary.UseVisualStyleBackColor = true;
            this.btnDelSecretary.Click += new System.EventHandler(this.btnDelDoctor_Click);
            // 
            // btnEditSecretary
            // 
            this.btnEditSecretary.Location = new System.Drawing.Point(285, 62);
            this.btnEditSecretary.Name = "btnEditSecretary";
            this.btnEditSecretary.Size = new System.Drawing.Size(78, 23);
            this.btnEditSecretary.TabIndex = 40;
            this.btnEditSecretary.Text = "تغییر";
            this.btnEditSecretary.UseVisualStyleBackColor = true;
            this.btnEditSecretary.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnInsertSecretary
            // 
            this.btnInsertSecretary.Location = new System.Drawing.Point(239, 189);
            this.btnInsertSecretary.Name = "btnInsertSecretary";
            this.btnInsertSecretary.Size = new System.Drawing.Size(75, 23);
            this.btnInsertSecretary.TabIndex = 39;
            this.btnInsertSecretary.Text = "ثبت";
            this.btnInsertSecretary.UseVisualStyleBackColor = true;
            this.btnInsertSecretary.Click += new System.EventHandler(this.btnInsertSecretary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = ": رمز عبور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = ": شماره پرسنلی";
            // 
            // txtPassUpdate
            // 
            this.txtPassUpdate.Location = new System.Drawing.Point(78, 23);
            this.txtPassUpdate.Name = "txtPassUpdate";
            this.txtPassUpdate.Size = new System.Drawing.Size(101, 20);
            this.txtPassUpdate.TabIndex = 36;
            this.txtPassUpdate.UseSystemPasswordChar = true;
            // 
            // txtIdUpdate
            // 
            this.txtIdUpdate.Location = new System.Drawing.Point(294, 23);
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.Size = new System.Drawing.Size(101, 20);
            this.txtIdUpdate.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = ": رمز عبور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = ": شماره پرسنلی";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(129, 103);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(101, 20);
            this.txtPass.TabIndex = 32;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(348, 103);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(101, 20);
            this.txtId.TabIndex = 31;
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 236);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelSecretary);
            this.Controls.Add(this.btnEditSecretary);
            this.Controls.Add(this.btnInsertSecretary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassUpdate);
            this.Controls.Add(this.txtIdUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtId);
            this.Name = "SecretaryForm";
            this.Text = "SecretaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelSecretary;
        private System.Windows.Forms.Button btnEditSecretary;
        private System.Windows.Forms.Button btnInsertSecretary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassUpdate;
        private System.Windows.Forms.TextBox txtIdUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtId;
    }
}