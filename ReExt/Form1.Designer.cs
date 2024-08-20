namespace ReExt {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dstExt = new System.Windows.Forms.TextBox();
            this.txt_fileFolder = new System.Windows.Forms.TextBox();
            this.txt_srcExt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_regex = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_preview = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_installRcRm = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.btn_doIt = new System.Windows.Forms.Button();
            this.toolTip_installRcCm = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_browse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dstExt);
            this.groupBox1.Controls.Add(this.txt_fileFolder);
            this.groupBox1.Controls.Add(this.txt_srcExt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "File/Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target ext";
            // 
            // btn_browse
            // 
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_browse.Location = new System.Drawing.Point(121, 22);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(25, 20);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source ext";
            // 
            // txt_dstExt
            // 
            this.txt_dstExt.Location = new System.Drawing.Point(70, 76);
            this.txt_dstExt.Name = "txt_dstExt";
            this.txt_dstExt.Size = new System.Drawing.Size(76, 20);
            this.txt_dstExt.TabIndex = 1;
            // 
            // txt_fileFolder
            // 
            this.txt_fileFolder.Location = new System.Drawing.Point(70, 22);
            this.txt_fileFolder.Name = "txt_fileFolder";
            this.txt_fileFolder.Size = new System.Drawing.Size(45, 20);
            this.txt_fileFolder.TabIndex = 0;
            // 
            // txt_srcExt
            // 
            this.txt_srcExt.Location = new System.Drawing.Point(70, 50);
            this.txt_srcExt.Name = "txt_srcExt";
            this.txt_srcExt.Size = new System.Drawing.Size(76, 20);
            this.txt_srcExt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_regex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // txt_regex
            // 
            this.txt_regex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_regex.DetectUrls = false;
            this.txt_regex.Location = new System.Drawing.Point(6, 32);
            this.txt_regex.Name = "txt_regex";
            this.txt_regex.Size = new System.Drawing.Size(140, 67);
            this.txt_regex.TabIndex = 1;
            this.txt_regex.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filename regex";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_preview);
            this.groupBox3.Location = new System.Drawing.Point(265, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // list_preview
            // 
            this.list_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_preview.HideSelection = false;
            this.list_preview.Location = new System.Drawing.Point(3, 16);
            this.list_preview.Name = "list_preview";
            this.list_preview.Size = new System.Drawing.Size(194, 199);
            this.list_preview.TabIndex = 0;
            this.list_preview.UseCompatibleStateImageBehavior = false;
            this.list_preview.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(170, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(92, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drop box";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop a file or a folder here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label1_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label1_DragEnter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_installRcRm);
            this.groupBox5.Controls.Add(this.btn_abort);
            this.groupBox5.Controls.Add(this.btn_doIt);
            this.groupBox5.Location = new System.Drawing.Point(170, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(92, 106);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // btn_installRcRm
            // 
            this.btn_installRcRm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_installRcRm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_installRcRm.Location = new System.Drawing.Point(6, 77);
            this.btn_installRcRm.Name = "btn_installRcRm";
            this.btn_installRcRm.Size = new System.Drawing.Size(80, 23);
            this.btn_installRcRm.TabIndex = 2;
            this.btn_installRcRm.Text = "Install RC-CM";
            this.btn_installRcRm.UseVisualStyleBackColor = true;
            this.btn_installRcRm.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // btn_abort
            // 
            this.btn_abort.Enabled = false;
            this.btn_abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abort.Location = new System.Drawing.Point(6, 48);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(80, 23);
            this.btn_abort.TabIndex = 1;
            this.btn_abort.Text = "Abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            // 
            // btn_doIt
            // 
            this.btn_doIt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_doIt.Location = new System.Drawing.Point(6, 19);
            this.btn_doIt.Name = "btn_doIt";
            this.btn_doIt.Size = new System.Drawing.Size(80, 23);
            this.btn_doIt.TabIndex = 0;
            this.btn_doIt.Text = "Do it";
            this.btn_doIt.UseVisualStyleBackColor = true;
            // 
            // toolTip_installRcCm
            // 
            this.toolTip_installRcCm.ToolTipTitle = "Install the Right-Click-Context-Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 242);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReExt - File Extension Renamer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolTip toolTip_installRcCm;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_regex;

        private System.Windows.Forms.TextBox txt_srcExt;
        private System.Windows.Forms.TextBox txt_dstExt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_installRcRm;

        private System.Windows.Forms.Button btn_doIt;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.TextBox txt_fileFolder;
        private System.Windows.Forms.Button btn_browse;

        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListView list_preview;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.GroupBox groupBox1;

        #endregion
    }
}