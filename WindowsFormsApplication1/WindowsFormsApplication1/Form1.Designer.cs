namespace WindowsFormsApplication1
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(29, 74);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(94, 32);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "C";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(175, 74);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(94, 33);
            this.btn_Read.TabIndex = 1;
            this.btn_Read.Text = "R";
            this.btn_Read.UseVisualStyleBackColor = true;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(29, 156);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(94, 32);
            this.btn_Upload.TabIndex = 2;
            this.btn_Upload.Text = "U";
            this.btn_Upload.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(175, 156);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 32);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "D";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 261);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Delete;
    }
}

