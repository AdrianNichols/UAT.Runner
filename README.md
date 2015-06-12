# UAT.Runner
UAT.Runner is an automated UAT test framework that utilises WatiN, SpecFlow, and PicklesDoc to create business and developer friendly UAT test declarations and execution.

The UAT.Runner test suite enables UAT tests to be executed as part of a build and release process. It uses:

* WatiN (http://watin.org/)
* SpecFlow (http://www.specflow.org/)
* PicklesDoc (http://www.picklesdoc.com/)

# Solution Structure
The UAT.Runner test framework has been inspired by Jason Roberts Pluralsight course on Automated Acceptance Tests (http://www.pluralsight.com/courses/automated-acceptance-testing-specflow-gherkin).

The solution has been structured so that: 

* UAT tests are detaced from the solution/site under test
* Feature tests are structured in a similar way to the site under test
* The structure of pages under test can be abstracted making future changes easier
