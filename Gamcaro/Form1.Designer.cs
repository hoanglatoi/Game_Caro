namespace Gamcaro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.palChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.bntLAN = new System.Windows.Forms.Button();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // palChessBoard
            // 
            this.palChessBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.palChessBoard.Location = new System.Drawing.Point(12, 27);
            this.palChessBoard.Name = "palChessBoard";
            this.palChessBoard.Size = new System.Drawing.Size(585, 606);
            this.palChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BackgroundImage = global::Gamcaro.Properties.Resources.weplay_vn_caro_xogame;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(613, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 228);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bntLAN);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(613, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 338);
            this.panel3.TabIndex = 2;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(15, 44);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(93, 23);
            this.prcbCoolDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 123);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anh Hoàng\r\n\r\n Đẹp Trai";
            // 
            // bntLAN
            // 
            this.bntLAN.Location = new System.Drawing.Point(15, 118);
            this.bntLAN.Name = "bntLAN";
            this.bntLAN.Size = new System.Drawing.Size(91, 28);
            this.bntLAN.TabIndex = 4;
            this.bntLAN.Text = "button1";
            this.bntLAN.UseVisualStyleBackColor = true;
            // 
            // pctbMark
            // 
            this.pctbMark.Location = new System.Drawing.Point(134, 18);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(81, 85);
            this.pctbMark.TabIndex = 3;
            this.pctbMark.TabStop = false;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(17, 83);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(90, 20);
            this.txbIP.TabIndex = 2;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(15, 18);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.Size = new System.Drawing.Size(93, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.palChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntLAN;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
    }
}

