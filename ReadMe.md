# Prerequisites:
Visual Studio 2019

Visual Studio 2019 SDK

Tridion Sites 9.5 (9.1*)
* Tridion assembly references within the project tempaltes must be adjusted accordingly in order to support 9.1 version

# How to build the VSIX installer
* Choose the Release target

* Build 'VSIX Installer'->'TridionExtensionTemplates' project

* Now you've got the VSIX installer in your bin\Release folder

# How to update the project template

Generate the updated project template:
* Select the 'Template Sources'->'EventSystemExtension' project 
  * Warning: don't build it, if you occasionally did that, revert the changes made by the build before proceeding to the next step
* Project->Export template
* Filldown all the required properties and proceed with the template creation 
* As a result there will be explorer window opened pointing to the folder containing the template zip archive (EventSystemExtension.zip). That is our tempalte. Copy it into the clipboard.

Put that template into the installer:
* Navigate to 'VSIX Installer'->'TridionExtensionTemplates'->ProjectTemplates folder
* Paste there the previosuly copied EventSystemExtension.zip file
* Choose the Release target
* Build 'VSIX Installer'->'TridionExtensionTemplates' project
* Now you've got the VSIX installer in your bin\Release folder
