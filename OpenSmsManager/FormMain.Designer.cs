
namespace OpenSmsManager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.existingMessageDelete = new System.Windows.Forms.Button();
            this.messageList = new System.Windows.Forms.ListView();
            this.Received = new System.Windows.Forms.ColumnHeader();
            this.From = new System.Windows.Forms.ColumnHeader();
            this.Message = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newMessageSend = new System.Windows.Forms.Button();
            this.newMessageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newMessageTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Panel();
            this.progressText = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.serialPortList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(598, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phone Connection Settings";
            // 
            // serialPortList
            // 
            this.serialPortList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serialPortList.FormattingEnabled = true;
            this.serialPortList.Location = new System.Drawing.Point(446, 23);
            this.serialPortList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.serialPortList.Name = "serialPortList";
            this.serialPortList.Size = new System.Drawing.Size(138, 21);
            this.serialPortList.TabIndex = 1;
            this.serialPortList.SelectedIndexChanged += new System.EventHandler(this.SerialPortList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the COM port that your phone is currently connected to:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.existingMessageDelete);
            this.groupBox2.Controls.Add(this.messageList);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(598, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phone Sms Messages";
            // 
            // existingMessageDelete
            // 
            this.existingMessageDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.existingMessageDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.existingMessageDelete.Location = new System.Drawing.Point(497, 178);
            this.existingMessageDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.existingMessageDelete.Name = "existingMessageDelete";
            this.existingMessageDelete.Size = new System.Drawing.Size(88, 27);
            this.existingMessageDelete.TabIndex = 5;
            this.existingMessageDelete.Text = "Delete";
            this.existingMessageDelete.UseVisualStyleBackColor = true;
            this.existingMessageDelete.Click += new System.EventHandler(this.ExistingMessageDelete_Click);
            // 
            // messageList
            // 
            this.messageList.AllowColumnReorder = true;
            this.messageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Received,
            this.From,
            this.Message});
            this.messageList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageList.FullRowSelect = true;
            this.messageList.GridLines = true;
            this.messageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.messageList.HideSelection = false;
            this.messageList.Location = new System.Drawing.Point(10, 23);
            this.messageList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.messageList.MultiSelect = false;
            this.messageList.Name = "messageList";
            this.messageList.Size = new System.Drawing.Size(573, 148);
            this.messageList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.messageList.TabIndex = 0;
            this.messageList.UseCompatibleStateImageBehavior = false;
            this.messageList.View = System.Windows.Forms.View.Details;
            this.messageList.SelectedIndexChanged += new System.EventHandler(this.MessageList_SelectedIndexChanged);
            // 
            // Received
            // 
            this.Received.Text = "Received";
            this.Received.Width = 100;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 90;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 240;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.newMessageSend);
            this.groupBox3.Controls.Add(this.newMessageText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.newMessageTo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(15, 309);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(597, 240);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send SMS using Phone";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please note: If a message is longer than 160 characters it will be splited and se" +
    "nt as multiple messages, and combined by the recipient.";
            // 
            // newMessageSend
            // 
            this.newMessageSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessageSend.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMessageSend.Location = new System.Drawing.Point(496, 159);
            this.newMessageSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newMessageSend.Name = "newMessageSend";
            this.newMessageSend.Size = new System.Drawing.Size(88, 27);
            this.newMessageSend.TabIndex = 4;
            this.newMessageSend.Text = "Send";
            this.newMessageSend.UseVisualStyleBackColor = true;
            this.newMessageSend.Click += new System.EventHandler(this.NewMessageSend_Click);
            // 
            // newMessageText
            // 
            this.newMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessageText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMessageText.Location = new System.Drawing.Point(13, 66);
            this.newMessageText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newMessageText.Multiline = true;
            this.newMessageText.Name = "newMessageText";
            this.newMessageText.Size = new System.Drawing.Size(570, 86);
            this.newMessageText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // newMessageTo
            // 
            this.newMessageTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessageTo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMessageTo.Location = new System.Drawing.Point(329, 20);
            this.newMessageTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newMessageTo.Name = "newMessageTo";
            this.newMessageTo.Size = new System.Drawing.Size(254, 22);
            this.newMessageTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Recipients phone number (format: 46712345678):";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.BackColor = System.Drawing.SystemColors.Info;
            this.progress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progress.Controls.Add(this.progressText);
            this.progress.Location = new System.Drawing.Point(83, 179);
            this.progress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(458, 190);
            this.progress.TabIndex = 4;
            this.progress.Visible = false;
            // 
            // progressText
            // 
            this.progressText.Location = new System.Drawing.Point(4, 13);
            this.progressText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(440, 164);
            this.progressText.TabIndex = 0;
            this.progressText.Text = "...";
            this.progressText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 3000;
            this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 624);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(633, 663);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open SMS Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.progress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serialPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView messageList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button newMessageSend;
        private System.Windows.Forms.TextBox newMessageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newMessageTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel progress;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.ColumnHeader Received;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Button existingMessageDelete;
    }
}

