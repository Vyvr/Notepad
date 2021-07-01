
namespace Notatnik
{
    partial class FormConfig
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
            this.buttonConfigTextColor = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfigBackground = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConfigFontSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text color";
            // 
            // buttonConfigTextColor
            // 
            this.buttonConfigTextColor.Location = new System.Drawing.Point(125, 25);
            this.buttonConfigTextColor.Name = "buttonConfigTextColor";
            this.buttonConfigTextColor.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigTextColor.TabIndex = 1;
            this.buttonConfigTextColor.UseVisualStyleBackColor = true;
            this.buttonConfigTextColor.Click += new System.EventHandler(this.buttonConfigTextColor_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 214);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(220, 144);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background color";
            // 
            // buttonConfigBackground
            // 
            this.buttonConfigBackground.Location = new System.Drawing.Point(125, 79);
            this.buttonConfigBackground.Name = "buttonConfigBackground";
            this.buttonConfigBackground.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigBackground.TabIndex = 4;
            this.buttonConfigBackground.UseVisualStyleBackColor = true;
            this.buttonConfigBackground.Click += new System.EventHandler(this.buttonConfigBackground_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font";
            // 
            // buttonConfigFontSize
            // 
            this.buttonConfigFontSize.AutoSize = true;
            this.buttonConfigFontSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConfigFontSize.Location = new System.Drawing.Point(125, 134);
            this.buttonConfigFontSize.Name = "buttonConfigFontSize";
            this.buttonConfigFontSize.Size = new System.Drawing.Size(34, 23);
            this.buttonConfigFontSize.TabIndex = 6;
            this.buttonConfigFontSize.Text = "test";
            this.buttonConfigFontSize.UseVisualStyleBackColor = true;
            this.buttonConfigFontSize.Click += new System.EventHandler(this.buttonConfigFontSize_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 386);
            this.Controls.Add(this.buttonConfigFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfigBackground);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonConfigTextColor);
            this.Controls.Add(this.label1);
            this.Name = "FormConfig";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfigTextColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfigBackground;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfigFontSize;
    }
}