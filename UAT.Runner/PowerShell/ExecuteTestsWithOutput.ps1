#
# ExecuteTestsWithOutput.ps1
#
param(
	[string]$TestFile
)

#Run Tests
$testDLL = "$PsScriptRoot\..\bin\debug\UAT.Runner.dll"
$testOut = "$PsScriptRoot\..\..\TestResults\" + $TestFile
$fs = New-Object -ComObject Scripting.FileSystemObject
$f = $fs.GetFile("C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\mstest.exe")
$mstestPath = $f.shortpath   
$arguments = " /testcontainer:" + $testDLL + " /resultsfile:" + $testOut
Invoke-Expression "$mstestPath $arguments"