@echo off

:: --- CONFIGURATION ---
:: Paste the full path of the folder you want to scan between the quotes below.
:: Example: set "TargetFolder=F:\Code Projects\00 Study 00\C#\lesson_1\resources\C# in a Nutshell"

set "TargetFolder=F:\Code Projects\00 Study 00\C#\lesson_1\resources\C# in a Nutshell


:: --- SCRIPT EXECUTION ---
:: Do not change the lines below.

echo Scanning folder: %TargetFolder%
echo Please wait...

:: The "dir" command scans the target folder and its subfolders (/s)
:: in bare format (/b), then saves the output (>) to a text file.
dir "%TargetFolder%" /s /b > "file_list.txt"

echo.
echo Done! The list has been created successfully.
echo The output has been saved to "file_list.txt" in the same folder as this script.
echo.
pause