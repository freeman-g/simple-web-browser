namespace simple_web_browser
{
    partial class ParentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleWebBrowser = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navBox = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.exportHistory = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleWebBrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 492);
            this.panel1.TabIndex = 6;
            // 
            // simpleWebBrowser
            // 
            this.simpleWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.simpleWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.simpleWebBrowser.Name = "simpleWebBrowser";
            this.simpleWebBrowser.Size = new System.Drawing.Size(899, 492);
            this.simpleWebBrowser.TabIndex = 0;
            this.simpleWebBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.simpleWebBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.updateNavBox);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.navBox);
            this.flowLayoutPanel1.Controls.Add(this.go);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // navBox
            // 
            this.navBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBox.Location = new System.Drawing.Point(3, 3);
            this.navBox.Name = "navBox";
            this.navBox.Size = new System.Drawing.Size(847, 22);
            this.navBox.TabIndex = 1;
            this.navBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.url_Enter);
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(856, 3);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(40, 22);
            this.go.TabIndex = 3;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 553);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.exportHistory);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(908, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(264, 29);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // exportHistory
            // 
            this.exportHistory.Location = new System.Drawing.Point(3, 3);
            this.exportHistory.Name = "exportHistory";
            this.exportHistory.Size = new System.Drawing.Size(88, 22);
            this.exportHistory.TabIndex = 4;
            this.exportHistory.Text = "Export History";
            this.exportHistory.UseVisualStyleBackColor = true;
            this.exportHistory.Click += new System.EventHandler(this.exportHistory_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(908, 38);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(264, 492);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Export History";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ParentForm";
            this.Text = "Simple Web Browser";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser simpleWebBrowser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox navBox;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button exportHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

