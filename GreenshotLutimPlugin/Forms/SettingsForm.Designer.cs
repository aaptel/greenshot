using GreenshotPlugin.Core;

namespace GreenshotLutimPlugin.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new GreenshotPlugin.Controls.GreenshotLabel();
            this.hostTextBox = new GreenshotPlugin.Controls.GreenshotTextBox();
            this.buttonOK = new GreenshotPlugin.Controls.GreenshotButton();
            this.buttonCancel = new GreenshotPlugin.Controls.GreenshotButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = Language.GetString("lutim", LangKey.label_host);
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(192, 10);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.PropertyName = "LutimHost";
            this.hostTextBox.SectionName = "Lutim";
            this.hostTextBox.Size = new System.Drawing.Size(251, 20);
            this.hostTextBox.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(284, 87);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = Language.GetString("lutim", LangKey.OK);
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(365, 87);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = Language.GetString("lutim", LangKey.CANCEL); ;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 122);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = Language.GetString("lutim", LangKey.settings_title);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GreenshotPlugin.Controls.GreenshotLabel label1;
        private GreenshotPlugin.Controls.GreenshotTextBox hostTextBox;
        private GreenshotPlugin.Controls.GreenshotButton buttonOK;
        private GreenshotPlugin.Controls.GreenshotButton buttonCancel;
    }
}