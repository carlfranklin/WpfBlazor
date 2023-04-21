using WpfBlazor.Components;

namespace WpfBlazor;

public partial class Index
{
    private Canvas2DContext _context;
    protected BECanvasComponent _canvasReference;

    private string message = "Hey, it's Blazor in WPF!";
    public string Message
    {
        get => message;
        set
        {
            message = value;
            StateHasChanged();
        }
    }

    protected async Task ClickMe()
    {
        var width = await JSRuntime.InvokeAsync<int>("GetWindowWidth", null);
        Message = $"Message updated at {DateTime.Now.ToLongTimeString()} Window Width: {width}";
    }

    public void ShowModal()
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(DisplayMessage.Message), "Hey, WPF!");
        Modal.Show<DisplayMessage>("Passing Data", parameters);
    }

    protected void TalkToWPF()
    {
        AppState.MainWindow?.ShowMessageBox("Hey, this is Blazor Calling!");
    }

    protected override void OnInitialized()
    {
        AppState.IndexComponent = this;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("RegisterWPFApp", DotNetObjectReference.Create(this));
        }
        this._context = await this._canvasReference.CreateCanvas2DAsync();
        await this._context.SetFillStyleAsync("green");

        await this._context.FillRectAsync(10, 100, 100, 100);

        await this._context.SetFontAsync("48px serif");
        await this._context.StrokeTextAsync("Hello Blazor!!!", 10, 100);
    }

    [JSInvokable]
    public async Task WindowResized(int Width, int Height)
    {
        Message = $"Screen Size: {Width} x {Height}";
        await InvokeAsync(StateHasChanged);
    }
}
