namespace In_Out_system
{
    partial class Form_admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin_login));
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.btn_form_exit = new System.Windows.Forms.Button();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(113, 34);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '*';
            this.txtBox_password.Size = new System.Drawing.Size(133, 20);
            this.txtBox_password.TabIndex = 2;
            // 
            // btn_form_exit
            // 
            this.btn_form_exit.Location = new System.Drawing.Point(218, 60);
            this.btn_form_exit.Name = "btn_form_exit";
            this.btn_form_exit.Size = new System.Drawing.Size(28, 28);
            this.btn_form_exit.TabIndex = 4;
            this.btn_form_exit.Text = "X";
            this.btn_form_exit.UseVisualStyleBackColor = true;
            this.btn_form_exit.Click += new System.EventHandler(this.btn_form_exit_Click);
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Location = new System.Drawing.Point(32, 60);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(163, 28);
            this.btn_admin_login.TabIndex = 3;
            this.btn_admin_login.Text = "Přihlásit";
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Přihlašovací heslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Přihlašovací jméno";
            // 
            // txtBox_login
            // 
            this.txtBox_login.Location = new System.Drawing.Point(113, 8);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.Size = new System.Drawing.Size(133, 20);
            this.txtBox_login.TabIndex = 1;
            // 
            // Form_admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 98);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.btn_form_exit);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_admin_login";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.Form_admin_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Button btn_form_exit;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_login;
    }
}