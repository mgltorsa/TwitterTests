using System.Collections.Generic;
using TweetSharp;

namespace TwitterCase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogin = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTweet = new System.Windows.Forms.TextBox();
            this.lbCharacters = new System.Windows.Forms.Label();
            this.tbKeyWordk = new System.Windows.Forms.TextBox();
            this.btKeyWord = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(404, 26);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(54, 28);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Tag = "User";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(240, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Tag = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbTweet
            // 
            this.tbTweet.Location = new System.Drawing.Point(54, 132);
            this.tbTweet.Multiline = true;
            this.tbTweet.Name = "tbTweet";
            this.tbTweet.Size = new System.Drawing.Size(425, 129);
            this.tbTweet.TabIndex = 1;
            this.tbTweet.Tag = "User";
            // 
            // lbCharacters
            // 
            this.lbCharacters.AutoSize = true;
            this.lbCharacters.Location = new System.Drawing.Point(394, 116);
            this.lbCharacters.Name = "lbCharacters";
            this.lbCharacters.Size = new System.Drawing.Size(85, 13);
            this.lbCharacters.TabIndex = 3;
            this.lbCharacters.Text = "Caracteres : 140";
            // 
            // tbKeyWordk
            // 
            this.tbKeyWordk.Location = new System.Drawing.Point(54, 77);
            this.tbKeyWordk.Name = "tbKeyWordk";
            this.tbKeyWordk.Size = new System.Drawing.Size(130, 20);
            this.tbKeyWordk.TabIndex = 1;
            this.tbKeyWordk.Tag = "User";
            // 
            // btKeyWord
            // 
            this.btKeyWord.Location = new System.Drawing.Point(215, 77);
            this.btKeyWord.Name = "btKeyWord";
            this.btKeyWord.Size = new System.Drawing.Size(151, 23);
            this.btKeyWord.TabIndex = 4;
            this.btKeyWord.Text = "Buscar por palabra clave";
            this.btKeyWord.UseVisualStyleBackColor = true;
            this.btKeyWord.Click += new System.EventHandler(this.BtKeyWord_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(291, 267);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "-->";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(154, 268);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 6;
            this.btBack.Text = "<--";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 340);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btKeyWord);
            this.Controls.Add(this.lbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbTweet);
            this.Controls.Add(this.tbKeyWordk);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTweet;
        private System.Windows.Forms.Label lbCharacters;
        private System.Windows.Forms.TextBox tbKeyWordk;
        private System.Windows.Forms.Button btKeyWord;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private string consumerKey;
        private string consumerSecret;
        private string tokenAccess;
        private string tokenSecret;
        private int tweetCount;
        private IEnumerable<TwitterStatus> tweetEnum;
        private List<TwitterStatus> resultSearch;
        private int index;
        private const string KEYS_PATH = "..//..//Resources//Keys.txt";
    }
}

