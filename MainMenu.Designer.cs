namespace NTTweak {
    using System;
    using System.Runtime.CompilerServices;

    using System.Xml.Schema;

    using Terminal.Gui;
    
    
    public partial class MainMenu : Terminal.Gui.Window {
        
        private Terminal.Gui.Label performanceL;

        private Terminal.Gui.Button infoProgram;

        private Terminal.Gui.Button links;

        private Terminal.Gui.Button restartExplorer;

        private Terminal.Gui.Button maxPerformance;

        private Terminal.Gui.Label interfaceL;

        private Terminal.Gui.Button onShowHiddenFolders;

        private Terminal.Gui.Button offShowHiddenFolders;

        private Terminal.Gui.Button onDisplaySeconds;

        private Terminal.Gui.Button offDisplaySeconds;

        private Terminal.Gui.Button onCopilotIcon;

        private Terminal.Gui.Button offCopilotIcon;

        private Terminal.Gui.Button onUserAccountControl;

        private Terminal.Gui.Button offUserAccountControl;

        private Terminal.Gui.Button deleteWinDefender;

        private Terminal.Gui.Button offUpdateCenter;

        private Terminal.Gui.Button onUpdateCenter;

        private Terminal.Gui.Label installAppsL;

        private Terminal.Gui.Button infoApps;

        private Terminal.Gui.Button chocolateyInstall;

        private Terminal.Gui.Button chromeInstall;

        private Terminal.Gui.Button firefoxInstall;

        private Terminal.Gui.Button discordInstall;

        private Terminal.Gui.Button telegramInstall;

        private Terminal.Gui.Button steamInstall;

        private Terminal.Gui.Button epicGamesLauncherInstall;

        private Terminal.Gui.Button obsStudioInstall;

        private Terminal.Gui.Button winRarInstall;

        private Terminal.Gui.Button zip7Install;
        
        private void InitializeComponent() {
            this.performanceL = new Terminal.Gui.Label();
            this.infoProgram = new Terminal.Gui.Button();
            this.links = new Terminal.Gui.Button();
            this.restartExplorer = new Terminal.Gui.Button();
            this.maxPerformance = new Terminal.Gui.Button();
            this.interfaceL = new Terminal.Gui.Label();
            this.onShowHiddenFolders = new Terminal.Gui.Button();
            this.offShowHiddenFolders = new Terminal.Gui.Button();
            this.onDisplaySeconds = new Terminal.Gui.Button();
            this.offDisplaySeconds = new Terminal.Gui.Button();
            this.onCopilotIcon = new Terminal.Gui.Button();
            this.offCopilotIcon = new Terminal.Gui.Button();
            this.onUserAccountControl = new Terminal.Gui.Button();
            this.offUserAccountControl = new Terminal.Gui.Button();
            this.deleteWinDefender = new Terminal.Gui.Button();
            this.onUpdateCenter = new Terminal.Gui.Button();
            this.offUpdateCenter = new Terminal.Gui.Button();
            this.installAppsL = new Terminal.Gui.Label();
            this.infoApps = new Terminal.Gui.Button();
            this.chocolateyInstall = new Terminal.Gui.Button();
            this.chromeInstall = new Terminal.Gui.Button();
            this.firefoxInstall = new Terminal.Gui.Button();
            this.discordInstall = new Terminal.Gui.Button();
            this.telegramInstall = new Terminal.Gui.Button();
            this.steamInstall = new Terminal.Gui.Button();
            this.epicGamesLauncherInstall = new Terminal.Gui.Button();
            this.obsStudioInstall = new Terminal.Gui.Button();
            this.winRarInstall = new Terminal.Gui.Button();
            this.zip7Install = new Terminal.Gui.Button();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Modal = false;
            this.Text = "";
            this.Border.BorderStyle = Terminal.Gui.BorderStyle.Single;
            this.Border.Effect3D = false;
            this.Border.DrawMarginFrame = true;
            this.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Title = "NTTweak v1.0";
            
            this.infoProgram.Width = 12;
            this.infoProgram.X = Pos.Top(infoProgram);
            this.infoProgram.Y = Pos.Top(infoProgram);
            this.infoProgram.Data = "infoProgram";
            this.infoProgram.Text = "Информация о NTTweak";
            this.Add(this.infoProgram);
            
            this.links.Width = 12;
            this.links.X = Pos.Top(links) + 26;
            this.links.Y = Pos.Top(links);
            this.links.Data = "links";
            this.links.Text = "Ссылки на нас";
            this.Add(this.links);
            
            this.restartExplorer.Width = 12;
            this.restartExplorer.X = Pos.Top(links) + 45;
            this.restartExplorer.Y = Pos.Top(links);
            this.restartExplorer.Data = "restartExplorer";
            this.restartExplorer.Text = "Перезапустить проводник";
            this.Add(this.restartExplorer);

            // Tweak-menu

            // labels 
            this.performanceL.Width = 4;
            this.performanceL.Height = 1;
            this.performanceL.X = Pos.Top(performanceL);
            this.performanceL.Y = Pos.Top(performanceL) + 2;
            this.performanceL.Data = "label1";
            this.performanceL.Text = "Производительность";
            this.performanceL.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.performanceL);

            this.interfaceL.Width = 4;
            this.interfaceL.Height = 1;
            this.interfaceL.X = Pos.Top(interfaceL) + 35;
            this.interfaceL.Y = Pos.Top(interfaceL) + 2;
            this.interfaceL.Data = "interfaceL";
            this.interfaceL.Text = "Интерфейс";
            this.interfaceL.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.interfaceL);

            this.installAppsL.Width = 4;
            this.installAppsL.Height = 1;
            this.installAppsL.X = Pos.Top(installAppsL) + 35;
            this.installAppsL.Y = Pos.Top(installAppsL) + 12;
            this.installAppsL.Data = "installAppsL";
            this.installAppsL.Text = "Установка программ";
            this.installAppsL.TextAlignment = Terminal.Gui.TextAlignment.Left;
            this.Add(this.installAppsL);



            // buttons 

            // performance
            this.maxPerformance.Width = 12;
            this.maxPerformance.X = Pos.Top(maxPerformance);
            this.maxPerformance.Y = Pos.Top(maxPerformance) + 3;
            this.maxPerformance.Data = "maxPerformance";
            this.maxPerformance.Text = "Макс. производительность";
            this.Add(this.maxPerformance);

            this.onUserAccountControl.Width = 12;
            this.onUserAccountControl.X = Pos.Top(onUserAccountControl);
            this.onUserAccountControl.Y = Pos.Top(onUserAccountControl) + 5;
            this.onUserAccountControl.Data = "onUserAccountContol";
            this.onUserAccountControl.Text = "Вкл. UAC";
            this.Add(this.onUserAccountControl);

            this.offUserAccountControl.Width = 12;
            this.offUserAccountControl.X = Pos.Top(offUserAccountControl);
            this.offUserAccountControl.Y = Pos.Top(offUserAccountControl) + 6;
            this.offUserAccountControl.Data = "offUserAccountContol";
            this.offUserAccountControl.Text = "Выкл. UAC";
            this.Add(this.offUserAccountControl);

            this.deleteWinDefender.Width = 12;
            this.deleteWinDefender.X = Pos.Top(deleteWinDefender);
            this.deleteWinDefender.Y = Pos.Top(deleteWinDefender) + 8;
            this.deleteWinDefender.Data = "deleteWinDefender";
            this.deleteWinDefender.Text = "Удалить Windows Defender";
            this.Add(this.deleteWinDefender);

            this.offUpdateCenter.Width = 12;
            this.offUpdateCenter.X = Pos.Top(offUpdateCenter);
            this.offUpdateCenter.Y = Pos.Top(offUpdateCenter) + 10;
            this.offUpdateCenter.Data = "offUpdateCenter";
            this.offUpdateCenter.Text = "Отключить обновления";
            this.Add(this.offUpdateCenter);

            this.onUpdateCenter.Width = 12;
            this.onUpdateCenter.X = Pos.Top(onUpdateCenter);
            this.onUpdateCenter.Y = Pos.Top(onUpdateCenter) + 11;
            this.onUpdateCenter.Data = "onUpdateCenter";
            this.onUpdateCenter.Text = "Включить обновления";
            this.Add(this.onUpdateCenter);

            // interface
            this.onShowHiddenFolders.Width = 12;
            this.onShowHiddenFolders.X = Pos.Top(maxPerformance) + 34;
            this.onShowHiddenFolders.Y = Pos.Top(maxPerformance);
            this.onShowHiddenFolders.Data = "onShowHiddenFolders";
            this.onShowHiddenFolders.Text = "Вкл. показ скрытых папок";
            this.Add(this.onShowHiddenFolders);

            this.offShowHiddenFolders.Width = 12;
            this.offShowHiddenFolders.X = Pos.Top(maxPerformance) + 34;
            this.offShowHiddenFolders.Y = Pos.Top(maxPerformance) + 1;
            this.offShowHiddenFolders.Data = "offShowHiddenFolders";
            this.offShowHiddenFolders.Text = "Выкл. показ скрытых папок";
            this.Add(this.offShowHiddenFolders);

            this.onDisplaySeconds.Width = 12;
            this.onDisplaySeconds.X = Pos.Top(maxPerformance) + 34;
            this.onDisplaySeconds.Y = Pos.Top(maxPerformance) + 3;
            this.onDisplaySeconds.Data = "onDisplaySeconds";
            this.onDisplaySeconds.Text = "Вкл. отображение секунд на панели задач";
            this.Add(this.onDisplaySeconds);

            this.offDisplaySeconds.Width = 12;
            this.offDisplaySeconds.X = Pos.Top(maxPerformance) + 34;
            this.offDisplaySeconds.Y = Pos.Top(maxPerformance) + 4;
            this.offDisplaySeconds.Data = "offDisplaySeconds";
            this.offDisplaySeconds.Text = "Выкл. отображение секунд на панели задач";
            this.Add(this.offDisplaySeconds);

            this.onCopilotIcon.Width = 12;
            this.onCopilotIcon.X = Pos.Top(maxPerformance) + 34;
            this.onCopilotIcon.Y = Pos.Top(maxPerformance) + 6;
            this.onCopilotIcon.Data = "onCopilotIcon";
            this.onCopilotIcon.Text = "Вкл. отображение иконки Copilot (Windows 11)";
            this.Add(this.onCopilotIcon);

            this.offCopilotIcon.Width = 12;
            this.offCopilotIcon.X = Pos.Top(maxPerformance) + 34;
            this.offCopilotIcon.Y = Pos.Top(maxPerformance) + 7;
            this.offCopilotIcon.Data = "offCopilotIcon";
            this.offCopilotIcon.Text = "Выкл. отображение иконки Copilot (Windows 11)";
            this.Add(this.offCopilotIcon);

            // installApps

            this.infoApps.Width = 8;
            this.infoApps.X = Pos.Top(installAppsL) + 24;
            this.infoApps.Y = Pos.Top(installAppsL) + 1;
            this.infoApps.Data = "infoApps";
            this.infoApps.Text = "ВАЖНО!";
            this.Add(this.infoApps);

            this.chocolateyInstall.Width = 12;
            this.chocolateyInstall.X = Pos.Top(installAppsL) + 24;
            this.chocolateyInstall.Y = Pos.Top(installAppsL) + 3;
            this.chocolateyInstall.Data = "chocolateyInstall";
            this.chocolateyInstall.Text = "Установить Chocolatey";
            this.Add(this.chocolateyInstall);

            this.chromeInstall.Width = 12;
            this.chromeInstall.X = Pos.Top(installAppsL) + 24;
            this.chromeInstall.Y = Pos.Top(installAppsL) + 5;
            this.chromeInstall.Data = "chromeInstall";
            this.chromeInstall.Text = "Google Chrome";
            this.Add(this.chromeInstall);

            this.firefoxInstall.Width = 12;
            this.firefoxInstall.X = Pos.Top(installAppsL) + 24;
            this.firefoxInstall.Y = Pos.Top(installAppsL) + 6;
            this.firefoxInstall.Data = "firefoxInstall";
            this.firefoxInstall.Text = "Firefox";
            this.Add(this.firefoxInstall);

            this.discordInstall.Width = 12;
            this.discordInstall.X = Pos.Top(installAppsL) + 24;
            this.discordInstall.Y = Pos.Top(installAppsL) + 7;
            this.discordInstall.Data = "discordInstall";
            this.discordInstall.Text = "Discord";
            this.Add(this.discordInstall);

            this.telegramInstall.Width = 12;
            this.telegramInstall.X = Pos.Top(installAppsL) + 24;
            this.telegramInstall.Y = Pos.Top(installAppsL) + 8;
            this.telegramInstall.Data = "telegramInstall";
            this.telegramInstall.Text = "Telegram";
            this.Add(this.telegramInstall);

            this.steamInstall.Width = 8;
            this.steamInstall.X = Pos.Top(installAppsL) + 24;
            this.steamInstall.Y = Pos.Top(installAppsL) + 9;
            this.steamInstall.Data = "steamInstall";
            this.steamInstall.Text = "Steam";
            this.Add(this.steamInstall);

            this.epicGamesLauncherInstall.Width = 12;
            this.epicGamesLauncherInstall.X = Pos.Top(installAppsL) + 24;
            this.epicGamesLauncherInstall.Y = Pos.Top(installAppsL) + 10;
            this.epicGamesLauncherInstall.Data = "epicGamesLauncherInstall";
            this.epicGamesLauncherInstall.Text = "Epic Games Launcher";
            this.Add(this.epicGamesLauncherInstall);

            this.winRarInstall.Width = 12;
            this.winRarInstall.X = Pos.Top(installAppsL) + 24;
            this.winRarInstall.Y = Pos.Top(installAppsL) + 11;
            this.winRarInstall.Data = "winRarInstall";
            this.winRarInstall.Text = "Win-RAR";
            this.Add(this.winRarInstall);

            this.zip7Install.Width = 8;
            this.zip7Install.X = Pos.Top(installAppsL) + 24;
            this.zip7Install.Y = Pos.Top(installAppsL) + 12;
            this.zip7Install.Data = "zip7Install";
            this.zip7Install.Text = "7-Zip";
            this.Add(this.zip7Install);

        }
    }
}
