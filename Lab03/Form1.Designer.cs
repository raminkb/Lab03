namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxBirhtY = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMajor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxNumS = new System.Windows.Forms.TextBox();
            this.maxGPA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(123, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birth year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "GPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Major";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(110, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxBirhtY
            // 
            this.textBoxBirhtY.Location = new System.Drawing.Point(110, 95);
            this.textBoxBirhtY.Name = "textBoxBirhtY";
            this.textBoxBirhtY.Size = new System.Drawing.Size(125, 27);
            this.textBoxBirhtY.TabIndex = 9;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(110, 128);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(125, 27);
            this.textBoxHeight.TabIndex = 10;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(110, 161);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxGPA.TabIndex = 11;
            // 
            // textBoxMajor
            // 
            this.textBoxMajor.Location = new System.Drawing.Point(110, 198);
            this.textBoxMajor.Name = "textBoxMajor";
            this.textBoxMajor.Size = new System.Drawing.Size(125, 27);
            this.textBoxMajor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnID,
            this.ColumnBY,
            this.ColumnH,
            this.ColumnGPA,
            this.ColumnMajor});
            this.dataGridView1.Location = new System.Drawing.Point(241, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(531, 282);
            this.dataGridView1.TabIndex = 13;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnName.Width = 125;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 125;
            // 
            // ColumnBY
            // 
            this.ColumnBY.DataPropertyName = "Birthyear";
            this.ColumnBY.HeaderText = "Birth year";
            this.ColumnBY.MinimumWidth = 6;
            this.ColumnBY.Name = "ColumnBY";
            this.ColumnBY.Width = 125;
            // 
            // ColumnH
            // 
            this.ColumnH.DataPropertyName = "Height";
            this.ColumnH.HeaderText = "Height";
            this.ColumnH.MinimumWidth = 6;
            this.ColumnH.Name = "ColumnH";
            this.ColumnH.Width = 125;
            // 
            // ColumnGPA
            // 
            this.ColumnGPA.DataPropertyName = "GPA";
            this.ColumnGPA.HeaderText = "GPA";
            this.ColumnGPA.MinimumWidth = 6;
            this.ColumnGPA.Name = "ColumnGPA";
            this.ColumnGPA.Width = 125;
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.DataPropertyName = "Major";
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.MinimumWidth = 6;
            this.ColumnMajor.Name = "ColumnMajor";
            this.ColumnMajor.Width = 125;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(241, 334);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxGPA.TabIndex = 14;
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(454, 334);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinGPA.TabIndex = 15;
            // 
            // textBoxNumS
            // 
            this.textBoxNumS.Location = new System.Drawing.Point(663, 334);
            this.textBoxNumS.Name = "textBoxNumS";
            this.textBoxNumS.Size = new System.Drawing.Size(125, 27);
            this.textBoxNumS.TabIndex = 16;
            // 
            // maxGPA
            // 
            this.maxGPA.AutoSize = true;
            this.maxGPA.Location = new System.Drawing.Point(167, 341);
            this.maxGPA.Name = "maxGPA";
            this.maxGPA.Size = new System.Drawing.Size(64, 20);
            this.maxGPA.TabIndex = 17;
            this.maxGPA.Text = "maxGPA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "minGPA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "NUM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxGPA);
            this.Controls.Add(this.textBoxNumS);
            this.Controls.Add(this.textBoxMinGPA);
            this.Controls.Add(this.textBoxMaxGPA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxMajor);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxBirhtY);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxID;
        private TextBox textBoxBirhtY;
        private TextBox textBoxHeight;
        private TextBox textBoxGPA;
        private TextBox textBoxMajor;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnBY;
        private DataGridViewTextBoxColumn ColumnH;
        private DataGridViewTextBoxColumn ColumnGPA;
        private DataGridViewTextBoxColumn ColumnMajor;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxMinGPA;
        private TextBox textBoxNumS;
        private Label maxGPA;
        private Label label7;
        private Label label8;
    }
}