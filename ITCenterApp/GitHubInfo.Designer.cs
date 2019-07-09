namespace ITCenterApp
{
    partial class GitHubInfo
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
            this.lbl_repo_username = new System.Windows.Forms.Label();
            this.lbl_creationDate = new System.Windows.Forms.Label();
            this.lbl_repositoryRating = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_creationDate = new System.Windows.Forms.TextBox();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_repo_username
            // 
            this.lbl_repo_username.AutoSize = true;
            this.lbl_repo_username.Location = new System.Drawing.Point(116, 69);
            this.lbl_repo_username.Name = "lbl_repo_username";
            this.lbl_repo_username.Size = new System.Drawing.Size(81, 17);
            this.lbl_repo_username.TabIndex = 0;
            this.lbl_repo_username.Text = "User name:";
            // 
            // lbl_creationDate
            // 
            this.lbl_creationDate.AutoSize = true;
            this.lbl_creationDate.Location = new System.Drawing.Point(100, 97);
            this.lbl_creationDate.Name = "lbl_creationDate";
            this.lbl_creationDate.Size = new System.Drawing.Size(97, 17);
            this.lbl_creationDate.TabIndex = 1;
            this.lbl_creationDate.Text = "Creation date:";
            // 
            // lbl_repositoryRating
            // 
            this.lbl_repositoryRating.AutoSize = true;
            this.lbl_repositoryRating.Location = new System.Drawing.Point(77, 125);
            this.lbl_repositoryRating.Name = "lbl_repositoryRating";
            this.lbl_repositoryRating.Size = new System.Drawing.Size(120, 17);
            this.lbl_repositoryRating.TabIndex = 2;
            this.lbl_repositoryRating.Text = "Repository rating:";
            // 
            // tb_username
            // 
            this.tb_username.Enabled = false;
            this.tb_username.Location = new System.Drawing.Point(203, 66);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(218, 22);
            this.tb_username.TabIndex = 3;
            // 
            // tb_creationDate
            // 
            this.tb_creationDate.Enabled = false;
            this.tb_creationDate.Location = new System.Drawing.Point(203, 94);
            this.tb_creationDate.Name = "tb_creationDate";
            this.tb_creationDate.ReadOnly = true;
            this.tb_creationDate.Size = new System.Drawing.Size(218, 22);
            this.tb_creationDate.TabIndex = 4;
            // 
            // tb_rating
            // 
            this.tb_rating.Enabled = false;
            this.tb_rating.Location = new System.Drawing.Point(203, 122);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.ReadOnly = true;
            this.tb_rating.Size = new System.Drawing.Size(218, 22);
            this.tb_rating.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(214, 170);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // GitHubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 226);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_rating);
            this.Controls.Add(this.tb_creationDate);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_repositoryRating);
            this.Controls.Add(this.lbl_creationDate);
            this.Controls.Add(this.lbl_repo_username);
            this.Name = "GitHubInfo";
            this.Text = "GitHubInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_repo_username;
        private System.Windows.Forms.Label lbl_creationDate;
        private System.Windows.Forms.Label lbl_repositoryRating;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_creationDate;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.Button btn_ok;
    }
}