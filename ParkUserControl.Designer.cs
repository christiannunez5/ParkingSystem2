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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkUserControl));
            panel1 = new Panel();
            endSearchBox = new PictureBox();
            zeroParkPanel = new Panel();
            addParkButton = new PictureBox();
            messageLabel = new Label();
            searchPlateNumber = new TextBox();
            label2 = new Label();
            parkedListPanel = new FlowLayoutPanel();
            searchPlateButton = new PictureBox();
            label1 = new Label();
            parkInDetailPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)endSearchBox).BeginInit();
            zeroParkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addParkButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchPlateButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addParkButton);
            panel1.Controls.Add(endSearchBox);
            panel1.Controls.Add(zeroParkPanel);
            panel1.Controls.Add(searchPlateNumber);
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
            // endSearchBox
            // 
            endSearchBox.Image = (Image)resources.GetObject("endSearchBox.Image");
            endSearchBox.Location = new Point(245, 118);
            endSearchBox.Name = "endSearchBox";
            endSearchBox.Size = new Size(32, 34);
            endSearchBox.SizeMode = PictureBoxSizeMode.StretchImage;
            endSearchBox.TabIndex = 7;
            endSearchBox.TabStop = false;
            endSearchBox.Visible = false;
            // 
            // zeroParkPanel
            // 
            zeroParkPanel.BorderStyle = BorderStyle.FixedSingle;
            zeroParkPanel.Controls.Add(messageLabel);
            zeroParkPanel.Location = new Point(3, 182);
            zeroParkPanel.Name = "zeroParkPanel";
            zeroParkPanel.Size = new Size(378, 495);
            zeroParkPanel.TabIndex = 6;
            zeroParkPanel.Paint += zeroParkPanel_Paint;
            // 
            // addParkButton
            // 
            addParkButton.BackColor = Color.Transparent;
            addParkButton.Cursor = Cursors.Hand;
            addParkButton.Image = (Image)resources.GetObject("addParkButton.Image");
            addParkButton.Location = new Point(157, 654);
            addParkButton.Name = "addParkButton";
            addParkButton.Size = new Size(61, 55);
            addParkButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addParkButton.TabIndex = 0;
            addParkButton.TabStop = false;
            addParkButton.Click += addParkButton_Click;
            // 
            // messageLabel
            // 
            messageLabel.BackColor = Color.White;
            messageLabel.Font = new Font("Cascadia Mono Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(35, 119);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(304, 205);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "0 parked cars.";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            searchPlateNumber.TextChanged += searchPlateNumber_TextChanged;
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
            parkedListPanel.AutoScroll = true;
            parkedListPanel.BorderStyle = BorderStyle.FixedSingle;
            parkedListPanel.Location = new Point(3, 182);
            parkedListPanel.Name = "parkedListPanel";
            parkedListPanel.Size = new Size(378, 480);
            parkedListPanel.TabIndex = 3;
            parkedListPanel.Paint += parkedListPanel_Paint;
            // 
            // searchPlateButton
            // 
            searchPlateButton.BackColor = Color.FromArgb(32, 32, 66);
            searchPlateButton.Cursor = Cursors.Hand;
            searchPlateButton.Image = (Image)resources.GetObject("searchPlateButton.Image");
            searchPlateButton.Location = new Point(288, 112);
            searchPlateButton.Name = "searchPlateButton";
            searchPlateButton.Padding = new Padding(5);
            searchPlateButton.Size = new Size(57, 47);
            searchPlateButton.SizeMode = PictureBoxSizeMode.StretchImage;
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
            label1.Size = new Size(391, 95);
            label1.TabIndex = 0;
            label1.Text = "PARKED";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parkInDetailPanel
            // 
            parkInDetailPanel.BackColor = Color.White;
            parkInDetailPanel.BorderStyle = BorderStyle.Fixed3D;
            parkInDetailPanel.Location = new Point(367, -5);
            parkInDetailPanel.Name = "parkInDetailPanel";
            parkInDetailPanel.Size = new Size(797, 723);
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
            ((System.ComponentModel.ISupportInitialize)endSearchBox).EndInit();
            zeroParkPanel.ResumeLayout(false);
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

        public PictureBox GetAddParkButton()
        {
            return addParkButton;
        }

        public Panel GetParkedListPanel()
        {
            return parkedListPanel;
        }

        public TextBox GetPlateNumberSearch()
        {
            return searchPlateNumber;
        }

        public Label GetMessageLabel()
        {
            return messageLabel;
        }

        public PictureBox GetEndSearchBox()
        {
            return endSearchBox;
        }

        public Panel GetParkInDetailPanel()
        {
            return parkInDetailPanel;
        }

        public Panel GetZeroParkPanel()
        {
            return zeroParkPanel;
        }

        public PictureBox GetSearchBox()
        {
            return searchPlateButton;
        }



        private Panel zeroParkPanel;
        private Label messageLabel;
        private PictureBox endSearchBox;
    }
}
