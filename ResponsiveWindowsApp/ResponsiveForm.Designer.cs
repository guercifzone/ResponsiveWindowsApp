namespace ResponsiveWindowsApp
{
    partial class ResponsiveForm
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
            this.Responsivelabel = new System.Windows.Forms.Label();
            this.ResponsiveTextBox = new System.Windows.Forms.TextBox();
            this.ResponsiveDataGridView = new System.Windows.Forms.DataGridView();
            this.ResponsiveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Responsivelabel
            // 
            this.Responsivelabel.AutoSize = true;
            this.Responsivelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsivelabel.Location = new System.Drawing.Point(540, 114);
            this.Responsivelabel.Name = "Responsivelabel";
            this.Responsivelabel.Size = new System.Drawing.Size(221, 31);
            this.Responsivelabel.TabIndex = 0;
            this.Responsivelabel.Text = "Responsive label";
            // 
            // ResponsiveTextBox
            // 
            this.ResponsiveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsiveTextBox.Location = new System.Drawing.Point(596, 333);
            this.ResponsiveTextBox.Name = "ResponsiveTextBox";
            this.ResponsiveTextBox.Size = new System.Drawing.Size(244, 38);
            this.ResponsiveTextBox.TabIndex = 1;
            // 
            // ResponsiveDataGridView
            // 
            this.ResponsiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResponsiveDataGridView.Location = new System.Drawing.Point(41, 74);
            this.ResponsiveDataGridView.Name = "ResponsiveDataGridView";
            this.ResponsiveDataGridView.Size = new System.Drawing.Size(465, 273);
            this.ResponsiveDataGridView.TabIndex = 2;
            // 
            // ResponsiveButton
            // 
            this.ResponsiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsiveButton.Location = new System.Drawing.Point(275, 439);
            this.ResponsiveButton.Name = "ResponsiveButton";
            this.ResponsiveButton.Size = new System.Drawing.Size(465, 72);
            this.ResponsiveButton.TabIndex = 3;
            this.ResponsiveButton.Text = "Click";
            this.ResponsiveButton.UseVisualStyleBackColor = true;
            // 
            // ResponsiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 724);
            this.Controls.Add(this.ResponsiveButton);
            this.Controls.Add(this.ResponsiveDataGridView);
            this.Controls.Add(this.ResponsiveTextBox);
            this.Controls.Add(this.Responsivelabel);
            this.Name = "ResponsiveForm";
            this.Text = "Responsive Form";
            this.Load += new System.EventHandler(this.ResponsiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResponsiveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Responsivelabel;
        private System.Windows.Forms.TextBox ResponsiveTextBox;
        private System.Windows.Forms.DataGridView ResponsiveDataGridView;
        private System.Windows.Forms.Button ResponsiveButton;
    }
}

