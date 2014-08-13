# AgeBase: Golf Hole Editor

The Golf Hole Editor package...

## Installation

The Golf Hole Editor package can be installed via the package's page on [our.umbraco.org](http://our.umbraco.org/projects/backoffice-extensions/golf-hole-editor) or via NuGet. If installing via NuGet, use the following package manager command:

    Install-Package AgeBase.GolfHoleEditor

## Contributing

To raise a new bug, create an [issue](https://github.com/agebase/umbraco-golf-hole-editor/issues) on the Github repository. To fix a bug or add new features or providers, fork the repository and send a [pull request](https://github.com/agebase/umbraco-golf-hole-editor/pulls) with your changes. Feel free to add ideas to the repository's [issues](https://github.com/agebase/umbraco-golf-hole-editor/issues) list if you would to discuss anything related to the package.

## Publishing

Remember to include all necessary files within the package.xml file. Run the following script, entering the new version number when prompted to created a published version of the package:

    Build\Release.bat

The release script will amend all assembly versions for the package, build the solution and create the package file. The script will also commit and tag the repository accordingly to reflect the new version.