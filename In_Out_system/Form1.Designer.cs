namespace In_Out_system
{
    partial class In_Out_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In_Out_form));
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_currenttime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_currentdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(12, 12);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(137, 49);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "Příchod";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(157, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(137, 49);
            this.btn_out.TabIndex = 1;
            this.btn_out.Text = "Odchod";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(107, 196);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(87, 29);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Čas   :";
            // 
            // lbl_currenttime
            // 
            this.lbl_currenttime.AutoSize = true;
            this.lbl_currenttime.Location = new System.Drawing.Point(137, 96);
            this.lbl_currenttime.Name = "lbl_currenttime";
            this.lbl_currenttime.Size = new System.Drawing.Size(68, 13);
            this.lbl_currenttime.TabIndex = 4;
            this.lbl_currenttime.Text = "- ukáže čas -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum :";
            // 
            // lbl_currentdate
            // 
            this.lbl_currentdate.AutoSize = true;
            this.lbl_currentdate.Location = new System.Drawing.Point(132, 78);
            this.lbl_currentdate.Name = "lbl_currentdate";
            this.lbl_currentdate.Size = new System.Drawing.Size(80, 13);
            this.lbl_currentdate.TabIndex = 6;
            this.lbl_currentdate.Text = "- ukáže datum -";
            // 
            // In_Out_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 235);
            this.Controls.Add(this.lbl_currentdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_currenttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "In_Out_form";
            this.Text = "In Out";
            this.Load += new System.EventHandler(this.In_Out_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_currenttime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_currentdate;
    }
}

