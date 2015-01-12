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
	set FILE=-attacht %BUILDLOG%)

if "%ERRORS%"=="FileSucceeded" (
	set SUBJECT="FileSucceeded"
	set BODY="File Succeeded, some file not found")

if "%ERRORS%"=="TestSucceeded" (
	set SUBJECT="TestSucceeded"
	set BODY="Some tests failed"
	set FILE=-attacht %TESTSLOG%)

%BLAT% -subject %SUBJECT% -body %BODY% -to %EMAIL% %FILE%