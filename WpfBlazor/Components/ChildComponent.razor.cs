namespace WpfBlazor.Components
{
    public partial class ChildComponent : ComponentBase
    {
        protected string Message { get; set; } = "";

        protected override void OnInitialized()
        {
            Message = $"ChildComponent initialized at {DateTime.Now.ToLongTimeString()}";
        }
    }
}
