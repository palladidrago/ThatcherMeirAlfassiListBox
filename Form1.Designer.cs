
namespace ThatcherSongListBox___Ashi_Alfassi__Meir_Di_Capua
{
    partial class SongListBox
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
            this.lyricBox = new System.Windows.Forms.ListBox();
            this.iCarlyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lyricBox
            // 
            this.lyricBox.Font = new System.Drawing.Font("Rockwell Nova Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricBox.FormattingEnabled = true;
            this.lyricBox.ItemHeight = 44;
            this.lyricBox.Location = new System.Drawing.Point(12, 158);
            this.lyricBox.Name = "lyricBox";
            this.lyricBox.Size = new System.Drawing.Size(688, 136);
            this.lyricBox.TabIndex = 0;
            // 
            // iCarlyButton
            // 
            this.iCarlyButton.BackColor = System.Drawing.Color.Transparent;
            this.iCarlyButton.Font = new System.Drawing.Font("Georgia Pro Cond", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iCarlyButton.Location = new System.Drawing.Point(502, 28);
            this.iCarlyButton.Name = "iCarlyButton";
            this.iCarlyButton.Size = new System.Drawing.Size(198, 91);
            this.iCarlyButton.TabIndex = 1;
            this.iCarlyButton.Text = "iCarly";
            this.iCarlyButton.UseVisualStyleBackColor = false;
            this.iCarlyButton.Click += new System.EventHandler(this.SongPlay);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 140);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Explanation: Click the button to play iCarly\'s intro, and the lyrics will be show" +
    "n in the listbox";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SongListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(719, 616);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iCarlyButton);
            this.Controls.Add(this.lyricBox);
            this.Name = "SongListBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lyricBox;
        private System.Windows.Forms.Button iCarlyButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

