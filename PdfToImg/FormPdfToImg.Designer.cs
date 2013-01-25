namespace PdfToImg
{
    partial class FormPdfToImg
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.textBoxDst = new System.Windows.Forms.TextBox();
            this.buttonDst = new System.Windows.Forms.Button();
            this.buttonSrc = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelDst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(346, 23);
            this.progressBar.TabIndex = 0;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(75, 12);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(318, 20);
            this.textBoxSrc.TabIndex = 1;
            // 
            // textBoxDst
            // 
            this.textBoxDst.Location = new System.Drawing.Point(75, 50);
            this.textBoxDst.Name = "textBoxDst";
            this.textBoxDst.Size = new System.Drawing.Size(318, 20);
            this.textBoxDst.TabIndex = 2;
            // 
            // buttonDst
            // 
            this.buttonDst.Location = new System.Drawing.Point(399, 50);
            this.buttonDst.Name = "buttonDst";
            this.buttonDst.Size = new System.Drawing.Size(40, 23);
            this.buttonDst.TabIndex = 4;
            this.buttonDst.Text = "...";
            this.buttonDst.UseVisualStyleBackColor = true;
            this.buttonDst.Click += new System.EventHandler(this.buttonDst_Click);
            // 
            // buttonSrc
            // 
            this.buttonSrc.Location = new System.Drawing.Point(399, 12);
            this.buttonSrc.Name = "buttonSrc";
            this.buttonSrc.Size = new System.Drawing.Size(40, 23);
            this.buttonSrc.TabIndex = 5;
            this.buttonSrc.Text = "...";
            this.buttonSrc.UseVisualStyleBackColor = true;
            this.buttonSrc.Click += new System.EventHandler(this.buttonSrc_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(364, 96);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(9, 15);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 7;
            this.labelSource.Text = "Source";
            this.labelSource.Click += new System.EventHandler(this.labelSource_Click);
            // 
            // labelDst
            // 
            this.labelDst.AutoSize = true;
            this.labelDst.Location = new System.Drawing.Point(9, 55);
            this.labelDst.Name = "labelDst";
            this.labelDst.Size = new System.Drawing.Size(60, 13);
            this.labelDst.TabIndex = 8;
            this.labelDst.Text = "Destination";
            // 
            // FormPdfToImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 144);
            this.Controls.Add(this.labelDst);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSrc);
            this.Controls.Add(this.buttonDst);
            this.Controls.Add(this.textBoxDst);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.progressBar);
            this.Name = "FormPdfToImg";
            this.Text = "PdfToImg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.TextBox textBoxDst;
        private System.Windows.Forms.Button buttonDst;
        private System.Windows.Forms.Button buttonSrc;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelDst;
    }
}

