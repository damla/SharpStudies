namespace ObjectOrientedExample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.cmbLecturer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listCourses = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dUPLICATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCourseNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(290, 45);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(213, 31);
            this.txtCourse.TabIndex = 0;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(55, 48);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(174, 25);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "COURSE NAME:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "GROUP EMAIL:\r\n";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(290, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblLecturer
            // 
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.Location = new System.Drawing.Point(55, 179);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(131, 25);
            this.lblLecturer.TabIndex = 4;
            this.lblLecturer.Text = "LECTURER:\r\n";
            // 
            // cmbLecturer
            // 
            this.cmbLecturer.FormattingEnabled = true;
            this.cmbLecturer.Location = new System.Drawing.Point(290, 179);
            this.cmbLecturer.Name = "cmbLecturer";
            this.cmbLecturer.Size = new System.Drawing.Size(213, 33);
            this.cmbLecturer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD COURSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCourses
            // 
            this.listCourses.ContextMenuStrip = this.contextMenuStrip1;
            this.listCourses.FormattingEnabled = true;
            this.listCourses.ItemHeight = 25;
            this.listCourses.Location = new System.Drawing.Point(60, 304);
            this.listCourses.Name = "listCourses";
            this.listCourses.Size = new System.Drawing.Size(443, 154);
            this.listCourses.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem,
            this.dUPLICATEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // dUPLICATEToolStripMenuItem
            // 
            this.dUPLICATEToolStripMenuItem.Name = "dUPLICATEToolStripMenuItem";
            this.dUPLICATEToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.dUPLICATEToolStripMenuItem.Text = "DUPLICATE";
            this.dUPLICATEToolStripMenuItem.Click += new System.EventHandler(this.dUPLICATEToolStripMenuItem_Click);
            // 
            // txtCourseNo
            // 
            this.txtCourseNo.Location = new System.Drawing.Point(60, 246);
            this.txtCourseNo.Name = "txtCourseNo";
            this.txtCourseNo.Size = new System.Drawing.Size(213, 31);
            this.txtCourseNo.TabIndex = 8;
            this.txtCourseNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 472);
            this.Controls.Add(this.txtCourseNo);
            this.Controls.Add(this.listCourses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLecturer);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.ComboBox cmbLecturer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listCourses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dUPLICATEToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCourseNo;
    }
}

