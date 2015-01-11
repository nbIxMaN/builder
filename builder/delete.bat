@echo off
if not "%ISSTARTED%"=="STARTED" goto :EOF

rmdir /S /Q %REPOLOC%