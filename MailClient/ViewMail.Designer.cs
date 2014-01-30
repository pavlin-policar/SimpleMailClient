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
      this.b_reply = new System.Windows.Forms.Button();
      this.tb_from = new System.Windows.Forms.TextBox();
      this.tb_subject = new System.Windows.Forms.TextBox();
      this.wb_msg = new System.Windows.Forms.WebBrowser();
      this.b_forward = new System.Windows.Forms.Button();
      this.b_ViewAttachments = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // b_reply
      // 
      this.b_reply.Location = new System.Drawing.Point(13, 13);
      this.b_reply.Name = "b_reply";
      this.b_reply.Size = new System.Drawing.Size(75, 23);
      this.b_reply.TabIndex = 0;
      this.b_reply.Text = "Reply";
      this.b_reply.UseVisualStyleBackColor = true;
      this.b_reply.Click += new System.EventHandler(this.b_reply_Click);
      // 
      // tb_from
      // 
      this.tb_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tb_from.Enabled = false;
      this.tb_from.Location = new System.Drawing.Point(13, 43);
      this.tb_from.Name = "tb_from";
      this.tb_from.Size = new System.Drawing.Size(917, 20);
      this.tb_from.TabIndex = 1;
      // 
      // tb_subject
      // 
      this.tb_subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tb_subject.Enabled = false;
      this.tb_subject.Location = new System.Drawing.Point(13, 70);
      this.tb_subject.Name = "tb_subject";
      this.tb_subject.Size = new System.Drawing.Size(917, 20);
      this.tb_subject.TabIndex = 2;
      // 
      // wb_msg
      // 
      this.wb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.wb_msg.Location = new System.Drawing.Point(13, 97);
      this.wb_msg.MinimumSize = new System.Drawing.Size(20, 20);
      this.wb_msg.Name = "wb_msg";
      this.wb_msg.Size = new System.Drawing.Size(917, 473);
      this.wb_msg.TabIndex = 3;
      // 
      // b_forward
      // 
      this.b_forward.Location = new System.Drawing.Point(94, 14);
      this.b_forward.Name = "b_forward";
      this.b_forward.Size = new System.Drawing.Size(75, 23);
      this.b_forward.TabIndex = 4;
      this.b_forward.Text = "Forward";
      this.b_forward.UseVisualStyleBackColor = true;
      this.b_forward.Click += new System.EventHandler(this.b_forward_Click);
      // 
      // b_ViewAttachments
      // 
      this.b_ViewAttachments.Location = new System.Drawing.Point(834, 14);
      this.b_ViewAttachments.Name = "b_ViewAttachments";
      this.b_ViewAttachments.Size = new System.Drawing.Size(96, 23);
      this.b_ViewAttachments.TabIndex = 5;
      this.b_ViewAttachments.Text = "Attachments";
      this.b_ViewAttachments.UseVisualStyleBackColor = true;
      this.b_ViewAttachments.Click += new System.EventHandler(this.b_ViewAttachments_Click);
      // 
      // ViewMail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 582);
      this.Controls.Add(this.b_ViewAttachments);
      this.Controls.Add(this.b_forward);
      this.Controls.Add(this.wb_msg);
      this.Controls.Add(this.tb_subject);
      this.Controls.Add(this.tb_from);
      this.Controls.Add(this.b_reply);
      this.Name = "ViewMail";
      this.Text = "ViewMail";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button b_reply;
    private System.Windows.Forms.TextBox tb_from;
    private System.Windows.Forms.TextBox tb_subject;
    private System.Windows.Forms.WebBrowser wb_msg;
    private System.Windows.Forms.Button b_forward;
    private System.Windows.Forms.Button b_ViewAttachments;

  }
}