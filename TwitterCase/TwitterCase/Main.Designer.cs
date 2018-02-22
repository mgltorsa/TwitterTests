using System.Collections.Generic;
using System.Windows.Forms;
using Tweetinvi.Models;

namespace TwitterCase
{
    partial class Main
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
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbTweet = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.lbKeyword = new System.Windows.Forms.Label();
            this.lbCharacterCount = new System.Windows.Forms.Label();
            this.lbLoadTweets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(177, 42);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Buscar";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(32, 42);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // tbTweet
            // 
            this.tbTweet.Location = new System.Drawing.Point(34, 118);
            this.tbTweet.Multiline = true;
            this.tbTweet.Name = "tbTweet";
            this.tbTweet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTweet.Size = new System.Drawing.Size(220, 102);
            this.tbTweet.TabIndex = 2;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(59, 226);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "<--";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(140, 226);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "-->";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.BtNext_Click);
            // 
            // lbKeyword
            // 
            this.lbKeyword.AutoSize = true;
            this.lbKeyword.Location = new System.Drawing.Point(44, 26);
            this.lbKeyword.Name = "lbKeyword";
            this.lbKeyword.Size = new System.Drawing.Size(72, 13);
            this.lbKeyword.TabIndex = 5;
            this.lbKeyword.Text = "Palabra clave";
            // 
            // lbCharacterCount
            // 
            this.lbCharacterCount.AutoSize = true;
            this.lbCharacterCount.Location = new System.Drawing.Point(182, 102);
            this.lbCharacterCount.Name = "lbCharacterCount";
            this.lbCharacterCount.Size = new System.Drawing.Size(70, 13);
            this.lbCharacterCount.TabIndex = 6;
            this.lbCharacterCount.Text = "Caracteres: 0";
            // 
            // lbLoadTweets
            // 
            this.lbLoadTweets.AutoSize = true;
            this.lbLoadTweets.Location = new System.Drawing.Point(34, 101);
            this.lbLoadTweets.Name = "lbLoadTweets";
            this.lbLoadTweets.Size = new System.Drawing.Size(0, 13);
            this.lbLoadTweets.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbLoadTweets);
            this.Controls.Add(this.lbCharacterCount);
            this.Controls.Add(this.lbKeyword);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.tbTweet);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btSearch);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private const string KEY_PATH = "..//..//Resources/Keys.ser";
        private System.Windows.Forms.TextBox tbTweet;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        public ToolTip tooltip;
        private Label lbKeyword;
        private IEnumerable<ITweetWithSearchMetadata> currentTweets;
        private int index;
        private Label lbCharacterCount;
        private Label lbLoadTweets;
    }
}