namespace ParkingSystemGUI
{
    partial class ParkUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            searchPlateNumber = new TextBox();
            addParkButton = new PictureBox();
            label2 = new Label();
            parkedListPanel = new FlowLayoutPanel();
            searchPlateButton = new PictureBox();
            label1 = new Label();
            parkInDetailPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addParkButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPlateButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(searchPlateNumber);
            panel1.Controls.Add(addParkButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(parkedListPanel);
            panel1.Controls.Add(searchPlateButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 709);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // searchPlateNumber
            // 
            searchPlateNumber.BorderStyle = BorderStyle.None;
            searchPlateNumber.Font = new Font("Cascadia Mono Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPlateNumber.Location = new Point(35, 120);
            searchPlateNumber.Multiline = true;
            searchPlateNumber.Name = "searchPlateNumber";
            searchPlateNumber.PlaceholderText = "Search Plate No..";
            searchPlateNumber.Size = new Size(236, 34);
            searchPlateNumber.TabIndex = 5;
            // 
            // addParkButton
            // 
            addParkButton.BackColor = Color.FromArgb(32, 32, 66);
            addParkButton.Cursor = Cursors.Hand;
            addParkButton.Location = new Point(125, 619);
            addParkButton.Name = "addParkButton";
            addParkButton.Size = new Size(104, 72);
            addParkButton.TabIndex = 0;
            addParkButton.TabStop = false;
            addParkButton.Click += addParkButton_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(25, 112);
            label2.Name = "label2";
            label2.Size = new Size(257, 47);
            label2.TabIndex = 4;
            // 
            // parkedListPanel
            // 
            parkedListPanel.BorderStyle = BorderStyle.FixedSingle;
            parkedListPanel.Location = new Point(-1, 182);
            parkedListPanel.Name = "parkedListPanel";
            parkedListPanel.Size = new Size(369, 478);
            parkedListPanel.TabIndex = 3;
            parkedListPanel.Paint += parkedListPanel_Paint;
            // 
            // searchPlateButton
            // 
            searchPlateButton.BackColor = Color.FromArgb(32, 32, 66);
            searchPlateButton.Cursor = Cursors.Hand;
            searchPlateButton.Location = new Point(288, 112);
            searchPlateButton.Name = "searchPlateButton";
            searchPlateButton.Size = new Size(57, 47);
            searchPlateButton.TabIndex = 2;
            searchPlateButton.TabStop = false;
            searchPlateButton.Click += searchPlateButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Cascadia Mono", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 95);
            label1.TabIndex = 0;
            label1.Text = "PARKED";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkInDetailPanel
            // 
            parkInDetailPanel.BackColor = Color.White;
            parkInDetailPanel.BorderStyle = BorderStyle.FixedSingle;
            parkInDetailPanel.Location = new Point(350, -5);
            parkInDetailPanel.Name = "parkInDetailPanel";
            parkInDetailPanel.Size = new Size(814, 723);
            parkInDetailPanel.TabIndex = 1;
            parkInDetailPanel.Paint += parkInDetailPanel_Paint;
            // 
            // ParkUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parkInDetailPanel);
            Controls.Add(panel1);
            Name = "ParkUserControl";
            Size = new Size(1130, 701);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addParkButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchPlateButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox searchPlateButton;
        private PictureBox addParkButton;
        private FlowLayoutPanel parkedListPanel;
        private Panel parkInDetailPanel;
        private TextBox searchPlateNumber;
        private Label label2;
    }
}
