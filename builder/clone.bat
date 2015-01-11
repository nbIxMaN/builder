@echo off

if not "%ISSTARTED%"=="STARTED" goto :EOF

%GIT% clone %REPOURL% %REPOLOC%

if ERRORLEVEL 1 set ERRORS=CloneSucceeded