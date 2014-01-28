namespace MailClient
{
    partial class SendMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.b_send = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.l_attachmentName = new System.Windows.Forms.Label();
            this.b_removeAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(62, 32);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(811, 20);
            this.tb_subject.TabIndex = 2;
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(62, 6);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(811, 20);
            this.tb_to.TabIndex = 1;
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(12, 87);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(861, 402);
            this.rtb_message.TabIndex = 3;
            this.rtb_message.Text = "";
            // 
            // b_send
            // 
            this.b_send.Location = new System.Drawing.Point(12, 495);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(861, 23);
            this.b_send.TabIndex = 5;
            this.b_send.Text = "Send";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.sendEmail);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select attachment...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddAttachment);
            // 
            // l_attachmentName
            // 
            this.l_attachmentName.AutoSize = true;
            this.l_attachmentName.Location = new System.Drawing.Point(299, 63);
            this.l_attachmentName.Name = "l_attachmentName";
            this.l_attachmentName.Size = new System.Drawing.Size(0, 13);
            this.l_attachmentName.TabIndex = 7;
            // 
            // b_removeAttachment
            // 
            this.b_removeAttachment.Location = new System.Drawing.Point(162, 58);
            this.b_removeAttachment.Name = "b_removeAttachment";
            this.b_removeAttachment.Size = new System.Drawing.Size(131, 23);
            this.b_removeAttachment.TabIndex = 8;
            this.b_removeAttachment.Text = "Remove attachment";
            this.b_removeAttachment.UseVisualStyleBackColor = true;
            this.b_removeAttachment.Click += new System.EventHandler(this.RemoveAttachment);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 530);
            this.Controls.Add(this.b_removeAttachment);
            this.Controls.Add(this.l_attachmentName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_send);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.tb_to);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SendMail";
            this.Text = "Send email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_attachmentName;
        private System.Windows.Forms.Button b_removeAttachment;
    }
}