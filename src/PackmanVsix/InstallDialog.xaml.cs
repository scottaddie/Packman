﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Packman;
using PackmanVsix.Models;

namespace PackmanVsix
{
    public partial class InstallDialog
    {
        private readonly string _folder;

        public InstallDialog(string folder)
        {
            InitializeComponent();

            _folder = folder;

            Loaded += OnLoaded;
        }

        public InstallablePackage Package
        {
            get { return ViewModel.Package; }
        }

        public string InstallDirectory
        {
            get { return ViewModel.IncludePackageName ? Package.Name : string.Empty; }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Icon = BitmapFrame.Create(new Uri("pack://application:,,,/PackmanVsix;component/Resources/dialog-icon.png", UriKind.RelativeOrAbsolute));
            Title = Vsix.Name;

            cbName.Focus();

            ViewModel = new InstallDialogViewModel(Dispatcher, CloseDialog)
            {
                RootFolderName = _folder
            };
        }

        private void CloseDialog(bool res)
        {
            DialogResult = res;
            Close();
        }

        public InstallDialogViewModel ViewModel
        {
            get { return DataContext as InstallDialogViewModel; }
            set { DataContext = value; }
        }

        private void NavigateToHomepage(object sender, RequestNavigateEventArgs e)
        {
            Hyperlink link = sender as Hyperlink;

            if (link != null)
            {
                Process.Start(link.NavigateUri.AbsoluteUri);
            }

            e.Handled = true;
            cbName.ResumeFocusEvents();
        }

        private void HyperlinkPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            cbName.SuspendFocusEvents();
        }
    }
}
