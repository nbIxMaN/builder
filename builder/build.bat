@echo off

if not "%ISSTARTED%"=="STARTED" goto :EOF
%MSBUILD% %REPOLOC%\%PROJECTNAME%

if ERRORLEVEL 1 (
	set ERRORS=BuildSucceeded
	goto :EOF
	)

for /f "tokens=*" %%a in (%FILES%) do (
	if not exist %REPOLOC%\%%a (
		set ERRORS=FileSucceeded
		goto :EOF
	)
)