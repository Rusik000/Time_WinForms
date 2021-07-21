namespace WindowsFormsApp3
{
    partial class Form1
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
            this.Baku = new System.Windows.Forms.Button();
            this.England = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baku
            // 
            this.Baku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baku.Location = new System.Drawing.Point(261, 177);
            this.Baku.Margin = new System.Windows.Forms.Padding(6);
            this.Baku.Name = "Baku";
            this.Baku.Size = new System.Drawing.Size(289, 122);
            this.Baku.TabIndex = 0;
            this.Baku.Text = "Baku";
            this.Baku.UseVisualStyleBackColor = true;
            this.Baku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_click);
            // 
            // England
            // 
            this.England.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.England.Location = new System.Drawing.Point(741, 177);
            this.England.Margin = new System.Windows.Forms.Padding(6);
            this.England.Name = "England";
            this.England.Size = new System.Drawing.Size(306, 122);
            this.England.TabIndex = 1;
            this.England.Text = "London";
            this.England.UseVisualStyleBackColor = true;
            this.England.Click += new System.EventHandler(this.England_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.England);
            this.Controls.Add(this.Baku);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Task1";
            this.Click += new System.EventHandler(this.Baku_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Baku;
        private System.Windows.Forms.Button England;
    }
}

