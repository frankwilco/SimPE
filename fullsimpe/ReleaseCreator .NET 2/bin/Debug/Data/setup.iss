; SimPE Installer v. 0.3
; Note: the installer version is unrelated to SimPe version: it's related to the installer code only.
; New in v.0.2: added components for 3 tools by Theo
; New in v.0.2a: fixed the default Group for menu icons.
; New in v.0.3:
;   - The structure of the source files has been modified, to sort them by function, more than by final destination.
;   - The script has been modified to automatically install all the files found in the various subfolders (but an
;     explicit list of files included in each sectionhas been kept for the records and for checking purposes).
;   - Readded the Career Editor, now compatible with Pets careers.

[Setup]
AppName=SimPE
AppVerName=SimPE {shortver} (alpha)
DefaultDirName={pf}\SimPE
OutputBaseFilename={setupname}
Compression=lzma
WizardImageFile=..\__Installer\embedded\WizardImage.bmp
WizardSmallImageFile=..\__Installer\embedded\WizardSmallImage.bmp
InternalCompressLevel=ultra
DisableReadyPage=false
SetupIconFile=..\__Installer\embedded\SimPE.ico
AppID=SimPE
UninstallDisplayIcon={app}\SimPe.exe
OutputDir=.
SolidCompression=true
ChangesAssociations=true
AllowNoIcons=true
DirExistsWarning=no
ShowComponentSizes=false
DefaultGroupName=SimPE

[Dirs]
Name: {app}\Data\Plugins\pjse.coder.plugin\Includes; Components: core\pljones
Name: {app}\Teleport; Components: core\simpe

[Files]

; ===========================================================================================================
; |   COMMON COMPONENTS    |=================================================================================
; ===========================================================================================================
Source: ..\__Installer\AppFiles\Core\Readme.txt; DestDir: {app}; Flags: ignoreversion isreadme
; ===========================================================================================================
; |   *CORE* COMPONENTS    |=================================================================================
; ===========================================================================================================
; Component: core\simpe (i.e. "Core")
Source: ..\__Installer\AppFiles\Core\SimPE\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: core\simpe
; NOTE: the "Core" is composed by files in {app}, {app}\Data and {app}\Plugins
; (the "recursesubdirs" flag takes care of writing each file to the correct destination).
; Here are listed only the files created by Quaxi for the SimPE; the core files for the PJSE are listed below
; -----------------------------------------------------------------------------------------------------------
; Files in the CORE\SIMPE section (copied to {app}):
; 7z.dll
; AdvancedForms.dll
; ambertation.3D.dll
; ambertation.3D.mdx.binding.dll
; ambertation.utilities.dll
; EnumComboBox.dll
; Eyefinder.dll
; GPL-LICENSE.txt
; graphcontrol.dll
; ICSharpCode.SharpZipLib.dll
; License.txt
; License-de.txt
; Navisight.dll
; NetDocks.dll
; NewHexEdit.dll
; SandDock.dll
; simpe.3idr.dll
; simpe.cache.dll
; simpe.clst.dll
; simpe.commandline.dll
; simpe.commonhandler.dll
; SimPe.exe
; SimPe.exe.manifest
; simpe.extfilehandler.dll
; simpe.filehandler.dll
; simpe.geometry.dll
; simpe.gmdc.exporter.base.dll
; simpe.helper.dll
; simpe.interfaces.dll
; simpe.names.dll
; simpe.package.dll
; simpe.rcol.dll
; simpe.resourcecontrols.dll
; simpe.s2cp.dll
; simpe.scenegraph.dll
; simpe.sims.dll
; simpe.splash.dll
; SimPe.vshost.exe.manifest
; simpe.wizardbase.dll
; simpe.workspace.dll
; sims.guid.dll
; TemplWarning.txt
; TemplWarning-de.txt
; tgaview.dll
; Warning.txt
; Warning-de.txt
; XPCommonControls.dll
; xsi.lib.dll
; -----------------------------------------------------------------------------------------------------------
; Files in the CORE\SIMPE\DATA section (copied to {app}\Data):
; additional_careers.xml
; additional_majors.xml
; additional_schools.xml
; expansions.xreg
; objddefinition.xml
; propertydefinition.xsd
; semiglobals.xml
; tgi.xml
; tgi.xsd
; txmtdefinition.xml
; txmtdefinition.xsd
; xreg.xsd
; -----------------------------------------------------------------------------------------------------------
; Files in the CORE\SIMPE\PLUGINS section (copied to {app}\Plugins);
; simpe.ngbh.plugin.dll
; simpe.scanfolder.plugin.dll
; simpe.toolbox.plugin.dll
; simpe.workshop.plugin.dll
; ===========================================================================================================
; Component: ThirdParty\PLJones (PJSE Core Files = PLJones Coder) (CORE files!)
Source: ..\__Installer\AppFiles\Core\PJSE\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: core\pljones
; Files in the CORE\PJSE\PLUGINS section (copied to {app}\Plugins);
; pjse.coder.plugin.dll
; pjse.coder.plugin\*.* (incl. PJSE_Help subfolder)
; pjse.filetable.plugin.dll
; pjse.localisation.dll
; pjse.SystemClasses.dll
; pjse.updatetool.dll
; ===========================================================================================================
; |   *PLUGIN* COMPONENTS    |===============================================================================
; ===========================================================================================================
; Component: Plugins\3D
Source: ..\__Installer\AppFiles\Non-Core\SimPE-3D\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: Plugins\3D
; Files in the NON-CORE\SIMPE-3D\PLUGINS section (copied to {app}\Plugins);
; optional.simpe.3d.plugin.dll
; + SimPE Core Files: ambertation.3D, ambertation.3D.mdx.binding, ambertation.utilities, simpe.commonhandlersimpe.geometry, simpe.gmdc.exporter.base, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.workspace, XPCommonControls
; + Microsoft DirectX (not included)
; + Microsoft VisualBasic (not included)
; ===========================================================================================================
; Component: SimpeGmdcExporter (adds formats .OBJ, .TXT, .X, .XSI to the GMDC import/export window)
Source: ..\__Installer\AppFiles\Non-Core\SimPE-GmdcExporter\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\SimpeGMDC
; Files in the NON-CORE\SIMPE-GMDCEXPORTER\PLUGINS section (copied to {app}\Plugins);
; simpe.default.gmdc.exporter.dll
; + SimPE Core Files: ambertation.3D, ambertation.utilities, simpe.commonhandler, simpe.geometry, simpe.gmdc.exporter.base, simpe.helper, simpe.interfaces, simpe.rcol, xsi.lib
; ===========================================================================================================
; Component: SimpeNHscanner
Source: ..\__Installer\AppFiles\Non-Core\SimPE-NHscanner\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\SimpeNHscanner
; Files in the NON-CORE\SIMPE-NHSCANNER\PLUGINS section (copied to {app}\Plugins);
; simpe.ngbh.scanner.plugin.dll
; + SimPE Core Files: simpe.cache, simpe.commonhandler, simpe.helper, simpe.interfaces, simpe.ngbh.plugin, simpe.package, simpe.rcol, simpe.scanfolder.plugin
; ===========================================================================================================
; Component: SimpeScenegrapher
Source: ..\__Installer\AppFiles\Non-Core\SimPE-Scenegrapher\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\SimpeScenegrapher
; Files in the NON-CORE\SIMPE-SCENEGRAPHER\PLUGINS section (copied to {app}\Plugins);
; simpe.scenegrapher.plugin.dll
; + SimPE Core Files: graphcontrol, simpe.clst, simpe.commonhandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.scenegraph, simpe.workspace
; ===========================================================================================================
; Component: ThirdParty\CareerEditor (Requires the PJSE Common Files in order to work)
Source: ..\__Installer\AppFiles\Non-Core\Bidou-CareerEditor\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\careereditor
; Files in the NON-CORE\BIDOU-CAREEREDITOR\PLUGINS section (copied to {app}\Plugins);
; bidou.career.plugin.dll
; + SimPE Core Files: simpe.3idr, simpe.clst, simpe.commonhandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.workspace
; + PJSE  Core Files: pjse.coder.plugin, pjse.SystemClasses
; ===========================================================================================================
; Component: ThirdParty\PLJonesObj (Object Finder)
Source: ..\__Installer\AppFiles\Non-Core\PLJones-ObjectFinder\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\pljonesobj
; Files in the NON-CORE\PLJONES-OBJECTFINDER\PLUGINS section (copied to {app}\Plugins);
; pjse.guidtool.plugin.dll
; + PJSE Common Files (see above)
; ===========================================================================================================
; Component: ThirdParty\PLJonesBody (Body Mesh Tool)
Source: ..\__Installer\AppFiles\Non-Core\PLJones-BodyMeshTool\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\pljonesbody
; Files in the NON-CORE\PLJONES-BODYMESHTOOL\PLUGINS section (copied to {app}\Plugins);
; pjBodyMeshTool.plugin.dll
; pjBodyMeshTool.plugin\*.*
; + SimPE Core Files: simpe.3idr, simpe.commonhandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.scenegraph, simpe.workspace
; ===========================================================================================================
; Component: ThirdParty\PLJonesObjKey (ObjKey [3IDR] Tool)
Source: ..\__Installer\AppFiles\Non-Core\PLJones-ObjKey\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\pljonesobjkey
; Files in the NON-CORE\PLJONES-OBJKEY\PLUGINS section (copied to {app}\Plugins);
; pjObjKeyTool.plugin.dll
; pjObjKeyTool.plugin\*.*
; + PJSE Common Files (see above)
; ===========================================================================================================
; Component: ThirdParty\Includes (PJSE 'Includes' + GUID list)
Source: ..\__Installer\AppFiles\Non-Core\Numenor\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\Includes
; Files in the NON-CORE\NUMENOR\PLUGINS section (copied to {app}\Plugins);
; pjse.coder.plugin\Includes\*.*
; pjse.coder.plugin\guidindex.txt
; ===========================================================================================================
; Component: ThirdParty\SimDeleter
;Source: ..\__Installer\AppFiles\Non-Core\SimPE-SimDeleter\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\simdeleter
; Files in the NON-CORE\SIMPE-SIMDELETER\PLUGINS section (copied to {app}\Plugins);
; simpe.actiondeletesim.plugin.dll
; ===========================================================================================================
; Component: ThirdParty\SkankyBoy
Source: ..\__Installer\AppFiles\Non-Core\SkankyBoy\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\skankyboy
; Files in the NON-CORE\SKANKYBOY\PLUGINS section (copied to {app}\Plugins);
; skankyboy.mesh.importer.exporter.dll
; skankyboy.smd.importer.exporter.dll
; ===========================================================================================================
; Component: ThirdParty\TheoSurgery
;Source: ..\__Installer\AppFiles\Non-Core\Theo-Surgery\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\TheoSurgery
; Files in the NON-CORE\THEO-SUERGERY\PLUGINS section (copied to {app}\Plugins);
; theo.surgery.plugin.dll
; ===========================================================================================================
; Component: ThirdParty\TheoScanner
;Source: ..\__Installer\AppFiles\Non-Core\Theo-MeshScanner\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\TheoScanner
; Files in the NON-CORE\THEO-MESHSCANNER\PLUGINS section (copied to {app}\Plugins);
; theo.meshscanner.plugin.dll
; ===========================================================================================================
; Component: ThirdParty\TheoBinningTool
;Source: ..\__Installer\AppFiles\Non-Core\Theo-BinningTool\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\TheoBinningTool
; Files in the NON-CORE\THEO-BINNINGTOOL\PLUGINS section (copied to {app}\Plugins);
; theos.gbct.plugin.dll
; ===========================================================================================================
; Component: ThirdParty\TheoClothingEditor
;Source: ..\__Installer\AppFiles\Non-Core\Theo-ClothingEditor\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: plugins\TheoClothingEditor
; Files in the NON-CORE\THEO-CLOTHINGEDITOR\PLUGINS section (copied to {app}\Plugins);
; theos.sim-clothing-editor.plugin.dll
; ===========================================================================================================
; Component: SimpeBHAV (SimPE built-in BHAV editor)
Source: ..\__Installer\AppFiles\Non-Core\SimPE-BHAV\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: core\simpe
; Files in the NON-CORE\SIMPE-BHAV section (copied to {app});
; simpe.bhav.plugin.dll
; + SimPE Core Files: simpe.clst, simpe.commonhandler, simpe.extfilehandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.workspace
; + PJSE  Core Files: pjse.coder.plugin
; ===========================================================================================================
; |   *EXTRA* COMPONENTS    |================================================================================
; ===========================================================================================================
; Component: SimpeDockBox
Source: ..\__Installer\AppFiles\Extra\SimPE-DockBox\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: extra\SimpeDockBox
; Files in the NON-CORE\SIMPE-DOCKBOX\PLUGINS section (copied to {app}\Plugins);
; simpe.dockbox.plugin.dll
; + SimPE Core Files: AdvancedForms, graphcontrol, NetDocks, NewHexEdit, simpe.3idr, simpe.clst, simpe.commonhandler, simpe.extfilehandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.s2cp, simpe.scenegraph, simpe.workspace, XPCommonControls
; + Microsoft VisualBasic
; ===========================================================================================================
; Component: SimpeDownloads
Source: ..\__Installer\AppFiles\Extra\SimPE-Downloads\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: extra\SimpeDownloads
; Files in the NON-CORE\SIMPE-DOWNLOADS\PLUGINS section (copied to {app}\Plugins);
; simpe.downloads.plugin.dll
; + SimPE Core Files: 7z.dll, ambertation.3D, ambertation.3D.mdx.binding, ambertation.utilities, EnumComboBox, graphcontrol, simpe.3idr, simpe.cache, simpe.clst, simpe.commonhandler, simpe.extfilehandler, simpe.filehandler, simpe.gmdc.exporter.base, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.s2cp, simpe.scanfolder.plugin, simpe.scenegraph, simpe.workshop.plugin, simpe.workspace
; + Microsoft DirectX
; ===========================================================================================================
; Component: wos (Wizards of SimPE - Includes files in {app} and in {app}\Plugins)
Source: ..\__Installer\AppFiles\Extra\SimPE-WOS\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: extra\wos
; Files in the NON-CORE\SIMPE-WOS section (copied to {app});
; Wizards of SimPE.exe
; Wizards of SimPE.exe.manifest
; Wizards of SimPE.vshost.exe.manifest
; wosimpe.interfaces.dll
; Plugins\wosimpe.recolor.wizard.dll
; + SimPE Core Files: graphcontrol, simpe.cache, simpe.commandline, simpe.extfilehandler, simpe.filehandler, simpe.helper, simpe.interfaces, simpe.package, simpe.rcol, simpe.scenegraph, simpe.workshop.plugin, simpe.toolbox.plugin, simpe.workspace
; ===========================================================================================================
; Component: debug
Source: ..\__Installer\AppFiles\Extra\SimPE-Debug\*.*; DestDir: {app}; Flags: overwritereadonly ignoreversion recursesubdirs; Components: extra\debug
; Files in the NON-CORE\SIMPE-DEBUG section (copied to {app});
; CacheBrowser.exe
; NET Test.exe
; Validator.exe
; WrapperTest.exe
; Data\release.nfo
; ===========================================================================================================
; Component: Doc\...
Source: ..\__Installer\AppFiles\Extra\Doc\de\*.*; DestDir: {app}\Doc\de; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Components: extra\doc\de
Source: ..\__Installer\AppFiles\Extra\Doc\en\*.*; DestDir: {app}\Doc\en; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Components: extra\doc\en
; ===========================================================================================================
; Task: lang\...
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\de\*.*; DestDir: {app}\de; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langDE
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\es\*.*; DestDir: {app}\es; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langES
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\fr\*.*; DestDir: {app}\fr; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langFR
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\it\*.*; DestDir: {app}\it; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langIT
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\pl\*.*; DestDir: {app}\pl; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langPL
Source: ..\__Installer\AppFiles\Extra\LanguagePacks\ru\*.*; DestDir: {app}\ru; Flags: overwritereadonly ignoreversion recursesubdirs createallsubdirs; Tasks: langRU
; ===========================================================================================================
; ===========================================================================================================



[Registry]
Root: HKCR; Subkey: .package; ValueType: String; ValueData: Sims2.Package; Tasks: assocpackage; Flags: uninsdeletevalue uninsdeletekeyifempty
Root: HKCR; Subkey: Sims2.Package; ValueType: String; ValueData: DBPF Package; Tasks: assocpackage; Flags: uninsdeletekey
Root: HKCR; Subkey: Sims2.Package\Shell\Open\Command; ValueType: String; ValueData: """{app}\SimPe.exe"" ""%1"""; Tasks: assocpackage; Flags: uninsdeletevalue
Root: HKCR; Subkey: .simpe; ValueType: String; ValueData: Sims2.SimPEData; Tasks: assocsimpe; Flags: uninsdeletevalue uninsdeletekeyifempty
Root: HKCR; Subkey: Sims2.SimPEData; ValueType: String; ValueData: SimPE Packed File; Tasks: assocsimpe; Flags: uninsdeletekey
Root: HKCR; Subkey: Sims2.SimPEData\Shell\Open\Command; ValueType: String; ValueData: """{app}\SimPe.exe"" ""%1"""; Tasks: assocsimpe; Flags: uninsdeletevalue
Root: HKCR; Subkey: .s2cp; ValueType: String; ValueData: Sims2.CommunityPackage; Tasks: assocs2cp; Flags: uninsdeletevalue uninsdeletekeyifempty
Root: HKCR; Subkey: Sims2.CommunityPackage; ValueType: String; ValueData: Sims2Community Package; Tasks: assocs2cp; Flags: uninsdeletekey
Root: HKCR; Subkey: Sims2.CommunityPackage\Shell\Open\Command; ValueType: String; ValueData: """{app}\SimPe.exe"" ""%1"""; Tasks: assocs2cp; Flags: uninsdeletevalue
Root: HKCU; Subkey: Software\Ambertation\SimPe; Components: core\simpe

[Run]
Filename: {app}\SimPe.exe; Description: {cm:LaunchProgram,SimPE}; Components: core\simpe; Flags: postinstall nowait; Tasks: ; Languages: 
;Filename: {app}\Readme.txt; Description: {cm:ViewReadme}; Flags: postinstall nowait shellexec

[Icons]
Name: {group}\{cm:C_Doc}\SimPE Einfhrung (Übersetzt von Rado); Filename: {app}\Doc\Einleitung.pdf; Components: extra\doc\de
Name: {group}\{cm:C_Doc}\TazzMann's SimPE von Grund auf (Übersetzt von Rado); Filename: {app}\Doc\SimPE_VGA.pdf; Components: extra\doc\de
Name: {group}\{cm:C_Doc}\SimPE Introduction; Filename: {app}\Doc\Introduction.pdf; Components: extra\doc\en
Name: {group}\{cm:C_Doc}\TazzMann's SimPE from the Group up; Filename: {app}\Doc\SimPE_FTGU.pdf; Components: extra\doc\en
Name: {group}\{cm:C_Theme}\{cm:C_classic_look}; Filename: {app}\SimPe.exe; Parameters: -classicpreset
Name: {group}\{cm:C_Theme}\{cm:C_modern_look}; Filename: {app}\SimPe.exe; Parameters: -modernpreset
Name: {group}\SimPE; Filename: {app}\SimPe.exe
Name: {group}\Wizards of SimPE; Filename: {app}\Wizards of SimPE.exe; Components: extra\wos
Name: {userdesktop}\SimPE; Filename: {app}\SimPe.exe; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\SimPE; Filename: {app}\SimPe.exe; Tasks: quicklaunchicon

[Tasks]
Name: assocpackage; Description: {cm:AssocFileExtension,SimPE,.package}; Components: core\simpe
Name: assocsimpe; Description: {cm:AssocFileExtension,SimPE,.simpe}; Components: core\simpe
Name: assocs2cp; Description: {cm:AssocFileExtension,SimPE,.s2cp}; Components: core\simpe
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Components: core\simpe
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Components: core\simpe
Name: langEN; Description: {cm:C_LangEN}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Check: UnsupportedLang; Flags: unchecked; Languages: 
Name: langDE; Description: {cm:C_LangDE}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangDE
Name: langFR; Description: {cm:C_LangFR}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangFR
Name: langES; Description: {cm:C_LangES}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangES
Name: langIT; Description: {cm:C_LangIT}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangIT; Languages: 
Name: langPL; Description: {cm:C_LangPL}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangPL
Name: langRU; Description: {cm:C_LangRU}; Components: core\simpe; GroupDescription: {cm:C_LangTask}; Flags: unchecked; Check: IsLangRU

[Components]
Name: core; Description: {cm:C_Core}; Types: full custom min; Flags: disablenouninstallwarning fixed
Name: core\simpe; Description: {cm:C_Main}; Types: full custom min; Flags: disablenouninstallwarning fixed
Name: core\pljones; Description: {cm:C_PLJones}; Types: full custom min; Flags: disablenouninstallwarning fixed
Name: extra; Description: {cm:C_Extra}; Types: full custom; Flags: disablenouninstallwarning
Name: extra\SimpeDockBox; Description: {cm:C_SimpeDockBox}; Types: custom min full; Flags: disablenouninstallwarning
Name: extra\SimpeDownloads; Description: {cm:C_SimpeDownloads}; Types: custom min full; Flags: disablenouninstallwarning
Name: extra\wos; Description: {cm:C_Wos}; Types: full custom min; Flags: disablenouninstallwarning
Name: extra\debug; Description: {cm:C_Debug}; Types: full custom; Flags: disablenouninstallwarning
Name: extra\doc; Description: {cm:C_Doc}; Types: full custom; Flags: disablenouninstallwarning
Name: extra\doc\en; Description: {cm:C_doc_en}; Types: full custom; Flags: disablenouninstallwarning
Name: extra\doc\de; Description: {cm:C_doc_de}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins; Description: {cm:C_Plugins}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\3d; Description: {cm:C_3D_Plugins}; Types: full custom; Flags: disablenouninstallwarning
;Name: plugins\SimpeBHAV; Description: {cm:C_SimpeBHAV}; Types: full custom min; Flags: disablenouninstallwarning
Name: plugins\SimpeGMDC; Description: {cm:C_SimpeGMDC}; Types: full custom min; Flags: disablenouninstallwarning
Name: plugins\SimpeNHscanner; Description: {cm:C_SimpeNHscanner}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\SimpeScenegrapher; Description: {cm:C_SimpeScenegrapher}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\careereditor; Description: {cm:C_CareerEditor}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\Includes; Description: {cm:C_Includes}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\pljonesobj; Description: {cm:C_PLJones_obj}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\pljonesbody; Description: {cm:C_PLJones_body}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\pljonesobjkey; Description: {cm:C_PLJones_objkey}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\simdeleter; Description: {cm:C_SimDeleter}; Types: full custom; Flags: disablenouninstallwarning
Name: plugins\skankyboy; Description: {cm:C_SkankyBoy}; Types: full custom; Flags: disablenouninstallwarning
;Name: plugins\TheoScanner; Description: {cm:C_TheoScanner}; Types: full custom; Flags: disablenouninstallwarning
;Name: plugins\TheoSurgery; Description: {cm:C_TheoSurgery}; Types: full custom; Flags: disablenouninstallwarning
;Name: plugins\TheoBinningTool; Description: {cm:C_TheoBinningTool}; Types: full custom; Flags: disablenouninstallwarning
;Name: plugins\TheoClothingEditor; Description: {cm:C_TheoClothingEditor}; Types: full custom; Flags: disablenouninstallwarning




[Types]
Name: full; Description: {cm:C_Complete}
Name: min; Description: {cm:C_Min}
Name: custom; Description: {cm:C_Custom}; Flags: iscustom

[CustomMessages]
en.NameAndVersion=%1 version %2
it.NameAndVersion=%1 versione %2
de.NameAndVersion=%1 Version %2
pl.NameAndVersion=%1 wersja %2
en.AdditionalIcons=Additional icons:
it.AdditionalIcons=Icone aggiuntive:
de.AdditionalIcons=Zusätzliche Symbole:
pl.AdditionalIcons=Dodatkowe ikony:
en.CreateDesktopIcon=Create a &desktop icon
it.CreateDesktopIcon=Crea icone sul &desktop
de.CreateDesktopIcon=&Desktop-Symbol anlegen
pl.CreateDesktopIcon=Utwórz ikonê na &pulpicie
en.CreateQuickLaunchIcon=Create a &Quick Launch icon
it.CreateQuickLaunchIcon=Crea icona nel menu &Quick Launch
de.CreateQuickLaunchIcon=Symbol in der Schnellstartleiste anlegen
pl.CreateQuickLaunchIcon=Utwórz ikonê na pasku &szybkiego uruchamiania
en.ProgramOnTheWeb=%1 on the Web
it.ProgramOnTheWeb=%1 sul Web
de.ProgramOnTheWeb=%1 im Internet
pl.ProgramOnTheWeb=Strona WWW programu %1
en.UninstallProgram=Uninstall %1
it.UninstallProgram=Disinstalla %1
de.UninstallProgram=%1 entfernen
pl.UninstallProgram=Deinstalacja programu %1
en.LaunchProgram=Launch %1
it.LaunchProgram=Avvia %1
de.LaunchProgram=%1 starten
pl.LaunchProgram=Uruchom program %1
en.AssocFileExtension=&Associate %1 with the %2 file extension
it.AssocFileExtension=&Associa %1 con l'estensione %2
de.AssocFileExtension=&Registriere %1 mit der %2-Dateierweiterung
pl.AssocFileExtension=&Przypisz program %1 do rozszerzenia pliku %2
en.AssocingFileExtension=Associating %1 with the %2 file extension...
it.AssocingFileExtension=Associazione di %1 con l'estensione %2...
de.AssocingFileExtension=%1 wird mit der %2-Dateierweiterung registriert...
pl.AssocingFileExtension=Przypisywanie programu %1 do rozszerzenia pliku %2...
NoDotNet=The .NET Framework v2.0 does not appear to be installed, and SimPE will not run without it.%n%nYou can download the framework from Windows Update.%n%nPress OK to install SimPE anyway, or Cancel to exit.
it.NoDotNet=Il Framework .NET v2.0 non sembra installato sul sistema; SimPE non può funzionare senza di esso.%n%nE' possibile scaricare il Framework .NET tramite Windows Update.%n%nPremere OK per installare comunque SimPE, o Cancel per interrompere.
de.NoDotNet=Das .NET Framework v2.0 ist auf ihrem System scheinbar nicht installiert. SimPE wird ohne .NET nicht starten.%n%n.NEt kann z.B. ber das Windows Update installiert werden%n%nWhlen si OK um SimPE dennoch zu installieren oder Abbrechen um zu beenden.
ViewReadme=View readme file
it.ViewReadme=Visualizza il file Leggimi
de.ViewReadme=Readme Datei anzeigen
C_Core=Core components
it.C_Core=Componenti essenziali
de.C_Core=Kern-Komponenten
C_Main=SimPE and basic plugins
it.C_Main=SimPE e plugins di base
de.C_Main=SimPE und standard Erweiterungen
C_Classic=SimPE (classic GUI)
it.C_Classic=SimPE (Interfaccia "Classic")
de.C_Classic=SimPE (altes Benutzerinterface)
C_Wos=Wizards of SimPE
it.C_Wos=Wizards of SimPE
de.C_Wos=Wizards of SimPE
C_LangEN=(Option not available on this system)
it.C_LangEN=(Opzione non disponibile su questo sistema)
de.C_LangEN=(Option ist auf diesem System nicht verfügbar)
C_LangDE=German
it.C_LangDE=Tedesco
de.C_LangDE=Deutsch
C_LangIT=Italian (by Sims2Cri)
it.C_LangIT=Italiano (by Sims2Cri)
de.C_LangIT=Italienisch (von Sims2Cri)
C_Theme=Theme
it.C_Theme=Tema
de.C_Theme=Aussehen
C_modern_look=Modern Look
it.C_modern_look=Interfaccia Moderna
de.C_modern_look=Modern
C_classic_look=Classic Look
it.C_classic_look=Interfaccia Classica
de.C_classic_look=Klassisch
C_Doc=Documentation
it.C_Doc=Documentazione
de.C_Doc=Dokumentation
C_Debug=Debugging Components
it.C_Debug=Componenti per il debug
de.C_Debug=Komponenten zur Fehlersuche
C_PsTemplate=Photo Studio Templates
it.C_PsTemplate=Templates per Photo Studio
de.C_PsTemplate=Vorlagen für Photo Studio
UninstallPrevious=Uninstalling the previous version of SimPE...
it.UninstallPrevious=Disinstallazione versioni precedenti di SimPE...
de.UninstallPrevious=Eine bestehende Version von SimPE deinstallieren...
UninstallPreviousFailed=Uninstallation of the previous version of SimPE failed.%n%nDo you want to ignore that and continue installing SimPE anyway?
it.UninstallPreviousFailed=La disinstallazione delle precedenti versioni di SimPE è fallita.%n%nVuoi proseguire comunque con l'installazione?
de.UninstallPreviousFailed=Die Deinstallation von SimPE schlug fehl.%n%nSoll dieser Fehler ignoriert und SimPE dennoch installiert werden?
C_ThirdParty=ThirdParty SimPE Plugins
it.C_ThirdParty=Plugins di terze parti
de.C_ThirdParty=Zusätzliche Erweiterungen
C_CareerEditor=Bidou's Career Editor
it.C_CareerEditor=Editor delle Carriere (by Bidou)
de.C_CareerEditor=Bidou's Kariere Editor
C_PLJones=PLJones SimAntics Editor
it.C_PLJones=SimAntics Editor (by PLJones)
de.C_PLJones=PLJones SimAntics Editor
C_doc_en=English Documentation
it.C_doc_en=Documentazione in inglese
de.C_doc_en=Englische Anleitungen
C_doc_de=German Documentation
it.C_doc_de=Documentazione in tedesco
de.C_doc_de=Deutsche Anleitungen
C_Lang=Language Files (Translations)
it.C_Lang=Lingue alternative di SimPE (Traduzioni)
de.C_Lang=Sprachpakete (Übersetzungen)
C_Complete=Complete
it.C_Complete=Installazione completa
de.C_Complete=Vollständig
C_Custom=Custom
it.C_Custom=Installazione personalizzata
de.C_Custom=Benutzerdefiniert
C_Min=Minimum
it.C_Min=Installazione minima
de.C_Min=Minimal
C_PLJones_obj=PLJones Object Finder
it.C_PLJones_obj=Object Finder (by PLJones)
de.C_PLJones_obj=PLJones Objekt Finder
C_PLJones_body=PLJones Body Mesh Tool
it.C_PLJones_body=Body Mesh Tool (by PLJones)
de.C_PLJones_body=PLJones Body Mesh Tool
C_SkankyBoy=SkankyBoys Mesh Importer/Exporter (3DS, SMD)
it.C_SkankyBoy=Mesh Importer/Exporter (3DS, SMD) (by SkankyBoys)
de.C_SkankyBoy=SkankyBoys Mesh Importer/Exporter (3DS, SMD)
C_Plugins=Additional Plugins (optional)
it.C_Plugins=Plugin aggiuntivi (opzionali)
de.C_Plugins=Zusätzliche Erweiterungen
C_3D_Plugins=3D Preview for ANIM files
it.C_3D_Plugins=Anteprima 3D di file ANIM
de.C_3D_Plugins=3D Werkzeuge
C_LangES=Spanish (by Malakun)
it.C_LangES=Spagnolo (by Malakun)
de.C_LangES=Spanisch (von Malakun)
C_LangPL=Polish (by Wlodi)
it.C_LangPL=Polacco (by Wlodi)
de.C_LangPL=Polnisch (von Wlodi)
C_LangRU=Russian (by Necromante)
it.C_LangRU=Russo (by Necromante)
de.C_LangRU=Russisch (von Necromante)
C_LangFR=French (by DeeVo)
it.C_LangFR=Francese (by DeeVo)
de.C_LangFR=Französisch (von DeeVo)
C_LangTask=Install OPTIONAL interface translation:
it.C_LangTask=Installa traduzione OPZIONALE per l'interfaccia:
de.C_LangTask=Installiere OPTIONALE Übersetzungen:
C_TheoSurgery=Theo's Sim Surgery
it.C_TheoSurgery=Sim Surgery (by Theo)
de.C_TheoSurgery=Sim Surgery (von Theo)
C_TheoScanner=Theo's Mesh Scanner
it.C_TheoScanner=Mesh Scanner (by Theo)
de.C_TheoScanner=Mesh Scanner (von Theo)
C_TheoBinningTool=Theo's Binning Tool
it.C_TheoBinningTool=Binning Tool (by Theo)
de.C_TheoBinningTool=Binning Tool (von Theo)
C_TheoClothingEditor=Theo's Clothing Editor
it.C_TheoClothingEditor=Clothing Editor (by Theo)
de.C_TheoClothingEditor=Clothing Editor (von Theo)
C_Includes=Optional TRCN and TPRP list for SimAntics Editor
it.C_Includes=File TRCN/TPRP opzionali per il SimAntics Editor
de.C_Includes=Optional TRCN und TPRP für SimAntics Editor
C_SimDeleter=Sim Deleter Tool (by Quaxi)
it.C_SimDeleter=Sim Deleter Tool (by Quaxi)
de.C_SimDeleter=Sim Deleter Tool (von Quaxi)
C_Extra=Extras
it.C_Extra=Componenti aggiuntivi
de.C_Extra=Extras
C_SimpeBHAV=SimPE built-in BHAV editor
it.C_SimpeBHAV=Editor BHAV standard
de.C_SimpeBHAV=SimPE BHAV Editor
C_SimpeDockBox=Support for dockable windows
it.C_SimpeDockBox=Supporto per la personalizz. delle finestre
de.C_SimpeDockBox=Support für dockbare Fenster
C_SimpeDownloads=Support for external downloads
it.C_SimpeDownloads=Supporto per downloads esterni
de.C_SimpeDownloads=Support für die externen Downloads
C_SimpeGMDC=Support for mesh in OBJ, TXT, X, XSI formats
it.C_SimpeGMDC=Supporto per mesh in formato OBJ, TXT, X, XSI
de.C_SimpeGMDC=Support für 3D-Formate in OBJ, TXT, X, XSI
C_SimpeNHscanner=Neighborhood Scanner
it.C_SimpeNHscanner=Scanner dei quartieri
de.C_SimpeNHscanner=Nachbarschafts-Scanner
C_SimpeScenegrapher=Scenegrapher
it.C_SimpeScenegrapher=Scenegrapher
de.C_SimpeScenegrapher=Scenegrapher
C_PLJones_objkey=PLJones ObjKey (3idr) Tool
it.C_PLJones_objkey=PLJones ObjKey (3idr) Tool
de.C_PLJones_objkey=PLJones ObjKey (3idr) Tool

[Languages]
; Note: When adding a new language here, please include also a translation of all the 'Custom Messages'
Name: en; MessagesFile: compiler:Default.isl; LicenseFile: ..\__Installer\embedded\enLicense.txt; InfoBeforeFile: ..\__Installer\embedded\enInfoBefore.txt
Name: de; MessagesFile: compiler:Languages\German.isl; LicenseFile: ..\__Installer\embedded\deLicense.txt; InfoBeforeFile: ..\__Installer\embedded\deInfoBefore.txt
Name: pl; MessagesFile: compiler:Languages\Polish.isl; LicenseFile: ..\__Installer\embedded\plLicense.txt; InfoBeforeFile: ..\__Installer\embedded\plInfoBefore.txt
Name: it; MessagesFile: compiler:Languages\Italian.isl; LicenseFile: ..\__Installer\embedded\itLicense.txt; InfoBeforeFile: ..\__Installer\embedded\itInfoBefore.txt


[InstallDelete]
Name: {app}\Plugins\theo*.dll; Type: files
Name: {app}\Data\*; Type: files

[UninstallDelete]
;Name: {app}\Data\*.template; Type: files
Name: {app}\Data\*; Type: files
Name: {app}\Teleport; Type: dirifempty
Name: {app}; Type: dirifempty

[Messages]
BeveledLabel=SimPE - Simple Package Editor
ComponentSize1=
ComponentSize2=
ComponentsDiskSpaceMBLabel=

[_ISToolPreCompile]
; The following batch file copies all the files provided by Peter into the folder 'AppFiles' (sorted by functions);
; The expected folder structure is:
;    (Folder where this script resides)
;    (it also contains the files sent by Peter, unsorted, as the CVS creates them)
;                 |------> ..\__Installer
;                              |------> LatestWorkingAppFiles (it's the AppFiles from the latest working release: needed to get the documentation and few other files, always missing from the QA releases provided by Peter)
;                              |------> Embedded (contains Licence, icon and language files: they never change)
;
; The batch files creates and regroups the file in a folder structure like this:
;    (Folder where this script resides)
;                              |------> AppFiles (where the files are copied to, at this stage; later on, the script will read them and compress into the installer)
;                                           |------> Core (created by this script during copy)
;                                           |------> Non-Core (created by this script during copy)
;                                           |------> Extras (created by this script during copy)
;
; called by the release Creator now
; Name: ..\__Installer\___COPY-files-to-Release.bat; Flags: abortonerror

[Code]
//================================================================================================
function UnsupportedLang(): Boolean;
//Note: the language codes can be found at http://msdn2.microsoft.com/en-us/library/ms776294
begin
  Result := True;
  if GetUILanguage and $3FF = $07 then Result := False;
  if GetUILanguage and $3FF = $0C then Result := False;
  if GetUILanguage and $3FF = $0A then Result := False;
  if GetUILanguage and $3FF = $10 then Result := False;
  if GetUILanguage and $3FF = $15 then Result := False;
  if GetUILanguage and $3FF = $19 then Result := False;
end;
//================================================================================================
function IsLangDE(): Boolean;
begin
  if GetUILanguage and $3FF = $07 then Result := True;
end;
//================================================================================================
function IsLangFR(): Boolean;
begin
  if GetUILanguage and $3FF = $0C then Result := True;
end;
//================================================================================================
function IsLangES(): Boolean;
begin
  if GetUILanguage and $3FF = $0A then Result := True;
end;
//================================================================================================
function IsLangIT(): Boolean;
begin
  if GetUILanguage and $3FF = $10 then Result := True;
end;
//================================================================================================
function IsLangPL(): Boolean;
begin
  if GetUILanguage and $3FF = $15 then Result := True;
end;
//================================================================================================
function IsLangRU(): Boolean;
begin
  if GetUILanguage and $3FF = $19 then Result := True;
end;
//================================================================================================
function GetUninstallString( AppID: String ): String;
var
 sPrevPath: String;
begin
 sPrevPath := '';
 if not RegQueryStringValue( HKLM, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\'+AppID+'_is1', 'UninstallString', sPrevpath ) then RegQueryStringValue( HKCU, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\'+AppID+'_is1' , 'UninstallString', sPrevpath ); Result := sPrevPath;
end;
//================================================================================================
function FileMove(sFile: String; sSrcPath: String; sDestPath: String): Boolean;
begin
 FileCopy((sSrcPath+sFile), (sDestPath+sFile), False);
 DeleteFile((sSrcPath+sFile));
end;
//================================================================================================
procedure CurStepChanged(CurStep: TSetupStep);
var
  sPrevPath: String;
  sPrevID: String;
  ResultCode: Integer;
begin
  if CurStep = ssInstall then begin
	 //Uninstalls previous installations, as per user request.
	 sPrevID := 'SimPE';
	 sPrevPath := GetUninstallString(sPrevID);
	 if (Length(sPrevPath) > 0) then begin
		 sPrevPath := RemoveQuotes(sPrevPath);
		 if FileExists(sPrevPath) then Exec( sPrevPath, '/SILENT', '', SW_SHOW, ewWaitUntilTerminated, ResultCode );
	 end;
  end;
end;
