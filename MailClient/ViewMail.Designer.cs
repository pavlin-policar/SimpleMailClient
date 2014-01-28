namespace MailClient
{
  partial class ViewMail
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
      this.wb_msg = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // wb_msg
      // 
      this.wb_msg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wb_msg.Location = new System.Drawing.Point(0, 0);
      this.wb_msg.MinimumSize = new System.Drawing.Size(20, 20);
      this.wb_msg.Name = "wb_msg";
      this.wb_msg.Size = new System.Drawing.Size(942, 582);
      this.wb_msg.TabIndex = 0;
      // 
      // ViewMail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 582);
      this.Controls.Add(this.wb_msg);
      this.Name = "ViewMail";
      this.Text = "ViewMail";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser wb_msg;
  }
}