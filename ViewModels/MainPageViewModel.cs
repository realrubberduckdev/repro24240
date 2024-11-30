namespace test24240.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public string SubHeadline { get; set; } = $"v{AppInfo.Current.VersionString} Build {AppInfo.Current.BuildString}";
}
