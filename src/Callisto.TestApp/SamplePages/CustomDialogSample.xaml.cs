﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LinqToVisualTree;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Callisto.Controls.Common;
using Callisto.Controls;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Callisto.TestApp.SamplePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomDialogSample : Page
    {
        public CustomDialogSample()
        {
            this.InitializeComponent();
        }

        private void CustomDialogClicked(object sender, RoutedEventArgs e)
        {
            var mp = Frame.Ancestors<Frame>().FirstOrDefault().Descendants<Page>().FirstOrDefault();
            (mp as MainPage).LoginDialog.IsOpen = true;
        }

        private void MessageDialogClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog md = new MessageDialog("Bacon ipsum dolor sit amet bacon ham drumstick strip steak, sausage frankfurter tenderloin turkey salami andouille bresaola. Venison salami prosciutto, pork belly turducken tri-tip spare ribs chicken strip steak fatback shankle tongue boudin andouille. Meatloaf salami pork ground round turkey jerky meatball ball tip, filet mignon fatback flank prosciutto shank. Turkey boudin ham hock, filet mignon tri-tip bresaola tongue venison spare ribs meatloaf flank beef pancetta. Leberkas turducken flank ground round biltong chuck bacon kielbasa. Beef pastrami meatball, short loin venison swine pork loin shank meatloaf spare ribs.",
                "Bacon Terms and Conditions");
#pragma warning disable 4014
            md.ShowAsync();
#pragma warning restore 4014
        }

        private void DialogCancelClicked(object sender, RoutedEventArgs e)
        {
            //TaggedDialog.IsOpen = false;
        }
    }
}
