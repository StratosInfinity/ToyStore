
namespace Магазин_игрушек
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.shopingbutton = new System.Windows.Forms.Button();
            this.catalogbutton = new System.Windows.Forms.Button();
            this.shopname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Yellow;
            this.exitbutton.Location = new System.Drawing.Point(23, 273);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(160, 48);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Выход";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // shopingbutton
            // 
            this.shopingbutton.BackColor = System.Drawing.Color.Yellow;
            this.shopingbutton.Location = new System.Drawing.Point(23, 157);
            this.shopingbutton.Name = "shopingbutton";
            this.shopingbutton.Size = new System.Drawing.Size(160, 48);
            this.shopingbutton.TabIndex = 10;
            this.shopingbutton.Text = "Корзина";
            this.shopingbutton.UseVisualStyleBackColor = false;
            this.shopingbutton.Click += new System.EventHandler(this.shopingbutton_Click);
            // 
            // catalogbutton
            // 
            this.catalogbutton.BackColor = System.Drawing.Color.Yellow;
            this.catalogbutton.Location = new System.Drawing.Point(23, 44);
            this.catalogbutton.Name = "catalogbutton";
            this.catalogbutton.Size = new System.Drawing.Size(160, 48);
            this.catalogbutton.TabIndex = 11;
            this.catalogbutton.Text = "Каталог";
            this.catalogbutton.UseVisualStyleBackColor = false;
            this.catalogbutton.Click += new System.EventHandler(this.catalogbutton_Click);
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.BackColor = System.Drawing.Color.Transparent;
            this.shopname.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopname.Location = new System.Drawing.Point(225, 53);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(233, 34);
            this.shopname.TabIndex = 12;
            this.shopname.Text = "Магазин игрушек \"Юла\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 529);
            this.Controls.Add(this.shopname);
            this.Controls.Add(this.catalogbutton);
            this.Controls.Add(this.shopingbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "mainpage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button shopingbutton;
        private System.Windows.Forms.Button catalogbutton;
        private System.Windows.Forms.Label shopname;
    }
}