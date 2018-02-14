namespace Builder
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
            this.btn_laptop = new System.Windows.Forms.Button();
            this.btn_desktop = new System.Windows.Forms.Button();
            this.txtBox_display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_laptop
            // 
            this.btn_laptop.Location = new System.Drawing.Point(12, 12);
            this.btn_laptop.Name = "btn_laptop";
            this.btn_laptop.Size = new System.Drawing.Size(162, 32);
            this.btn_laptop.TabIndex = 0;
            this.btn_laptop.Text = "Build Laptop";
            this.btn_laptop.UseVisualStyleBackColor = true;
            this.btn_laptop.Click += new System.EventHandler(this.btn_laptop_Click);
            // 
            // btn_desktop
            // 
            this.btn_desktop.Location = new System.Drawing.Point(12, 50);
            this.btn_desktop.Name = "btn_desktop";
            this.btn_desktop.Size = new System.Drawing.Size(162, 32);
            this.btn_desktop.TabIndex = 1;
            this.btn_desktop.Text = "Build Desktop";
            this.btn_desktop.UseVisualStyleBackColor = true;
            this.btn_desktop.Click += new System.EventHandler(this.btn_desktop_Click);
            // 
            // txtBox_display
            // 
            this.txtBox_display.Location = new System.Drawing.Point(180, 12);
            this.txtBox_display.Name = "txtBox_display";
            this.txtBox_display.Size = new System.Drawing.Size(419, 466);
            this.txtBox_display.TabIndex = 2;
            this.txtBox_display.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 535);
            this.Controls.Add(this.txtBox_display);
            this.Controls.Add(this.btn_desktop);
            this.Controls.Add(this.btn_laptop);
            this.Name = "Form1";
            this.Text = "Builder Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_laptop;
        private System.Windows.Forms.Button btn_desktop;
        private System.Windows.Forms.RichTextBox txtBox_display;
    }
}

