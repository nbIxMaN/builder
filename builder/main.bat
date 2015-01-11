@echo off
set ISSTARTED=STARTED

call settings.bat
call delete.bat
call clone.bat
if not "%ERRORS%"=="OK" goto :error
call build.bat
if not "%ERRORS%"=="OK" goto :error
:error
call email.bat