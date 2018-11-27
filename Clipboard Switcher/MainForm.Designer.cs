namespace Clipboard_Switcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.withBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceButtom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foundCount = new System.Windows.Forms.Label();
            this.previewButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // replaceBox
            // 
            this.replaceBox.Location = new System.Drawing.Point(79, 29);
            this.replaceBox.Multiline = true;
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(187, 20);
            this.replaceBox.TabIndex = 0;
            this.replaceBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // withBox
            // 
            this.withBox.Location = new System.Drawing.Point(79, 66);
            this.withBox.Multiline = true;
            this.withBox.Name = "withBox";
            this.withBox.Size = new System.Drawing.Size(187, 20);
            this.withBox.TabIndex = 1;
            this.withBox.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Replace:";
            // 
            // replaceButtom
            // 
            this.replaceButtom.Location = new System.Drawing.Point(79, 102);
            this.replaceButtom.Name = "replaceButtom";
            this.replaceButtom.Size = new System.Drawing.Size(186, 23);
            this.replaceButtom.TabIndex = 3;
            this.replaceButtom.Text = "Replace In Clipboard";
            this.replaceButtom.UseVisualStyleBackColor = true;
            this.replaceButtom.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "With:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Found:";
            // 
            // foundCount
            // 
            this.foundCount.AutoSize = true;
            this.foundCount.Location = new System.Drawing.Point(325, 50);
            this.foundCount.Name = "foundCount";
            this.foundCount.Size = new System.Drawing.Size(0, 13);
            this.foundCount.TabIndex = 7;
            // 
            // previewButtom
            // 
            this.previewButtom.Location = new System.Drawing.Point(307, 126);
            this.previewButtom.Name = "previewButtom";
            this.previewButtom.Size = new System.Drawing.Size(75, 23);
            this.previewButtom.TabIndex = 8;
            this.previewButtom.Text = "Preview>>";
            this.previewButtom.UseVisualStyleBackColor = true;
            this.previewButtom.Click += new System.EventHandler(this.PreviewButtom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.previewButtom);
            this.Controls.Add(this.foundCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replaceButtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "ClipboardReplace";
            this.Activated += new System.EventHandler(this.TextBox1_TextChanged);
            this.Click += new System.EventHandler(this.UpdatePreview);
            this.Enter += new System.EventHandler(this.TextBox1_TextChanged);
            this.MouseEnter += new System.EventHandler(this.TextBox1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.TextBox withBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replaceButtom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label foundCount;
        private System.Windows.Forms.Button previewButtom;
    }
}

