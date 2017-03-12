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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteControl));
            this.Text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.Location = new System.Drawing.Point(8, 8);
            this.Text.MaximumSize = new System.Drawing.Size(200, 0);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(198, 221);
            this.Text.TabIndex = 1;
            this.Text.Text = resources.GetString("Text.Text");
            this.Text.Click += new System.EventHandler(this.Text_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Notes.Properties.Resources.ellipsis16;
            this.button1.Location = new System.Drawing.Point(8, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Image = global::Notes.Properties.Resources.edit32;
            this.EditButton.Location = new System.Drawing.Point(212, 8);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(30, 30);
            this.EditButton.TabIndex = 0;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // NoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(234)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text);
            this.Name = "NoteControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(250, 200);
            this.Resize += new System.EventHandler(this.NoteControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Button button1;
    }
}
