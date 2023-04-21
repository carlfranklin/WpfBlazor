namespace WpfBlazor.Components;

public partial class DisplayMessage : ComponentBase
{
    [CascadingParameter]
    public BlazoredModalInstance BlazoredModal { get; set; }

    [Parameter] 
    public string Message { get; set; }

    async Task SubmitForm() => await BlazoredModal.CloseAsync();
    async Task Cancel() => await BlazoredModal.CancelAsync();
}
