namespace Notes
{
    partial class NotesForm
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
            this.components = new System.ComponentModel.Container();
            this.NotesAreaScrollbar = new System.Windows.Forms.VScrollBar();
            this.NotesArea = new System.Windows.Forms.Panel();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.MyNotesButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.NoteGroups = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesAreaScrollbar
            // 
            this.NotesAreaScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesAreaScrollbar.LargeChange = 1;
            this.NotesAreaScrollbar.Location = new System.Drawing.Point(905, 0);
            this.NotesAreaScrollbar.Maximum = 0;
            this.NotesAreaScrollbar.Name = "NotesAreaScrollbar";
            this.NotesAreaScrollbar.Size = new System.Drawing.Size(19, 550);
            this.NotesAreaScrollbar.TabIndex = 1;
            this.NotesAreaScrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NotesAreaScrollbar_Scroll);
            // 
            // NotesArea
            // 
            this.NotesArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesArea.BackColor = System.Drawing.Color.Transparent;
            this.NotesArea.Location = new System.Drawing.Point(259, 0);
            this.NotesArea.Name = "NotesArea";
            this.NotesArea.Size = new System.Drawing.Size(645, 550);
            this.NotesArea.TabIndex = 2;
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.CategoriesPanel.Controls.Add(this.AddNoteButton);
            this.CategoriesPanel.Controls.Add(this.SettingsButton);
            this.CategoriesPanel.Controls.Add(this.FriendsButton);
            this.CategoriesPanel.Controls.Add(this.MyNotesButton);
            this.CategoriesPanel.Controls.Add(this.MenuButton);
            this.CategoriesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(60, 551);
            this.CategoriesPanel.TabIndex = 3;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = global::Notes.Properties.Resources.New_note;
            this.AddNoteButton.Location = new System.Drawing.Point(0, 161);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(60, 50);
            this.AddNoteButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.AddNoteButton, "Add new note to current category");
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Image = global::Notes.Properties.Resources.settings_32_2;
            this.SettingsButton.Location = new System.Drawing.Point(0, 502);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(60, 50);
            this.SettingsButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.SettingsButton, "Application settings");
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.FlatAppearance.BorderSize = 0;
            this.FriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsButton.Image = global::Notes.Properties.Resources.friends_icon_32_2;
            this.FriendsButton.Location = new System.Drawing.Point(0, 111);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(60, 50);
            this.FriendsButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.FriendsButton, "Friends management");
            this.FriendsButton.UseVisualStyleBackColor = true;
            // 
            // MyNotesButton
            // 
            this.MyNotesButton.FlatAppearance.BorderSize = 0;
            this.MyNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyNotesButton.Image = global::Notes.Properties.Resources.my_notes_menu_32_2;
            this.MyNotesButton.Location = new System.Drawing.Point(0, 61);
            this.MyNotesButton.Name = "MyNotesButton";
            this.MyNotesButton.Size = new System.Drawing.Size(60, 50);
            this.MyNotesButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.MyNotesButton, "Show all notes");
            this.MyNotesButton.UseVisualStyleBackColor = true;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuButton.Image = global::Notes.Properties.Resources.menu_button;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(60, 60);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // NoteGroups
            // 
            this.NoteGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.NoteGroups.Location = new System.Drawing.Point(59, 0);
            this.NoteGroups.Name = "NoteGroups";
            this.NoteGroups.Size = new System.Drawing.Size(200, 550);
            this.NoteGroups.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Notes.Properties.Resources.backgroundForNotesWithEffectsCutted;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 551);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.CheckFileExists = false;
            this.OpenFileDialog.DefaultExt = "notessave";
            this.OpenFileDialog.Filter = "Notes save file (.notessave)|*.notessave";
            this.OpenFileDialog.Title = "Load save file";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "notessave";
            this.SaveFileDialog.Filter = "Notes save file (.notessave)|*.notessave";
            this.SaveFileDialog.Title = "Save save file";
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(924, 551);
            this.Controls.Add(this.NoteGroups);
            this.Controls.Add(this.NotesAreaScrollbar);
            this.Controls.Add(this.CategoriesPanel);
            this.Controls.Add(this.NotesArea);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.Resize += new System.EventHandler(this.NotesForm_Resize);
            this.CategoriesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar NotesAreaScrollbar;
        private System.Windows.Forms.Panel NotesArea;
        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button MyNotesButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Panel NoteGroups;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

