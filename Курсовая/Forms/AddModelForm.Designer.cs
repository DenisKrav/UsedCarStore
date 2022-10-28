
namespace Курсовая.Forms
{
    partial class AddModelForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.addCarcaseB = new System.Windows.Forms.Button();
            this.chooseTypeCarcaseCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBrandB = new System.Windows.Forms.Button();
            this.chooseBrandCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelNameTB = new System.Windows.Forms.TextBox();
            this.addModelB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 88);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление модели";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Не нашли кузов? Нажмите:";
            // 
            // addCarcaseB
            // 
            this.addCarcaseB.BackColor = System.Drawing.Color.White;
            this.addCarcaseB.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarcaseB.Location = new System.Drawing.Point(330, 226);
            this.addCarcaseB.Name = "addCarcaseB";
            this.addCarcaseB.Size = new System.Drawing.Size(245, 44);
            this.addCarcaseB.TabIndex = 12;
            this.addCarcaseB.Text = "Добавить тип кузова";
            this.addCarcaseB.UseVisualStyleBackColor = false;
            this.addCarcaseB.Click += new System.EventHandler(this.addCarcaseB_Click);
            // 
            // chooseTypeCarcaseCB
            // 
            this.chooseTypeCarcaseCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTypeCarcaseCB.FormattingEnabled = true;
            this.chooseTypeCarcaseCB.Location = new System.Drawing.Point(330, 148);
            this.chooseTypeCarcaseCB.Name = "chooseTypeCarcaseCB";
            this.chooseTypeCarcaseCB.Size = new System.Drawing.Size(245, 39);
            this.chooseTypeCarcaseCB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите тип кузова:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(622, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Не нашли марку? Нажмите:";
            // 
            // addBrandB
            // 
            this.addBrandB.BackColor = System.Drawing.Color.White;
            this.addBrandB.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBrandB.Location = new System.Drawing.Point(944, 226);
            this.addBrandB.Name = "addBrandB";
            this.addBrandB.Size = new System.Drawing.Size(245, 44);
            this.addBrandB.TabIndex = 16;
            this.addBrandB.Text = "Добавить марку";
            this.addBrandB.UseVisualStyleBackColor = false;
            this.addBrandB.Click += new System.EventHandler(this.addBrandB_Click);
            // 
            // chooseBrandCB
            // 
            this.chooseBrandCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseBrandCB.FormattingEnabled = true;
            this.chooseBrandCB.Location = new System.Drawing.Point(944, 148);
            this.chooseBrandCB.Name = "chooseBrandCB";
            this.chooseBrandCB.Size = new System.Drawing.Size(245, 39);
            this.chooseBrandCB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(626, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите марку:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(497, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "Введите название новой модеи:";
            // 
            // modelNameTB
            // 
            this.modelNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelNameTB.Location = new System.Drawing.Point(593, 400);
            this.modelNameTB.Name = "modelNameTB";
            this.modelNameTB.Size = new System.Drawing.Size(556, 45);
            this.modelNameTB.TabIndex = 19;
            // 
            // addModelB
            // 
            this.addModelB.BackColor = System.Drawing.Color.White;
            this.addModelB.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelB.Location = new System.Drawing.Point(443, 518);
            this.addModelB.Name = "addModelB";
            this.addModelB.Size = new System.Drawing.Size(296, 64);
            this.addModelB.TabIndex = 20;
            this.addModelB.Text = "Добавить модель";
            this.addModelB.UseVisualStyleBackColor = false;
            this.addModelB.Click += new System.EventHandler(this.addModelB_Click);
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1211, 633);
            this.Controls.Add(this.addModelB);
            this.Controls.Add(this.modelNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBrandB);
            this.Controls.Add(this.chooseBrandCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addCarcaseB);
            this.Controls.Add(this.chooseTypeCarcaseCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "AddModelForm";
            this.Text = "AddModelForm";
            this.Load += new System.EventHandler(this.AddModelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCarcaseB;
        private System.Windows.Forms.ComboBox chooseTypeCarcaseCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBrandB;
        private System.Windows.Forms.ComboBox chooseBrandCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modelNameTB;
        private System.Windows.Forms.Button addModelB;
    }
}