@echo off
sc config wuauserv start= disabled
net stop wuauserv
pause