﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chinese_Word_Analyzer
{
    /// <summary>
    /// SearchBox.xaml 的交互逻辑
    /// </summary>
    public partial class SearchBox : Window
    {
        public SearchBox()
        {
            InitializeComponent();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            IconRemover.RemoveIcon(this);
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var hwnd = new WindowInteropHelper(this).Handle;
            IconRemover.SetWindowLong(hwnd, IconRemover.GWL_STYLE, IconRemover.GetWindowLong(hwnd, IconRemover.GWL_STYLE) & ~IconRemover.WS_SYSMENU);
        }
    }
}
