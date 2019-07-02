namespace OpenWTRG
{
    partial class FormOpenModel
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
            this.textBoxModelPath = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelModelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxModelPath
            // 
            this.textBoxModelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModelPath.Location = new System.Drawing.Point(12, 29);
            this.textBoxModelPath.Name = "textBoxModelPath";
            this.textBoxModelPath.Size = new System.Drawing.Size(461, 22);
            this.textBoxModelPath.TabIndex = 0;
            this.textBoxModelPath.Text = "C:\\Path\\To\\The\\Model.wtg.sqlite";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 57);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(114, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open Model";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 86);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close Model";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelModelInfo
            // 
            this.labelModelInfo.AutoSize = true;
            this.labelModelInfo.Location = new System.Drawing.Point(12, 127);
            this.labelModelInfo.Name = "labelModelInfo";
            this.labelModelInfo.Size = new System.Drawing.Size(0, 17);
            this.labelModelInfo.TabIndex = 2;
            // 
            // FormOpenModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 153);
            this.Controls.Add(this.labelModelInfo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxModelPath);
            this.Name = "FormOpenModel";
            this.Text = "Open/Close WTG.SQLite files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxModelPath;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelModelInfo;
    }
}

