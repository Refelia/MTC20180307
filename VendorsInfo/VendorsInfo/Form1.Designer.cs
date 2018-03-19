namespace VendorsInfo
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
            this.loadDataButton = new System.Windows.Forms.Button();
            this.vendorsListdataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadDataButton
            // 
            this.loadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDataButton.Location = new System.Drawing.Point(364, 410);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(89, 35);
            this.loadDataButton.TabIndex = 0;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // vendorsListdataGridView
            // 
            this.vendorsListdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorsListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsListdataGridView.Location = new System.Drawing.Point(51, 42);
            this.vendorsListdataGridView.Name = "vendorsListdataGridView";
            this.vendorsListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorsListdataGridView.Size = new System.Drawing.Size(798, 364);
            this.vendorsListdataGridView.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(459, 412);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 35);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 457);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.vendorsListdataGridView);
            this.Controls.Add(this.loadDataButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List of vendors";
            ((System.ComponentModel.ISupportInitialize)(this.vendorsListdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.DataGridView vendorsListdataGridView;
        private System.Windows.Forms.Button exitButton;
    }
}

