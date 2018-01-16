namespace Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.word = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // word
            // 
            resources.ApplyResources(this.word, "word");
            this.word.Name = "word";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // sign
            // 
            resources.ApplyResources(this.sign, "sign");
            this.sign.Name = "sign";
            this.sign.ReadOnly = true;
            // 
            // search
            // 
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // labeltitulo
            // 
            resources.ApplyResources(this.labeltitulo, "labeltitulo");
            this.labeltitulo.Name = "labeltitulo";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.word);
            this.Name = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sign;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label labeltitulo;
    }
}

