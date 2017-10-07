using GreenshotPlugin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GreenshotLutimPlugin.Forms
{
    public partial class SettingsForm : LutimForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            CancelButton = buttonCancel;
            AcceptButton = buttonOK;
        }
    }
}
