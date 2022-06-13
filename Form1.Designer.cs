
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.HallBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.NewBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingsBTN = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player";
            // 
            // PlayBTN
            // 
            this.PlayBTN.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBTN.Location = new System.Drawing.Point(90, 234);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(388, 57);
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
            this.ExitBTN.Location = new System.Drawing.Point(90, 384);
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
            this.NewBTN.Location = new System.Drawing.Point(415, 162);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BlackJackGame.Properties.Resources.name1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(26, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 120);
            this.panel1.TabIndex = 8;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(210, 189);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(199, 29);
            this.passwordTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBTN.Location = new System.Drawing.Point(90, 341);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(388, 37);
            this.SettingsBTN.TabIndex = 11;
            this.SettingsBTN.Text = "Settings";
            this.SettingsBTN.UseVisualStyleBackColor = true;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(210, 143);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '*';
            this.usernameTxt.Size = new System.Drawing.Size(199, 29);
            this.usernameTxt.TabIndex = 12;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackGame.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(564, 448);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.SettingsBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.HallBTN);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayBTN;
        private System.Windows.Forms.Button HallBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button NewBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SettingsBTN;
        private System.Windows.Forms.TextBox usernameTxt;
    }
}

