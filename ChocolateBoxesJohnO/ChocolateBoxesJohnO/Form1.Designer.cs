namespace ChocolateBoxesJohnO
{
    partial class frmChocolateBoxes
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
            this.lblSold = new System.Windows.Forms.Label();
            this.btnReward = new System.Windows.Forms.Button();
            this.lblReward = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.txtBoxesSold = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSold.Location = new System.Drawing.Point(12, 83);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(431, 34);
            this.lblSold.TabIndex = 1;
            this.lblSold.Text = "Enter the number of boxes sold:";
            // 
            // btnReward
            // 
            this.btnReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReward.Location = new System.Drawing.Point(328, 203);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(144, 44);
            this.btnReward.TabIndex = 3;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(117, 330);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(160, 25);
            this.lblReward.TabIndex = 4;
            this.lblReward.Text = "The reward is a";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(323, 330);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(105, 25);
            this.lblPrize.TabIndex = 5;
            this.lblPrize.Text = "REWARD";
            // 
            // txtBoxesSold
            // 
            this.txtBoxesSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxesSold.Location = new System.Drawing.Point(449, 87);
            this.txtBoxesSold.Name = "txtBoxesSold";
            this.txtBoxesSold.Size = new System.Drawing.Size(152, 31);
            this.txtBoxesSold.TabIndex = 6;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxesSold);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.lblSold);
            this.Name = "frmChocolateBoxes";
            this.Text = "ChocolateBoxes by John O";
            this.Load += new System.EventHandler(this.frmChocolateBoxes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.TextBox txtBoxesSold;
    }
}

