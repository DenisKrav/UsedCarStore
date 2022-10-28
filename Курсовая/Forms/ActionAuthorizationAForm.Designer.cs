
namespace Курсовая.Forms
{
    partial class ActionAuthorizationAForm
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
            this.goB = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 122);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // goB
            // 
            this.goB.BackColor = System.Drawing.Color.White;
            this.goB.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goB.Location = new System.Drawing.Point(281, 342);
            this.goB.Name = "goB";
            this.goB.Size = new System.Drawing.Size(270, 79);
            this.goB.TabIndex = 13;
            this.goB.Text = "Войти";
            this.goB.UseVisualStyleBackColor = false;
            this.goB.Click += new System.EventHandler(this.goB_Click);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordText.Location = new System.Drawing.Point(206, 229);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(420, 60);
            this.passwordText.TabIndex = 12;
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите пароль";
            // 
            // ActionAuthorizationAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(843, 471);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goB);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Name = "ActionAuthorizationAForm";
            this.Text = "ActionAuthorizationAForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goB;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
    }
}