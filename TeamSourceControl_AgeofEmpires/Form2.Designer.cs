namespace TeamSourceControl_AgeofEmpires
{
    partial class frmEditArmy
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
            this.lblArmyName = new System.Windows.Forms.Label();
            this.txtArmyName = new System.Windows.Forms.TextBox();
            this.lblArmyOwner = new System.Windows.Forms.Label();
            this.txtArmyOwner = new System.Windows.Forms.TextBox();
            this.lblCurrArmySoldiers = new System.Windows.Forms.Label();
            this.lstBoxCurrSoldiers = new System.Windows.Forms.ListBox();
            this.btnAddSoldier = new System.Windows.Forms.Button();
            this.btnDeleteSoldier = new System.Windows.Forms.Button();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.cbSoldiers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblArmyName
            // 
            this.lblArmyName.AutoSize = true;
            this.lblArmyName.Location = new System.Drawing.Point(29, 26);
            this.lblArmyName.Name = "lblArmyName";
            this.lblArmyName.Size = new System.Drawing.Size(64, 13);
            this.lblArmyName.TabIndex = 0;
            this.lblArmyName.Text = "Army Name:";
            // 
            // txtArmyName
            // 
            this.txtArmyName.Location = new System.Drawing.Point(114, 23);
            this.txtArmyName.Name = "txtArmyName";
            this.txtArmyName.Size = new System.Drawing.Size(100, 20);
            this.txtArmyName.TabIndex = 1;
            // 
            // lblArmyOwner
            // 
            this.lblArmyOwner.AutoSize = true;
            this.lblArmyOwner.Location = new System.Drawing.Point(29, 58);
            this.lblArmyOwner.Name = "lblArmyOwner";
            this.lblArmyOwner.Size = new System.Drawing.Size(67, 13);
            this.lblArmyOwner.TabIndex = 2;
            this.lblArmyOwner.Text = "Army Owner:";
            // 
            // txtArmyOwner
            // 
            this.txtArmyOwner.Location = new System.Drawing.Point(114, 55);
            this.txtArmyOwner.Name = "txtArmyOwner";
            this.txtArmyOwner.Size = new System.Drawing.Size(100, 20);
            this.txtArmyOwner.TabIndex = 3;
            // 
            // lblCurrArmySoldiers
            // 
            this.lblCurrArmySoldiers.AutoSize = true;
            this.lblCurrArmySoldiers.Location = new System.Drawing.Point(29, 90);
            this.lblCurrArmySoldiers.Name = "lblCurrArmySoldiers";
            this.lblCurrArmySoldiers.Size = new System.Drawing.Size(69, 13);
            this.lblCurrArmySoldiers.TabIndex = 4;
            this.lblCurrArmySoldiers.Text = "Your Soldiers";
            // 
            // lstBoxCurrSoldiers
            // 
            this.lstBoxCurrSoldiers.FormattingEnabled = true;
            this.lstBoxCurrSoldiers.Location = new System.Drawing.Point(114, 90);
            this.lstBoxCurrSoldiers.Name = "lstBoxCurrSoldiers";
            this.lstBoxCurrSoldiers.Size = new System.Drawing.Size(120, 95);
            this.lstBoxCurrSoldiers.TabIndex = 5;
            // 
            // btnAddSoldier
            // 
            this.btnAddSoldier.Location = new System.Drawing.Point(278, 119);
            this.btnAddSoldier.Name = "btnAddSoldier";
            this.btnAddSoldier.Size = new System.Drawing.Size(99, 26);
            this.btnAddSoldier.TabIndex = 6;
            this.btnAddSoldier.Text = "Add Soldier";
            this.btnAddSoldier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSoldier
            // 
            this.btnDeleteSoldier.Location = new System.Drawing.Point(278, 162);
            this.btnDeleteSoldier.Name = "btnDeleteSoldier";
            this.btnDeleteSoldier.Size = new System.Drawing.Size(99, 26);
            this.btnDeleteSoldier.TabIndex = 8;
            this.btnDeleteSoldier.Text = "Delete Soldier";
            this.btnDeleteSoldier.UseVisualStyleBackColor = true;
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Location = new System.Drawing.Point(129, 205);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(85, 29);
            this.btnConfirmEdit.TabIndex = 9;
            this.btnConfirmEdit.Text = "Update Army";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // cbSoldiers
            // 
            this.cbSoldiers.FormattingEnabled = true;
            this.cbSoldiers.Location = new System.Drawing.Point(266, 90);
            this.cbSoldiers.Name = "cbSoldiers";
            this.cbSoldiers.Size = new System.Drawing.Size(121, 21);
            this.cbSoldiers.TabIndex = 10;
            // 
            // frmEditArmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 284);
            this.Controls.Add(this.cbSoldiers);
            this.Controls.Add(this.btnConfirmEdit);
            this.Controls.Add(this.btnDeleteSoldier);
            this.Controls.Add(this.btnAddSoldier);
            this.Controls.Add(this.lstBoxCurrSoldiers);
            this.Controls.Add(this.lblCurrArmySoldiers);
            this.Controls.Add(this.txtArmyOwner);
            this.Controls.Add(this.lblArmyOwner);
            this.Controls.Add(this.txtArmyName);
            this.Controls.Add(this.lblArmyName);
            this.Name = "frmEditArmy";
            this.Text = "Edit Army";
            this.Load += new System.EventHandler(this.frmEditArmy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArmyName;
        private System.Windows.Forms.TextBox txtArmyName;
        private System.Windows.Forms.Label lblArmyOwner;
        private System.Windows.Forms.TextBox txtArmyOwner;
        private System.Windows.Forms.Label lblCurrArmySoldiers;
        private System.Windows.Forms.ListBox lstBoxCurrSoldiers;
        private System.Windows.Forms.Button btnAddSoldier;
        private System.Windows.Forms.Button btnDeleteSoldier;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.ComboBox cbSoldiers;
    }
}