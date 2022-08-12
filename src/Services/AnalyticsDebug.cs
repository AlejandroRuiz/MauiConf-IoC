using System.Diagnostics;

namespace DIDemo.Services;

public class AnalyticsDebug : IAnalytics
{
    public void SendEvent(string eventName)
        => Debug.WriteLine(eventName);
}
