@echo off

{simpedrive}
chdir {simpedir}
set PATH=%PATH%;C:\Program Files\7-Zip;

del {archivename}
7z.exe a {archivename} *.dll *.pdb SimPe.exe "SimPe*.manifest"  "Wizards of SimPE.exe" README.txt GPL-LICENSE.txt Plugins/*.dll Plugins/*.pdb Data/tgi.xml Data/txmtdefinition.xml Data/objddefinition.xml Data/propertydefinition.xsd Data/additional_*.xml Validator.exe "NET Test.exe" Data/release.nfo Plugins/pjse.coder.plugin/* Plugins/pjse.guidtool.plugin/*  "DivElements License.rtf"  Plugins/pjse.coder.plugin/PJSE_Help/* Plugins/pjse.coder.plugin/PJSE_Help/PJSE_HelpImages/* Data/expansions.xreg Data/semiglobals.xml Plugins/pjBodyMeshTool.plugin/pjBodyMeshTool_Help/* Plugins/pjBodyMeshTool.plugin/* Plugins/pjObjKeyTool.plugin/* Plugins/pjObjKeyTool.plugin/pjObjKeyTool_Help/* Plugins/*.plugin it\* ru\* fr\* de\* de-DE\* pl\* es\* Plugins/it\* Plugins/ru\* Plugins/fr\* Plugins/de\* Plugins/de-DE\* Plugins/pl\* Plugins/es\* 
echo ---------------------Done
pause
