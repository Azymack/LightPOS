﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NickAc.LightPOS.Frontend.Forms
{
    public partial class MainMenuForm : TemplateForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
            translationHelper1.Translate(this);
        }
        public override Size MaximumSize { get => Size.Empty; set => base.MaximumSize = value; }
    }
}
