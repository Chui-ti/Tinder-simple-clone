namespace WindowsFormsApp1
{
    partial class settings
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
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(143, 234);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(379, 115);
            this.button_back.TabIndex = 0;
            this.button_back.Text = "назад, Миша, изменяй кнопку по красоте, на ней событие для возврата на страницу п" +
    "оиска";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 795);
            this.ControlBox = false;
            this.Controls.Add(this.button_back);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
    }
}