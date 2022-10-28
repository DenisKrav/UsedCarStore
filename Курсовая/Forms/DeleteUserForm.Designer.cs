
namespace Курсовая.Forms
{
    partial class DeleteUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseUserCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameUserTB = new System.Windows.Forms.TextBox();
            this.addressUserTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teleponeUserTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 80);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите номер сотрудника:";
            // 
            // chooseUserCB
            // 
            this.chooseUserCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseUserCB.FormattingEnabled = true;
            this.chooseUserCB.Location = new System.Drawing.Point(543, 141);
            this.chooseUserCB.Name = "chooseUserCB";
            this.chooseUserCB.Size = new System.Drawing.Size(325, 42);
            this.chooseUserCB.TabIndex = 3;
            this.chooseUserCB.SelectedIndexChanged += new System.EventHandler(this.chooseUserCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО сотрудника:";
            // 
            // nameUserTB
            // 
            this.nameUserTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUserTB.Location = new System.Drawing.Point(543, 211);
            this.nameUserTB.Name = "nameUserTB";
            this.nameUserTB.Size = new System.Drawing.Size(325, 42);
            this.nameUserTB.TabIndex = 5;
            // 
            // addressUserTB
            // 
            this.addressUserTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressUserTB.Location = new System.Drawing.Point(543, 278);
            this.addressUserTB.Name = "addressUserTB";
            this.addressUserTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressUserTB.Size = new System.Drawing.Size(325, 42);
            this.addressUserTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адрес сотрудника:";
            // 
            // teleponeUserTB
            // 
            this.teleponeUserTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleponeUserTB.Location = new System.Drawing.Point(543, 346);
            this.teleponeUserTB.Name = "teleponeUserTB";
            this.teleponeUserTB.Size = new System.Drawing.Size(324, 42);
            this.teleponeUserTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тефон сотрудника:";
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.White;
            this.deleteB.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteB.Location = new System.Drawing.Point(363, 455);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(303, 74);
            this.deleteB.TabIndex = 10;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1025, 589);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.teleponeUserTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressUserTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameUserTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseUserCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteUserForm";
            this.Text = "DeleteUserForm";
            this.Load += new System.EventHandler(this.DeleteUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseUserCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameUserTB;
        private System.Windows.Forms.TextBox addressUserTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teleponeUserTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteB;
    }
}