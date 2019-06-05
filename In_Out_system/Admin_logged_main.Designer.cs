namespace In_Out_system
{
    partial class Admin_logged_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_logged_main));
            this.btn_addPerson = new System.Windows.Forms.Button();
            this.txtBox_createID = new System.Windows.Forms.TextBox();
            this.txtBox_createPassword = new System.Windows.Forms.TextBox();
            this.combo_hodnost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_createPerson = new System.Windows.Forms.GroupBox();
            this.groupBox_Rank = new System.Windows.Forms.GroupBox();
            this.combo_deleteRank = new System.Windows.Forms.ComboBox();
            this.txtBox_addRank = new System.Windows.Forms.TextBox();
            this.btn_deleteRank = new System.Windows.Forms.Button();
            this.btn_addRank = new System.Windows.Forms.Button();
            this.btn_showPersons = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_deletePerson = new System.Windows.Forms.Button();
            this.combo_deletePerson = new System.Windows.Forms.ComboBox();
            this.btn_form_exit = new System.Windows.Forms.Button();
            this.btn_changeinout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_newPassword = new System.Windows.Forms.TextBox();
            this.btn_changePassword = new System.Windows.Forms.Button();
            this.combo_changePassword = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_createPerson.SuspendLayout();
            this.groupBox_Rank.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addPerson
            // 
            this.btn_addPerson.Location = new System.Drawing.Point(91, 98);
            this.btn_addPerson.Name = "btn_addPerson";
            this.btn_addPerson.Size = new System.Drawing.Size(121, 30);
            this.btn_addPerson.TabIndex = 0;
            this.btn_addPerson.Text = "Přidat člena";
            this.btn_addPerson.UseVisualStyleBackColor = true;
            this.btn_addPerson.Click += new System.EventHandler(this.btn_addPerson_Click);
            // 
            // txtBox_createID
            // 
            this.txtBox_createID.Location = new System.Drawing.Point(91, 19);
            this.txtBox_createID.Name = "txtBox_createID";
            this.txtBox_createID.Size = new System.Drawing.Size(121, 20);
            this.txtBox_createID.TabIndex = 1;
            // 
            // txtBox_createPassword
            // 
            this.txtBox_createPassword.Location = new System.Drawing.Point(91, 45);
            this.txtBox_createPassword.Name = "txtBox_createPassword";
            this.txtBox_createPassword.Size = new System.Drawing.Size(121, 20);
            this.txtBox_createPassword.TabIndex = 2;
            // 
            // combo_hodnost
            // 
            this.combo_hodnost.FormattingEnabled = true;
            this.combo_hodnost.Location = new System.Drawing.Point(91, 71);
            this.combo_hodnost.Name = "combo_hodnost";
            this.combo_hodnost.Size = new System.Drawing.Size(121, 21);
            this.combo_hodnost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Přihlášení";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Heslo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hodnost";
            // 
            // groupBox_createPerson
            // 
            this.groupBox_createPerson.Controls.Add(this.txtBox_createID);
            this.groupBox_createPerson.Controls.Add(this.label3);
            this.groupBox_createPerson.Controls.Add(this.btn_addPerson);
            this.groupBox_createPerson.Controls.Add(this.label2);
            this.groupBox_createPerson.Controls.Add(this.txtBox_createPassword);
            this.groupBox_createPerson.Controls.Add(this.label1);
            this.groupBox_createPerson.Controls.Add(this.combo_hodnost);
            this.groupBox_createPerson.Location = new System.Drawing.Point(12, 12);
            this.groupBox_createPerson.Name = "groupBox_createPerson";
            this.groupBox_createPerson.Size = new System.Drawing.Size(224, 139);
            this.groupBox_createPerson.TabIndex = 7;
            this.groupBox_createPerson.TabStop = false;
            this.groupBox_createPerson.Text = "Vytvoření nového člena";
            // 
            // groupBox_Rank
            // 
            this.groupBox_Rank.Controls.Add(this.combo_deleteRank);
            this.groupBox_Rank.Controls.Add(this.txtBox_addRank);
            this.groupBox_Rank.Controls.Add(this.btn_deleteRank);
            this.groupBox_Rank.Controls.Add(this.btn_addRank);
            this.groupBox_Rank.Location = new System.Drawing.Point(243, 12);
            this.groupBox_Rank.Name = "groupBox_Rank";
            this.groupBox_Rank.Size = new System.Drawing.Size(268, 87);
            this.groupBox_Rank.TabIndex = 8;
            this.groupBox_Rank.TabStop = false;
            this.groupBox_Rank.Text = "Práce s hodnostmi";
            // 
            // combo_deleteRank
            // 
            this.combo_deleteRank.FormattingEnabled = true;
            this.combo_deleteRank.Location = new System.Drawing.Point(13, 50);
            this.combo_deleteRank.Name = "combo_deleteRank";
            this.combo_deleteRank.Size = new System.Drawing.Size(117, 21);
            this.combo_deleteRank.TabIndex = 4;
            // 
            // txtBox_addRank
            // 
            this.txtBox_addRank.Location = new System.Drawing.Point(13, 21);
            this.txtBox_addRank.Name = "txtBox_addRank";
            this.txtBox_addRank.Size = new System.Drawing.Size(117, 20);
            this.txtBox_addRank.TabIndex = 2;
            // 
            // btn_deleteRank
            // 
            this.btn_deleteRank.Location = new System.Drawing.Point(136, 48);
            this.btn_deleteRank.Name = "btn_deleteRank";
            this.btn_deleteRank.Size = new System.Drawing.Size(119, 23);
            this.btn_deleteRank.TabIndex = 1;
            this.btn_deleteRank.Text = "Smazat hodnost";
            this.btn_deleteRank.UseVisualStyleBackColor = true;
            this.btn_deleteRank.Click += new System.EventHandler(this.btn_deleteRank_Click);
            // 
            // btn_addRank
            // 
            this.btn_addRank.Location = new System.Drawing.Point(136, 19);
            this.btn_addRank.Name = "btn_addRank";
            this.btn_addRank.Size = new System.Drawing.Size(119, 23);
            this.btn_addRank.TabIndex = 0;
            this.btn_addRank.Text = "Přidat hodnost";
            this.btn_addRank.UseVisualStyleBackColor = true;
            this.btn_addRank.Click += new System.EventHandler(this.btn_addRank_Click);
            // 
            // btn_showPersons
            // 
            this.btn_showPersons.Location = new System.Drawing.Point(133, 249);
            this.btn_showPersons.Name = "btn_showPersons";
            this.btn_showPersons.Size = new System.Drawing.Size(115, 30);
            this.btn_showPersons.TabIndex = 9;
            this.btn_showPersons.Text = "Výpis členů";
            this.btn_showPersons.UseVisualStyleBackColor = true;
            this.btn_showPersons.Click += new System.EventHandler(this.btn_showPersons_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_deletePerson);
            this.groupBox1.Controls.Add(this.combo_deletePerson);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smazání člena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jméno člena";
            // 
            // btn_deletePerson
            // 
            this.btn_deletePerson.Location = new System.Drawing.Point(91, 46);
            this.btn_deletePerson.Name = "btn_deletePerson";
            this.btn_deletePerson.Size = new System.Drawing.Size(121, 30);
            this.btn_deletePerson.TabIndex = 5;
            this.btn_deletePerson.Text = "Smazat člena";
            this.btn_deletePerson.UseVisualStyleBackColor = true;
            this.btn_deletePerson.Click += new System.EventHandler(this.btn_deletePerson_Click);
            // 
            // combo_deletePerson
            // 
            this.combo_deletePerson.FormattingEnabled = true;
            this.combo_deletePerson.Location = new System.Drawing.Point(91, 19);
            this.combo_deletePerson.Name = "combo_deletePerson";
            this.combo_deletePerson.Size = new System.Drawing.Size(121, 21);
            this.combo_deletePerson.TabIndex = 4;
            // 
            // btn_form_exit
            // 
            this.btn_form_exit.Location = new System.Drawing.Point(383, 249);
            this.btn_form_exit.Name = "btn_form_exit";
            this.btn_form_exit.Size = new System.Drawing.Size(115, 30);
            this.btn_form_exit.TabIndex = 13;
            this.btn_form_exit.Text = "Odhlásit se";
            this.btn_form_exit.UseVisualStyleBackColor = true;
            this.btn_form_exit.Click += new System.EventHandler(this.btn_form_exit_Click);
            // 
            // btn_changeinout
            // 
            this.btn_changeinout.Location = new System.Drawing.Point(12, 249);
            this.btn_changeinout.Name = "btn_changeinout";
            this.btn_changeinout.Size = new System.Drawing.Size(115, 30);
            this.btn_changeinout.TabIndex = 1;
            this.btn_changeinout.Text = "Změnit IN/OUT čas";
            this.btn_changeinout.UseVisualStyleBackColor = true;
            this.btn_changeinout.Click += new System.EventHandler(this.btn_changeinout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.combo_changePassword);
            this.groupBox2.Controls.Add(this.txtBox_newPassword);
            this.groupBox2.Controls.Add(this.btn_changePassword);
            this.groupBox2.Location = new System.Drawing.Point(243, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Změna hesel";
            // 
            // txtBox_newPassword
            // 
            this.txtBox_newPassword.Location = new System.Drawing.Point(13, 52);
            this.txtBox_newPassword.Name = "txtBox_newPassword";
            this.txtBox_newPassword.Size = new System.Drawing.Size(117, 20);
            this.txtBox_newPassword.TabIndex = 2;
            // 
            // btn_changePassword
            // 
            this.btn_changePassword.Location = new System.Drawing.Point(136, 85);
            this.btn_changePassword.Name = "btn_changePassword";
            this.btn_changePassword.Size = new System.Drawing.Size(119, 23);
            this.btn_changePassword.TabIndex = 0;
            this.btn_changePassword.Text = "Změnit heslo";
            this.btn_changePassword.UseVisualStyleBackColor = true;
            this.btn_changePassword.Click += new System.EventHandler(this.btn_changePassword_Click);
            // 
            // combo_changePassword
            // 
            this.combo_changePassword.FormattingEnabled = true;
            this.combo_changePassword.Location = new System.Drawing.Point(13, 21);
            this.combo_changePassword.Name = "combo_changePassword";
            this.combo_changePassword.Size = new System.Drawing.Size(117, 21);
            this.combo_changePassword.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jméno člena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nové heslo";
            // 
            // Admin_logged_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_changeinout);
            this.Controls.Add(this.btn_form_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_showPersons);
            this.Controls.Add(this.groupBox_Rank);
            this.Controls.Add(this.groupBox_createPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_logged_main";
            this.Text = "In Out - Admin";
            this.Load += new System.EventHandler(this.Admin_logged_main_Load);
            this.groupBox_createPerson.ResumeLayout(false);
            this.groupBox_createPerson.PerformLayout();
            this.groupBox_Rank.ResumeLayout(false);
            this.groupBox_Rank.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addPerson;
        private System.Windows.Forms.TextBox txtBox_createID;
        private System.Windows.Forms.TextBox txtBox_createPassword;
        private System.Windows.Forms.ComboBox combo_hodnost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_createPerson;
        private System.Windows.Forms.GroupBox groupBox_Rank;
        private System.Windows.Forms.ComboBox combo_deleteRank;
        private System.Windows.Forms.TextBox txtBox_addRank;
        private System.Windows.Forms.Button btn_deleteRank;
        private System.Windows.Forms.Button btn_addRank;
        private System.Windows.Forms.Button btn_showPersons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_deletePerson;
        private System.Windows.Forms.ComboBox combo_deletePerson;
        private System.Windows.Forms.Button btn_form_exit;
        private System.Windows.Forms.Button btn_changeinout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_changePassword;
        private System.Windows.Forms.TextBox txtBox_newPassword;
        private System.Windows.Forms.Button btn_changePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}