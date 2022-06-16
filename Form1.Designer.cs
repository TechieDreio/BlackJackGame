
namespace BlackJackGame
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.unameLabel = new System.Windows.Forms.Label();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.HallBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.NewBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.blackjackLogoPanel = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.pwordLabel = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.BackColor = System.Drawing.Color.Transparent;
            this.unameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameLabel.ForeColor = System.Drawing.Color.White;
            this.unameLabel.Location = new System.Drawing.Point(85, 145);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(118, 25);
            this.unameLabel.TabIndex = 1;
            this.unameLabel.Text = "Username";
            // 
            // PlayBTN
            // 
            this.PlayBTN.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBTN.Location = new System.Drawing.Point(90, 228);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(388, 63);
            this.PlayBTN.TabIndex = 3;
            this.PlayBTN.Text = "PLAY";
            this.PlayBTN.UseVisualStyleBackColor = true;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // HallBTN
            // 
            this.HallBTN.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HallBTN.Location = new System.Drawing.Point(90, 298);
            this.HallBTN.Name = "HallBTN";
            this.HallBTN.Size = new System.Drawing.Size(388, 37);
            this.HallBTN.TabIndex = 4;
            this.HallBTN.Text = "HALL OF FAME";
            this.HallBTN.UseVisualStyleBackColor = true;
            this.HallBTN.Click += new System.EventHandler(this.HallBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(90, 341);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(388, 37);
            this.ExitBTN.TabIndex = 5;
            this.ExitBTN.Text = "EXIT";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // NewBTN
            // 
            this.NewBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBTN.Location = new System.Drawing.Point(415, 141);
            this.NewBTN.Name = "NewBTN";
            this.NewBTN.Size = new System.Drawing.Size(63, 32);
            this.NewBTN.TabIndex = 6;
            this.NewBTN.Text = "New";
            this.NewBTN.UseVisualStyleBackColor = true;
            this.NewBTN.Click += new System.EventHandler(this.NewBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // blackjackLogoPanel
            // 
            this.blackjackLogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.blackjackLogoPanel.BackgroundImage = global::BlackJackGame.Properties.Resources.name1;
            this.blackjackLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.blackjackLogoPanel.Location = new System.Drawing.Point(26, 9);
            this.blackjackLogoPanel.Name = "blackjackLogoPanel";
            this.blackjackLogoPanel.Size = new System.Drawing.Size(510, 120);
            this.blackjackLogoPanel.TabIndex = 8;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(210, 180);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(199, 29);
            this.passwordTxt.TabIndex = 9;
            // 
            // pwordLabel
            // 
            this.pwordLabel.AutoSize = true;
            this.pwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordLabel.ForeColor = System.Drawing.Color.White;
            this.pwordLabel.Location = new System.Drawing.Point(85, 182);
            this.pwordLabel.Name = "pwordLabel";
            this.pwordLabel.Size = new System.Drawing.Size(114, 25);
            this.pwordLabel.TabIndex = 10;
            this.pwordLabel.Text = "Password";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(210, 143);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(199, 29);
            this.usernameTxt.TabIndex = 12;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGame.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(564, 448);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.pwordLabel);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.blackjackLogoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.HallBTN);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.unameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Jack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Button PlayBTN;
        private System.Windows.Forms.Button HallBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel blackjackLogoPanel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label pwordLabel;
        private System.Windows.Forms.TextBox usernameTxt;
    }
}

