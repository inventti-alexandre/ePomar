﻿namespace Uniplac.ePomar.WindowsApp.Controls.ReceitaForms
{
    partial class ReceitaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listReceitas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listReceitas
            // 
            this.listReceitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listReceitas.FormattingEnabled = true;
            this.listReceitas.Location = new System.Drawing.Point(0, 0);
            this.listReceitas.Name = "listReceitas";
            this.listReceitas.Size = new System.Drawing.Size(458, 352);
            this.listReceitas.TabIndex = 1;
            // 
            // ReceitaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listReceitas);
            this.Name = "ReceitaControl";
            this.Size = new System.Drawing.Size(458, 352);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listReceitas;
    }
}
