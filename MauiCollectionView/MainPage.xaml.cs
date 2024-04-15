﻿using MauiCollectionView.Views;

namespace MauiCollectionView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAppearing(object? sender, EventArgs e)
    {
#if IOS || ANDROID || MACCATALYST
        CallGc();
#endif
    }

    private void OnLoaded(object? sender, EventArgs e)
    {
#if WINDOWS10_0_17763_0_OR_GREATER
            CallGc();
#endif
    }

    private void CallGc()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        var totalMemory = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory: {totalMemory}");
    }

    private async void ButtonXaml_OnClicked(object? sender, EventArgs e)
    {
        CallGc();
        await Navigation.PushAsync(new PageXamlLeak());
    }

    private async void ButtonCs_OnClicked(object? sender, EventArgs e)
    {
        CallGc();
        await Navigation.PushAsync(new PageCsOk());
    }
}