namespace MailClient.wuc
{
  partial class wuc_contactList
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
      this.flp = new System.Windows.Forms.FlowLayoutPanel();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.b_AddContact = new System.Windows.Forms.Button();
      this.b_DeleteContact = new System.Windows.Forms.Button();
      this.lv_contactList = new System.Windows.Forms.ListView();
      this.name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.b_EditContact = new System.Windows.Forms.Button();
      this.flp.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // flp
      // 
      this.flp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flp.Controls.Add(this.flowLayoutPanel1);
      this.flp.Controls.Add(this.lv_contactList);
      this.flp.Location = new System.Drawing.Point(3, 6);
      this.flp.Name = "flp";
      this.flp.Size = new System.Drawing.Size(572, 348);
      this.flp.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.b_AddContact);
      this.flowLayoutPanel1.Controls.Add(this.b_EditContact);
      this.flowLayoutPanel1.Controls.Add(this.b_DeleteContact);
      this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(138, 345);
      this.flowLayoutPanel1.TabIndex = 1;
      // 
      // b_AddContact
      // 
      this.b_AddContact.Location = new System.Drawing.Point(3, 3);
      this.b_AddContact.Name = "b_AddContact";
      this.b_AddContact.Size = new System.Drawing.Size(135, 23);
      this.b_AddContact.TabIndex = 0;
      this.b_AddContact.Text = "Add contact";
      this.b_AddContact.UseVisualStyleBackColor = true;
      this.b_AddContact.Click += new System.EventHandler(this.b_AddContact_Click);
      // 
      // b_DeleteContact
      // 
      this.b_DeleteContact.Location = new System.Drawing.Point(3, 61);
      this.b_DeleteContact.Name = "b_DeleteContact";
      this.b_DeleteContact.Size = new System.Drawing.Size(135, 23);
      this.b_DeleteContact.TabIndex = 1;
      this.b_DeleteContact.Text = "Delete Contact";
      this.b_DeleteContact.UseVisualStyleBackColor = true;
      this.b_DeleteContact.Click += new System.EventHandler(this.b_DeleteContact_Click);
      // 
      // lv_contactList
      // 
      this.lv_contactList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_col});
      this.lv_contactList.Location = new System.Drawing.Point(147, 3);
      this.lv_contactList.MultiSelect = false;
      this.lv_contactList.Name = "lv_contactList";
      this.lv_contactList.Size = new System.Drawing.Size(422, 345);
      this.lv_contactList.TabIndex = 0;
      this.lv_contactList.UseCompatibleStateImageBehavior = false;
      this.lv_contactList.View = System.Windows.Forms.View.Details;
      this.lv_contactList.ItemActivate += new System.EventHandler(this.SendMailTo);
      // 
      // name_col
      // 
      this.name_col.Text = "Name";
      this.name_col.Width = 283;
      // 
      // b_EditContact
      // 
      this.b_EditContact.Location = new System.Drawing.Point(3, 32);
      this.b_EditContact.Name = "b_EditContact";
      this.b_EditContact.Size = new System.Drawing.Size(135, 23);
      this.b_EditContact.TabIndex = 2;
      this.b_EditContact.Text = "Edit Contact";
      this.b_EditContact.UseVisualStyleBackColor = true;
      this.b_EditContact.Click += new System.EventHandler(this.b_EditContact_Click);
      // 
      // wuc_contactList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.flp);
      this.Name = "wuc_contactList";
      this.Size = new System.Drawing.Size(578, 357);
      this.flp.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flp;
    private System.Windows.Forms.ListView lv_contactList;
    private System.Windows.Forms.ColumnHeader name_col;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button b_AddContact;
    private System.Windows.Forms.Button b_DeleteContact;
    private System.Windows.Forms.Button b_EditContact;
  }
}
