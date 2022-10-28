
namespace Курсовая.Forms
{
    partial class DeleteCarcaseForm
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
            this.deleteB = new System.Windows.Forms.Button();
            this.chooseCarcaseCB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.White;
            this.deleteB.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteB.Location = new System.Drawing.Point(282, 372);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(303, 74);
            this.deleteB.TabIndex = 15;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // chooseCarcaseCB
            // 
            this.chooseCarcaseCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseCarcaseCB.FormattingEnabled = true;
            this.chooseCarcaseCB.Location = new System.Drawing.Point(507, 218);
            this.chooseCarcaseCB.Name = "chooseCarcaseCB";
            this.chooseCarcaseCB.Size = new System.Drawing.Size(325, 42);
            this.chooseCarcaseCB.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 79);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление типа кузова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите тип кузова:";
            // 
            // DeleteCarcaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(907, 495);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.chooseCarcaseCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "DeleteCarcaseForm";
            this.Text = "DeleteCarcaseForm";
            this.Load += new System.EventHandler(this.DeleteCarcaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.ComboBox chooseCarcaseCB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}