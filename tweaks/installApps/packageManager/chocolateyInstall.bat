@echo off
chcp 65001
powershell -ExecutionPolicy ByPass -command "Set-ExecutionPolicy Bypass -Scope Process -Force; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))"
echo Если вам кидает что-то типа : 'choco' was found at.... , то это значит что у вас уже установлен Chocolatey, и вы можете спокойно устанавливать программы из списка в твикере.
pause