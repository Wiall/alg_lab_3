using System.ComponentModel;

namespace alg_lab_3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DataLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.RecordsListBox = new System.Windows.Forms.ListBox();
            this.PopulateButton = new System.Windows.Forms.Button();
            this.MeasureComp = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowData = new System.Windows.Forms.Button();
            this.VisualizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataTextBox.Location = new System.Drawing.Point(241, 107);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(380, 22);
            this.DataTextBox.TabIndex = 0;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyTextBox.Location = new System.Drawing.Point(37, 107);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(198, 22);
            this.KeyTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddButton.Location = new System.Drawing.Point(37, 181);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(198, 48);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseMnemonic = false;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DataLabel
            // 
            this.DataLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(241, 86);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(119, 21);
            this.DataLabel.TabIndex = 3;
            this.DataLabel.Text = "Your data:";
            // 
            // IndexLabel
            // 
            this.IndexLabel.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexLabel.Location = new System.Drawing.Point(37, 86);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(177, 21);
            this.IndexLabel.TabIndex = 4;
            this.IndexLabel.Text = "Index of data:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Location = new System.Drawing.Point(37, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(198, 48);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete Record";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowAllButton.BackgroundImage")));
            this.ShowAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowAllButton.FlatAppearance.BorderSize = 0;
            this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.ShowAllButton.Location = new System.Drawing.Point(241, 289);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(198, 48);
            this.ShowAllButton.TabIndex = 6;
            this.ShowAllButton.Text = "Show All Data";
            this.ShowAllButton.UseVisualStyleBackColor = false;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // RecordsListBox
            // 
            this.RecordsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsListBox.FormattingEnabled = true;
            this.RecordsListBox.ItemHeight = 16;
            this.RecordsListBox.Location = new System.Drawing.Point(458, 181);
            this.RecordsListBox.Name = "RecordsListBox";
            this.RecordsListBox.Size = new System.Drawing.Size(284, 240);
            this.RecordsListBox.TabIndex = 7;
            // 
            // PopulateButton
            // 
            this.PopulateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PopulateButton.BackgroundImage")));
            this.PopulateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PopulateButton.FlatAppearance.BorderSize = 0;
            this.PopulateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopulateButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopulateButton.ForeColor = System.Drawing.Color.Transparent;
            this.PopulateButton.Location = new System.Drawing.Point(322, 381);
            this.PopulateButton.Name = "PopulateButton";
            this.PopulateButton.Size = new System.Drawing.Size(117, 32);
            this.PopulateButton.TabIndex = 8;
            this.PopulateButton.Text = "Populate";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += new System.EventHandler(this.PopulateButton_Click);
            // 
            // MeasureComp
            // 
            this.MeasureComp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MeasureComp.BackgroundImage")));
            this.MeasureComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeasureComp.FlatAppearance.BorderSize = 0;
            this.MeasureComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeasureComp.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasureComp.ForeColor = System.Drawing.Color.Transparent;
            this.MeasureComp.Location = new System.Drawing.Point(322, 343);
            this.MeasureComp.Name = "MeasureComp";
            this.MeasureComp.Size = new System.Drawing.Size(117, 32);
            this.MeasureComp.TabIndex = 9;
            this.MeasureComp.Text = "Measure";
            this.MeasureComp.UseVisualStyleBackColor = true;
            this.MeasureComp.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.Transparent;
            this.EditButton.Location = new System.Drawing.Point(241, 181);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(198, 48);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Edit Record";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteAllButton
            // 
            this.DeleteAllButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteAllButton.BackgroundImage")));
            this.DeleteAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteAllButton.FlatAppearance.BorderSize = 0;
            this.DeleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAllButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteAllButton.Location = new System.Drawing.Point(241, 235);
            this.DeleteAllButton.Name = "DeleteAllButton";
            this.DeleteAllButton.Size = new System.Drawing.Size(198, 48);
            this.DeleteAllButton.TabIndex = 11;
            this.DeleteAllButton.Text = "Delete All";
            this.DeleteAllButton.UseVisualStyleBackColor = false;
            this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 68);
            this.label1.TabIndex = 12;
            this.label1.Text = "My DBMS";
            // 
            // ShowData
            // 
            this.ShowData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowData.BackgroundImage")));
            this.ShowData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowData.FlatAppearance.BorderSize = 0;
            this.ShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowData.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowData.ForeColor = System.Drawing.Color.Transparent;
            this.ShowData.Location = new System.Drawing.Point(37, 289);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(198, 48);
            this.ShowData.TabIndex = 13;
            this.ShowData.Text = "Show Data";
            this.ShowData.UseVisualStyleBackColor = false;
            this.ShowData.Click += new System.EventHandler(this.ShowDataButton_Click);
            // 
            // VisualizeButton
            // 
            this.VisualizeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VisualizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VisualizeButton.BackgroundImage")));
            this.VisualizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisualizeButton.FlatAppearance.BorderSize = 0;
            this.VisualizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizeButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisualizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.VisualizeButton.Location = new System.Drawing.Point(37, 343);
            this.VisualizeButton.Name = "VisualizeButton";
            this.VisualizeButton.Size = new System.Drawing.Size(198, 48);
            this.VisualizeButton.TabIndex = 14;
            this.VisualizeButton.Text = "Visualize";
            this.VisualizeButton.UseVisualStyleBackColor = false;
            this.VisualizeButton.Click += new System.EventHandler(this.VisualizeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 459);
            this.Controls.Add(this.VisualizeButton);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteAllButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MeasureComp);
            this.Controls.Add(this.PopulateButton);
            this.Controls.Add(this.RecordsListBox);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.DataTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button VisualizeButton;

        private System.Windows.Forms.Button ShowData;

        private System.Windows.Forms.Label label1;


        private System.Windows.Forms.Button DeleteAllButton;

        private System.Windows.Forms.Button EditButton;

        private System.Windows.Forms.Button MeasureComp;

        private System.Windows.Forms.Button PopulateButton;

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.ListBox RecordsListBox;

        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label IndexLabel;

        public System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.TextBox KeyTextBox;

        private System.Windows.Forms.TextBox DataTextBox;

        #endregion
    }
}