﻿
namespace Курсовая.Forms
{
    partial class DeleteClientForm
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
            this.chooseClientCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameClientTB = new System.Windows.Forms.TextBox();
            this.phoneClientTB = new System.Windows.Forms.TextBox();
            this.addressClientTB = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 79);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите номер клиента:";
            // 
            // chooseClientCB
            // 
            this.chooseClientCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseClientCB.FormattingEnabled = true;
            this.chooseClientCB.Location = new System.Drawing.Point(501, 111);
            this.chooseClientCB.Name = "chooseClientCB";
            this.chooseClientCB.Size = new System.Drawing.Size(338, 44);
            this.chooseClientCB.TabIndex = 5;
            this.chooseClientCB.SelectedIndexChanged += new System.EventHandler(this.chooseClientCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО клиента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефлон клиента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адрес клиента:";
            // 
            // nameClientTB
            // 
            this.nameClientTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClientTB.Location = new System.Drawing.Point(501, 179);
            this.nameClientTB.Name = "nameClientTB";
            this.nameClientTB.Size = new System.Drawing.Size(338, 41);
            this.nameClientTB.TabIndex = 9;
            // 
            // phoneClientTB
            // 
            this.phoneClientTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneClientTB.Location = new System.Drawing.Point(501, 243);
            this.phoneClientTB.Name = "phoneClientTB";
            this.phoneClientTB.Size = new System.Drawing.Size(338, 41);
            this.phoneClientTB.TabIndex = 10;
            // 
            // addressClientTB
            // 
            this.addressClientTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressClientTB.Location = new System.Drawing.Point(501, 317);
            this.addressClientTB.Name = "addressClientTB";
            this.addressClientTB.Size = new System.Drawing.Size(338, 41);
            this.addressClientTB.TabIndex = 11;
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.White;
            this.deleteB.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteB.Location = new System.Drawing.Point(316, 418);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(270, 64);
            this.deleteB.TabIndex = 12;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // DeleteClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(911, 526);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.addressClientTB);
            this.Controls.Add(this.phoneClientTB);
            this.Controls.Add(this.nameClientTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseClientCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteClientForm";
            this.Text = "DeleteClientForm";
            this.Load += new System.EventHandler(this.DeleteClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseClientCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameClientTB;
        private System.Windows.Forms.TextBox phoneClientTB;
        private System.Windows.Forms.TextBox addressClientTB;
        private System.Windows.Forms.Button deleteB;
    }
}