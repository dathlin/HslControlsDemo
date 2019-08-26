using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormClassifier : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FormClassifier()
        {
            InitializeComponent();
        }

        private void FormClassifier_Load(object sender, EventArgs e)
        {
            hslClassifier5.Text = "温度：123 ℃" + Environment.NewLine + "压力：1.34 mpa";
        }
    }
}
