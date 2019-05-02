namespace DisconnectedDemo
{
    partial class Form3
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
            this.dgEmp = new System.Windows.Forms.DataGridView();
            this.btnFinalChanges = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmp
            // 
            this.dgEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmp.Location = new System.Drawing.Point(119, 132);
            this.dgEmp.Name = "dgEmp";
            this.dgEmp.Size = new System.Drawing.Size(733, 319);
            this.dgEmp.TabIndex = 0;
            // 
            // btnFinalChanges
            // 
            this.btnFinalChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalChanges.Location = new System.Drawing.Point(951, 60);
            this.btnFinalChanges.Name = "btnFinalChanges";
            this.btnFinalChanges.Size = new System.Drawing.Size(168, 40);
            this.btnFinalChanges.TabIndex = 1;
            this.btnFinalChanges.Text = "Final Changes";
            this.btnFinalChanges.UseVisualStyleBackColor = true;
            this.btnFinalChanges.Click += new System.EventHandler(this.btnFinalChanges_Click);
            // 
            // btnXml
            // 
            this.btnXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXml.Location = new System.Drawing.Point(951, 151);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(168, 40);
            this.btnXml.TabIndex = 2;
            this.btnXml.Text = "Write XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 565);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnFinalChanges);
            this.Controls.Add(this.dgEmp);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmp;
        private System.Windows.Forms.Button btnFinalChanges;
        private System.Windows.Forms.Button btnXml;
    }
}