#
# PublishHtml.ps1
#
param(
	[string]$TestFile
)

$testOut = "$PsScriptRoot\..\..\TestResults\" + $TestFile

#Import Pickles Doc Module
Import-Module "$PsScriptRoot\..\..\packages\Pickles.1.1.0\tools\PicklesDoc.Pickles.PowerShell.dll"

#Output DHTML
Pickle-Features -SystemUnderTestName "UAT.Runner" -TestResultsFile $testOut  -TestResultsFormat mstest -DocumentationFormat Dhtml -FeatureDirectory "$PsScriptRoot\..\Features" -OutputDirectory "$PsScriptRoot\..\Html"
