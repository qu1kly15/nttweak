using NTTweak;
using Terminal.Gui;

Application.Init();

try
{
    Application.Run(new MainMenu());
}
finally
{
    Application.Shutdown();
}