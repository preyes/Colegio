namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.app1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarUnMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.app3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.facebookCelegioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.calculoDeSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.app1ToolStripMenuItem,
            this.app2ToolStripMenuItem,
            this.app3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // app1ToolStripMenuItem
            // 
            this.app1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSWordToolStripMenuItem,
            this.mSExcelToolStripMenuItem,
            this.enviarUnMailToolStripMenuItem});
            this.app1ToolStripMenuItem.Name = "app1ToolStripMenuItem";
            this.app1ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.app1ToolStripMenuItem.Text = "App1";
            // 
            // mSWordToolStripMenuItem
            // 
            this.mSWordToolStripMenuItem.Name = "mSWordToolStripMenuItem";
            this.mSWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mSWordToolStripMenuItem.Text = "MS Word";
            this.mSWordToolStripMenuItem.Click += new System.EventHandler(this.mSWordToolStripMenuItem_Click);
            // 
            // mSExcelToolStripMenuItem
            // 
            this.mSExcelToolStripMenuItem.Name = "mSExcelToolStripMenuItem";
            this.mSExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mSExcelToolStripMenuItem.Text = "MS Excel";
            // 
            // enviarUnMailToolStripMenuItem
            // 
            this.enviarUnMailToolStripMenuItem.Name = "enviarUnMailToolStripMenuItem";
            this.enviarUnMailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enviarUnMailToolStripMenuItem.Text = "Calculadora";
            this.enviarUnMailToolStripMenuItem.Click += new System.EventHandler(this.enviarUnMailToolStripMenuItem_Click);
            // 
            // app2ToolStripMenuItem
            // 
            this.app2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookCelegioToolStripMenuItem});
            this.app2ToolStripMenuItem.Name = "app2ToolStripMenuItem";
            this.app2ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.app2ToolStripMenuItem.Text = "Internet";
            // 
            // app3ToolStripMenuItem
            // 
            this.app3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeSueldoToolStripMenuItem});
            this.app3ToolStripMenuItem.Name = "app3ToolStripMenuItem";
            this.app3ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.app3ToolStripMenuItem.Text = "My App";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(439, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // facebookCelegioToolStripMenuItem
            // 
            this.facebookCelegioToolStripMenuItem.Name = "facebookCelegioToolStripMenuItem";
            this.facebookCelegioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.facebookCelegioToolStripMenuItem.Text = "Facebook Celegio";
            this.facebookCelegioToolStripMenuItem.Click += new System.EventHandler(this.facebookCelegioToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 38);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(428, 404);
            this.webBrowser1.TabIndex = 2;
            // 
            // calculoDeSueldoToolStripMenuItem
            // 
            this.calculoDeSueldoToolStripMenuItem.Name = "calculoDeSueldoToolStripMenuItem";
            this.calculoDeSueldoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.calculoDeSueldoToolStripMenuItem.Text = "Calculo de sueldo";
            this.calculoDeSueldoToolStripMenuItem.Click += new System.EventHandler(this.calculoDeSueldoToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem app1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem app3ToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem enviarUnMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookCelegioToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem calculoDeSueldoToolStripMenuItem;
        private System.Windows.Forms.Button button1;

    }
}

