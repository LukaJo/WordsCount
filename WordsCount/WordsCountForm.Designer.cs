namespace WordsCount
{
    partial class WordsCountForm
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
            this.rbText = new System.Windows.Forms.RadioButton();
            this.rbFajl = new System.Windows.Forms.RadioButton();
            this.rbBaza = new System.Windows.Forms.RadioButton();
            this.tbText = new System.Windows.Forms.TextBox();
            this.traziFajl = new System.Windows.Forms.OpenFileDialog();
            this.btnFajl = new System.Windows.Forms.Button();
            this.tbFajl = new System.Windows.Forms.TextBox();
            this.btnBrojReci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridIzBaze = new System.Windows.Forms.DataGridView();
            this.tbBaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzBaze)).BeginInit();
            this.SuspendLayout();
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(23, 53);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(76, 17);
            this.rbText.TabIndex = 0;
            this.rbText.TabStop = true;
            this.rbText.Text = "Unesi Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbFajl
            // 
            this.rbFajl.AutoSize = true;
            this.rbFajl.Location = new System.Drawing.Point(23, 162);
            this.rbFajl.Name = "rbFajl";
            this.rbFajl.Size = new System.Drawing.Size(84, 17);
            this.rbFajl.TabIndex = 1;
            this.rbFajl.TabStop = true;
            this.rbFajl.Text = "Ucitaj iz fajla";
            this.rbFajl.UseVisualStyleBackColor = true;
            this.rbFajl.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // rbBaza
            // 
            this.rbBaza.AutoSize = true;
            this.rbBaza.Location = new System.Drawing.Point(23, 280);
            this.rbBaza.Name = "rbBaza";
            this.rbBaza.Size = new System.Drawing.Size(88, 17);
            this.rbBaza.TabIndex = 2;
            this.rbBaza.TabStop = true;
            this.rbBaza.Text = "Ucitaj iz baze";
            this.rbBaza.UseVisualStyleBackColor = true;
            this.rbBaza.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(3, 10);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(565, 86);
            this.tbText.TabIndex = 3;
            // 
            // traziFajl
            // 
            this.traziFajl.FileName = "openFileDialog1";
            // 
            // btnFajl
            // 
            this.btnFajl.Location = new System.Drawing.Point(6, 41);
            this.btnFajl.Name = "btnFajl";
            this.btnFajl.Size = new System.Drawing.Size(123, 23);
            this.btnFajl.TabIndex = 4;
            this.btnFajl.Text = "Izaberi fajl";
            this.btnFajl.UseVisualStyleBackColor = true;
            this.btnFajl.Click += new System.EventHandler(this.btnFajl_Click);
            // 
            // tbFajl
            // 
            this.tbFajl.Location = new System.Drawing.Point(147, 10);
            this.tbFajl.Multiline = true;
            this.tbFajl.Name = "tbFajl";
            this.tbFajl.Size = new System.Drawing.Size(421, 86);
            this.tbFajl.TabIndex = 5;
            // 
            // btnBrojReci
            // 
            this.btnBrojReci.Location = new System.Drawing.Point(277, 475);
            this.btnBrojReci.Name = "btnBrojReci";
            this.btnBrojReci.Size = new System.Drawing.Size(127, 23);
            this.btnBrojReci.TabIndex = 7;
            this.btnBrojReci.Text = "Prebroj broj reci";
            this.btnBrojReci.UseVisualStyleBackColor = true;
            this.btnBrojReci.Click += new System.EventHandler(this.btnBrojReci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbText);
            this.groupBox1.Location = new System.Drawing.Point(130, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFajl);
            this.groupBox2.Controls.Add(this.tbFajl);
            this.groupBox2.Location = new System.Drawing.Point(130, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 102);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridIzBaze);
            this.groupBox3.Controls.Add(this.tbBaza);
            this.groupBox3.Location = new System.Drawing.Point(130, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 231);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // gridIzBaze
            // 
            this.gridIzBaze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIzBaze.Location = new System.Drawing.Point(3, 10);
            this.gridIzBaze.Name = "gridIzBaze";
            this.gridIzBaze.RowHeadersVisible = false;
            this.gridIzBaze.Size = new System.Drawing.Size(565, 123);
            this.gridIzBaze.TabIndex = 12;
            this.gridIzBaze.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIzBaze_CellEnter);
            // 
            // tbBaza
            // 
            this.tbBaza.Location = new System.Drawing.Point(3, 139);
            this.tbBaza.Multiline = true;
            this.tbBaza.Name = "tbBaza";
            this.tbBaza.Size = new System.Drawing.Size(565, 86);
            this.tbBaza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(343, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broj reči:";
            // 
            // WordsCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrojReci);
            this.Controls.Add(this.rbBaza);
            this.Controls.Add(this.rbFajl);
            this.Controls.Add(this.rbText);
            this.MinimumSize = new System.Drawing.Size(732, 489);
            this.Name = "WordsCountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordsCount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIzBaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbFajl;
        private System.Windows.Forms.RadioButton rbBaza;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.OpenFileDialog traziFajl;
        private System.Windows.Forms.Button btnFajl;
        private System.Windows.Forms.TextBox tbFajl;
        private System.Windows.Forms.Button btnBrojReci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridIzBaze;
    }
}

