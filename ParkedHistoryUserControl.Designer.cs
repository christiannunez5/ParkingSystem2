namespace ParkingSystemGUI
{
    partial class ParkedHistoryUserControl
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
            label1 = new Label();
            errorPanel = new Panel();
            label6 = new Label();
            transactionPanel = new Panel();
            historyPanel = new FlowLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            errorPanel.SuspendLayout();
            transactionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 174);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Mono", 52.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(175, 22);
            label1.Name = "label1";
            label1.Size = new Size(780, 119);
            label1.TabIndex = 0;
            label1.Text = "PARKED HISTORY";
            // 
            // errorPanel
            // 
            errorPanel.BackColor = Color.White;
            errorPanel.BorderStyle = BorderStyle.FixedSingle;
            errorPanel.Controls.Add(label6);
            errorPanel.Location = new Point(-29, 211);
            errorPanel.Name = "errorPanel";
            errorPanel.Size = new Size(1187, 416);
            errorPanel.TabIndex = 2;
            errorPanel.Paint += errorPanel_Paint;
            // 
            // label6
            // 
            label6.Font = new Font("Cascadia Mono SemiLight", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(136, 22);
            label6.Name = "label6";
            label6.Size = new Size(951, 352);
            label6.TabIndex = 0;
            label6.Text = "No transaction records to display.";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // transactionPanel
            // 
            transactionPanel.Controls.Add(historyPanel);
            transactionPanel.Controls.Add(label5);
            transactionPanel.Controls.Add(label4);
            transactionPanel.Controls.Add(label3);
            transactionPanel.Controls.Add(label2);
            transactionPanel.Location = new Point(27, 211);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(1076, 416);
            transactionPanel.TabIndex = 3;
            // 
            // historyPanel
            // 
            historyPanel.AutoScroll = true;
            historyPanel.Location = new Point(0, 70);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(1076, 346);
            historyPanel.TabIndex = 4;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(32, 32, 64);
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Cascadia Mono SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(807, 1);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(269, 51);
            label5.TabIndex = 3;
            label5.Text = "Parking Fee";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(32, 32, 64);
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Cascadia Mono SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(538, 1);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(269, 51);
            label4.TabIndex = 2;
            label4.Text = "Park out";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(32, 32, 64);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Cascadia Mono SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(269, 1);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(269, 51);
            label3.TabIndex = 1;
            label3.Text = "Park in";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(32, 32, 64);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Cascadia Mono SemiLight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 1);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(269, 51);
            label2.TabIndex = 0;
            label2.Text = "Plate Number";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ParkedHistoryUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(transactionPanel);
            Controls.Add(panel1);
            Controls.Add(errorPanel);
            Name = "ParkedHistoryUserControl";
            Size = new Size(1130, 701);
            panel1.ResumeLayout(false);
            errorPanel.ResumeLayout(false);
            transactionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;

        public FlowLayoutPanel GetHistoryPanel()
        {
            return historyPanel;
        }

        public Panel GetErrorPanel()
        {
            return errorPanel;
        }

        public Panel GetTransactionPanel()
        {
            return transactionPanel;
        }
        private Panel errorPanel;
        private Label label6;
        private Panel transactionPanel;
        private Label label2;
        private FlowLayoutPanel historyPanel;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
