namespace SMS.App
{
    partial class ProgramView
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
            textBoxProgramName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            textBoxID = new TextBox();
            buttonCreate = new Button();
            buttonRead = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dataGridViewProgramList = new DataGridView();
            textBoxSearch = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(26, 119);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(184, 23);
            textBoxProgramName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 101);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 149);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(26, 167);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(184, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 56);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 5;
            label3.Text = "I.D.";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(26, 74);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(184, 23);
            textBoxID.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(26, 215);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(184, 23);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(26, 244);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(184, 23);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(26, 273);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(184, 23);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(26, 302);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(184, 23);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(240, 74);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.Size = new Size(423, 251);
            dataGridViewProgramList.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(479, 33);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(184, 23);
            textBoxSearch.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 9);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Filter";
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 382);
            Controls.Add(label4);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRead);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxProgramName);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            Load += ProgramView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramName;
        private Label label1;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private TextBox textBoxID;
        private Button buttonCreate;
        private Button buttonRead;
        private Button buttonUpdate;
        private Button buttonDelete;
        private DataGridView dataGridViewProgramList;
        private TextBox textBoxSearch;
        private Label label4;
    }
}