
namespace Курсовая.Forms
{
    partial class ClientForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engCapacityTB = new System.Windows.Forms.TextBox();
            this.typeCarcaseCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeEngineCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.foilTypeCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datEditionTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mileageTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stateCarCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 84);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автомобиьный ряд автосалона";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(236)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(463, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 658);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параметры поиска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Марка машины:";
            // 
            // brandCB
            // 
            this.brandCB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(247, 165);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(197, 34);
            this.brandCB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Объем двигателя:";
            // 
            // engCapacityTB
            // 
            this.engCapacityTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engCapacityTB.Location = new System.Drawing.Point(247, 226);
            this.engCapacityTB.Name = "engCapacityTB";
            this.engCapacityTB.Size = new System.Drawing.Size(197, 34);
            this.engCapacityTB.TabIndex = 6;
            // 
            // typeCarcaseCB
            // 
            this.typeCarcaseCB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCarcaseCB.FormattingEnabled = true;
            this.typeCarcaseCB.Location = new System.Drawing.Point(247, 289);
            this.typeCarcaseCB.Name = "typeCarcaseCB";
            this.typeCarcaseCB.Size = new System.Drawing.Size(197, 34);
            this.typeCarcaseCB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип кузова:";
            // 
            // typeEngineCB
            // 
            this.typeEngineCB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeEngineCB.FormattingEnabled = true;
            this.typeEngineCB.Items.AddRange(new object[] {
            "бензиновый",
            "дизельный",
            "электро двигатель"});
            this.typeEngineCB.Location = new System.Drawing.Point(247, 349);
            this.typeEngineCB.Name = "typeEngineCB";
            this.typeEngineCB.Size = new System.Drawing.Size(197, 34);
            this.typeEngineCB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип двигателя:";
            // 
            // foilTypeCB
            // 
            this.foilTypeCB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foilTypeCB.FormattingEnabled = true;
            this.foilTypeCB.Items.AddRange(new object[] {
            "бензин",
            "дизель",
            "электричевство",
            "газ",
            "газ/бензин"});
            this.foilTypeCB.Location = new System.Drawing.Point(247, 411);
            this.foilTypeCB.Name = "foilTypeCB";
            this.foilTypeCB.Size = new System.Drawing.Size(197, 34);
            this.foilTypeCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип топлива:";
            // 
            // datEditionTB
            // 
            this.datEditionTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datEditionTB.Location = new System.Drawing.Point(247, 471);
            this.datEditionTB.Name = "datEditionTB";
            this.datEditionTB.Size = new System.Drawing.Size(197, 34);
            this.datEditionTB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Год выпуска:";
            // 
            // mileageTB
            // 
            this.mileageTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageTB.Location = new System.Drawing.Point(247, 533);
            this.mileageTB.Name = "mileageTB";
            this.mileageTB.Size = new System.Drawing.Size(197, 34);
            this.mileageTB.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Пробег:";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTB.Location = new System.Drawing.Point(247, 593);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(197, 34);
            this.priceTB.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Цена:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(79, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stateCarCB
            // 
            this.stateCarCB.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateCarCB.FormattingEnabled = true;
            this.stateCarCB.Items.AddRange(new object[] {
            "продано",
            "в наличии"});
            this.stateCarCB.Location = new System.Drawing.Point(247, 651);
            this.stateCarCB.Name = "stateCarCB";
            this.stateCarCB.Size = new System.Drawing.Size(197, 34);
            this.stateCarCB.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 649);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Состояние:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1481, 774);
            this.Controls.Add(this.stateCarCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mileageTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datEditionTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.foilTypeCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typeEngineCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typeCarcaseCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.engCapacityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brandCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox brandCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox engCapacityTB;
        private System.Windows.Forms.ComboBox typeCarcaseCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeEngineCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox foilTypeCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox datEditionTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mileageTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stateCarCB;
        private System.Windows.Forms.Label label11;
    }
}