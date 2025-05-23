using Microsoft.JSInterop;

public class ApexChartsInterop
{
    private readonly IJSRuntime _jsRuntime;

    public ApexChartsInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async ValueTask<IJSObjectReference> RenderChart(string elementId, object options)
    {
        return await _jsRuntime.InvokeAsync<IJSObjectReference>("renderApexChart", elementId, options);
    }

    public async ValueTask DisposeChart(IJSObjectReference chart)
    {
        await chart.InvokeVoidAsync("destroy");
    }
}