namespace LBox_Menu_Example
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pASTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.pRINTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(68, 38);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem,
            this.pASTEToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(75, 38);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(80, 38);
            this.hELPToolStripMenuItem.Text = "HELP";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            this.sAVEToolStripMenuItem.Click += new System.EventHandler(this.sAVEToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.cUTToolStripMenuItem.Text = "CUT";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.cOPYToolStripMenuItem.Text = "COPY";
            this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
            // 
            // pASTEToolStripMenuItem
            // 
            this.pASTEToolStripMenuItem.Name = "pASTEToolStripMenuItem";
            this.pASTEToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.pASTEToolStripMenuItem.Text = "PASTE";
            this.pASTEToolStripMenuItem.Click += new System.EventHandler(this.pASTEToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(82, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listNumbers
            // 
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.ItemHeight = 25;
            this.listNumbers.Location = new System.Drawing.Point(82, 139);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.Size = new System.Drawing.Size(332, 229);
            this.listNumbers.TabIndex = 3;
            this.listNumbers.SelectedIndexChanged += new System.EventHandler(this.listNumbers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(496, 447);
            this.Controls.Add(this.listNumbers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ListBox & Menu Usage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pASTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listNumbers;
    }
}

