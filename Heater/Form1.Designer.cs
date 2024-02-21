namespace Heater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.Color.White;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayLabel.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisplayLabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.DisplayLabel.Location = new System.Drawing.Point(133, 60);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(356, 91);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "label1";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpButton
            // 
            this.UpButton.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpButton.Location = new System.Drawing.Point(229, 179);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(157, 65);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButon
            // 
            this.DownButon.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownButon.Location = new System.Drawing.Point(229, 250);
            this.DownButon.Name = "DownButon";
            this.DownButon.Size = new System.Drawing.Size(157, 65);
            this.DownButon.TabIndex = 2;
            this.DownButon.Text = "Down";
            this.DownButon.UseVisualStyleBackColor = true;
            this.DownButon.Click += new System.EventHandler(this.DownButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 340);
            this.Controls.Add(this.DownButon);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.DisplayLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label DisplayLabel;
        private Button UpButton;
        private Button DownButon;
    }
}