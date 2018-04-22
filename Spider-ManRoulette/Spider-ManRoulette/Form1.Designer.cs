namespace Spider_ManRoulette
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
            this.txtinstructions = new System.Windows.Forms.TextBox();
            this.btnspinbarrel = new System.Windows.Forms.Button();
            this.btnloadgun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinstructions
            // 
            this.txtinstructions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtinstructions.Location = new System.Drawing.Point(100, 78);
            this.txtinstructions.Multiline = true;
            this.txtinstructions.Name = "txtinstructions";
            this.txtinstructions.ReadOnly = true;
            this.txtinstructions.Size = new System.Drawing.Size(293, 265);
            this.txtinstructions.TabIndex = 1;
            this.txtinstructions.TabStop = false;
            this.txtinstructions.Text = resources.GetString("txtinstructions.Text");
            this.txtinstructions.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnspinbarrel
            // 
            this.btnspinbarrel.Location = new System.Drawing.Point(869, 208);
            this.btnspinbarrel.Name = "btnspinbarrel";
            this.btnspinbarrel.Size = new System.Drawing.Size(154, 70);
            this.btnspinbarrel.TabIndex = 2;
            this.btnspinbarrel.Text = "Mask On";
            this.btnspinbarrel.UseVisualStyleBackColor = true;
            this.btnspinbarrel.Click += new System.EventHandler(this.btnspinbarrel_Click);
            // 
            // btnloadgun
            // 
            this.btnloadgun.Location = new System.Drawing.Point(869, 55);
            this.btnloadgun.Name = "btnloadgun";
            this.btnloadgun.Size = new System.Drawing.Size(164, 88);
            this.btnloadgun.TabIndex = 3;
            this.btnloadgun.Text = "grab web shooters";
            this.btnloadgun.UseVisualStyleBackColor = true;
            this.btnloadgun.Click += new System.EventHandler(this.btnloadgun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spider_ManRoulette.Resource1.news_illustre_1341824010;
            this.ClientSize = new System.Drawing.Size(1202, 598);
            this.Controls.Add(this.btnloadgun);
            this.Controls.Add(this.btnspinbarrel);
            this.Controls.Add(this.txtinstructions);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtinstructions;
        private System.Windows.Forms.Button btnspinbarrel;
        private System.Windows.Forms.Button btnloadgun;
    }
}