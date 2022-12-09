namespace Lab1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.modeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.mode1Button = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2Button = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeButton,
            this.aboutButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1279, 34);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // modeButton
            // 
            this.modeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode1Button,
            this.mode2Button});
            this.modeButton.Image = ((System.Drawing.Image)(resources.GetObject("modeButton.Image")));
            this.modeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(85, 29);
            this.modeButton.Text = "Режим";
            // 
            // mode1Button
            // 
            this.mode1Button.Name = "mode1Button";
            this.mode1Button.Size = new System.Drawing.Size(191, 34);
            this.mode1Button.Text = "Вираз";
            this.mode1Button.Click += new System.EventHandler(this.mode1Button_Click);
            // 
            // mode2Button
            // 
            this.mode2Button.Name = "mode2Button";
            this.mode2Button.Size = new System.Drawing.Size(191, 34);
            this.mode2Button.Text = "Значення";
            this.mode2Button.Click += new System.EventHandler(this.mode2Button_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(137, 29);
            this.aboutButton.Text = "Про програму";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 29);
            this.exitButton.Text = "Закрити";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Location = new System.Drawing.Point(12, 48);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.RowHeadersWidth = 62;
            this.mainDataGridView.RowTemplate.Height = 33;
            this.mainDataGridView.Size = new System.Drawing.Size(1255, 588);
            this.mainDataGridView.TabIndex = 7;
            this.mainDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 661);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainDataGridView);
            this.Name = "MainForm";
            this.Text = "Таблиця";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton modeButton;
        private ToolStripMenuItem mode1Button;
        private ToolStripMenuItem mode2Button;
        private ToolStripButton aboutButton;
        private ToolStripButton exitButton;
        private DataGridView mainDataGridView;
    }
}