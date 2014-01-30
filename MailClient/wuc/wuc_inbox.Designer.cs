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
      this.checkbox_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.subject_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.from_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.date_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.b_refresh = new System.Windows.Forms.Button();
      this.b_selectAll = new System.Windows.Forms.Button();
      this.b_selectNone = new System.Windows.Forms.Button();
      this.b_deleteMessages = new System.Windows.Forms.Button();
      this.b_MarkAsRead = new System.Windows.Forms.Button();
      this.b_MarkUnread = new System.Windows.Forms.Button();
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
      this.lv_messages.CheckBoxes = true;
      this.lv_messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkbox_col,
            this.uid,
            this.subject_col,
            this.from_col,
            this.date_col});
      this.lv_messages.FullRowSelect = true;
      this.lv_messages.GridLines = true;
      this.lv_messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lv_messages.Location = new System.Drawing.Point(214, 33);
      this.lv_messages.MultiSelect = false;
      this.lv_messages.Name = "lv_messages";
      this.lv_messages.Size = new System.Drawing.Size(581, 429);
      this.lv_messages.TabIndex = 4;
      this.lv_messages.UseCompatibleStateImageBehavior = false;
      this.lv_messages.View = System.Windows.Forms.View.Details;
      this.lv_messages.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lv_cancelResize);
      this.lv_messages.ItemActivate += new System.EventHandler(this.ShowEmailMessage);
      // 
      // checkbox_col
      // 
      this.checkbox_col.Text = "";
      this.checkbox_col.Width = 20;
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
      // b_refresh
      // 
      this.b_refresh.Location = new System.Drawing.Point(720, 4);
      this.b_refresh.Name = "b_refresh";
      this.b_refresh.Size = new System.Drawing.Size(75, 23);
      this.b_refresh.TabIndex = 5;
      this.b_refresh.Text = "Refresh";
      this.b_refresh.UseVisualStyleBackColor = true;
      this.b_refresh.Click += new System.EventHandler(this.Refresh);
      // 
      // b_selectAll
      // 
      this.b_selectAll.Location = new System.Drawing.Point(214, 4);
      this.b_selectAll.Name = "b_selectAll";
      this.b_selectAll.Size = new System.Drawing.Size(75, 23);
      this.b_selectAll.TabIndex = 6;
      this.b_selectAll.Text = "Select All";
      this.b_selectAll.UseVisualStyleBackColor = true;
      this.b_selectAll.Click += new System.EventHandler(this.SelectAll);
      // 
      // b_selectNone
      // 
      this.b_selectNone.Location = new System.Drawing.Point(295, 4);
      this.b_selectNone.Name = "b_selectNone";
      this.b_selectNone.Size = new System.Drawing.Size(75, 23);
      this.b_selectNone.TabIndex = 7;
      this.b_selectNone.Text = "Select none";
      this.b_selectNone.UseVisualStyleBackColor = true;
      this.b_selectNone.Click += new System.EventHandler(this.SelectNone);
      // 
      // b_deleteMessages
      // 
      this.b_deleteMessages.Location = new System.Drawing.Point(376, 4);
      this.b_deleteMessages.Name = "b_deleteMessages";
      this.b_deleteMessages.Size = new System.Drawing.Size(75, 23);
      this.b_deleteMessages.TabIndex = 8;
      this.b_deleteMessages.Text = "Delete";
      this.b_deleteMessages.UseVisualStyleBackColor = true;
      this.b_deleteMessages.Click += new System.EventHandler(this.DeleteMessages);
      // 
      // b_MarkAsRead
      // 
      this.b_MarkAsRead.Location = new System.Drawing.Point(481, 4);
      this.b_MarkAsRead.Name = "b_MarkAsRead";
      this.b_MarkAsRead.Size = new System.Drawing.Size(92, 23);
      this.b_MarkAsRead.TabIndex = 9;
      this.b_MarkAsRead.Text = "Mark as read";
      this.b_MarkAsRead.UseVisualStyleBackColor = true;
      this.b_MarkAsRead.Click += new System.EventHandler(this.MarkAsRead);
      // 
      // b_MarkUnread
      // 
      this.b_MarkUnread.Location = new System.Drawing.Point(579, 4);
      this.b_MarkUnread.Name = "b_MarkUnread";
      this.b_MarkUnread.Size = new System.Drawing.Size(94, 23);
      this.b_MarkUnread.TabIndex = 10;
      this.b_MarkUnread.Text = "Mark as unread";
      this.b_MarkUnread.UseVisualStyleBackColor = true;
      this.b_MarkUnread.Click += new System.EventHandler(this.MarkAsUnread);
      // 
      // wuc_inbox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.b_MarkUnread);
      this.Controls.Add(this.b_MarkAsRead);
      this.Controls.Add(this.b_deleteMessages);
      this.Controls.Add(this.b_selectNone);
      this.Controls.Add(this.b_selectAll);
      this.Controls.Add(this.b_refresh);
      this.Controls.Add(this.lv_messages);
      this.Controls.Add(this.b_sendMail);
      this.Name = "wuc_inbox";
      this.Size = new System.Drawing.Size(800, 467);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button b_sendMail;
    private System.Windows.Forms.ListView lv_messages;
    private System.Windows.Forms.ColumnHeader uid;
    private System.Windows.Forms.ColumnHeader subject_col;
    private System.Windows.Forms.ColumnHeader from_col;
    private System.Windows.Forms.ColumnHeader date_col;
    private System.Windows.Forms.Button b_refresh;
    private System.Windows.Forms.Button b_selectAll;
    private System.Windows.Forms.ColumnHeader checkbox_col;
    private System.Windows.Forms.Button b_selectNone;
    private System.Windows.Forms.Button b_deleteMessages;
    private System.Windows.Forms.Button b_MarkAsRead;
    private System.Windows.Forms.Button b_MarkUnread;

  }
}
