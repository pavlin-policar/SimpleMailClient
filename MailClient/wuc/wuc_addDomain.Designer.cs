namespace MailClient.wuc
{
  partial class wuc_addDomain
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
      this.label1 = new System.Windows.Forms.Label();
      this.tb_domain = new System.Windows.Forms.TextBox();
      this.b_Cancel = new System.Windows.Forms.Button();
      this.b_AddDomainToList = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Domain";
      // 
      // tb_domain
      // 
      this.tb_domain.Location = new System.Drawing.Point(52, 4);
      this.tb_domain.Name = "tb_domain";
      this.tb_domain.Size = new System.Drawing.Size(224, 20);
      this.tb_domain.TabIndex = 1;
      // 
      // b_Cancel
      // 
      this.b_Cancel.Location = new System.Drawing.Point(200, 38);
      this.b_Cancel.Name = "b_Cancel";
      this.b_Cancel.Size = new System.Drawing.Size(75, 23);
      this.b_Cancel.TabIndex = 2;
      this.b_Cancel.Text = "Cancel";
      this.b_Cancel.UseVisualStyleBackColor = true;
      this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
      // 
      // b_AddDomainToList
      // 
      this.b_AddDomainToList.Location = new System.Drawing.Point(119, 38);
      this.b_AddDomainToList.Name = "b_AddDomainToList";
      this.b_AddDomainToList.Size = new System.Drawing.Size(75, 23);
      this.b_AddDomainToList.TabIndex = 3;
      this.b_AddDomainToList.Text = "Add";
      this.b_AddDomainToList.UseVisualStyleBackColor = true;
      this.b_AddDomainToList.Click += new System.EventHandler(this.b_AddDomainToList_Click);
      // 
      // wuc_addDomain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.b_AddDomainToList);
      this.Controls.Add(this.b_Cancel);
      this.Controls.Add(this.tb_domain);
      this.Controls.Add(this.label1);
      this.Name = "wuc_addDomain";
      this.Size = new System.Drawing.Size(288, 64);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tb_domain;
    private System.Windows.Forms.Button b_Cancel;
    private System.Windows.Forms.Button b_AddDomainToList;
  }
}
