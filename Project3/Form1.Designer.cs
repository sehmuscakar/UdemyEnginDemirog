namespace Project3
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
            this.dgrdwCustomers = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirtstName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwCustomers)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrdwCustomers
            // 
            this.dgrdwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdwCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrdwCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgrdwCustomers.Name = "dgrdwCustomers";
            this.dgrdwCustomers.RowHeadersWidth = 51;
            this.dgrdwCustomers.RowTemplate.Height = 24;
            this.dgrdwCustomers.Size = new System.Drawing.Size(951, 330);
            this.dgrdwCustomers.TabIndex = 0;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxCity);
            this.gbxAdd.Controls.Add(this.tbxEmail);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Controls.Add(this.tbxFirstName);
            this.gbxAdd.Controls.Add(this.tbxId);
            this.gbxAdd.Controls.Add(this.lblEmail);
            this.gbxAdd.Controls.Add(this.lblCity);
            this.gbxAdd.Controls.Add(this.lblLastName);
            this.gbxAdd.Controls.Add(this.lblFirtstName);
            this.gbxAdd.Controls.Add(this.lblId);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(178, 348);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(454, 331);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCity.Location = new System.Drawing.Point(125, 197);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(167, 30);
            this.tbxCity.TabIndex = 21;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.Location = new System.Drawing.Point(125, 149);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(167, 30);
            this.tbxEmail.TabIndex = 20;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(125, 106);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(167, 30);
            this.tbxLastName.TabIndex = 19;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(125, 66);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(167, 30);
            this.tbxFirstName.TabIndex = 18;
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxId.Location = new System.Drawing.Point(125, 27);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(167, 30);
            this.tbxId.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(11, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(11, 200);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 25);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Location = new System.Drawing.Point(11, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(101, 25);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirtstName
            // 
            this.lblFirtstName.AutoSize = true;
            this.lblFirtstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirtstName.Location = new System.Drawing.Point(11, 65);
            this.lblFirtstName.Name = "lblFirtstName";
            this.lblFirtstName.Size = new System.Drawing.Size(101, 25);
            this.lblFirtstName.TabIndex = 13;
            this.lblFirtstName.Text = "FirstName";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(11, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 25);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 707);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgrdwCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdwCustomers)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdwCustomers;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirtstName;
        private System.Windows.Forms.Label lblId;
    }
}

