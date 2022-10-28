
namespace Курсовая.Forms
{
    partial class UserForm
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
            this.goTableB = new System.Windows.Forms.Button();
            this.makeDealButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.addBrandB = new System.Windows.Forms.Button();
            this.addCarcaseB = new System.Windows.Forms.Button();
            this.addWorkerB = new System.Windows.Forms.Button();
            this.deleteUserB = new System.Windows.Forms.Button();
            this.deleteCarB = new System.Windows.Forms.Button();
            this.deleteBrandB = new System.Windows.Forms.Button();
            this.deleteTypeCarcaseB = new System.Windows.Forms.Button();
            this.deleteClientB = new System.Windows.Forms.Button();
            this.deleteContractB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statisticYearB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главное меню";
            // 
            // goTableB
            // 
            this.goTableB.BackColor = System.Drawing.Color.White;
            this.goTableB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goTableB.Location = new System.Drawing.Point(864, 160);
            this.goTableB.Name = "goTableB";
            this.goTableB.Size = new System.Drawing.Size(334, 60);
            this.goTableB.TabIndex = 2;
            this.goTableB.Text = "Перейти к таблицам";
            this.goTableB.UseVisualStyleBackColor = false;
            this.goTableB.Click += new System.EventHandler(this.goTableB_Click);
            // 
            // makeDealButton
            // 
            this.makeDealButton.BackColor = System.Drawing.Color.White;
            this.makeDealButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeDealButton.Location = new System.Drawing.Point(864, 248);
            this.makeDealButton.Name = "makeDealButton";
            this.makeDealButton.Size = new System.Drawing.Size(334, 60);
            this.makeDealButton.TabIndex = 3;
            this.makeDealButton.Text = "Офрмить сделку";
            this.makeDealButton.UseVisualStyleBackColor = false;
            this.makeDealButton.Click += new System.EventHandler(this.makeDealButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.White;
            this.addCarButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarButton.Location = new System.Drawing.Point(447, 430);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(334, 60);
            this.addCarButton.TabIndex = 4;
            this.addCarButton.Text = "Добавить машину";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // addBrandB
            // 
            this.addBrandB.BackColor = System.Drawing.Color.White;
            this.addBrandB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBrandB.Location = new System.Drawing.Point(447, 248);
            this.addBrandB.Name = "addBrandB";
            this.addBrandB.Size = new System.Drawing.Size(334, 60);
            this.addBrandB.TabIndex = 5;
            this.addBrandB.Text = "Добавить марку";
            this.addBrandB.UseVisualStyleBackColor = false;
            this.addBrandB.Click += new System.EventHandler(this.addBrandB_Click);
            // 
            // addCarcaseB
            // 
            this.addCarcaseB.BackColor = System.Drawing.Color.White;
            this.addCarcaseB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarcaseB.Location = new System.Drawing.Point(447, 339);
            this.addCarcaseB.Name = "addCarcaseB";
            this.addCarcaseB.Size = new System.Drawing.Size(334, 60);
            this.addCarcaseB.TabIndex = 6;
            this.addCarcaseB.Text = "Добавить тип кузова";
            this.addCarcaseB.UseVisualStyleBackColor = false;
            this.addCarcaseB.Click += new System.EventHandler(this.addCarcaseB_Click);
            // 
            // addWorkerB
            // 
            this.addWorkerB.BackColor = System.Drawing.Color.White;
            this.addWorkerB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWorkerB.Location = new System.Drawing.Point(447, 160);
            this.addWorkerB.Name = "addWorkerB";
            this.addWorkerB.Size = new System.Drawing.Size(334, 60);
            this.addWorkerB.TabIndex = 7;
            this.addWorkerB.Text = "Добавить сотрудника";
            this.addWorkerB.UseVisualStyleBackColor = false;
            this.addWorkerB.Click += new System.EventHandler(this.addWorkerB_Click);
            // 
            // deleteUserB
            // 
            this.deleteUserB.BackColor = System.Drawing.Color.White;
            this.deleteUserB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUserB.Location = new System.Drawing.Point(22, 160);
            this.deleteUserB.Name = "deleteUserB";
            this.deleteUserB.Size = new System.Drawing.Size(334, 60);
            this.deleteUserB.TabIndex = 8;
            this.deleteUserB.Text = "Удалить сотрудника";
            this.deleteUserB.UseVisualStyleBackColor = false;
            this.deleteUserB.Click += new System.EventHandler(this.deleteUserB_Click);
            // 
            // deleteCarB
            // 
            this.deleteCarB.BackColor = System.Drawing.Color.White;
            this.deleteCarB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCarB.Location = new System.Drawing.Point(22, 248);
            this.deleteCarB.Name = "deleteCarB";
            this.deleteCarB.Size = new System.Drawing.Size(334, 60);
            this.deleteCarB.TabIndex = 9;
            this.deleteCarB.Text = "Удалить машину";
            this.deleteCarB.UseVisualStyleBackColor = false;
            this.deleteCarB.Click += new System.EventHandler(this.deleteCarB_Click);
            // 
            // deleteBrandB
            // 
            this.deleteBrandB.BackColor = System.Drawing.Color.White;
            this.deleteBrandB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBrandB.Location = new System.Drawing.Point(22, 339);
            this.deleteBrandB.Name = "deleteBrandB";
            this.deleteBrandB.Size = new System.Drawing.Size(334, 60);
            this.deleteBrandB.TabIndex = 10;
            this.deleteBrandB.Text = "Удалить марку";
            this.deleteBrandB.UseVisualStyleBackColor = false;
            this.deleteBrandB.Click += new System.EventHandler(this.deleteBrandB_Click);
            // 
            // deleteTypeCarcaseB
            // 
            this.deleteTypeCarcaseB.BackColor = System.Drawing.Color.White;
            this.deleteTypeCarcaseB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTypeCarcaseB.Location = new System.Drawing.Point(22, 430);
            this.deleteTypeCarcaseB.Name = "deleteTypeCarcaseB";
            this.deleteTypeCarcaseB.Size = new System.Drawing.Size(334, 60);
            this.deleteTypeCarcaseB.TabIndex = 11;
            this.deleteTypeCarcaseB.Text = "Удалить тип кузова";
            this.deleteTypeCarcaseB.UseVisualStyleBackColor = false;
            this.deleteTypeCarcaseB.Click += new System.EventHandler(this.deleteTypeCarcaseB_Click);
            // 
            // deleteClientB
            // 
            this.deleteClientB.BackColor = System.Drawing.Color.White;
            this.deleteClientB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteClientB.Location = new System.Drawing.Point(22, 609);
            this.deleteClientB.Name = "deleteClientB";
            this.deleteClientB.Size = new System.Drawing.Size(334, 60);
            this.deleteClientB.TabIndex = 12;
            this.deleteClientB.Text = "Удалить клиента";
            this.deleteClientB.UseVisualStyleBackColor = false;
            this.deleteClientB.Click += new System.EventHandler(this.deleteClientB_Click);
            // 
            // deleteContractB
            // 
            this.deleteContractB.BackColor = System.Drawing.Color.White;
            this.deleteContractB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteContractB.Location = new System.Drawing.Point(22, 520);
            this.deleteContractB.Name = "deleteContractB";
            this.deleteContractB.Size = new System.Drawing.Size(334, 60);
            this.deleteContractB.TabIndex = 13;
            this.deleteContractB.Text = "Удалить сделку";
            this.deleteContractB.UseVisualStyleBackColor = false;
            this.deleteContractB.Click += new System.EventHandler(this.deleteContractB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Удаление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(539, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Добавление";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(843, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дополнительные функции";
            // 
            // statisticYearB
            // 
            this.statisticYearB.BackColor = System.Drawing.Color.White;
            this.statisticYearB.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticYearB.Location = new System.Drawing.Point(864, 339);
            this.statisticYearB.Name = "statisticYearB";
            this.statisticYearB.Size = new System.Drawing.Size(334, 60);
            this.statisticYearB.TabIndex = 16;
            this.statisticYearB.Text = "Статистика за год";
            this.statisticYearB.UseVisualStyleBackColor = false;
            this.statisticYearB.Click += new System.EventHandler(this.statisticYearB_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1269, 736);
            this.Controls.Add(this.statisticYearB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteContractB);
            this.Controls.Add(this.deleteClientB);
            this.Controls.Add(this.deleteTypeCarcaseB);
            this.Controls.Add(this.deleteBrandB);
            this.Controls.Add(this.deleteCarB);
            this.Controls.Add(this.deleteUserB);
            this.Controls.Add(this.addWorkerB);
            this.Controls.Add(this.addCarcaseB);
            this.Controls.Add(this.addBrandB);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.makeDealButton);
            this.Controls.Add(this.goTableB);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goTableB;
        private System.Windows.Forms.Button makeDealButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button addBrandB;
        private System.Windows.Forms.Button addCarcaseB;
        private System.Windows.Forms.Button addWorkerB;
        private System.Windows.Forms.Button deleteUserB;
        private System.Windows.Forms.Button deleteCarB;
        private System.Windows.Forms.Button deleteBrandB;
        private System.Windows.Forms.Button deleteTypeCarcaseB;
        private System.Windows.Forms.Button deleteClientB;
        private System.Windows.Forms.Button deleteContractB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button statisticYearB;
    }
}