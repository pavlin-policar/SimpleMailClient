namespace MailClient.wuc
{
  partial class wuc_attachment
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.l_FileName = new System.Windows.Forms.Label();
      this.b_removeAttachment = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // l_FileName
      // 
      this.l_FileName.AutoSize = true;
      this.l_FileName.Location = new System.Drawing.Point(3, 8);
      this.l_FileName.Name = "l_FileName";
      this.l_FileName.Size = new System.Drawing.Size(35, 13);
      this.l_FileName.TabIndex = 0;
      this.l_FileName.Text = "label1";
      // 
      // b_removeAttachment
      // 
      this.b_removeAttachment.Location = new System.Drawing.Point(212, 3);
      this.b_removeAttachment.Name = "b_removeAttachment";
      this.b_removeAttachment.Size = new System.Drawing.Size(75, 23);
      this.b_removeAttachment.TabIndex = 1;
      this.b_removeAttachment.Text = "Remove";
      this.b_removeAttachment.UseVisualStyleBackColor = true;
      this.b_removeAttachment.Click += new System.EventHandler(this.b_removeAttachment_Click);
      // 
      // wuc_attachment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.b_removeAttachment);
      this.Controls.Add(this.l_FileName);
      this.Name = "wuc_attachment";
      this.Size = new System.Drawing.Size(290, 29);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label l_FileName;
    private System.Windows.Forms.Button b_removeAttachment;
  }
}
