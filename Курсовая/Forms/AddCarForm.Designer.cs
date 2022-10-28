
namespace Курсовая.Forms
{
    partial class AddCarForm
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
            this.chooseModelCB = new System.Windows.Forms.ComboBox();
            this.addModelB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberCarcaseTB = new System.Windows.Forms.TextBox();
            this.dateEditionTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mileageTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chooseTypeEngineCB = new System.Windows.Forms.ComboBox();
            this.chooseFoelTypeCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateIssueTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.engineCapacityTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.carPicturePB = new System.Windows.Forms.PictureBox();
            this.downloadPictureB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stateRTB = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addCarB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPicturePB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 63);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите модель:";
            // 
            // chooseModelCB
            // 
            this.chooseModelCB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseModelCB.FormattingEnabled = true;
            this.chooseModelCB.Location = new System.Drawing.Point(308, 444);
            this.chooseModelCB.Name = "chooseModelCB";
            this.chooseModelCB.Size = new System.Drawing.Size(273, 39);
            this.chooseModelCB.TabIndex = 3;
            // 
            // addModelB
            // 
            this.addModelB.BackColor = System.Drawing.Color.White;
            this.addModelB.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addModelB.Location = new System.Drawing.Point(310, 489);
            this.addModelB.Name = "addModelB";
            this.addModelB.Size = new System.Drawing.Size(271, 27);
            this.addModelB.TabIndex = 6;
            this.addModelB.Text = "Добавить модель";
            this.addModelB.UseVisualStyleBackColor = false;
            this.addModelB.Click += new System.EventHandler(this.addModelB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Не нашли модель? Нажмите:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(525, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Не обязательные поля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите номер кузова:";
            // 
            // numberCarcaseTB
            // 
            this.numberCarcaseTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberCarcaseTB.Location = new System.Drawing.Point(334, 115);
            this.numberCarcaseTB.Name = "numberCarcaseTB";
            this.numberCarcaseTB.Size = new System.Drawing.Size(272, 39);
            this.numberCarcaseTB.TabIndex = 9;
            // 
            // dateEditionTB
            // 
            this.dateEditionTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditionTB.Location = new System.Drawing.Point(335, 171);
            this.dateEditionTB.Name = "dateEditionTB";
            this.dateEditionTB.Size = new System.Drawing.Size(271, 39);
            this.dateEditionTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите дату выпуска:";
            // 
            // mileageTB
            // 
            this.mileageTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageTB.Location = new System.Drawing.Point(335, 227);
            this.mileageTB.Name = "mileageTB";
            this.mileageTB.Size = new System.Drawing.Size(271, 39);
            this.mileageTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Введите пробег:";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTB.Location = new System.Drawing.Point(333, 288);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(273, 39);
            this.priceTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Введите цену:";
            // 
            // colorTB
            // 
            this.colorTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTB.Location = new System.Drawing.Point(1087, 115);
            this.colorTB.Name = "colorTB";
            this.colorTB.Size = new System.Drawing.Size(267, 39);
            this.colorTB.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(692, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "Введите цвет:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(692, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(336, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Выберите тип двигателя:";
            // 
            // chooseTypeEngineCB
            // 
            this.chooseTypeEngineCB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTypeEngineCB.FormattingEnabled = true;
            this.chooseTypeEngineCB.Items.AddRange(new object[] {
            "бензиновый",
            "дизельный",
            "электро двигатель"});
            this.chooseTypeEngineCB.Location = new System.Drawing.Point(1087, 167);
            this.chooseTypeEngineCB.Name = "chooseTypeEngineCB";
            this.chooseTypeEngineCB.Size = new System.Drawing.Size(267, 39);
            this.chooseTypeEngineCB.TabIndex = 19;
            // 
            // chooseFoelTypeCB
            // 
            this.chooseFoelTypeCB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFoelTypeCB.FormattingEnabled = true;
            this.chooseFoelTypeCB.Items.AddRange(new object[] {
            "бензин",
            "дизель",
            "электричевство",
            "газ/бензин",
            "газ"});
            this.chooseFoelTypeCB.Location = new System.Drawing.Point(1087, 223);
            this.chooseFoelTypeCB.Name = "chooseFoelTypeCB";
            this.chooseFoelTypeCB.Size = new System.Drawing.Size(267, 39);
            this.chooseFoelTypeCB.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(692, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(317, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Выберите тип топлива:";
            // 
            // dateIssueTB
            // 
            this.dateIssueTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateIssueTB.Location = new System.Drawing.Point(1087, 282);
            this.dateIssueTB.Name = "dateIssueTB";
            this.dateIssueTB.Size = new System.Drawing.Size(267, 39);
            this.dateIssueTB.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(692, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Введите дату выставления:";
            // 
            // engineCapacityTB
            // 
            this.engineCapacityTB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineCapacityTB.Location = new System.Drawing.Point(1089, 336);
            this.engineCapacityTB.Name = "engineCapacityTB";
            this.engineCapacityTB.Size = new System.Drawing.Size(267, 39);
            this.engineCapacityTB.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(692, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(334, 31);
            this.label13.TabIndex = 24;
            this.label13.Text = "Введите объём двигателя:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(555, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(317, 39);
            this.label14.TabIndex = 26;
            this.label14.Text = "Обязательные поля";
            // 
            // carPicturePB
            // 
            this.carPicturePB.BackColor = System.Drawing.Color.White;
            this.carPicturePB.Location = new System.Drawing.Point(826, 424);
            this.carPicturePB.Name = "carPicturePB";
            this.carPicturePB.Size = new System.Drawing.Size(454, 256);
            this.carPicturePB.TabIndex = 27;
            this.carPicturePB.TabStop = false;
            // 
            // downloadPictureB
            // 
            this.downloadPictureB.BackColor = System.Drawing.Color.White;
            this.downloadPictureB.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadPictureB.Location = new System.Drawing.Point(826, 695);
            this.downloadPictureB.Name = "downloadPictureB";
            this.downloadPictureB.Size = new System.Drawing.Size(376, 42);
            this.downloadPictureB.TabIndex = 28;
            this.downloadPictureB.Text = "Загрузить изображение";
            this.downloadPictureB.UseVisualStyleBackColor = false;
            this.downloadPictureB.Click += new System.EventHandler(this.downloadPictureB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // stateRTB
            // 
            this.stateRTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateRTB.Location = new System.Drawing.Point(46, 581);
            this.stateRTB.Name = "stateRTB";
            this.stateRTB.Size = new System.Drawing.Size(535, 143);
            this.stateRTB.TabIndex = 29;
            this.stateRTB.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(40, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(251, 31);
            this.label15.TabIndex = 30;
            this.label15.Text = "Описание машины:";
            // 
            // addCarB
            // 
            this.addCarB.BackColor = System.Drawing.Color.White;
            this.addCarB.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarB.Location = new System.Drawing.Point(571, 762);
            this.addCarB.Name = "addCarB";
            this.addCarB.Size = new System.Drawing.Size(352, 53);
            this.addCarB.TabIndex = 31;
            this.addCarB.Text = "Добавить машину";
            this.addCarB.UseVisualStyleBackColor = false;
            this.addCarB.Click += new System.EventHandler(this.addCarB_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1397, 827);
            this.Controls.Add(this.addCarB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.stateRTB);
            this.Controls.Add(this.downloadPictureB);
            this.Controls.Add(this.carPicturePB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.engineCapacityTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateIssueTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chooseFoelTypeCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chooseTypeEngineCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.colorTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mileageTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateEditionTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberCarcaseTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addModelB);
            this.Controls.Add(this.chooseModelCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carPicturePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox chooseModelCB;
        private System.Windows.Forms.Button addModelB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberCarcaseTB;
        private System.Windows.Forms.TextBox dateEditionTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mileageTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox colorTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox chooseTypeEngineCB;
        private System.Windows.Forms.ComboBox chooseFoelTypeCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dateIssueTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox engineCapacityTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox carPicturePB;
        private System.Windows.Forms.Button downloadPictureB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox stateRTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button addCarB;
    }
}