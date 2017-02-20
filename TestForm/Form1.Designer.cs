namespace TestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcuteApi = new System.Windows.Forms.Button();
            this.btnInheritance = new System.Windows.Forms.Button();
            this.btnLinq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcuteApi
            // 
            this.btnExcuteApi.Location = new System.Drawing.Point(172, 44);
            this.btnExcuteApi.Name = "btnExcuteApi";
            this.btnExcuteApi.Size = new System.Drawing.Size(75, 23);
            this.btnExcuteApi.TabIndex = 1;
            this.btnExcuteApi.Text = "Get Json";
            this.btnExcuteApi.UseVisualStyleBackColor = true;
            this.btnExcuteApi.Click += new System.EventHandler(this.btnExcuteApi_Click);
            // 
            // btnInheritance
            // 
            this.btnInheritance.Location = new System.Drawing.Point(39, 85);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(100, 23);
            this.btnInheritance.TabIndex = 2;
            this.btnInheritance.Text = "TestInheritance";
            this.btnInheritance.UseVisualStyleBackColor = true;
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // btnLinq
            // 
            this.btnLinq.Location = new System.Drawing.Point(172, 85);
            this.btnLinq.Name = "btnLinq";
            this.btnLinq.Size = new System.Drawing.Size(75, 23);
            this.btnLinq.TabIndex = 3;
            this.btnLinq.Text = "Linq";
            this.btnLinq.UseVisualStyleBackColor = true;
            this.btnLinq.Click += new System.EventHandler(this.btnLinq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLinq);
            this.Controls.Add(this.btnInheritance);
            this.Controls.Add(this.btnExcuteApi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcuteApi;
        private System.Windows.Forms.Button btnInheritance;
        private System.Windows.Forms.Button btnLinq;
    }
}

