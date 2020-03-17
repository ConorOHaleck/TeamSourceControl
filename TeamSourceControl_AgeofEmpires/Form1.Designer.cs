namespace TeamSourceControl_AgeofEmpires
{
    partial class frmEditArmies
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
            this.SuspendLayout();
            // 
            // cbArmies
            // 
            this.cbArmies.FormattingEnabled = true;
            this.cbArmies.Location = new System.Drawing.Point(147, 121);
            this.cbArmies.Name = "cbArmies";
            this.cbArmies.Size = new System.Drawing.Size(121, 21);
            this.cbArmies.TabIndex = 0;
            // 
            // allArmies
            // 
            this.allArmies.AutoSize = true;
            this.allArmies.Location = new System.Drawing.Point(64, 124);
            this.allArmies.Name = "allArmies";
            this.allArmies.Size = new System.Drawing.Size(66, 13);
            this.allArmies.TabIndex = 1;
            this.allArmies.Text = "Select Army:";
            // 
            // btnEditArmy
            // 
            this.btnEditArmy.Location = new System.Drawing.Point(112, 164);
            this.btnEditArmy.Name = "btnEditArmy";
            this.btnEditArmy.Size = new System.Drawing.Size(111, 32);
            this.btnEditArmy.TabIndex = 2;
            this.btnEditArmy.Text = "Edit Army";
            this.btnEditArmy.UseVisualStyleBackColor = true;
            // 
            // btnAddArmy
            // 
            this.btnAddArmy.Location = new System.Drawing.Point(112, 23);
            this.btnAddArmy.Name = "btnAddArmy";
            this.btnAddArmy.Size = new System.Drawing.Size(111, 32);
            this.btnAddArmy.TabIndex = 3;
            this.btnAddArmy.Text = "Add Army";
            this.btnAddArmy.UseVisualStyleBackColor = true;
            this.btnAddArmy.Click += new System.EventHandler(this.btnAddArmy_Click);
            // 
            // btnDeleteArmy
            // 
            this.btnDeleteArmy.Location = new System.Drawing.Point(112, 217);
            this.btnDeleteArmy.Name = "btnDeleteArmy";
            this.btnDeleteArmy.Size = new System.Drawing.Size(111, 32);
            this.btnDeleteArmy.TabIndex = 4;
            this.btnDeleteArmy.Text = "Delete Army";
            this.btnDeleteArmy.UseVisualStyleBackColor = true;
            // 
            // frmEditArmies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 296);
            this.Controls.Add(this.btnDeleteArmy);
            this.Controls.Add(this.btnAddArmy);
            this.Controls.Add(this.btnEditArmy);
            this.Controls.Add(this.allArmies);
            this.Controls.Add(this.cbArmies);
            this.Name = "frmEditArmies";
            this.Text = "Armies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbArmies;
        private System.Windows.Forms.Label allArmies;
        private System.Windows.Forms.Button btnEditArmy;
        private System.Windows.Forms.Button btnAddArmy;
        private System.Windows.Forms.Button btnDeleteArmy;
    }
}

