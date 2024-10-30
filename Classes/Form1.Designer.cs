namespace Classes
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
            this.lbxStudent = new System.Windows.Forms.ListBox();
            this.dgrwStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudent
            // 
            this.lbxStudent.FormattingEnabled = true;
            this.lbxStudent.ItemHeight = 16;
            this.lbxStudent.Location = new System.Drawing.Point(50, 92);
            this.lbxStudent.Name = "lbxStudent";
            this.lbxStudent.Size = new System.Drawing.Size(225, 260);
            this.lbxStudent.TabIndex = 0;
            // 
            // dgrwStudent
            // 
            this.dgrwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudent.Location = new System.Drawing.Point(322, 92);
            this.dgrwStudent.Name = "dgrwStudent";
            this.dgrwStudent.RowHeadersWidth = 51;
            this.dgrwStudent.RowTemplate.Height = 24;
            this.dgrwStudent.Size = new System.Drawing.Size(403, 238);
            this.dgrwStudent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrwStudent);
            this.Controls.Add(this.lbxStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudent;
        private System.Windows.Forms.DataGridView dgrwStudent;
    }
}

