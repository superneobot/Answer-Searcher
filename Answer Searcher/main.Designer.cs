
namespace Answer_Searcher
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.top_panel = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_value = new System.Windows.Forms.TextBox();
            this.strip_p = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.text_out = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.top_panel.SuspendLayout();
            this.strip_p.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Controls.Add(this.search_btn);
            this.top_panel.Controls.Add(this.search_value);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(434, 43);
            this.top_panel.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(350, 10);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Искать";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_value
            // 
            this.search_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_value.Location = new System.Drawing.Point(12, 12);
            this.search_value.Name = "search_value";
            this.search_value.Size = new System.Drawing.Size(332, 20);
            this.search_value.TabIndex = 0;
            this.search_value.Click += new System.EventHandler(this.search_value_Click);
            // 
            // strip_p
            // 
            this.strip_p.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.strip_p.Location = new System.Drawing.Point(0, 380);
            this.strip_p.Name = "strip_p";
            this.strip_p.Size = new System.Drawing.Size(434, 22);
            this.strip_p.TabIndex = 2;
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(26, 17);
            this.status.Text = "Idle";
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.text_out);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 43);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(434, 337);
            this.main_panel.TabIndex = 3;
            // 
            // text_out
            // 
            this.text_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_out.ContextMenuStrip = this.menu;
            this.text_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_out.Location = new System.Drawing.Point(0, 0);
            this.text_out.Name = "text_out";
            this.text_out.ReadOnly = true;
            this.text_out.Size = new System.Drawing.Size(434, 337);
            this.text_out.TabIndex = 0;
            this.text_out.Text = "";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(140, 26);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = global::Answer_Searcher.Properties.Resources.copy;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 402);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.strip_p);
            this.Controls.Add(this.top_panel);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "otvetzdes.ru";
            this.TopMost = true;
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.strip_p.ResumeLayout(false);
            this.strip_p.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_value;
        private System.Windows.Forms.StatusStrip strip_p;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.RichTextBox text_out;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    }
}

