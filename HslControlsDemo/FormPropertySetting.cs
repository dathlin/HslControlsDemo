﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormPropertySetting : FormContent
    {
        public FormPropertySetting( )
        {
            InitializeComponent( );
        }

        public void SetControlRender(object control )
        {
			try
            {
                propertyGrid1.SelectedObject = control;
            }
            catch
			{

			}
        }
    }
}
