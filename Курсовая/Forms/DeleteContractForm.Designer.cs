
namespace Курсовая.Forms
{
    partial class DeleteContractForm
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
            this.deleteB = new System.Windows.Forms.Button();
            this.idDealerTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idClientTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseContractCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idLotTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.actualPriceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 74);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удаление сделки";
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.White;
            this.deleteB.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteB.Location = new System.Drawing.Point(358, 553);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(303, 74);
            this.deleteB.TabIndex = 19;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // idDealerTB
            // 
            this.idDealerTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idDealerTB.Location = new System.Drawing.Point(556, 297);
            this.idDealerTB.Name = "idDealerTB";
            this.idDealerTB.Size = new System.Drawing.Size(324, 42);
            this.idDealerTB.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "Номер сотрудника:";
            // 
            // idClientTB
            // 
            this.idClientTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idClientTB.Location = new System.Drawing.Point(556, 229);
            this.idClientTB.Name = "idClientTB";
            this.idClientTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.idClientTB.Size = new System.Drawing.Size(325, 42);
            this.idClientTB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Номер клиента:";
            // 
            // dataTB
            // 
            this.dataTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTB.Location = new System.Drawing.Point(556, 162);
            this.dataTB.Name = "dataTB";
            this.dataTB.Size = new System.Drawing.Size(325, 42);
            this.dataTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата сделки:";
            // 
            // chooseContractCB
            // 
            this.chooseContractCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseContractCB.FormattingEnabled = true;
            this.chooseContractCB.Location = new System.Drawing.Point(556, 92);
            this.chooseContractCB.Name = "chooseContractCB";
            this.chooseContractCB.Size = new System.Drawing.Size(325, 42);
            this.chooseContractCB.TabIndex = 12;
            this.chooseContractCB.SelectedIndexChanged += new System.EventHandler(this.chooseContractCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите номер контракта:";
            // 
            // idLotTB
            // 
            this.idLotTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLotTB.Location = new System.Drawing.Point(556, 366);
            this.idLotTB.Name = "idLotTB";
            this.idLotTB.Size = new System.Drawing.Size(324, 42);
            this.idLotTB.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "Номер лота:";
            // 
            // actualPriceTB
            // 
            this.actualPriceTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actualPriceTB.Location = new System.Drawing.Point(556, 436);
            this.actualPriceTB.Name = "actualPriceTB";
            this.actualPriceTB.Size = new System.Drawing.Size(324, 42);
            this.actualPriceTB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "Актуальная цена:";
            // 
            // DeleteContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1032, 659);
            this.Controls.Add(this.actualPriceTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idLotTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idDealerTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idClientTB);
            this.Controls.Add(this.chooseContractCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataTB);
            this.Name = "DeleteContractForm";
            this.Text = "DeleteConthactForm";
            this.Load += new System.EventHandler(this.DeleteContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.TextBox idDealerTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idClientTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chooseContractCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idLotTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox actualPriceTB;
        private System.Windows.Forms.Label label7;
    }
}