@echo off
echo %cd%
echo "Ini buat Ngeclean Unity Bro (baca tulisan dibawah ini)"
pause
echo "Last Reminder bro.."
pause
rd /s /q Library
rd /s /q Temp
rd /s /q .vs
del /s /q /f *.csproj
del /s /q /f *.pidb
del /s /q /f *.unityproj
del /s /q /f *.DS_Store
del /s /q /f *.sln
del /s /q /f *.userprefs
echo "done."
pause