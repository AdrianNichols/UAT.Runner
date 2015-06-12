#
# PublishHtml.ps1
#

#Import Pickles Doc Module
Import-Module "..\..\packages\Pickles.1.1.0\tools\PicklesDoc.Pickles.PowerShell.dll"

#Output DHTML
Pickle-Features -DocumentationFormat Dhtml -FeatureDirectory ..\Features -OutputDirectory ..\Html
