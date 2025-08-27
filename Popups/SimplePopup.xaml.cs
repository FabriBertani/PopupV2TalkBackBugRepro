using CommunityToolkit.Maui.Views;

namespace PopupV2TalkBackIssue.Popups;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
	}

	async void OnClosePopupButtonClicked(object? sender, EventArgs e)
	{
		await CloseAsync();
	}
}