namespace ParkingSystemGUI
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
            panel1 = new Panel();
            plateNumberInput = new TextBox();
            label3 = new Label();
            backButton = new Button();
            brandComboBox = new ComboBox();
            label2 = new Label();
            addCarButton = new Button();
            label4 = new Label();
            vTypeComboBox = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(plateNumberInput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(brandComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addCarButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(vTypeComboBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(38, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 380);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // plateNumberInput
            // 
            plateNumberInput.BorderStyle = BorderStyle.None;
            plateNumberInput.Font = new Font("Cascadia Mono SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumberInput.Location = new Point(270, 48);
            plateNumberInput.Multiline = true;
            plateNumberInput.Name = "plateNumberInput";
            plateNumberInput.PlaceholderText = "Plate Number...";
            plateNumberInput.Size = new Size(517, 34);
            plateNumberInput.TabIndex = 13;
            plateNumberInput.TextChanged += plateNumberInput_TextChanged;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(263, 42);
            label3.Name = "label3";
            label3.Size = new Size(534, 47);
            label3.TabIndex = 12;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(102, 0, 0);
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Cascadia Mono", 13.8F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(356, 288);
            backButton.Name = "backButton";
            backButton.Size = new Size(212, 50);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // brandComboBox
            // 
            brandComboBox.Font = new Font("Cascadia Mono ExtraLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brandComboBox.FormattingEnabled = true;
            brandComboBox.Location = new Point(263, 195);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(534, 48);
            brandComboBox.TabIndex = 10;
            brandComboBox.Text = "Select Brand";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 66);
            label2.Font = new Font("Cascadia Mono", 13.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 195);
            label2.Name = "label2";
            label2.Size = new Size(210, 48);
            label2.TabIndex = 8;
            label2.Text = "Brand";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addCarButton
            // 
            addCarButton.BackColor = Color.FromArgb(32, 32, 66);
            addCarButton.Cursor = Cursors.Hand;
            addCarButton.Font = new Font("Cascadia Mono", 13.8F);
            addCarButton.ForeColor = Color.White;
            addCarButton.Location = new Point(585, 288);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(212, 50);
            addCarButton.TabIndex = 7;
            addCarButton.Text = "Park in";
            addCarButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 66);
            label4.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 120);
            label4.Name = "label4";
            label4.Size = new Size(210, 48);
            label4.TabIndex = 4;
            label4.Text = "Vehicle Type";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vTypeComboBox
            // 
            vTypeComboBox.DropDownHeight = 1000;
            vTypeComboBox.Font = new Font("Cascadia Mono ExtraLight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vTypeComboBox.FormattingEnabled = true;
            vTypeComboBox.IntegralHeight = false;
            vTypeComboBox.Items.AddRange(new object[] { "Motorbike", "Van", "SUV", "Sedan" });
            vTypeComboBox.Location = new Point(263, 120);
            vTypeComboBox.Name = "vTypeComboBox";
            vTypeComboBox.Size = new Size(534, 48);
            vTypeComboBox.TabIndex = 3;
            vTypeComboBox.TabStop = false;
            vTypeComboBox.Text = "Select Vehicle";
            vTypeComboBox.SelectedIndexChanged += vTypeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(32, 32, 66);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(210, 48);
            label1.TabIndex = 1;
            label1.Text = "Plate Number";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(920, 522);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(255, 128, 128);
            Name = "AddCarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCarForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox vTypeComboBox;
        private Label label4;
        private Button addCarButton;
        private Label label2;
        private Button backButton;
        private ComboBox brandComboBox;
        private TextBox plateNumberInput;
        private Label label3;

        public TextBox GetPlateNumber()
        {
            return plateNumberInput;
        }

        public ComboBox GetVehicleType()
        {
            return vTypeComboBox;
        }

        public ComboBox GetBrand()
        {
            return brandComboBox;
        }

        public Button GetAddCarButton()
        {
            return addCarButton;
        }
    }
}