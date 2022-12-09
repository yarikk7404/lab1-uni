namespace Lab1
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitMenuButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitMenuButton
            // 
            this.exitMenuButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitMenuButton.Location = new System.Drawing.Point(522, 421);
            this.exitMenuButton.Name = "exitMenuButton";
            this.exitMenuButton.Size = new System.Drawing.Size(363, 117);
            this.exitMenuButton.TabIndex = 0;
            this.exitMenuButton.Text = "Вийти з програми";
            this.exitMenuButton.UseVisualStyleBackColor = true;
            this.exitMenuButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(114, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "Перейти до таблиці";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(164, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 192);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лабораторна робота №1\r\nАналіз та обічислення даних в таблиці\r\nАвтор: Кривенко Яро" +
    "слав, К-28\r\nКиїв, 2022";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitMenuButton);
            this.Name = "MenuForm";
            this.Text = "Головне меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitMenuButton;
        private Button button1;
        private Label label1;
    }
}