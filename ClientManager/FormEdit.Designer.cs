﻿namespace ClientManager
{
    partial class FormEdit
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
            this.button_add = new System.Windows.Forms.Button();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_egn = new System.Windows.Forms.TextBox();
            this.label_egn = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(16, 221);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(256, 23);
            this.button_add.TabIndex = 27;
            this.button_add.Text = "Добавяне";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(13, 188);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(41, 13);
            this.label_mail.TabIndex = 26;
            this.label_mail.Text = "Имейл";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(130, 188);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(142, 20);
            this.textBox_mail.TabIndex = 25;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(130, 161);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(142, 20);
            this.textBox_number.TabIndex = 24;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(13, 161);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(52, 13);
            this.label_number.TabIndex = 23;
            this.label_number.Text = "Телефон";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(130, 134);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(142, 20);
            this.textBox_address.TabIndex = 22;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(13, 133);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(38, 13);
            this.label_address.TabIndex = 21;
            this.label_address.Text = "Адрес";
            // 
            // textBox_egn
            // 
            this.textBox_egn.Location = new System.Drawing.Point(130, 107);
            this.textBox_egn.Name = "textBox_egn";
            this.textBox_egn.Size = new System.Drawing.Size(142, 20);
            this.textBox_egn.TabIndex = 20;
            // 
            // label_egn
            // 
            this.label_egn.AutoSize = true;
            this.label_egn.Location = new System.Drawing.Point(12, 107);
            this.label_egn.Name = "label_egn";
            this.label_egn.Size = new System.Drawing.Size(28, 13);
            this.label_egn.TabIndex = 19;
            this.label_egn.Text = "ЕГН";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(130, 78);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(142, 20);
            this.textBox_surname.TabIndex = 18;
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(12, 81);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(109, 13);
            this.label_surname.TabIndex = 17;
            this.label_surname.Text = "Фамилия на клиент";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(130, 50);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 16;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 53);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 13);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "Име на клиент";
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(69, 17);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(126, 13);
            this.label_add.TabIndex = 14;
            this.label_add.Text = "Редактиране на клиент";
            this.label_add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 259);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_egn);
            this.Controls.Add(this.label_egn);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_add);
            this.Name = "FormEdit";
            this.Text = "Редактиране на клиент";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_egn;
        private System.Windows.Forms.Label label_egn;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_add;
    }
}