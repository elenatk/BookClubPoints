
namespace BookClubPoints
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
            this.lblNumberOfBooks = new System.Windows.Forms.Label();
            this.txtNumberOfBooks = new System.Windows.Forms.TextBox();
            this.btnCalculatePoints = new System.Windows.Forms.Button();
            this.lblCalculatedPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberOfBooks
            // 
            this.lblNumberOfBooks.AutoSize = true;
            this.lblNumberOfBooks.Location = new System.Drawing.Point(32, 55);
            this.lblNumberOfBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfBooks.Name = "lblNumberOfBooks";
            this.lblNumberOfBooks.Size = new System.Drawing.Size(387, 39);
            this.lblNumberOfBooks.TabIndex = 0;
            this.lblNumberOfBooks.Text = "Enter a number of books";
            // 
            // txtNumberOfBooks
            // 
            this.txtNumberOfBooks.Location = new System.Drawing.Point(557, 49);
            this.txtNumberOfBooks.Name = "txtNumberOfBooks";
            this.txtNumberOfBooks.Size = new System.Drawing.Size(158, 45);
            this.txtNumberOfBooks.TabIndex = 1;
            // 
            // btnCalculatePoints
            // 
            this.btnCalculatePoints.Location = new System.Drawing.Point(39, 151);
            this.btnCalculatePoints.Name = "btnCalculatePoints";
            this.btnCalculatePoints.Size = new System.Drawing.Size(341, 76);
            this.btnCalculatePoints.TabIndex = 2;
            this.btnCalculatePoints.Text = "Calculate My Points!";
            this.btnCalculatePoints.UseVisualStyleBackColor = true;
            this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
            // 
            // lblCalculatedPoints
            // 
            this.lblCalculatedPoints.AutoSize = true;
            this.lblCalculatedPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculatedPoints.Location = new System.Drawing.Point(32, 306);
            this.lblCalculatedPoints.Name = "lblCalculatedPoints";
            this.lblCalculatedPoints.Size = new System.Drawing.Size(2, 41);
            this.lblCalculatedPoints.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 289);
            this.Controls.Add(this.lblCalculatedPoints);
            this.Controls.Add(this.btnCalculatePoints);
            this.Controls.Add(this.txtNumberOfBooks);
            this.Controls.Add(this.lblNumberOfBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfBooks;
        private System.Windows.Forms.TextBox txtNumberOfBooks;
        private System.Windows.Forms.Button btnCalculatePoints;
        private System.Windows.Forms.Label lblCalculatedPoints;
    }
}

