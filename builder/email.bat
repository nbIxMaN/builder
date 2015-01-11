@echo off
if not "%ISSTARTED%"=="STARTED" goto :EOF

if "%ERRORS%"=="OK" (
	set SUBJECT="Errors not found"
	set BODY="My congratulations")

if "%ERRORS%"=="CloneSucceeded" (
	set SUBJECT="CloneSucceeded"
	set BODY="Clone Succeeded, please check REPOURL in settings")

if "%ERRORS%"=="BuildSucceeded" (
	set SUBJECT="BuildSucceeded"
	set BODY="Build Succeeded, please read Logfile"
	set FILE="-attach %BUILDLOG%")

if "%ERRORS%"=="FileSucceeded" (
	set SUBJECT="FileSucceeded"
	set BODY="File Succeeded, some file not found")

%BLAT% -subject %SUBJECT% -body %BODY% -to %EMAIL% %FILE%