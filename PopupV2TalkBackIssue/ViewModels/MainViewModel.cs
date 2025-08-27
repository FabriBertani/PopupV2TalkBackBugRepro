using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PopupV2TalkBackIssue.Popups;

namespace PopupV2TalkBackIssue.ViewModels;

public partial class MainViewModel(IPopupService popupService) : ObservableObject
{
    private readonly IPopupService _popupService = popupService;

    [RelayCommand]
    private async Task ShowSimplePopup()
    {
        await _popupService.ShowPopupAsync<SimplePopup>(Shell.Current);
    }

    [RelayCommand]
    private async Task ShowComplexPopup()
    {
        await _popupService.ShowPopupAsync<ComplexPopup>(Shell.Current);
    }
}
