using CommunityToolkit.Maui.Views;

namespace PopupV2TalkBackIssue.Popups;

public partial class ComplexPopup : Popup
{
	public ComplexPopup()
	{
		InitializeComponent();
	}

	async void OnPopupCompletedClicked(object? sender, EventArgs e)
	{
		await CloseAsync();
	}
}