namespace TeamSourceControl_AgeofEmpires
{
    partial class frmArmies
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
            this.cbArmies = new System.Windows.Forms.ComboBox();
            this.allArmies = new System.Windows.Forms.Label();
            this.btnEditArmy = new System.Windows.Forms.Button();
            this.btnAddArmy = new System.Windows.Forms.Button();
            this.btnDeleteArmy = new System.Windows.Forms.Button();
            this.addArmyName = new System.Windows.Forms.Label();
            this.txtAddArmy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbArmies
            // 
            this.cbArmies.FormattingEnabled = true;
            this.cbArmies.Location = new System.Drawing.Point(147, 163);
            this.cbArmies.Name = "cbArmies";
            this.cbArmies.Size = new System.Drawing.Size(121, 21);
            this.cbArmies.TabIndex = 4;
            // 
            // allArmies
            // 
            this.allArmies.AutoSize = true;
            this.allArmies.Location = new System.Drawing.Point(67, 166);
            this.allArmies.Name = "allArmies";
            this.allArmies.Size = new System.Drawing.Size(66, 13);
            this.allArmies.TabIndex = 3;
            this.allArmies.Text = "Select Army:";
            // 
            // btnEditArmy
            // 
            this.btnEditArmy.Location = new System.Drawing.Point(112, 206);
            this.btnEditArmy.Name = "btnEditArmy";
            this.btnEditArmy.Size = new System.Drawing.Size(111, 32);
            this.btnEditArmy.TabIndex = 5;
            this.btnEditArmy.Text = "Edit Army";
            this.btnEditArmy.UseVisualStyleBackColor = true;
            // 
            // btnAddArmy
            // 
            this.btnAddArmy.Location = new System.Drawing.Point(112, 63);
            this.btnAddArmy.Name = "btnAddArmy";
            this.btnAddArmy.Size = new System.Drawing.Size(111, 32);
            this.btnAddArmy.TabIndex = 2;
            this.btnAddArmy.Text = "Add Army";
            this.btnAddArmy.UseVisualStyleBackColor = true;
            this.btnAddArmy.Click += new System.EventHandler(this.BtnAddArmy_Click);
            // 
            // btnDeleteArmy
            // 
            this.btnDeleteArmy.Location = new System.Drawing.Point(112, 259);
            this.btnDeleteArmy.Name = "btnDeleteArmy";
            this.btnDeleteArmy.Size = new System.Drawing.Size(111, 32);
            this.btnDeleteArmy.TabIndex = 6;
            this.btnDeleteArmy.Text = "Delete Army";
            this.btnDeleteArmy.UseVisualStyleBackColor = true;
            // 
            // addArmyName
            // 
            this.addArmyName.AutoSize = true;
            this.addArmyName.Location = new System.Drawing.Point(67, 27);
            this.addArmyName.Name = "addArmyName";
            this.addArmyName.Size = new System.Drawing.Size(67, 13);
            this.addArmyName.TabIndex = 0;
            this.addArmyName.Text = "Army Name: ";
            // 
            // txtAddArmy
            // 
            this.txtAddArmy.Location = new System.Drawing.Point(147, 24);
            this.txtAddArmy.Name = "txtAddArmy";
            this.txtAddArmy.Size = new System.Drawing.Size(121, 20);
            this.txtAddArmy.TabIndex = 1;
            // 
            // frmArmies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 340);
            this.Controls.Add(this.txtAddArmy);
            this.Controls.Add(this.addArmyName);
            this.Controls.Add(this.btnDeleteArmy);
            this.Controls.Add(this.btnAddArmy);
            this.Controls.Add(this.btnEditArmy);
            this.Controls.Add(this.allArmies);
            this.Controls.Add(this.cbArmies);
            this.Name = "frmArmies";
            this.Text = "Armies";
            this.Load += new System.EventHandler(this.FrmArmies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArmies;
        private System.Windows.Forms.Label allArmies;
        private System.Windows.Forms.Button btnEditArmy;
        private System.Windows.Forms.Button btnAddArmy;
        private System.Windows.Forms.Button btnDeleteArmy;
        private System.Windows.Forms.Label addArmyName;
        private System.Windows.Forms.TextBox txtAddArmy;
    }
}

