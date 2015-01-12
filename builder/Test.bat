@echo off
if not "%ISSTARTED%"=="STARTED" goto :EOF

%NUNIT% %TEST% > %TESTSLOG%

if ERRORLEVEL 1 set ERRORS=TestSucceeded