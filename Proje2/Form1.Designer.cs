namespace Proje2
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
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentList.Location = new System.Drawing.Point(42, 36);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(141, 25);
            this.lblStudentList.TabIndex = 0;
            this.lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 25;
            this.lbxStudentList.Location = new System.Drawing.Point(35, 87);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(228, 229);
            this.lbxStudentList.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(336, 134);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(115, 25);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStudentName.Location = new System.Drawing.Point(457, 134);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(291, 30);
            this.tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStudent.Location = new System.Drawing.Point(522, 190);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(191, 58);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Öğrenci Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(84, 333);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(191, 58);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Öğrenci Sil";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lbxStudentList);
            this.Controls.Add(this.lblStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}

