@echo off

set BUILDLOG=bulid.txt
set TESTSLOG=TestResult.txt
set ERRORS=OK

set GIT="C:\Program Files (x86)\Git\bin\git"
set MSBUILD=%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
set FILES=files.txt

set REPOLOC=D:\Test
set PROJECTNAME=Geometry\Geometry.sln
set TEST=%REPOLOC%\Geometry\Tests\bin\Debug\Tests.dll
set REPOURL="https://github.com/nbIxMaN/builder"

set BLAT=blat323\full\blat.exe
set EMAIL=Shulllik@gmail.com

set NUNIT="D:\nunit\bin\nunit-console.exe"