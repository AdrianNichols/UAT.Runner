# UAT.Runner
Automated UAT with WatiN, SpecFlow, and PicklesDoc

The UAT.Runner test suite enables UAT tests to be executed as part of a build and release process. It uses:

* WatiN (http://watin.org/)
* SpecFlow (http://www.specflow.org/)
* PicklesDoc (http://www.picklesdoc.com/)

# Solution Structure
The UAT.Runner test suite has been structured so that: 

* UAT tests are detaced from the solution/site under test
* Feature tests are structured in a similar way to the site under test
