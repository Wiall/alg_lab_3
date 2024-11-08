using System;
using System.ComponentModel;

namespace alg_lab_3
{
    partial class Visualisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualisation));
            this.indexDataGridView = new System.Windows.Forms.DataGridView();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.indexDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // indexDataGridView
            // 
            this.indexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexDataGridView.Location = new System.Drawing.Point(65, 27);
            this.indexDataGridView.Name = "indexDataGridView";
            this.indexDataGridView.RowTemplate.Height = 24;
            this.indexDataGridView.Size = new System.Drawing.Size(274, 325);
            this.indexDataGridView.TabIndex = 2;
            // 
            // dataDataGridView
            // 
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Location = new System.Drawing.Point(421, 27);
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.RowTemplate.Height = 24;
            this.dataDataGridView.Size = new System.Drawing.Size(273, 92);
            this.dataDataGridView.TabIndex = 3;
            // 
            // Visualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 391);
            this.Controls.Add(this.dataDataGridView);
            this.Controls.Add(this.indexDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visualisation";
            this.Text = "Visualisation";
            ((System.ComponentModel.ISupportInitialize)(this.indexDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataDataGridView;

        private System.Windows.Forms.DataGridView indexDataGridView;

        #endregion
    }
}