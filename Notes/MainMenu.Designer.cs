namespace Notes
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.MyNotesButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.NewNoteButton.FlatAppearance.BorderSize = 0;
            this.NewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.NewNoteButton.Image = global::Notes.Properties.Resources.New_note;
            this.NewNoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewNoteButton.Location = new System.Drawing.Point(1, 160);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.NewNoteButton.Size = new System.Drawing.Size(270, 50);
            this.NewNoteButton.TabIndex = 11;
            this.NewNoteButton.Text = "  New note";
            this.NewNoteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.NewNoteButton, "Add new note to current category");
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.SettingsButton.Image = global::Notes.Properties.Resources.settings_32_2;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(1, 450);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(270, 50);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "  Settings";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.SettingsButton, "Application settings");
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.FriendsButton.FlatAppearance.BorderSize = 0;
            this.FriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.FriendsButton.Image = global::Notes.Properties.Resources.friends_icon_32_2;
            this.FriendsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FriendsButton.Location = new System.Drawing.Point(1, 110);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.FriendsButton.Size = new System.Drawing.Size(270, 50);
            this.FriendsButton.TabIndex = 7;
            this.FriendsButton.Text = "  Friends";
            this.FriendsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.FriendsButton, "Friends management");
            this.FriendsButton.UseVisualStyleBackColor = false;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // MyNotesButton
            // 
            this.MyNotesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.MyNotesButton.FlatAppearance.BorderSize = 0;
            this.MyNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyNotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyNotesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.MyNotesButton.Image = global::Notes.Properties.Resources.my_notes_menu_32_2;
            this.MyNotesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyNotesButton.Location = new System.Drawing.Point(1, 60);
            this.MyNotesButton.Name = "MyNotesButton";
            this.MyNotesButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.MyNotesButton.Size = new System.Drawing.Size(270, 50);
            this.MyNotesButton.TabIndex = 6;
            this.MyNotesButton.Text = "  My Notes";
            this.MyNotesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.MyNotesButton, "Show all notes");
            this.MyNotesButton.UseVisualStyleBackColor = false;
            this.MyNotesButton.Click += new System.EventHandler(this.MyNotesButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(114)))));
            this.MenuButton.Image = global::Notes.Properties.Resources.menu_button;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(60, 60);
            this.MenuButton.TabIndex = 5;
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.NewNoteButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.FriendsButton);
            this.Controls.Add(this.MyNotesButton);
            this.Controls.Add(this.MenuButton);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(200, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button MyNotesButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
