[Constants]
#define FriendlyVersion "{shortver} (alpha)"

#define RawVersion GetFileVersion('SimPE.exe')

[Setup]
OutputDir=.
OutputBaseFilename={setupname}
AppName=SimPE
AppVerName=SimPE {#FriendlyVersion}
AppVersion={#FriendlyVersion}
VersionInfoVersion={#RawVersion}
AppPublisher=Ambertation
AppPublisherURL=http://sims.ambertation.de/
AppSupportURL=http://ambertation.de/simpeforum/
AppUpdatesURL=http://sims.ambertation.de/
DefaultDirName={pf}\SimPE
DefaultGroupName=SimPE
AllowNoIcons=true
Compression=lzma/ultra
SolidCompression=true
ChangesAssociations=true
InternalCompressLevel=ultra
ShowTasksTreeLines=true
ShowLanguageDialog=yes
FlatComponentsList=false
WizardImageFile=C:\Users\frank\Documents\Quellen\SVN\fullsimpe\SimPe Main\img\ModernImage.bmp
WizardSmallImageFile=C:\Users\frank\Documents\Quellen\SVN\fullsimpe\SimPe Main\img\SmallImage.bmp

[Languages]
Name: en; MessagesFile: compiler:Default.isl; InfoBeforeFile: Warning.txt; LicenseFile: license.txt
Name: de; MessagesFile: compiler:Languages\German.isl; InfoBeforeFile: Warning-de.txt; LicenseFile: license-de.txt
Name: pl; MessagesFile: compiler:Languages\Polish.isl; LicenseFile: License.txt; InfoBeforeFile: Warning.txt

[CustomMessages]
NoDotNet=The .NET Framework v2.0 does not appear to be installed, and SimPE will not run without it.%n%nYou can download the framework from Windows Update.%n%nPress OK to install SimPE anyway, or Cancel to exit.
de.NoDotNet=Das .NET Framework v2.0 ist auf ihrem System scheinbar nicht installiert. SimPE wird ohne .NET nicht starten.%n%n.NEt kann z.B. über das Windows Update installiert werden%n%nWählen si OK um SimPE dennoch zu installieren oder Abbrechen um zu beenden.
ViewReadme=View readme file
de.ViewReadme=Readme Datei anzeigen
C_Main=SimPE and basic plugins
de.C_Main=SimPE und standard Erweiterungen
C_Classic=SimPE (classic GUI)
de.C_Classic=SimPE (altes Benutzerinterface)
C_Wos=Wizards of SimPE
de.C_Wos=Wizards of SimPE
C_LangDE=German
de.C_LangDE=Deutsch
C_LangIT=Italian (by Sims2Cri)
de.C_LangIT=Italienisch (von Sims2Cri)
C_Theme=Theme
de.C_Theme=Aussehen
C_modern_look=Modern Look
de.C_modern_look=Modern
C_classic_look=Classic Look
de.C_classic_look=Klassisch
C_Doc=Documentation
de.C_Doc=Dokumentation
C_Debug=Debbuging Components
de.C_Debug=Komponenten zur Fehlersuche
C_PsTemplate=Photo Studio Templates
de.C_PsTemplate=Vorlagen für Photo Studio
UninstallPrevious=Uninstalling the previous version of SimPE...
de.UninstallPrevious=Eine bestehende Version von SimPE deinstallieren...
UninstallPreviousFailed=Uninstallation of the previous version of SimPE failed.%n%nDo you want to ignore that and continue installing SimPE anyway?
de.UninstallPreviousFailed=Die Deinstallation von SimPE schlug fehl.%n%nSoll dieser Fehler ignoriert und SimPE dennoch installiert werden?
C_ThirdParty=ThirdParty SimPE Plugins
de.C_ThirdParty=Zusätzliche Erweiterungen
C_CareerEditor=Bidou's Career Editor
de.C_CareerEditor=Bidou's Kariere Editor
C_PLJones=PlJones SimAntics Editor
de.C_PLJones=PlJones SimAntics Editor
C_doc_en=English Documentation
de.C_doc_en=Englische Anleitungen
C_doc_de=German Documentation
de.C_doc_de=Deutsche Anleitungen
C_Lang=Language Files (Translations)
de.C_Lang=Sprachpakete (Übersetzungen)
C_Complete=Complete
de.C_Complete=Vollständig
C_Custom=Custom
de.C_Custom=Benutzerdefiniert
C_Min=Minimum
de.C_Min=Minimal
C_PLJones_obj=PlJones Object Finder
de.C_PLJones_obj=PlJones Objekt Finder
C_PLJones_body=PlJones Body Mesh Tool
de.C_PLJones_body=PlJones Body Mesh Tool
C_SkankyBoy=SkankyBoys Mesh Importer/Exporter (3DS, SMD)
de.C_SkankyBoy=SkankyBoys Mesh Importer/Exporter (3DS, SMD)
C_Plugins=Extras
de.C_Plugins=Extras
C_3D_Plugins=3D Tools
de.C_3D_Plugins=3D Werkzeuge
C_LangES=Spanish (by Malakun)
de.C_LangES=Spanisch (von Malakun)
C_LangPL=Polish (by Wlodi)
de.C_LangPL=Polnisch (von Wlodi)
C_LangRU=Russian (by Necromante)
de.C_LangRU=Russisch (von Necromante)
C_LangFR=French (by DeeVo)
de.C_LangFR=Französisch (von DeeVo)
C_Theo=Theo's Shack
de.C_Theo=Theo's Shack

[Types]
Name: full; Description: {cm:C_Complete}
Name: min; Description: {cm:C_Min}
Name: custom; Description: {cm:C_Custom}; Flags: iscustom

[Components]
Name: main; Description: {cm:C_Main}; Flags: fixed; Types: full custom min
Name: lang; Description: {cm:C_Lang}; Types: custom full
Name: lang\DE; Description: {cm:C_LangDE}; Types: custom full
Name: lang\PL; Description: {cm:C_LangPL}; Types: custom full
Name: lang\ES; Description: {cm:C_LangES}; Types: custom full
Name: lang\IT; Description: {cm:C_LangIT}; Types: custom full
Name: lang\RU; Description: {cm:C_LangRU}; Types: custom full
Name: lang\FR; Description: {cm:C_LangFR}; Types: custom full
Name: doc; Description: {cm:C_Doc}; Types: full
Name: doc\en; Description: {cm:C_doc_en}; Types: custom full
Name: doc\de; Description: {cm:C_doc_de}; Types: custom full
Name: wos; Description: {cm:C_Wos}; Types: full
Name: debug; Description: {cm:C_Debug}; Types: full custom
Name: Plugins; Description: {cm:C_Plugins}; Types: full; Check: MyPluginsCheck
Name: Plugins\3D; Description: {cm:C_3D_Plugins}; Types: full; Check: My3DCheck
Name: ThirdParty; Description: {cm:C_ThirdParty}; Types: full custom
Name: ThirdParty\CareerEditor; Description: {cm:C_CareerEditor}; Types: custom full
Name: ThirdParty\PLJones; Description: {cm:C_PLJones}; Types: custom full min; Flags: fixed
Name: ThirdParty\PLJonesObj; Description: {cm:C_PLJones_obj}; Types: custom full
Name: ThirdParty\PLJonesBody; Description: {cm:C_PLJones_body}; Types: custom full
Name: ThirdParty\SkankyBoy; Description: {cm:C_SkankyBoy}; Types: custom full
Name: ThirdParty\Theo; Description: {cm:C_Theo}; Types: custom full


[Tasks]
Name: assocpackage; Description: {cm:AssocFileExtension,SimPE,.package}; Components: main; Flags: unchecked
Name: assocsimpe; Description: {cm:AssocFileExtension,SimPE,.simpe}; Components: main
Name: assocs2cp; Description: {cm:AssocFileExtension,SimPE,.s2cp}; Components: main; Flags: unchecked
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked; Components: main
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked; Components: main

[Registry]
Root: HKCR; SubKey: .package; ValueType: string; ValueData: Sims2.Package; Flags: uninsdeletevalue uninsdeletekeyifempty; Tasks: assocpackage
Root: HKCR; SubKey: Sims2.Package; ValueType: string; ValueData: DBPF Package; Flags: uninsdeletekey; Tasks: assocpackage
Root: HKCR; SubKey: Sims2.Package\Shell\Open\Command; ValueType: string; ValueData: """{app}\SimPe.exe"" ""%1"""; Flags: uninsdeletevalue; Tasks: assocpackage
Root: HKCR; SubKey: .simpe; ValueType: string; ValueData: Sims2.SimPEData; Flags: uninsdeletevalue uninsdeletekeyifempty; Tasks: assocsimpe
Root: HKCR; SubKey: Sims2.SimPEData; ValueType: string; ValueData: SimPE Packed File; Flags: uninsdeletekey; Tasks: assocsimpe
Root: HKCR; SubKey: Sims2.SimPEData\Shell\Open\Command; ValueType: string; ValueData: """{app}\SimPe.exe"" ""%1"""; Flags: uninsdeletevalue; Tasks: assocsimpe
Root: HKCR; SubKey: .s2cp; ValueType: string; ValueData: Sims2.CommunityPackage; Flags: uninsdeletevalue uninsdeletekeyifempty; Tasks: assocs2cp
Root: HKCR; SubKey: Sims2.CommunityPackage; ValueType: string; ValueData: Sims2Community Package; Flags: uninsdeletekey; Tasks: assocs2cp
Root: HKCR; SubKey: Sims2.CommunityPackage\Shell\Open\Command; ValueType: string; ValueData: """{app}\SimPe.exe"" ""%1"""; Flags: uninsdeletevalue; Tasks: assocs2cp
Root: HKCU; Subkey: Software\Ambertation\SimPe; Components: main

[Dirs]
Name: {app}; Flags: uninsalwaysuninstall
; The above entry isn't strictly required, but it requests Inno to try to delete the folder on uninstall,
; even if it already existed.  Don't worry though -- if the folder isn't empty (because some user-created
; files are still there) then it will be left alone.

[Files]
Source: Readme.txt; DestDir: {app}; Flags: ignoreversion
Source: SimPe.exe; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: Wizards of SimPE.exe; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: wos
Source: SimPe.exe.manifest; DestDir: {app}; Flags: ignoreversion; Components: main
Source: Data\*.xml; DestDir: {app}\Data; Flags: ignoreversion recursesubdirs; Components: main
Source: Data\*.xsd; DestDir: {app}\Data; Flags: ignoreversion recursesubdirs; Components: main
Source: Plugins\simpe*.dll; DestDir: {app}\Plugins; Flags: ignoreversion recursesubdirs overwritereadonly; Components: main
Source: Plugins\wos*.dll; DestDir: {app}\Plugins; Flags: ignoreversion recursesubdirs overwritereadonly; Components: wos
Source: de\*.dll; DestDir: {app}\de; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\DE
Source: pl\*.dll; DestDir: {app}\pl; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\PL
Source: es\*.dll; DestDir: {app}\es; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\ES
Source: it\*.dll; DestDir: {app}\it; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\IT
Source: ru\*.dll; DestDir: {app}\ru; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\RU
Source: fr\*.dll; DestDir: {app}\fr; Flags: ignoreversion recursesubdirs overwritereadonly; Components: lang\FR
Source: Doc\en\*.pdf; DestDir: {app}\Doc; Flags: ignoreversion recursesubdirs; Components: doc\en
Source: Doc\de\*.pdf; DestDir: {app}\Doc; Flags: ignoreversion recursesubdirs; Components: doc\de
Source: XPCommonControls.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
;Source: 3dview.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: Eyefinder.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: ICSharpCode.SharpZipLib.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: Navisight.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: NewHexEdit.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: SandBar.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: SandDock.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.3idr.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
; Source: simpe.byteview.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.cache.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.clst.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.commandline.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.commonhandler.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.extfilehandler.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.filehandler.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.geometry.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.gmdc.exporter.base.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.helper.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.interfaces.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.names.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.package.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.rcol.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.s2cp.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.scenegraph.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: simpe.workspace.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: sims.guid.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: skybound.visualstyles.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: tgaview.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: wosimpe.interfaces.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: wos
Source: graphcontrol.dll; DestDir: {app}; Components: main; Flags: ignoreversion overwritereadonly
Source: Data\release.nfo; DestDir: {app}\Data; Flags: overwritereadonly ignoreversion; Components: debug
Source: Validator.exe; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: debug
Source: NET Test.exe; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: debug
Source: simpe.sims.dll; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: main
Source: simpe.wizardbase.dll; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: main
Source: EnumComboBox.dll; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: main
Source: Plugins\bidou.career.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\CareerEditor
Source: Plugins\pjse.coder.plugin\*; DestDir: {app}\Plugins\pjse.coder.plugin\; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJones ThirdParty\CareerEditor
Source: Plugins\pjse.coder.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJones ThirdParty\CareerEditor
Source: Plugins\pjse.filetable.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJones ThirdParty\CareerEditor
Source: simpe.resourcecontrols.dll; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: main
Source: simpe.splash.dll; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: main
Source: Wizards of SimPE.exe.manifest; DestDir: {app}; Flags: overwritereadonly ignoreversion; Components: wos
Source: Plugins\pjse.guidtool.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesObj
Source: Plugins\pjse.guidtool.plugin\*; DestDir: {app}\Plugins\pjse.guidtool.plugin\; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesObj
Source: Plugins\skankyboy.mesh.importer.exporter.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\SkankyBoy
Source: Plugins\optional.simpe.3d.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: Plugins\3D
Source: Plugins\skankyboy.smd.importer.exporter.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\SkankyBoy
Source: Plugins\pjse.coder.plugin\PJSE_Help\*; DestDir: {app}\Plugins\pjse.coder.plugin\PJSE_Help\; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJones
Source: Plugins\pjse.coder.plugin\PJSE_Help\PJSE_HelpImages\*; DestDir: {app}\Plugins\pjse.coder.plugin\PJSE_Help\PJSE_HelpImages; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJones
Source: xsi.lib.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: ambertation.3D.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: ambertation.3D.mdx.binding.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: ambertation.utilities.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: 7z.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: Data\expansions.xreg; DestDir: {app}\Data; Flags: overwritereadonly ignoreversion; Components: main
Source: Plugins\pjBodyMeshTool.plugin\*; DestDir: {app}\Plugins\pjBodyMeshTool.plugin\; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesBody
Source: Plugins\pjBodyMeshTool.plugin\pjBodyMeshTool_Help\*; DestDir: {app}\Plugins\pjBodyMeshTool.plugin\pjBodyMeshTool_Help\; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesBody
Source: Plugins\pjBodyMeshTool.plugin.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesBody
Source: Plugins\pjse.localisation.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesBody ThirdParty\PLJonesObj ThirdParty\PLJones ThirdParty\CareerEditor
Source: Plugins\pjse.updatetool.dll; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\PLJonesBody ThirdParty\PLJonesObj ThirdParty\PLJones ThirdParty\CareerEditor
Source: AdvancedForms.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: NetDocks.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly; Components: main
Source: Data\expansions.xreg; DestDir: {app}\Data; Flags: ignoreversion overwritereadonly; Components: main
Source: Plugins\theo.*; DestDir: {app}\Plugins; Flags: overwritereadonly ignoreversion; Components: ThirdParty\Theo


[Icons]
Name: {group}\{cm:C_Doc}\SimPE Einführung (Übersetzt von Rado); Filename: {app}\Doc\Einleitung.pdf; Components: doc\de
Name: {group}\{cm:C_Doc}\TazzMann's SimPE von Grund auf (Übersetzt von Rado); Filename: {app}\Doc\SimPE_VGA.pdf; Components: doc\de
Name: {group}\{cm:C_Doc}\SimPE Introduction; Filename: {app}\Doc\Introduction.pdf; Components: doc\en
Name: {group}\{cm:C_Doc}\TazzMann's SimPE from the Group up; Filename: {app}\Doc\SimPE_FTGU.pdf; Components: doc\en
Name: {group}\{cm:C_Theme}\{cm:C_classic_look}; Filename: {app}\SimPe.exe; Parameters: -classicpreset; IconIndex: 0
Name: {group}\{cm:C_Theme}\{cm:C_modern_look}; Filename: {app}\SimPe.exe; Parameters: -modernpreset; IconIndex: 0
Name: {group}\SimPE; Filename: {app}\SimPe.exe
Name: {group}\Wizards of SimPE; Filename: {app}\Wizards of SimPE.exe; Components: wos
Name: {userdesktop}\SimPE; Filename: {app}\SimPe.exe; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\SimPE; Filename: {app}\SimPe.exe; Tasks: quicklaunchicon

[Run]
Filename: {app}\SimPe.exe; Description: {cm:LaunchProgram,SimPE}; Flags: nowait postinstall skipifsilent; Components: main
Filename: {app}\Readme.txt; Description: {cm:ViewReadme}; Flags: shellexec postinstall skipifsilent

[UninstallDelete]
Name: {app}\Formats; Type: filesandordirs; Components: main; Languages: 
Name: {app}\Codecs; Type: filesandordirs; Components: main
Name: {app}\7zecmd.dll; Type: files

[Code]
const
  UninstallKey = 'Software\Microsoft\Windows\CurrentVersion\Uninstall\SimPE_is1';
  MdxKey = 'SOFTWARE\Microsoft\.NETFramework\AssemblyFolders\Current Managed DirectX 9.2';

procedure UninstallPreviousVersion(Uninstaller: String);
var
  StatusPage: TOutputProgressWizardPage;
  Text, Path: String;
  ResultCode: Integer;
begin
  Text := SetupMessage(msgStatusUninstalling);
  StringChange(Text, '%1', 'SimPE');

  StatusPage := CreateOutputProgressPage(SetupMessage(msgWizardUninstalling), Text);
  StatusPage.SetText(ExpandConstant('{cm:UninstallPrevious}'), '');
  StatusPage.Show();
  try
    Path := ExtractFilePath(Uninstaller);
    if not Exec(Uninstaller, '/silent /norestart', Path, SW_SHOW, ewWaitUntilTerminated, ResultCode) then
      ResultCode := 1;
    if ResultCode <> 0 then begin
      if MsgBox(ExpandConstant('{cm:UninstallPreviousFailed}'), mbError, MB_YESNO) = IDNO then Abort;
    end;
  finally
    StatusPage.Hide();
    StatusPage.Free();
  end;
end;

function IsDotNet11Installed(): Boolean;
begin
  Result := RegKeyExists(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v2.0.50727');
end;

procedure DoPreInstall();
var
  ShouldUninstall: Boolean;
  Uninstaller: String;
begin
  ShouldUninstall := RegQueryStringValue(HKCU, UninstallKey, 'UninstallString', Uninstaller);
  if not ShouldUninstall then ShouldUninstall := RegQueryStringValue(HKLM, UninstallKey, 'UninstallString', Uninstaller);

  if ShouldUninstall then UninstallPreviousVersion(RemoveQuotes(Uninstaller));
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if not IsDotNet11Installed() then begin
    if MsgBox(ExpandConstant('{cm:NoDotNet}'), mbError, MB_OKCANCEL or MB_DEFBUTTON2) = IDCANCEL then begin
      Result := False;
      exit;
    end;
  end;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssInstall then DoPreInstall();
end;

function My3DCheck(): Boolean;
var
	mdxpath: String;
begin
	Result := False;
	if not RegKeyExists(HKLM, MdxKey) then begin
	    exit;
	end

	if not RegQueryStringValue(HKLM, MdxKey, '', mdxpath) then begin
		   exit;
	end

	Result := FileExists(mdxpath+'Microsoft.DirectX.dll');
end;

function MyPluginsCheck(): Boolean;
begin
    Result := My3DCheck();
end;
