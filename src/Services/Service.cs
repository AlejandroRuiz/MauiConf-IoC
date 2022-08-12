using System.Diagnostics;

namespace DIDemo.Services;

public class Service : IService
{
    public void OnButtonTapped()
    {
        Debug.WriteLine("OnButtonTapped");
    }
}
