namespace In_Out_system
{
    partial class Form_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_in));
            this.txtBox_in_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_form_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_in_login
            // 
            this.txtBox_in_login.Location = new System.Drawing.Point(110, 12);
            this.txtBox_in_login.Name = "txtBox_in_login";
            this.txtBox_in_login.Size = new System.Drawing.Size(133, 20);
            this.txtBox_in_login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Přihlašovací jméno";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(26, 38);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(163, 28);
            this.btn_in.TabIndex = 4;
            this.btn_in.Text = "Příchod";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_form_exit
            // 
            this.btn_form_exit.Location = new System.Drawing.Point(215, 38);
            this.btn_form_exit.Name = "btn_form_exit";
            this.btn_form_exit.Size = new System.Drawing.Size(28, 28);
            this.btn_form_exit.TabIndex = 5;
            this.btn_form_exit.Text = "X";
            this.btn_form_exit.UseVisualStyleBackColor = true;
            this.btn_form_exit.Click += new System.EventHandler(this.btn_form_exit_Click);
            // 
            // Form_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 74);
            this.Controls.Add(this.btn_form_exit);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_in_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_in";
            this.Text = "Příchod";
            this.Load += new System.EventHandler(this.Form_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_in_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_form_exit;
    }
}