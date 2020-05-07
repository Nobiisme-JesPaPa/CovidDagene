namespace SpaceInvaders {
    partial class Menu {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.onePlayerButton = new System.Windows.Forms.Button();
            this.highScoreTextSP = new System.Windows.Forms.Label();
            this.highScoreSP1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpaceInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            

            this.onePlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.onePlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.onePlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.onePlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.onePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onePlayerButton.ForeColor = System.Drawing.SystemColors.Control;
            this.onePlayerButton.Location = new System.Drawing.Point(337, 345);
            this.onePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(313, 55);
            this.onePlayerButton.TabIndex = 1;
            this.onePlayerButton.Text = " Play";
            this.onePlayerButton.UseVisualStyleBackColor = false;
            this.onePlayerButton.Click += new System.EventHandler(this.onePlayerButton_Click);
            
            this.highScoreTextSP.AutoSize = true;
            this.highScoreTextSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreTextSP.ForeColor = System.Drawing.SystemColors.Control;
            this.highScoreTextSP.Location = new System.Drawing.Point(418, 438);
            this.highScoreTextSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreTextSP.Name = "highScoreTextSP";
            this.highScoreTextSP.Size = new System.Drawing.Size(0, 36);
            this.highScoreTextSP.TabIndex = 3;
            

            this.highScoreSP1.AutoSize = true;
            this.highScoreSP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreSP1.ForeColor = System.Drawing.SystemColors.Control;
            this.highScoreSP1.Location = new System.Drawing.Point(508, 520);
            this.highScoreSP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreSP1.Name = "highScoreSP1";
            this.highScoreSP1.Size = new System.Drawing.Size(0, 36);
            this.highScoreSP1.TabIndex = 11;
            this.highScoreSP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(460, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            
            this.SpaceInv.AutoSize = true;
            this.SpaceInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceInv.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SpaceInv.Location = new System.Drawing.Point(327, 186);
            this.SpaceInv.Name = "SpaceInv";
            this.SpaceInv.Size = new System.Drawing.Size(359, 55);
            this.SpaceInv.TabIndex = 12;
            this.SpaceInv.Text = "Space Invaders";
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1021, 1148);
            this.Controls.Add(this.SpaceInv);
            this.Controls.Add(this.highScoreSP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highScoreTextSP);
            this.Controls.Add(this.onePlayerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button onePlayerButton;
        private System.Windows.Forms.Label highScoreTextSP;
        private System.Windows.Forms.Label highScoreSP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpaceInv;
    }
}