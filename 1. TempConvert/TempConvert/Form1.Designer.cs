
namespace TempConvert
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
            this.F = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.Label();
            this.txt_f = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.btn_Fahrenheight = new System.Windows.Forms.Button();
            this.btn_Celsius = new System.Windows.Forms.Button();
            this.btn_Kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.F.Location = new System.Drawing.Point(67, 101);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(156, 31);
            this.F.TabIndex = 0;
            this.F.Text = "Fahrenheight";
            this.F.Click += new System.EventHandler(this.label1_Click);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(67, 170);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(88, 31);
            this.C.TabIndex = 1;
            this.C.Text = "Celsius";
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K.Location = new System.Drawing.Point(67, 239);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(81, 31);
            this.K.TabIndex = 2;
            this.K.Text = "Kelvin";
            // 
            // txt_f
            // 
            this.txt_f.Location = new System.Drawing.Point(268, 105);
            this.txt_f.Name = "txt_f";
            this.txt_f.Size = new System.Drawing.Size(158, 27);
            this.txt_f.TabIndex = 3;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(268, 176);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(158, 27);
            this.txt_c.TabIndex = 4;
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(268, 243);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(158, 27);
            this.txt_k.TabIndex = 5;
            // 
            // btn_Fahrenheight
            // 
            this.btn_Fahrenheight.ForeColor = System.Drawing.Color.Black;
            this.btn_Fahrenheight.Location = new System.Drawing.Point(478, 99);
            this.btn_Fahrenheight.Name = "btn_Fahrenheight";
            this.btn_Fahrenheight.Size = new System.Drawing.Size(91, 41);
            this.btn_Fahrenheight.TabIndex = 6;
            this.btn_Fahrenheight.Text = "Convert";
            this.btn_Fahrenheight.UseVisualStyleBackColor = true;
            this.btn_Fahrenheight.Click += new System.EventHandler(this.btn_Fahrenheight_Click);
            // 
            // btn_Celsius
            // 
            this.btn_Celsius.ForeColor = System.Drawing.Color.Black;
            this.btn_Celsius.Location = new System.Drawing.Point(478, 169);
            this.btn_Celsius.Name = "btn_Celsius";
            this.btn_Celsius.Size = new System.Drawing.Size(91, 41);
            this.btn_Celsius.TabIndex = 7;
            this.btn_Celsius.Text = "Convert";
            this.btn_Celsius.UseVisualStyleBackColor = true;
            this.btn_Celsius.Click += new System.EventHandler(this.btn_Celsius_Click);
            // 
            // btn_Kelvin
            // 
            this.btn_Kelvin.ForeColor = System.Drawing.Color.Black;
            this.btn_Kelvin.Location = new System.Drawing.Point(478, 235);
            this.btn_Kelvin.Name = "btn_Kelvin";
            this.btn_Kelvin.Size = new System.Drawing.Size(91, 41);
            this.btn_Kelvin.TabIndex = 8;
            this.btn_Kelvin.Text = "Convert";
            this.btn_Kelvin.UseVisualStyleBackColor = true;
            this.btn_Kelvin.Click += new System.EventHandler(this.btn_Kelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 392);
            this.Controls.Add(this.btn_Kelvin);
            this.Controls.Add(this.btn_Celsius);
            this.Controls.Add(this.btn_Fahrenheight);
            this.Controls.Add(this.txt_k);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_f);
            this.Controls.Add(this.K);
            this.Controls.Add(this.C);
            this.Controls.Add(this.F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Temperature Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.TextBox txt_f;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.Button btn_Fahrenheight;
        private System.Windows.Forms.Button btn_Celsius;
        private System.Windows.Forms.Button btn_Kelvin;
    }
}

