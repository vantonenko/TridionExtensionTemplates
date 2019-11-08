# The roadmap

## Custom configuration template
Addon service supports uploading the custom configuration file per package so that the addon developer doesn't have to distribute sensitive information like passwords, connection strings within the zip package.

It's required to create a project template that consumes the data from the custom configuration file using the AddonService.SDK API
## Resolver template
Content Manager has "CMResolver" extension point capable to customize the resolving process.

It's required to create a project template that implements some sample resolver extension, preferably the one easy to smoke test on the CM environment.
## UI Model template
Typical CME addon uses three extension points: 
* "CMEventHandler" - in order to extend CoreService output, there's already a sample for that
* "UIEditor" - in order to extend the CME UI controls, there's already a lightweight sample for that
* "UIModel" - in order to extend the CME UI business logic

It is required to create a project template for the last one
## UI Editor complex template
There's already a lightweight UIEditor project template capable to extend the list with a new column by means of the editor.config file. 

Typical UIEditor extension though might also include JavaScript, ASPX and C# code.

It is required to create such a project template capable to build and pack all its sources into the add-on package.
## CM assemblies versions
Most of the extensions require to reference CM assemblies for their needs. 

Currently developed project templates use the 9.5 strong name assembly references. 
So that in order to create an extension targeting 9.1 CM the extension developer will have to adjust the references once he created a new project from the template.

It's required to find an approach for easier use of the project templates across different CM versions. Some of the alternative  options:
* Introduce a UI option into the project template
* Put the version-less references into the templates
* Put the referenced assembly files into the package
## Visual Studio version
Currently, the VSIX installer generated from the project only supports Visual Studio 2019. Consider enabling support of the other Visual Studio versions.
## Names & Descriptions
Currently, all the project templates' names are short single words, descriptions are empty.

Consider giving them more specific names so that it would be easier to find the project template across all the installed templates. 

Also, introduce self-describing descriptions.