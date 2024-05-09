namespace multimedia_finalProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.XRayPictureBox = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.XRayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MultiMedia-project";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "insert x-ray image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // XRayPictureBox
            // 
            this.XRayPictureBox.Location = new System.Drawing.Point(222, 45);
            this.XRayPictureBox.Name = "XRayPictureBox";
            this.XRayPictureBox.Size = new System.Drawing.Size(834, 447);
            this.XRayPictureBox.TabIndex = 2;
            this.XRayPictureBox.TabStop = false;
            this.XRayPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.XRayPictureBox_MouseClick);
            this.XRayPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XRayPictureBox_MouseMove_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(77, 252);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 582);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.XRayPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultimediaProject";
            ((System.ComponentModel.ISupportInitialize)(this.XRayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox XRayPictureBox;
        private System.Windows.Forms.ListView listView1;
    }
}

