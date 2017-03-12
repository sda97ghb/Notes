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
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.NotesAreaScrollbar = new System.Windows.Forms.VScrollBar();
            this.NotesArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(176)))), ((int)(((byte)(216)))));
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNoteButton.Location = new System.Drawing.Point(666, 1);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(40, 40);
            this.AddNoteButton.TabIndex = 0;
            this.AddNoteButton.Text = "+";
            this.AddNoteButton.UseVisualStyleBackColor = false;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // NotesAreaScrollbar
            // 
            this.NotesAreaScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesAreaScrollbar.LargeChange = 1;
            this.NotesAreaScrollbar.Location = new System.Drawing.Point(689, 47);
            this.NotesAreaScrollbar.Maximum = 0;
            this.NotesAreaScrollbar.Name = "NotesAreaScrollbar";
            this.NotesAreaScrollbar.Size = new System.Drawing.Size(17, 427);
            this.NotesAreaScrollbar.TabIndex = 1;
            this.NotesAreaScrollbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NotesAreaScrollbar_Scroll);
            // 
            // NotesArea
            // 
            this.NotesArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotesArea.Location = new System.Drawing.Point(69, 0);
            this.NotesArea.Name = "NotesArea";
            this.NotesArea.Size = new System.Drawing.Size(619, 474);
            this.NotesArea.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(3, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 408);
            this.panel2.TabIndex = 3;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(176)))), ((int)(((byte)(216)))));
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(60, 60);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Text = "=";
            this.MenuButton.UseVisualStyleBackColor = false;
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(708, 475);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.NotesAreaScrollbar);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NotesArea);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.NotesForm_Resize_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.VScrollBar NotesAreaScrollbar;
        private System.Windows.Forms.Panel NotesArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MenuButton;
    }
}

