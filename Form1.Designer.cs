namespace Atbash
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBText = new System.Windows.Forms.TextBox();
            this.tBMessage = new System.Windows.Forms.TextBox();
            this.btnoperation = new System.Windows.Forms.Button();
            this.gBSource = new System.Windows.Forms.GroupBox();
            this.rBFile = new System.Windows.Forms.RadioButton();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.gBSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(13, 13);
            this.tBText.Multiline = true;
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(326, 284);
            this.tBText.TabIndex = 0;
            // 
            // tBMessage
            // 
            this.tBMessage.Enabled = false;
            this.tBMessage.Location = new System.Drawing.Point(462, 13);
            this.tBMessage.Multiline = true;
            this.tBMessage.Name = "tBMessage";
            this.tBMessage.Size = new System.Drawing.Size(326, 284);
            this.tBMessage.TabIndex = 1;
            // 
            // btnoperation
            // 
            this.btnoperation.Location = new System.Drawing.Point(364, 90);
            this.btnoperation.Name = "btnoperation";
            this.btnoperation.Size = new System.Drawing.Size(75, 74);
            this.btnoperation.TabIndex = 2;
            this.btnoperation.Text = "Encrypt or Decrypt";
            this.btnoperation.UseVisualStyleBackColor = true;
            this.btnoperation.Click += new System.EventHandler(this.Btngo_Click);
            // 
            // gBSource
            // 
            this.gBSource.Controls.Add(this.rBFile);
            this.gBSource.Controls.Add(this.rBText);
            this.gBSource.Location = new System.Drawing.Point(364, 13);
            this.gBSource.Name = "gBSource";
            this.gBSource.Size = new System.Drawing.Size(75, 71);
            this.gBSource.TabIndex = 3;
            this.gBSource.TabStop = false;
            this.gBSource.Text = "Source";
            // 
            // rBFile
            // 
            this.rBFile.AutoSize = true;
            this.rBFile.Location = new System.Drawing.Point(7, 43);
            this.rBFile.Name = "rBFile";
            this.rBFile.Size = new System.Drawing.Size(41, 17);
            this.rBFile.TabIndex = 1;
            this.rBFile.Text = "File";
            this.rBFile.UseVisualStyleBackColor = true;
            this.rBFile.CheckedChanged += new System.EventHandler(this.Selectsource);
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(7, 20);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(46, 17);
            this.rBText.TabIndex = 0;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            this.rBText.CheckedChanged += new System.EventHandler(this.Selectsource);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.gBSource);
            this.Controls.Add(this.btnoperation);
            this.Controls.Add(this.tBMessage);
            this.Controls.Add(this.tBText);
            this.Name = "Form1";
            this.Text = "Atbash";
            this.gBSource.ResumeLayout(false);
            this.gBSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.TextBox tBMessage;
        private System.Windows.Forms.Button btnoperation;
        private System.Windows.Forms.GroupBox gBSource;
        private System.Windows.Forms.RadioButton rBFile;
        private System.Windows.Forms.RadioButton rBText;
    }
}

