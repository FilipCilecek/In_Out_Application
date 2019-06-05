namespace In_Out_system
{
    partial class Form_changeINOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_changeINOUT));
            this.inOutDB = new In_Out_system.InOutDB();
            this.inOutDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_INOUT = new System.Windows.Forms.DataGridView();
            this.combo_changeINOUT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inOutDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_INOUT)).BeginInit();
            this.SuspendLayout();
            // 
            // inOutDB
            // 
            this.inOutDB.DataSetName = "InOutDB";
            this.inOutDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inOutDBBindingSource
            // 
            this.inOutDBBindingSource.DataSource = this.inOutDB;
            this.inOutDBBindingSource.Position = 0;
            // 
            // dataGrid_INOUT
            // 
            this.dataGrid_INOUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_INOUT.Location = new System.Drawing.Point(12, 39);
            this.dataGrid_INOUT.Name = "dataGrid_INOUT";
            this.dataGrid_INOUT.Size = new System.Drawing.Size(312, 286);
            this.dataGrid_INOUT.TabIndex = 0;
            this.dataGrid_INOUT.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGrid_INOUT_CellBeginEdit);
            this.dataGrid_INOUT.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_INOUT_CellEndEdit);
            // 
            // combo_changeINOUT
            // 
            this.combo_changeINOUT.FormattingEnabled = true;
            this.combo_changeINOUT.Location = new System.Drawing.Point(116, 9);
            this.combo_changeINOUT.Name = "combo_changeINOUT";
            this.combo_changeINOUT.Size = new System.Drawing.Size(143, 21);
            this.combo_changeINOUT.TabIndex = 5;
            this.combo_changeINOUT.SelectedIndexChanged += new System.EventHandler(this.combo_changeINOUT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vyber člena";
            // 
            // Form_changeINOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_changeINOUT);
            this.Controls.Add(this.dataGrid_INOUT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_changeINOUT";
            this.Text = "Admin - Změna času IN/OUT";
            this.Load += new System.EventHandler(this.Form_changeINOUT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inOutDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inOutDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_INOUT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InOutDB inOutDB;
        private System.Windows.Forms.BindingSource inOutDBBindingSource;
        private System.Windows.Forms.DataGridView dataGrid_INOUT;
        private System.Windows.Forms.ComboBox combo_changeINOUT;
        private System.Windows.Forms.Label label1;
    }
}