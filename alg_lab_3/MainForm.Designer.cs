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
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(96, 161);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(380, 22);
            this.DataTextBox.TabIndex = 0;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(307, 71);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(239, 22);
            this.KeyTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(96, 189);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Record";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DataLabel
            // 
            this.DataLabel.Location = new System.Drawing.Point(96, 140);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(190, 21);
            this.DataLabel.TabIndex = 3;
            this.DataLabel.Text = "Your data:";
            // 
            // IndexLabel
            // 
            this.IndexLabel.Location = new System.Drawing.Point(307, 54);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(175, 17);
            this.IndexLabel.TabIndex = 4;
            this.IndexLabel.Text = "Index of data:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(97, 235);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(133, 40);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete Record";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(97, 352);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(132, 40);
            this.ShowAllButton.TabIndex = 6;
            this.ShowAllButton.Text = "Show All Data";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += ShowAllButton_Click;

            // 
            // RecordsListBox
            // 
            this.RecordsListBox.FormattingEnabled = true;
            this.RecordsListBox.ItemHeight = 16;
            this.RecordsListBox.Location = new System.Drawing.Point(318, 292);
            this.RecordsListBox.Name = "RecordsListBox";
            this.RecordsListBox.Size = new System.Drawing.Size(401, 100);
            this.RecordsListBox.TabIndex = 7;
            // 
            // PopulateButton
            // 
            this.PopulateButton.Location = new System.Drawing.Point(611, 112);
            this.PopulateButton.Name = "PopulateButton";
            this.PopulateButton.Size = new System.Drawing.Size(107, 28);
            this.PopulateButton.TabIndex = 8;
            this.PopulateButton.Text = "Populate";
            this.PopulateButton.UseVisualStyleBackColor = true;
            this.PopulateButton.Click += PopulateButton_Click;
            // 
            // MeasureComp
            // 
            this.MeasureComp.Location = new System.Drawing.Point(611, 155);
            this.MeasureComp.Name = "MeasureComp";
            this.MeasureComp.Size = new System.Drawing.Size(107, 27);
            this.MeasureComp.TabIndex = 9;
            this.MeasureComp.Text = "Measure";
            this.MeasureComp.UseVisualStyleBackColor = true;
            this.MeasureComp.Click += MeasureButton_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button MeasureComp;

        private System.Windows.Forms.Button PopulateButton;

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.ListBox RecordsListBox;

        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label IndexLabel;

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.TextBox KeyTextBox;

        private System.Windows.Forms.TextBox DataTextBox;

        #endregion
    }
}