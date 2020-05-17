namespace PbxManagement
{
    partial class ManagementForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabSubscibers = new System.Windows.Forms.TabPage();
            this.tbSearchSubscriber = new System.Windows.Forms.TextBox();
            this.btnAddSubscriber = new System.Windows.Forms.Button();
            this.tbSubscriberPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbSubscriberSurname = new System.Windows.Forms.TextBox();
            this.tbSubscriberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubscriberName = new System.Windows.Forms.Label();
            this.lblAddingSubscriber = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSubscribers = new System.Windows.Forms.ListBox();
            this.btnSubscriberShowInfo = new System.Windows.Forms.Button();
            this.btnSubscriberUpdate = new System.Windows.Forms.Button();
            this.btnSubscriberDelete = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabSubscibers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabSubscibers);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1097, 708);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabSubscibers
            // 
            this.tabSubscibers.Controls.Add(this.btnSubscriberDelete);
            this.tabSubscibers.Controls.Add(this.btnSubscriberUpdate);
            this.tabSubscibers.Controls.Add(this.btnSubscriberShowInfo);
            this.tabSubscibers.Controls.Add(this.lbSubscribers);
            this.tabSubscibers.Controls.Add(this.tbSearchSubscriber);
            this.tabSubscibers.Controls.Add(this.btnAddSubscriber);
            this.tabSubscibers.Controls.Add(this.tbSubscriberPhoneNumber);
            this.tabSubscibers.Controls.Add(this.tbSubscriberSurname);
            this.tabSubscibers.Controls.Add(this.tbSubscriberName);
            this.tabSubscibers.Controls.Add(this.label2);
            this.tabSubscibers.Controls.Add(this.label1);
            this.tabSubscibers.Controls.Add(this.lblSubscriberName);
            this.tabSubscibers.Controls.Add(this.lblAddingSubscriber);
            this.tabSubscibers.Location = new System.Drawing.Point(4, 22);
            this.tabSubscibers.Name = "tabSubscibers";
            this.tabSubscibers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSubscibers.Size = new System.Drawing.Size(1089, 682);
            this.tabSubscibers.TabIndex = 0;
            this.tabSubscibers.Text = "Subscribers";
            this.tabSubscibers.UseVisualStyleBackColor = true;
            // 
            // tbSearchSubscriber
            // 
            this.tbSearchSubscriber.Location = new System.Drawing.Point(396, 13);
            this.tbSearchSubscriber.Name = "tbSearchSubscriber";
            this.tbSearchSubscriber.Size = new System.Drawing.Size(685, 20);
            this.tbSearchSubscriber.TabIndex = 10;
            this.tbSearchSubscriber.TextChanged += new System.EventHandler(this.tbSearchSubscriber_TextChanged);
            // 
            // btnAddSubscriber
            // 
            this.btnAddSubscriber.Location = new System.Drawing.Point(13, 154);
            this.btnAddSubscriber.Name = "btnAddSubscriber";
            this.btnAddSubscriber.Size = new System.Drawing.Size(377, 23);
            this.btnAddSubscriber.TabIndex = 8;
            this.btnAddSubscriber.Text = "Add";
            this.btnAddSubscriber.UseVisualStyleBackColor = true;
            this.btnAddSubscriber.Click += new System.EventHandler(this.btnAddSubscriber_Click);
            // 
            // tbSubscriberPhoneNumber
            // 
            this.tbSubscriberPhoneNumber.Location = new System.Drawing.Point(102, 115);
            this.tbSubscriberPhoneNumber.Name = "tbSubscriberPhoneNumber";
            this.tbSubscriberPhoneNumber.Size = new System.Drawing.Size(288, 20);
            this.tbSubscriberPhoneNumber.TabIndex = 7;
            // 
            // tbSubscriberSurname
            // 
            this.tbSubscriberSurname.Location = new System.Drawing.Point(102, 83);
            this.tbSubscriberSurname.Name = "tbSubscriberSurname";
            this.tbSubscriberSurname.Size = new System.Drawing.Size(288, 20);
            this.tbSubscriberSurname.TabIndex = 6;
            // 
            // tbSubscriberName
            // 
            this.tbSubscriberName.Location = new System.Drawing.Point(102, 51);
            this.tbSubscriberName.Name = "tbSubscriberName";
            this.tbSubscriberName.Size = new System.Drawing.Size(288, 20);
            this.tbSubscriberName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // lblSubscriberName
            // 
            this.lblSubscriberName.AutoSize = true;
            this.lblSubscriberName.Location = new System.Drawing.Point(10, 54);
            this.lblSubscriberName.Name = "lblSubscriberName";
            this.lblSubscriberName.Size = new System.Drawing.Size(35, 13);
            this.lblSubscriberName.TabIndex = 2;
            this.lblSubscriberName.Text = "Name";
            // 
            // lblAddingSubscriber
            // 
            this.lblAddingSubscriber.AutoSize = true;
            this.lblAddingSubscriber.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddingSubscriber.Location = new System.Drawing.Point(8, 13);
            this.lblAddingSubscriber.Name = "lblAddingSubscriber";
            this.lblAddingSubscriber.Size = new System.Drawing.Size(157, 29);
            this.lblAddingSubscriber.TabIndex = 1;
            this.lblAddingSubscriber.Text = "Add subscriber";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSubscribers
            // 
            this.lbSubscribers.FormattingEnabled = true;
            this.lbSubscribers.Location = new System.Drawing.Point(396, 51);
            this.lbSubscribers.Name = "lbSubscribers";
            this.lbSubscribers.Size = new System.Drawing.Size(685, 628);
            this.lbSubscribers.TabIndex = 11;
            this.lbSubscribers.SelectedValueChanged += new System.EventHandler(this.lbSubscribers_SelectedValueChanged);
            // 
            // btnSubscriberShowInfo
            // 
            this.btnSubscriberShowInfo.Enabled = false;
            this.btnSubscriberShowInfo.Location = new System.Drawing.Point(210, 553);
            this.btnSubscriberShowInfo.Name = "btnSubscriberShowInfo";
            this.btnSubscriberShowInfo.Size = new System.Drawing.Size(180, 38);
            this.btnSubscriberShowInfo.TabIndex = 12;
            this.btnSubscriberShowInfo.Text = "Show Info about selected";
            this.btnSubscriberShowInfo.UseVisualStyleBackColor = true;
            this.btnSubscriberShowInfo.Click += new System.EventHandler(this.btnSubscriberShowInfo_Click);
            // 
            // btnSubscriberUpdate
            // 
            this.btnSubscriberUpdate.Enabled = false;
            this.btnSubscriberUpdate.Location = new System.Drawing.Point(210, 597);
            this.btnSubscriberUpdate.Name = "btnSubscriberUpdate";
            this.btnSubscriberUpdate.Size = new System.Drawing.Size(180, 38);
            this.btnSubscriberUpdate.TabIndex = 13;
            this.btnSubscriberUpdate.Text = "Update Subscriber";
            this.btnSubscriberUpdate.UseVisualStyleBackColor = true;
            this.btnSubscriberUpdate.Click += new System.EventHandler(this.btnSubscriberUpdate_Click);
            // 
            // btnSubscriberDelete
            // 
            this.btnSubscriberDelete.Enabled = false;
            this.btnSubscriberDelete.Location = new System.Drawing.Point(210, 641);
            this.btnSubscriberDelete.Name = "btnSubscriberDelete";
            this.btnSubscriberDelete.Size = new System.Drawing.Size(180, 38);
            this.btnSubscriberDelete.TabIndex = 14;
            this.btnSubscriberDelete.Text = "Delete Subscriber";
            this.btnSubscriberDelete.UseVisualStyleBackColor = true;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 708);
            this.Controls.Add(this.tabControlMain);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabSubscibers.ResumeLayout(false);
            this.tabSubscibers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabSubscibers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSubscriberName;
        private System.Windows.Forms.Label lblAddingSubscriber;
        private System.Windows.Forms.TextBox tbSubscriberPhoneNumber;
        private System.Windows.Forms.TextBox tbSubscriberSurname;
        private System.Windows.Forms.TextBox tbSubscriberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSubscriber;
        private System.Windows.Forms.TextBox tbSearchSubscriber;
        private System.Windows.Forms.ListBox lbSubscribers;
        private System.Windows.Forms.Button btnSubscriberDelete;
        private System.Windows.Forms.Button btnSubscriberUpdate;
        private System.Windows.Forms.Button btnSubscriberShowInfo;
    }
}