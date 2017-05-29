namespace Notes
{
    partial class NoteControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteControl));
            this.NoteText = new System.Windows.Forms.Label();
            this.ShareButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExpandButton = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // NoteText
            // 
            this.NoteText.AutoSize = true;
            this.NoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteText.Location = new System.Drawing.Point(0, 0);
            this.NoteText.Margin = new System.Windows.Forms.Padding(3);
            this.NoteText.MaximumSize = new System.Drawing.Size(215, 0);
            this.NoteText.Name = "NoteText";
            this.NoteText.Padding = new System.Windows.Forms.Padding(5);
            this.NoteText.Size = new System.Drawing.Size(212, 231);
            this.NoteText.TabIndex = 1;
            this.NoteText.Text = resources.GetString("NoteText.Text");
            this.NoteText.Click += new System.EventHandler(this.Text_Click);
            // 
            // ShareButton
            // 
            this.ShareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShareButton.FlatAppearance.BorderSize = 0;
            this.ShareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShareButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShareButton.Image = global::Notes.Properties.Resources.share_32;
            this.ShareButton.Location = new System.Drawing.Point(215, 35);
            this.ShareButton.Name = "ShareButton";
            this.ShareButton.Size = new System.Drawing.Size(35, 35);
            this.ShareButton.TabIndex = 3;
            this.toolTips.SetToolTip(this.ShareButton, "Share");
            this.ShareButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = global::Notes.Properties.Resources.Edit_32;
            this.EditButton.Location = new System.Drawing.Point(215, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(35, 35);
            this.EditButton.TabIndex = 0;
            this.toolTips.SetToolTip(this.EditButton, "Edit");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ExpandButton
            // 
            this.ExpandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandButton.FlatAppearance.BorderSize = 0;
            this.ExpandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpandButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExpandButton.Image = global::Notes.Properties.Resources.ellipsis16;
            this.ExpandButton.Location = new System.Drawing.Point(215, 178);
            this.ExpandButton.Name = "ExpandButton";
            this.ExpandButton.Size = new System.Drawing.Size(35, 35);
            this.ExpandButton.TabIndex = 2;
            this.toolTips.SetToolTip(this.ExpandButton, "Expand");
            this.ExpandButton.UseVisualStyleBackColor = true;
            this.ExpandButton.Click += new System.EventHandler(this.ExpandButton_Click);
            // 
            // NoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(154)))));
            this.Controls.Add(this.ShareButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ExpandButton);
            this.Controls.Add(this.NoteText);
            this.MinimumSize = new System.Drawing.Size(0, 70);
            this.Name = "NoteControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(250, 213);
            this.Resize += new System.EventHandler(this.NoteControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label NoteText;
        private System.Windows.Forms.Button ExpandButton;
        private System.Windows.Forms.Button ShareButton;
        private System.Windows.Forms.ToolTip toolTips;
    }
}
