namespace Final
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
            this.lblWins = new System.Windows.Forms.Label();
            this.lbllosses = new System.Windows.Forms.Label();
            this.btnCards = new System.Windows.Forms.Button();
            this.lblwinCount = new System.Windows.Forms.Label();
            this.lbllossCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(17, 16);
            this.lblWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(66, 29);
            this.lblWins.TabIndex = 0;
            this.lblWins.Text = "Wins";
            // 
            // lbllosses
            // 
            this.lbllosses.AutoSize = true;
            this.lbllosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllosses.Location = new System.Drawing.Point(17, 68);
            this.lbllosses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllosses.Name = "lbllosses";
            this.lbllosses.Size = new System.Drawing.Size(90, 29);
            this.lbllosses.TabIndex = 1;
            this.lbllosses.Text = "Losses";
            // 
            // btnCards
            // 
            this.btnCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCards.Location = new System.Drawing.Point(23, 122);
            this.btnCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCards.Name = "btnCards";
            this.btnCards.Size = new System.Drawing.Size(100, 38);
            this.btnCards.TabIndex = 2;
            this.btnCards.Text = "Cards";
            this.btnCards.UseVisualStyleBackColor = true;
            this.btnCards.Click += new System.EventHandler(this.btnCards_Click);
            // 
            // lblwinCount
            // 
            this.lblwinCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblwinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinCount.Location = new System.Drawing.Point(115, 17);
            this.lblwinCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwinCount.Name = "lblwinCount";
            this.lblwinCount.Size = new System.Drawing.Size(133, 28);
            this.lblwinCount.TabIndex = 3;
            // 
            // lbllossCount
            // 
            this.lbllossCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbllossCount.Location = new System.Drawing.Point(115, 69);
            this.lbllossCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllossCount.Name = "lbllossCount";
            this.lbllossCount.Size = new System.Drawing.Size(133, 28);
            this.lbllossCount.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(664, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(664, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 384);
            this.Controls.Add(this.lbllossCount);
            this.Controls.Add(this.lblwinCount);
            this.Controls.Add(this.btnCards);
            this.Controls.Add(this.lbllosses);
            this.Controls.Add(this.lblWins);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lbllosses;
        private System.Windows.Forms.Button btnCards;
        private System.Windows.Forms.Label lblwinCount;
        private System.Windows.Forms.Label lbllossCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

