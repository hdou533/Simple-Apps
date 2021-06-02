
namespace FriendsList
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
            this.txt_newFriends = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ascending = new System.Windows.Forms.Button();
            this.btn_descending = new System.Windows.Forms.Button();
            this.btn_clearlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_newFriends
            // 
            this.txt_newFriends.Location = new System.Drawing.Point(371, 39);
            this.txt_newFriends.Name = "txt_newFriends";
            this.txt_newFriends.Size = new System.Drawing.Size(364, 27);
            this.txt_newFriends.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(371, 87);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add Friend";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 364);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ascending
            // 
            this.btn_ascending.Location = new System.Drawing.Point(371, 265);
            this.btn_ascending.Name = "btn_ascending";
            this.btn_ascending.Size = new System.Drawing.Size(133, 54);
            this.btn_ascending.TabIndex = 6;
            this.btn_ascending.Text = "A -> Z";
            this.btn_ascending.UseVisualStyleBackColor = true;
            this.btn_ascending.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_descending
            // 
            this.btn_descending.Location = new System.Drawing.Point(371, 349);
            this.btn_descending.Name = "btn_descending";
            this.btn_descending.Size = new System.Drawing.Size(133, 54);
            this.btn_descending.TabIndex = 7;
            this.btn_descending.Text = "Z -> A";
            this.btn_descending.UseVisualStyleBackColor = true;
            this.btn_descending.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_clearlist
            // 
            this.btn_clearlist.Location = new System.Drawing.Point(580, 349);
            this.btn_clearlist.Name = "btn_clearlist";
            this.btn_clearlist.Size = new System.Drawing.Size(121, 54);
            this.btn_clearlist.TabIndex = 8;
            this.btn_clearlist.Text = "Clear";
            this.btn_clearlist.UseVisualStyleBackColor = true;
            this.btn_clearlist.Click += new System.EventHandler(this.btn_clearlist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clearlist);
            this.Controls.Add(this.btn_descending);
            this.Controls.Add(this.btn_ascending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_newFriends);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_newFriends;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ascending;
        private System.Windows.Forms.Button btn_descending;
        private System.Windows.Forms.Button btn_clearlist;
    }
}

