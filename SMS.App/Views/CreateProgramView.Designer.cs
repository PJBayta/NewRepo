namespace SMS.App.Views
{
    partial class CreateProgramView
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
            buttonCreate = new Button();
            label3 = new Label();
            textBoxID = new TextBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label1 = new Label();
            textBoxProgramName = new TextBox();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(165, 235);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(184, 23);
            buttonCreate.TabIndex = 13;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 76);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 12;
            label3.Text = "I.D.";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(165, 94);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(184, 23);
            textBoxID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 169);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(165, 187);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(184, 23);
            textBoxDescription.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 121);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 8;
            label1.Text = "Program Name";
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(165, 139);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(184, 23);
            textBoxProgramName.TabIndex = 7;
            // 
            // CreateProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 335);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxProgramName);
            Name = "CreateProgramView";
            Text = "Add Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private Label label3;
        private TextBox textBoxID;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label1;
        private TextBox textBoxProgramName;
    }
}