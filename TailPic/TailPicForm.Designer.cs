namespace TailPic
{
    partial class TailPicForm
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
            this.tailPictureBox1 = new TailPic.TailPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tailPictureBox1
            // 
            this.tailPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tailPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.tailPictureBox1.Name = "tailPictureBox1";
            this.tailPictureBox1.Size = new System.Drawing.Size(282, 253);
            this.tailPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tailPictureBox1.TabIndex = 2;
            this.tailPictureBox1.TabStop = false;
            // 
            // TailPicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tailPictureBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "TailPicForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TailPic";
            this.Shown += new System.EventHandler(this.TailPicForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TailPictureBox tailPictureBox1;
    }
}

