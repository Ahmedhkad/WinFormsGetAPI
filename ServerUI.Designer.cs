namespace WinFormsClassTest
{
    partial class ServerUI
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label appTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerUI));
            statusStrip1 = new StatusStrip();
            StatusLabelDown = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            respondTextBox = new RichTextBox();
            respondLabel = new Label();
            buttonGetHttp = new Button();
            buttonStartLIsten = new Button();
            buttonStopListning = new Button();
            dataGridView = new DataGridView();
            appTitle = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Segoe UI", 14F);
            appTitle.Location = new Point(42, 24);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(164, 25);
            appTitle.TabIndex = 2;
            appTitle.Text = "WinForms Get API";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabelDown });
            statusStrip1.Location = new Point(0, 565);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(664, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelDown
            // 
            StatusLabelDown.Name = "StatusLabelDown";
            StatusLabelDown.Size = new Size(39, 17);
            StatusLabelDown.Text = "Ready";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(664, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // respondTextBox
            // 
            respondTextBox.Location = new Point(42, 80);
            respondTextBox.Name = "respondTextBox";
            respondTextBox.Size = new Size(580, 182);
            respondTextBox.TabIndex = 3;
            respondTextBox.Text = "";
            // 
            // respondLabel
            // 
            respondLabel.AutoSize = true;
            respondLabel.Location = new Point(42, 57);
            respondLabel.Name = "respondLabel";
            respondLabel.Size = new Size(80, 20);
            respondLabel.TabIndex = 4;
            respondLabel.Text = "Responds :";
            // 
            // buttonGetHttp
            // 
            buttonGetHttp.Location = new Point(527, 50);
            buttonGetHttp.Name = "buttonGetHttp";
            buttonGetHttp.Size = new Size(95, 29);
            buttonGetHttp.TabIndex = 5;
            buttonGetHttp.Text = "GET HTTP";
            buttonGetHttp.UseVisualStyleBackColor = true;
            buttonGetHttp.Click += buttonGetHttp_Click;
            // 
            // buttonStartLIsten
            // 
            buttonStartLIsten.Location = new Point(278, 24);
            buttonStartLIsten.Name = "buttonStartLIsten";
            buttonStartLIsten.Size = new Size(138, 28);
            buttonStartLIsten.TabIndex = 6;
            buttonStartLIsten.Text = "Start Listen";
            buttonStartLIsten.UseVisualStyleBackColor = true;
            buttonStartLIsten.Click += buttonStartLIsten_Click;
            // 
            // buttonStopListning
            // 
            buttonStopListning.FlatStyle = FlatStyle.System;
            buttonStopListning.Location = new Point(422, 26);
            buttonStopListning.Name = "buttonStopListning";
            buttonStopListning.Size = new Size(121, 26);
            buttonStopListning.TabIndex = 7;
            buttonStopListning.Text = "Stop Listining";
            buttonStopListning.UseVisualStyleBackColor = true;
            buttonStopListning.Click += buttonStopListning_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(42, 287);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(580, 209);
            dataGridView.TabIndex = 8;
            // 
            // ServerUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 587);
            Controls.Add(dataGridView);
            Controls.Add(buttonStopListning);
            Controls.Add(buttonStartLIsten);
            Controls.Add(buttonGetHttp);
            Controls.Add(respondLabel);
            Controls.Add(respondTextBox);
            Controls.Add(appTitle);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServerUI";
            Text = "Server HTTP Listener";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabelDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label appTitle;
        private RichTextBox respondTextBox;
        private Label respondLabel;
        private Button buttonGetHttp;
        private Button buttonStartLIsten;
        private Button buttonStopListning;
        private DataGridView dataGridView;
    }
}
