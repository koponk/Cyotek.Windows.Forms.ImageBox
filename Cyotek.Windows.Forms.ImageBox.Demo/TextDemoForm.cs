﻿using System;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2013 Cyotek.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See imagebox-license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal partial class TextDemoForm : BaseForm
  {
    #region Constructors

    public TextDemoForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Overridden Members

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      propertyGrid.SelectItem("Text");
    }

    #endregion

    #region Event Handlers

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutDialog.ShowAboutDialog();
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion
  }
}
