namespace Hackathon
{
    partial class aboutUs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutUs));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(757, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 111);
            this.label2.TabIndex = 0;
            this.label2.Text = "ABOUT US";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 531);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1229, 204);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.guna2Panel3.Controls.Add(this.label10);
            this.guna2Panel3.Controls.Add(this.guna2ImageButton5);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 1015);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(2090, 125);
            this.guna2Panel3.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(471, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1167, 58);
            this.label10.TabIndex = 9;
            this.label10.Text = "NourishDesk | © 2025 All Rights Reserved | giansuico@gmail.com | Privacy Policy |" +
    "  Terms of Service\r\n\r\n";
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.BackgroundImage = global::Hackathon.Properties.Resources.Logo_Design;
            this.guna2ImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2ImageButton5.CheckedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.HoverState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Location = new System.Drawing.Point(367, 25);
            this.guna2ImageButton5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Size = new System.Drawing.Size(78, 67);
            this.guna2ImageButton5.TabIndex = 7;
            // 
            // aboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "aboutUs";
            this.Size = new System.Drawing.Size(2090, 1140);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
    }
}
