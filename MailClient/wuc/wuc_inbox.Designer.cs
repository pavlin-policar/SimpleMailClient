namespace MailClient.wuc
{
  partial class wuc_inbox
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
      this.b_sendMail = new System.Windows.Forms.Button();
      this.lv_messages = new System.Windows.Forms.ListView();
      this.uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.subject_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.from_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.date_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // b_sendMail
      // 
      this.b_sendMail.Location = new System.Drawing.Point(3, 439);
      this.b_sendMail.Name = "b_sendMail";
      this.b_sendMail.Size = new System.Drawing.Size(205, 23);
      this.b_sendMail.TabIndex = 3;
      this.b_sendMail.Text = "Send email";
      this.b_sendMail.UseVisualStyleBackColor = true;
      this.b_sendMail.Click += new System.EventHandler(this.OpenMailForm);
      // 
      // lv_messages
      // 
      this.lv_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lv_messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uid,
            this.subject_col,
            this.from_col,
            this.date_col});
      this.lv_messages.FullRowSelect = true;
      this.lv_messages.GridLines = true;
      this.lv_messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lv_messages.Location = new System.Drawing.Point(214, 3);
      this.lv_messages.MultiSelect = false;
      this.lv_messages.Name = "lv_messages";
      this.lv_messages.Size = new System.Drawing.Size(581, 459);
      this.lv_messages.TabIndex = 4;
      this.lv_messages.UseCompatibleStateImageBehavior = false;
      this.lv_messages.View = System.Windows.Forms.View.Details;
      this.lv_messages.ItemActivate += new System.EventHandler(this.ShowEmailMessage);
      // 
      // uid
      // 
      this.uid.Text = "uid";
      // 
      // subject_col
      // 
      this.subject_col.Text = "Subject";
      this.subject_col.Width = 250;
      // 
      // from_col
      // 
      this.from_col.Text = "From";
      this.from_col.Width = 130;
      // 
      // date_col
      // 
      this.date_col.Text = "Date recieved";
      this.date_col.Width = 110;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(47, 97);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // wuc_inbox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lv_messages);
      this.Controls.Add(this.b_sendMail);
      this.Name = "wuc_inbox";
      this.Size = new System.Drawing.Size(800, 467);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button b_sendMail;
    private System.Windows.Forms.ListView lv_messages;
    private System.Windows.Forms.ColumnHeader uid;
    private System.Windows.Forms.ColumnHeader subject_col;
    private System.Windows.Forms.ColumnHeader from_col;
    private System.Windows.Forms.ColumnHeader date_col;
    private System.Windows.Forms.Label label1;

  }
}
