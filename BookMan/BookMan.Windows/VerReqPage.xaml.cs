﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BookMan {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VerReqPage : Page {
        public VerReqPage() {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            this.Frame.GoBack();
        }

        private void submit_Click(object sender, RoutedEventArgs e) {
            int field, target;

            target = Convert.ToInt32(user_id.Text);
            field = target;
        }
    }
}
