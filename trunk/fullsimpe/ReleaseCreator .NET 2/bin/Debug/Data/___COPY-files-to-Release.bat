@PROMPT -  

REM - The root folder it the one where the .bat resides
SET SRC={simpedir}
SET SRC2={simpedir}\..\__Installer\LatestWorkingAppfiles
SET DST={simpedir}\..\__Installer\AppFiles

REM - Deletes the existing AppFiles folder so to provide a clean environment
RD /S /Q %DST%


XCOPY "%SRC%\Readme.txt" "%DST%\Core\" /C /I /R /Y

REM =====================================================================================================
REM - Copying files from QA in the proper DST folders

REM -----------------------------------------------------------------------------------------------------
REM - Core\SimPE (root)

MD "%DST%\Core\SimPE"
MD "%DST%\Core\PJSE"

XCOPY "%SRC%\7z.dll" "%DST%\Core\SimPE\" /Y
XCOPY "%SRC%\AdvancedForms.dll" "%DST%\Core\SimPE\" /Y
XCOPY "%SRC%\ambertation.3D.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\ambertation.3D.mdx.binding.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\ambertation.utilities.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\EnumComboBox.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\Eyefinder.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\GPL-LICENSE.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\graphcontrol.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\ICSharpCode.SharpZipLib.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\License.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\License-de.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\Navisight.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\NetDocks.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\NewHexEdit.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\SandDock.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.3idr.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.cache.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.clst.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.commandline.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.commonhandler.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\SimPe.exe" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\SimPe.exe.manifest" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.extfilehandler.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.filehandler.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.geometry.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.gmdc.exporter.base.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.helper.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.interfaces.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.names.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.package.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.rcol.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.resourcecontrols.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.s2cp.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.scenegraph.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.sims.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.splash.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\SimPe.vshost.exe.manifest" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.wizardbase.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\simpe.workspace.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\sims.guid.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\TemplWarning.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\TemplWarning-de.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\tgaview.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\Warning.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\Warning-de.txt" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\XPCommonControls.dll" "%DST%\Core\SimPE\" /C /I /R /Y
XCOPY "%SRC%\xsi.lib.dll" "%DST%\Core\SimPE\" /C /I /R /Y

REM -----------------------------------------------------------------------------------------------------
REM - Core\SimPE\Data

XCOPY "%SRC%\Data\additional_careers.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\additional_majors.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\additional_schools.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\expansions.xreg" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\objddefinition.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\propertydefinition.xsd" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\semiglobals.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\tgi.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\tgi.xsd" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\txmtdefinition.xml" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\txmtdefinition.xsd" "%DST%\Core\SimPE\Data\" /C /I /R /Y
XCOPY "%SRC%\Data\xreg.xsd" "%DST%\Core\SimPE\Data\" /C /I /R /Y

REM -----------------------------------------------------------------------------------------------------
REM - Core\SimPE\Plugins

XCOPY "%SRC%\Plugins\simpe.ngbh.plugin.dll" "%DST%\Core\SimPE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.scanfolder.plugin.dll" "%DST%\Core\SimPE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.toolbox.plugin.dll" "%DST%\Core\SimPE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.workshop.plugin.dll" "%DST%\Core\SimPE\Plugins\" /C /I /R /Y

REM -----------------------------------------------------------------------------------------------------
REM - Core\PJSE (rot and subfolders)

XCOPY "%SRC%\Plugins\pjse.coder.plugin.dll" "%DST%\Core\PJSE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.coder.plugin\*.*" "%DST%\Core\PJSE\Plugins\pjse.coder.plugin\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.filetable.plugin.dll" "%DST%\Core\PJSE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.localisation.dll" "%DST%\Core\PJSE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.SystemClasses.dll" "%DST%\Core\PJSE\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.updatetool.dll" "%DST%\Core\PJSE\Plugins\" /C /I /R /Y

REM -----------------------------------------------------------------------------------------------------
REM - Extras & Optional plugins

XCOPY "%SRC%\Plugins\optional.simpe.3d.plugin.dll" "%DST%\Non-Core\SimPE-3D\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.default.gmdc.exporter.dll" "%DST%\Non-Core\SimPE-GmdcExporter\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.ngbh.scanner.plugin.dll" "%DST%\Non-Core\SimPE-NHscanner\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.scenegrapher.plugin.dll" "%DST%\Non-Core\SimPE-Scenegrapher\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\bidou.career.plugin.dll" "%DST%\Non-Core\Bidou-CareerEditor\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjse.guidtool.plugin.dll" "%DST%\Non-Core\PLJones-ObjectFinder\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjBodyMeshTool.plugin.dll" "%DST%\Non-Core\PLJones-BodyMeshTool\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjBodyMeshTool.plugin\*.*" "%DST%\Non-Core\PLJones-BodyMeshTool\Plugins\pjBodyMeshTool.plugin\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.actiondeletesim.plugin.dll" "%DST%\Non-Core\SimPE-SimDeleter\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\skankyboy.mesh.importer.exporter.dll" "%DST%\Non-Core\SkankyBoy\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\skankyboy.smd.importer.exporter.dll" "%DST%\Non-Core\SkankyBoy\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\theo.meshscanner.plugin.dll" "%DST%\Non-Core\Theo-MeshScanner\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\theos.gbct.plugin.dll" "%DST%\Non-Core\Theo-BinningTool\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\theos.sim-clothing-editor.plugin.dll" "%DST%\Non-Core\Theo-ClothingEditor\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\theos.simsurgery.plugin.dll" "%DST%\Non-Core\Theo-Surgery\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.bhav.plugin.dll" "%DST%\Non-Core\SimPE-BHAV\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.dockbox.plugin.dll" "%DST%\Extra\SimPE-DockBox\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Plugins\simpe.downloads.plugin.dll" "%DST%\Extra\SimPE-Downloads\Plugins\" /C /I /R /Y
XCOPY "%SRC%\Wizards of SimPE.exe" "%DST%\Extra\SimPE-WOS\" /C /I /R /Y
XCOPY "%SRC%\Wizards of SimPE.exe.manifest" "%DST%\Extra\SimPE-WOS\" /C /I /R /Y
XCOPY "%SRC%\Wizards of SimPE.vshost.exe.manifest" "%DST%\Extra\SimPE-WOS\" /C /I /R /Y
XCOPY "%SRC%\wosimpe.interfaces.dll" "%DST%\Extra\SimPE-WOS\" /C /I /R /Y
XCOPY "%SRC%\Plugins\wosimpe.recolor.wizard.dll" "%DST%\Extra\SimPE-WOS\Plugins\" /C /I /R /Y
XCOPY "%SRC%\CacheBrowser.exe" "%DST%\Extra\SimPE-Debug\" /C /I /R /Y
XCOPY "%SRC%\NET Test.exe" "%DST%\Extra\SimPE-Debug\" /C /I /R /Y
XCOPY "%SRC%\Validator.exe" "%DST%\Extra\SimPE-Debug\" /C /I /R /Y
XCOPY "%SRC%\WrapperTest.exe" "%DST%\Extra\SimPE-Debug\" /C /I /R /Y
XCOPY "%SRC%\Data\release.nfo" "%DST%\Extra\SimPE-Debug\Data\" /C /I /R /Y
XCOPY "%SRC%\Plugins\pjObjKeyTool.plugin\*.*" "%DST%\Non-Core\PLJones-ObjKey\Plugins\pjObjKeyTool.plugin\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\pjObjKeyTool.plugin.dll" "%DST%\Non-Core\PLJones-ObjKey\Plugins\" /C /I /R /Y

REM =====================================================================================================
REM - Copying Includes and GUIDlist from LatestWorking (keeping them up-to-date is my job)

XCOPY "%SRC2%\Non-Core\Numenor\Data\Plugins\pjse.coder.plugin\Includes\*.*" "%DST%\Non-Core\Numenor\Data\Plugins\pjse.coder.plugin\Includes\" /S /C /I /R /Y
XCOPY "%SRC2%\Non-Core\Numenor\Data\Plugins\pjse.coder.plugin\guidindex.txt" "%DST%\Non-Core\Numenor\Data\Plugins\pjse.coder.plugin\" /C /I /R /Y

REM =====================================================================================================
REM - Copying Docs from LatestWorking and then overwriting the files with the ones from QA Docs
REM - (needed because often the QA doesn't contain complete documentation)

XCOPY "%SRC2%\Extra\Doc\*.*" "%DST%\Extra\Doc\" /S /C /I /R /Y
XCOPY "%SRC%\Doc\*.*" "%DST%\Extra\Doc\" /S /C /I /R /Y

REM =====================================================================================================
REM - Merging Language Packs from SRC Root and Plugins into Extra/Languagepacks

XCOPY "%SRC%\de\*.*" "%DST%\Extra\LanguagePacks\de\" /S /C /I /R /Y
XCOPY "%SRC%\es\*.*" "%DST%\Extra\LanguagePacks\es\" /S /C /I /R /Y
XCOPY "%SRC%\fr\*.*" "%DST%\Extra\LanguagePacks\fr\" /S /C /I /R /Y
XCOPY "%SRC%\it\*.*" "%DST%\Extra\LanguagePacks\it\" /S /C /I /R /Y
XCOPY "%SRC%\pl\*.*" "%DST%\Extra\LanguagePacks\pl\" /S /C /I /R /Y
XCOPY "%SRC%\ru\*.*" "%DST%\Extra\LanguagePacks\ru\" /S /C /I /R /Y

XCOPY "%SRC%\Plugins\de\*.*" "%DST%\Extra\LanguagePacks\de\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\es\*.*" "%DST%\Extra\LanguagePacks\es\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\fr\*.*" "%DST%\Extra\LanguagePacks\fr\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\it\*.*" "%DST%\Extra\LanguagePacks\it\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\pl\*.*" "%DST%\Extra\LanguagePacks\pl\" /S /C /I /R /Y
XCOPY "%SRC%\Plugins\ru\*.*" "%DST%\Extra\LanguagePacks\ru\" /S /C /I /R /Y

REM =====================================================================================================

pause