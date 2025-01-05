namespace BlazorTailwindAppWithTheme.Components.Theme;
public class ThemeManager
{
    public string CurrentTheme { get; private set; } = "light";

    public event Action? OnThemeChanged;

    public void ToggleTheme()
    {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
        OnThemeChanged?.Invoke();
    }
}
