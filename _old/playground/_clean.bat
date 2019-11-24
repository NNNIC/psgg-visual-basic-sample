@echo off
cd /d %~dp0

echo : This batch delete Test\doc\*.* and Test\TestControl.vb.
echo : 
echo : continue ?
pause
echo on

del /q Test\doc\*.*
del /q Test\TestControl.vb

pause