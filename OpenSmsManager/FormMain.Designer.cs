
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
            this.ProgressInfoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.serialPortList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // serialPortList
            // 
            resources.ApplyResources(this.serialPortList, "serialPortList");
            this.serialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortList.FormattingEnabled = true;
            this.serialPortList.Name = "serialPortList";
            this.serialPortList.SelectedIndexChanged += new System.EventHandler(this.SerialPortList_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.existingMessageDelete);
            this.groupBox2.Controls.Add(this.messageList);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // existingMessageDelete
            // 
            resources.ApplyResources(this.existingMessageDelete, "existingMessageDelete");
            this.existingMessageDelete.Name = "existingMessageDelete";
            this.existingMessageDelete.UseVisualStyleBackColor = true;
            this.existingMessageDelete.Click += new System.EventHandler(this.ExistingMessageDelete_Click);
            // 
            // messageList
            // 
            this.messageList.AllowColumnReorder = true;
            resources.ApplyResources(this.messageList, "messageList");
            this.messageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Received,
            this.From,
            this.Message});
            this.messageList.FullRowSelect = true;
            this.messageList.GridLines = true;
            this.messageList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.messageList.HideSelection = false;
            this.messageList.MultiSelect = false;
            this.messageList.Name = "messageList";
            this.messageList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.messageList.UseCompatibleStateImageBehavior = false;
            this.messageList.View = System.Windows.Forms.View.Details;
            this.messageList.SelectedIndexChanged += new System.EventHandler(this.MessageList_SelectedIndexChanged);
            // 
            // Received
            // 
            resources.ApplyResources(this.Received, "Received");
            // 
            // From
            // 
            resources.ApplyResources(this.From, "From");
            // 
            // Message
            // 
            resources.ApplyResources(this.Message, "Message");
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.newMessageSend);
            this.groupBox3.Controls.Add(this.newMessageText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.newMessageTo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // newMessageSend
            // 
            resources.ApplyResources(this.newMessageSend, "newMessageSend");
            this.newMessageSend.Name = "newMessageSend";
            this.newMessageSend.UseVisualStyleBackColor = true;
            this.newMessageSend.Click += new System.EventHandler(this.NewMessageSend_Click);
            // 
            // newMessageText
            // 
            resources.ApplyResources(this.newMessageText, "newMessageText");
            this.newMessageText.Name = "newMessageText";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // newMessageTo
            // 
            resources.ApplyResources(this.newMessageTo, "newMessageTo");
            this.newMessageTo.Name = "newMessageTo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ProgressInfoLabel
            // 
            resources.ApplyResources(this.ProgressInfoLabel, "ProgressInfoLabel");
            this.ProgressInfoLabel.Name = "ProgressInfoLabel";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgressInfoLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ColumnHeader Received;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Button existingMessageDelete;
        private System.Windows.Forms.Label ProgressInfoLabel;
    }
}

