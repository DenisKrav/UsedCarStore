
namespace Курсовая.Forms
{
    partial class AddTypeCarcaseForm
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
            this.typeCarcaseTB = new System.Windows.Forms.TextBox();
            this.addCarcaseB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 88);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление кузова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите название нового кузова:";
            // 
            // typeCarcaseTB
            // 
            this.typeCarcaseTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCarcaseTB.Location = new System.Drawing.Point(548, 226);
            this.typeCarcaseTB.Name = "typeCarcaseTB";
            this.typeCarcaseTB.Size = new System.Drawing.Size(337, 45);
            this.typeCarcaseTB.TabIndex = 4;
            // 
            // addCarcaseB
            // 
            this.addCarcaseB.BackColor = System.Drawing.Color.White;
            this.addCarcaseB.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarcaseB.Location = new System.Drawing.Point(284, 380);
            this.addCarcaseB.Name = "addCarcaseB";
            this.addCarcaseB.Size = new System.Drawing.Size(276, 60);
            this.addCarcaseB.TabIndex = 5;
            this.addCarcaseB.Text = "Добавить кузов";
            this.addCarcaseB.UseVisualStyleBackColor = false;
            this.addCarcaseB.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // AddTypeCarcaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.addCarcaseB);
            this.Controls.Add(this.typeCarcaseTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTypeCarcaseForm";
            this.Text = "AddTypeCarcaseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeCarcaseTB;
        private System.Windows.Forms.Button addCarcaseB;
    }
}