﻿using Apt.App.ViewModels.Pages.Video.FrameInterpolation;
using Wpf.Ui.Abstractions.Controls;

namespace Apt.App.Views.Pages.Video.FrameInterpolation
{
    public partial class IndexPage : INavigableView<IndexPageViewModel>
    {
        public IndexPageViewModel ViewModel { get; }

        public IndexPage(IndexPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();

            IsVisibleChanged += (s, e) =>
            {
                if (!IsVisible) FileView.Pause();
            };
        }
    }
}
