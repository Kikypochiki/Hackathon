namespace Hackathon
{
    partial class donatePrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button_esc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_money = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_food = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose donation type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(125, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "FOOD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label3.Location = new System.Drawing.Point(439, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = "MONEY";
            // 
            // guna2Button_esc
            // 
            this.guna2Button_esc.BackgroundImage = global::Hackathon.Properties.Resources.close;
            this.guna2Button_esc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button_esc.CheckedState.Parent = this.guna2Button_esc;
            this.guna2Button_esc.CustomImages.Parent = this.guna2Button_esc;
            this.guna2Button_esc.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_esc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_esc.ForeColor = System.Drawing.Color.White;
            this.guna2Button_esc.HoverState.Parent = this.guna2Button_esc;
            this.guna2Button_esc.Location = new System.Drawing.Point(718, 21);
            this.guna2Button_esc.Name = "guna2Button_esc";
            this.guna2Button_esc.ShadowDecoration.Parent = this.guna2Button_esc;
            this.guna2Button_esc.Size = new System.Drawing.Size(30, 40);
            this.guna2Button_esc.TabIndex = 6;
            this.guna2Button_esc.Click += new System.EventHandler(this.guna2Button_esc_Click);
            // 
            // guna2Button_money
            // 
            this.guna2Button_money.BackgroundImage = global::Hackathon.Properties.Resources.money;
            this.guna2Button_money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button_money.CheckedState.Parent = this.guna2Button_money;
            this.guna2Button_money.CustomImages.Parent = this.guna2Button_money;
            this.guna2Button_money.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_money.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_money.ForeColor = System.Drawing.Color.White;
            this.guna2Button_money.HoverState.Parent = this.guna2Button_money;
            this.guna2Button_money.Location = new System.Drawing.Point(466, 148);
            this.guna2Button_money.Name = "guna2Button_money";
            this.guna2Button_money.ShadowDecoration.Parent = this.guna2Button_money;
            this.guna2Button_money.Size = new System.Drawing.Size(136, 135);
            this.guna2Button_money.TabIndex = 1;
            this.guna2Button_money.Click += new System.EventHandler(this.guna2Button_money_Click);
            // 
            // guna2Button_food
            // 
            this.guna2Button_food.BackgroundImage = global::Hackathon.Properties.Resources.diet;
            this.guna2Button_food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button_food.CheckedState.Parent = this.guna2Button_food;
            this.guna2Button_food.CustomImages.Parent = this.guna2Button_food;
            this.guna2Button_food.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button_food.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_food.ForeColor = System.Drawing.Color.White;
            this.guna2Button_food.HoverState.Parent = this.guna2Button_food;
            this.guna2Button_food.Location = new System.Drawing.Point(148, 148);
            this.guna2Button_food.Name = "guna2Button_food";
            this.guna2Button_food.ShadowDecoration.Parent = this.guna2Button_food;
            this.guna2Button_food.Size = new System.Drawing.Size(136, 135);
            this.guna2Button_food.TabIndex = 0;
            this.guna2Button_food.Click += new System.EventHandler(this.guna2Button_food_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Location = new System.Drawing.Point(-7, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(781, 14);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button_esc);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button_money);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button_food);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-4, -3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(778, 491);
            this.guna2ShadowPanel1.TabIndex = 8;
            // 
            // donatePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 490);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "donatePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "donatePrompt";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button_food;
        private Guna.UI2.WinForms.Guna2Button guna2Button_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button_esc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}