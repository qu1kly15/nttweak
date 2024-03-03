@echo off 
sc config wuauserv start= auto
net start wuauserv
pause