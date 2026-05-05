@echo off
setlocal
set "SRC=LAN"
set "DST=..\SHAKE"
copy "%SRC%\DefaultEngine.ini" "%DST%\Config\DefaultEngine.ini" /Y
copy "%SRC%\SHAKE.uproject" "%DST%\SHAKE.uproject" /Y
copy "%SRC%\SHAKE.Build.cs" "%DST%\Source\SHAKE\SHAKE.Build.cs" /Y
powershell -command "Add-Type -AssemblyName PresentationFramework;[System.Windows.MessageBox]::Show('Don''t forget to enable LAN in BP_SHAKE_GameManagerFunctions!','LAN Mode Activated')"
