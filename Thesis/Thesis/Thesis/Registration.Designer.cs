namespace Thesis
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.txt_studentnumber = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_studentname = new System.Windows.Forms.TextBox();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_studentnumber
            // 
            this.txt_studentnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentnumber.Location = new System.Drawing.Point(315, 136);
            this.txt_studentnumber.Name = "txt_studentnumber";
            this.txt_studentnumber.Size = new System.Drawing.Size(160, 24);
            this.txt_studentnumber.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(241, 174);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(160, 24);
            this.txt_password.TabIndex = 4;
            // 
            // txt_studentname
            // 
            this.txt_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_studentname.Location = new System.Drawing.Point(282, 212);
            this.txt_studentname.Name = "txt_studentname";
            this.txt_studentname.Size = new System.Drawing.Size(160, 24);
            this.txt_studentname.TabIndex = 5;
            // 
            // txt_course
            // 
            this.txt_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.Location = new System.Drawing.Point(193, 304);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(160, 24);
            this.txt_course.TabIndex = 6;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(606, 366);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(122, 40);
            this.btn_signup.TabIndex = 7;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_studentname);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_studentnumber);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_studentnumber;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_studentname;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Button btn_signup;
    }
}