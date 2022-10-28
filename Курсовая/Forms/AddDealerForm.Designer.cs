
namespace Курсовая.Forms
{
    partial class AddDealerForm
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
            this.nameUserTB = new System.Windows.Forms.TextBox();
            this.addressUserTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telephoneUserTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUserB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление нового сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите ФИО:";
            // 
            // nameUserTB
            // 
            this.nameUserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUserTB.Location = new System.Drawing.Point(508, 160);
            this.nameUserTB.Name = "nameUserTB";
            this.nameUserTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.nameUserTB.Size = new System.Drawing.Size(439, 38);
            this.nameUserTB.TabIndex = 3;
            // 
            // addressUserTB
            // 
            this.addressUserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressUserTB.Location = new System.Drawing.Point(508, 250);
            this.addressUserTB.Name = "addressUserTB";
            this.addressUserTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.addressUserTB.Size = new System.Drawing.Size(439, 38);
            this.addressUserTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите место жительства:";
            // 
            // telephoneUserTB
            // 
            this.telephoneUserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneUserTB.Location = new System.Drawing.Point(508, 341);
            this.telephoneUserTB.Name = "telephoneUserTB";
            this.telephoneUserTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.telephoneUserTB.Size = new System.Drawing.Size(439, 38);
            this.telephoneUserTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите телефон:";
            // 
            // addUserB
            // 
            this.addUserB.BackColor = System.Drawing.Color.White;
            this.addUserB.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserB.Location = new System.Drawing.Point(333, 480);
            this.addUserB.Name = "addUserB";
            this.addUserB.Size = new System.Drawing.Size(332, 74);
            this.addUserB.TabIndex = 8;
            this.addUserB.Text = "Добавить";
            this.addUserB.UseVisualStyleBackColor = false;
            this.addUserB.Click += new System.EventHandler(this.addUserB_Click);
            // 
            // AddDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.addUserB);
            this.Controls.Add(this.telephoneUserTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressUserTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameUserTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddDealerForm";
            this.Text = "AddDealerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameUserTB;
        private System.Windows.Forms.TextBox addressUserTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telephoneUserTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUserB;
    }
}