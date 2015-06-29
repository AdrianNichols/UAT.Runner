#
# ExecuteAllAndGenerateDox.ps1
#
$testfile = "TestResults" + (get-date -format "yyyyMMdd_hhmmss") + ".trx"

cd $PsScriptRoot

.\ExecuteTestsWithOutput.ps1 -TestFile $testfile
.\PublishHtml.ps1 -TestFile $testfile