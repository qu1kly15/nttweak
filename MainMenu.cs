
namespace NTTweak{
    using Terminal.Gui;
    using System;
    using NTTweak;
    using System.Diagnostics;


    public partial class MainMenu {
        
        // tweak-menu functions

        public void RestartExplorer() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\main\\RestartExplorer.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }
        // performance
        public void SetMaxPerformance() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\performance\\SetMaxPerformance.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();


        }

        public void OnUserAccountControl() {
            MessageBox.ErrorQuery("Секундочку...", "\nУчтите, что после примемения этого твика, необходимо будет \nперезагрузить компьютер, чтобы изменения вступили в силу.", "ОК");
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\performance\\OnUserAccountControl.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OffUserAccountControl() {
            MessageBox.ErrorQuery("Секундочку...", "\nУчтите, что после примемения этого твика, необходимо будет \nперезагрузить компьютер, чтобы изменения вступили в силу.", "ОК");
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\performance\\OffUserAccountControl.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void DeleteWinDefender() {
            MessageBox.ErrorQuery("Секундочку...", "\nДля удаления Windows Defender будет использован другой софт (DefenderKiller).\n Также, после применения этих твиков,\nнеобходимо будет перезагрузить компьютер, чтобы\nизменения вступили в силу.", "ОК");
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\defender\\DefenderKiller.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OnUpdateCenter() {
            MessageBox.ErrorQuery("Секундочку...", "\nУчтите, что после примемения этого твика, необходимо будет \nперезагрузить компьютер, чтобы изменения вступили в силу.", "ОК");
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\performance\\OnUpdateCenter.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OffUpdateCenter() {
            MessageBox.ErrorQuery("Секундочку...", "\nУчтите, что после примемения этого твика, необходимо будет \nперезагрузить компьютер, чтобы изменения вступили в силу.", "ОК");
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\performance\\OffUpdateCenter.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        // interface
        public void OnShowHiddenFolders() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OnShowHiddenFolders.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OffShowHiddenFolders() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OffShowHiddenFolders.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OnDisplaySeconds() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OnDisplaySeconds.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();

        }

        public void OffDisplaySeconds() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OffDisplaySeconds.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OnCopilotIcon() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OnCopilotIcon.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void OffCopilotIcon() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\interface\\OffCopilotIcon.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        // installApps
        public void ChocolateyInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\packageManager\\chocolateyInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void ChromeInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\chromeInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void FirefoxInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\firefoxInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void DiscordInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\discordInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void TelegramInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\telegramInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void SteamInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\steamInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void EpicGamesLauncherInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\epicGamesLauncherInstall.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void WinRARInstall() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\winRarInstaller.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public void Zip7Install() {
            Process process = new Process();
            process.StartInfo.FileName = "tweaks\\installApps\\appsInstallers\\zip7Install.bat";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Verb = "runas";
            process.Start();
        }

        public MainMenu() {
            InitializeComponent();
            // tweak-menu buttons
            restartExplorer.Clicked += () => RestartExplorer();

            // performance 
            maxPerformance.Clicked += () => SetMaxPerformance();

            onUserAccountControl.Clicked += () => OnUserAccountControl();
            offUserAccountControl.Clicked += () => OffUserAccountControl();

            deleteWinDefender.Clicked += () => DeleteWinDefender();

            // interface 
            onShowHiddenFolders.Clicked += () => OnShowHiddenFolders();
            offShowHiddenFolders.Clicked += () => OffShowHiddenFolders();

            onDisplaySeconds.Clicked += () => OnDisplaySeconds();
            offDisplaySeconds.Clicked += () => OffDisplaySeconds();

            onCopilotIcon.Clicked += () => OnCopilotIcon();
            offCopilotIcon.Clicked += () => OffCopilotIcon();

            onUpdateCenter.Clicked += () => OnUpdateCenter();
            offUpdateCenter.Clicked += () => OffUpdateCenter();

            // installApps
            infoApps.Clicked += () => MessageBox.ErrorQuery("Важно!", "\nДля установки приложений из списка, необходимо будет установить\n Chocolatey (пакетный менеджер), иначе без него\n у вас ничего не установится.", "ОК");

            chocolateyInstall.Clicked += () => ChocolateyInstall();

            chromeInstall.Clicked += () => ChromeInstall();
            firefoxInstall.Clicked += () => FirefoxInstall();
            discordInstall.Clicked += () => DiscordInstall();
            telegramInstall.Clicked += () => TelegramInstall();
            steamInstall.Clicked += () => SteamInstall();
            epicGamesLauncherInstall.Clicked += () => EpicGamesLauncherInstall();
            winRarInstall.Clicked += () => WinRARInstall();
            zip7Install.Clicked += () => Zip7Install();


            
            
            infoProgram.Clicked += () => MessageBox.Query("NTTweak", "\nNTTweak - программа, которая в себе содержит твики, которые могут улучшить и оптимизировать \nработу вашей Windows. Но помните, что Вы делаете всё на свой страх и риск, потому что \nразработчики не несут отвественность в том случае, если после \nустановки твиков что-то случилось с вашей Windows. \n\nРазработчик NTTweak: qu1kly1\nПриятного использования! ;)\n", "Хорошо");
            links.Clicked += () => MessageBox.Query("Ссылки", "Ссылки на нас:\nGithub - https://github.com/qu1kly15/nttweak/", "Хорошо");
        }
    }
}
