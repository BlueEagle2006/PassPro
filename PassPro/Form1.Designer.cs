
namespace PassPro
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
            this.btnURL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchURL = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.RichTextBox();
            this.textAddWeb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(704, 372);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(75, 23);
            this.btnURL.TabIndex = 0;
            this.btnURL.Text = "Search";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // txtAddURL
            // 
            this.txtAddURL.Location = new System.Drawing.Point(66, 126);
            this.txtAddURL.Name = "txtAddURL";
            this.txtAddURL.Size = new System.Drawing.Size(140, 23);
            this.txtAddURL.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // btnAddURL
            // 
            this.btnAddURL.Location = new System.Drawing.Point(89, 208);
            this.btnAddURL.Name = "btnAddURL";
            this.btnAddURL.Size = new System.Drawing.Size(75, 23);
            this.btnAddURL.TabIndex = 8;
            this.btnAddURL.Text = "Add";
            this.btnAddURL.UseVisualStyleBackColor = true;
            this.btnAddURL.Click += new System.EventHandler(this.btnAddURL_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(66, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txtSearchURL
            // 
            this.txtSearchURL.Location = new System.Drawing.Point(267, 371);
            this.txtSearchURL.Name = "txtSearchURL";
            this.txtSearchURL.Size = new System.Drawing.Size(431, 23);
            this.txtSearchURL.TabIndex = 11;
            // 
            // listResult
            // 
            this.listResult.Location = new System.Drawing.Point(267, 12);
            this.listResult.Name = "listResult";
            this.listResult.ReadOnly = true;
            this.listResult.Size = new System.Drawing.Size(431, 305);
            this.listResult.TabIndex = 12;
            this.listResult.Text = "";
            // 
            // textAddWeb
            // 
            this.textAddWeb.Location = new System.Drawing.Point(66, 86);
            this.textAddWeb.Name = "textAddWeb";
            this.textAddWeb.Size = new System.Drawing.Size(140, 23);
            this.textAddWeb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAddWeb);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.txtSearchURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnURL);
            this.Name = "Form1";
            this.Text = "ProPass";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchURL;
        private System.Windows.Forms.RichTextBox listResult;
        private System.Windows.Forms.TextBox textAddWeb;
        private System.Windows.Forms.Label label4;
    }
}

