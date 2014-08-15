# AgeBase: Golf Hole Editor

The Golf Hole Editor package is an Umbraco data type for creating golf hole information. This data type could be used on a golf club website for displaying course information. An editor can configure each hole's tees and it's par, stroke index and distances. The data type can also accommodate for different numbers of tees, holes and pars.

## Installation

The Golf Hole Editor package can be installed via the package's page on [our.umbraco.org](http://our.umbraco.org/projects/backoffice-extensions/golf-hole-editor) or via NuGet. If installing via NuGet, use the following package manager command:

    Install-Package AgeBase.GolfHoleEditor

## Configuration

Setup a new data type and select the AgeBase.GolfHoleEditor within Umbraco's Developer section. After your selection, you will be presented with three options for your data type which are as follows:

- Tees: A comma separated list of tees available to edit. For example, White,Yellow,Red. The default tees value is set to White, Yellow and Red.
- Holes: A comma separated list of tees available for each hole. For example: 1,2,3,4,5,6,7,8,9. The default holes value is set to 1 to 18 holes.
- Pars: A comma separated list of pars available for each hole. For example: 3,4,5. The default value is set to pars 3, 4 and 5.

Once setup, you will be able to add the data type as a property to a document type. When an instance of that document type is created, the editor will be displayed a collection of editable tees.

## Usage

When using a property value on a template, add the following code to return and use a list of golf tees.

    var holes = Model.Content.GetPropertyValue<AgeBase.GolfHoleEditor.Models.GolfTees>("alias");

Once converted, you will be able to select or loop through each golf tee. For example:

    @{
        <ul>
            @foreach (var hole in holes)
            {
                <li>
                    Tee: @hole.Name
                    <ul>
                        <li>Par: @hole.Par</li>
                        <li>Stroke Index: @hole.StrokeIndex</li>
                        <li>Distance: @hole.Distance yards</li>
                    </ul>
                </li>
            }
        </ul>
    }

## Contributing

To raise a new bug, create an [issue](https://github.com/agebase/umbraco-golf-hole-editor/issues) on the Github repository. To fix a bug or add new features or providers, fork the repository and send a [pull request](https://github.com/agebase/umbraco-golf-hole-editor/pulls) with your changes. Feel free to add ideas to the repository's [issues](https://github.com/agebase/umbraco-golf-hole-editor/issues) list if you would to discuss anything related to the package.

## Publishing

Remember to include all necessary files within the package.xml file. Run the following script, entering the new version number when prompted to created a published version of the package:

    Build\Release.bat

The release script will amend all assembly versions for the package, build the solution and create the package file. The script will also commit and tag the repository accordingly to reflect the new version.