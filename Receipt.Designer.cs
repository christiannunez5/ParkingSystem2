namespace ParkingSystemGUI
{
    partial class Receipt
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
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            plateNumberData = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            vTypeData = new Label();
            brandData = new Label();
            flagdownData = new Label();
            parkinData = new Label();
            parkoutData = new Label();
            durationData = new Label();
            feeData = new Label();
            backButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 32, 66);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-17, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 118);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono", 43.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 12);
            label1.Name = "label1";
            label1.Size = new Size(375, 89);
            label1.TabIndex = 0;
            label1.Text = "RECEIPT";
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 143);
            label7.Name = "label7";
            label7.Size = new Size(247, 39);
            label7.TabIndex = 16;
            label7.Text = "Plate Number";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plateNumberData
            // 
            plateNumberData.BorderStyle = BorderStyle.FixedSingle;
            plateNumberData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumberData.Location = new Point(302, 143);
            plateNumberData.Name = "plateNumberData";
            plateNumberData.Size = new Size(581, 39);
            plateNumberData.TabIndex = 20;
            plateNumberData.Text = "Plate Number";
            plateNumberData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 198);
            label2.Name = "label2";
            label2.Size = new Size(247, 39);
            label2.TabIndex = 22;
            label2.Text = "Vehicle Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 255);
            label3.Name = "label3";
            label3.Size = new Size(247, 39);
            label3.TabIndex = 23;
            label3.Text = "Brand";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 309);
            label4.Name = "label4";
            label4.Size = new Size(247, 39);
            label4.TabIndex = 24;
            label4.Text = "Flagdown";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 365);
            label5.Name = "label5";
            label5.Size = new Size(247, 39);
            label5.TabIndex = 25;
            label5.Text = "Parkin";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Cascadia Mono ExtraLight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 532);
            label6.Name = "label6";
            label6.Size = new Size(247, 39);
            label6.TabIndex = 27;
            label6.Text = "Parking Fee";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Cascadia Mono ExtraLight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 478);
            label8.Name = "label8";
            label8.Size = new Size(247, 39);
            label8.TabIndex = 28;
            label8.Text = "Duration";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Cascadia Mono ExtraLight", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 420);
            label9.Name = "label9";
            label9.Size = new Size(247, 39);
            label9.TabIndex = 29;
            label9.Text = "Parkout";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vTypeData
            // 
            vTypeData.BorderStyle = BorderStyle.FixedSingle;
            vTypeData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vTypeData.Location = new Point(302, 198);
            vTypeData.Name = "vTypeData";
            vTypeData.Size = new Size(581, 39);
            vTypeData.TabIndex = 30;
            vTypeData.Text = "Plate Number";
            vTypeData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // brandData
            // 
            brandData.BorderStyle = BorderStyle.FixedSingle;
            brandData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandData.Location = new Point(302, 255);
            brandData.Name = "brandData";
            brandData.Size = new Size(581, 39);
            brandData.TabIndex = 31;
            brandData.Text = "Plate Number";
            brandData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flagdownData
            // 
            flagdownData.BorderStyle = BorderStyle.FixedSingle;
            flagdownData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flagdownData.Location = new Point(302, 309);
            flagdownData.Name = "flagdownData";
            flagdownData.Size = new Size(581, 39);
            flagdownData.TabIndex = 32;
            flagdownData.Text = "Plate Number";
            flagdownData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkinData
            // 
            parkinData.BorderStyle = BorderStyle.FixedSingle;
            parkinData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkinData.Location = new Point(302, 365);
            parkinData.Name = "parkinData";
            parkinData.Size = new Size(581, 39);
            parkinData.TabIndex = 33;
            parkinData.Text = "Plate Number";
            parkinData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkoutData
            // 
            parkoutData.BorderStyle = BorderStyle.FixedSingle;
            parkoutData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkoutData.Location = new Point(302, 420);
            parkoutData.Name = "parkoutData";
            parkoutData.Size = new Size(581, 39);
            parkoutData.TabIndex = 34;
            parkoutData.Text = "Plate Number";
            parkoutData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // durationData
            // 
            durationData.BorderStyle = BorderStyle.FixedSingle;
            durationData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationData.Location = new Point(302, 478);
            durationData.Name = "durationData";
            durationData.Size = new Size(581, 39);
            durationData.TabIndex = 35;
            durationData.Text = "Plate Number";
            durationData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // feeData
            // 
            feeData.BorderStyle = BorderStyle.FixedSingle;
            feeData.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feeData.Location = new Point(302, 533);
            feeData.Name = "feeData";
            feeData.Size = new Size(581, 39);
            feeData.TabIndex = 36;
            feeData.Text = "Plate Number";
            feeData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(102, 0, 0);
            backButton.Font = new Font("Cascadia Mono ExtraLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(661, 599);
            backButton.Name = "backButton";
            backButton.Size = new Size(222, 47);
            backButton.TabIndex = 37;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 674);
            Controls.Add(backButton);
            Controls.Add(feeData);
            Controls.Add(durationData);
            Controls.Add(parkoutData);
            Controls.Add(parkinData);
            Controls.Add(flagdownData);
            Controls.Add(brandData);
            Controls.Add(vTypeData);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(plateNumberData);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label7;
        private Label plateNumberData;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label vTypeData;
        private Label brandData;
        private Label flagdownData;
        private Label parkinData;
        private Label parkoutData;
        private Label durationData;
        private Label feeData;
        private Button backButton;

        public Button GetBackButton()
        {
            return backButton;
        }
    }
}