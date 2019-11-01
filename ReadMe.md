Prerequisites:
# Visual Studio SDK

In order to build the VSIX installer containing the project templates:
# Choose the Release target
# Build 'VSIX Installer'->'TridionExtensionTemplates' project
# Now you've got the VSIX installer in your bin\Release folder

In order to modify the source code of one of the templates (e.g. 'EventSystemExtension') and get an effect of those changes within the installer:

First, generate the updated project template
# Select the 'Template Sources'->'EventSystemExtension' project (Warning: don't build it, if you occasionally did that, revert the changes made by the build before proceeding to the next step)
# Project->Export template
# Filldown all the required properties and proceed with the template creation 
# As a result there will be explorer window opened pointing to the folder containing the template zip archive (EventSystemExtension.zip). That is our tempalte. Copy it into the clipboard.

Put that template into the installer:
# Navigate to 'VSIX Installer'->'TridionExtensionTemplates'->ProjectTemplates folder
# Paste there the previosuly copied EventSystemExtension.zip file
# Choose the Release target
# Build 'VSIX Installer'->'TridionExtensionTemplates' project
# Now you've got the VSIX installer in your bin\Release folder
