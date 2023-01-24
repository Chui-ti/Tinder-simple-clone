namespace WindowsFormsApp1
{
    partial class pairs
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
            this.button_back2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_back2
            // 
            this.button_back2.Location = new System.Drawing.Point(188, 160);
            this.button_back2.Name = "button_back2";
            this.button_back2.Size = new System.Drawing.Size(282, 182);
            this.button_back2.TabIndex = 0;
            this.button_back2.Text = "тоже назад к меню, можешь изменять и двигать";
            this.button_back2.UseVisualStyleBackColor = true;
            this.button_back2.Click += new System.EventHandler(this.button_back2_Click);
            // 
            // pairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 795);
            this.ControlBox = false;
            this.Controls.Add(this.button_back2);
            this.Name = "pairs";
            this.Text = "pairs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back2;
    }
}