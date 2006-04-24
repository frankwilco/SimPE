SimPe is a Community effort and will soon be released under the GPL.

I will give Credit to everyone involved in the development in Detail with a Final Version of SimPe. Some are listed below.


REMEMBER YOU NEED TO INSTALL Microsoft .NET Framework 1.1 IN ORDER TO RUN SimPE. 


SimPE Commandline Arguments:
---------------------------
Set the Theme of the new GUI to a more classic/modern like appearance
SimPE.exe -classicpreset
SimPe.exe -modernpreset

Create a new Package file form a package Description (package.xml)
SimPE.exe -build -desc [packag.xml] -out [output].package

Create a new Texture File from an arbitary Image File
SimPE.exe -txtr -image [imgfile] -out [output].package -name [textureNam] -format [dxt1|dxt3|dxt5|raw8|raw24|raw32] -levels [nr] -width [max. Width] -height [max. Height]

Make an old package EP Ready
SimPE.exe -fix -package [input].package -modelname [newModelName] -prefix [newPrefix]

SimPE File Table:
---------------------------
SimPe uses a Filetable to locate packed Files. This is used when creating a clone. SimPe is searching the FileTable for the needed Files.
This table is built from the content of package Files found in special Locations. Th Folders where SimPE searches those package Files 
can be set in the data/folder.xml File.

Here is the DTD used to process the folder.xml File
<?xml version="1.0" encoding="UTF-8"?>
<!ELEMENT folders (filetable)>
<!ELEMENT filetable (path*)>
<!ELEMENT path (#PCDATA)>
<!ATTLIST path
	root (game | ep1 | simpe | save) #IMPLIED
	recursive (0 | 1) #IMPLIED
	epversion (0 | 1) #IMPLIED
>

if some ressources are found in more than one location, SimPE will allways choose the resource found in the path that that was listed first

Adding Family Members:
---------------------------
Before you start, be sure to Backup your complete Sims 2 Savegame Folder. Just in case. 
(Remember SimPe 2 is in alpha state!).


1. Open the Nxxx_Neighborhood.package
2. Select (in the left Listbox) the Family Information Item
   ---> The righthand Listview will shouw you all available Families
4. Select the "Plugin View"-Tab and click on the first Family in the ListView
5. The "Plugin View" will show you The FamilyName and it's members. So look through 
   all your Family Files until you found the Family you want to change.
6. Add or Remove Family Members by pressing the corresponding button
7. Click the Commit Button.
8. Select "File->Save" to store the changed Package


Adding Family Members might not always work. Some Sims don't have a Sim Description File, if you 
add such a Sim, the Game will lokk when you enter the Lot. So before Loading a Lot, you have to look
at the Status Screen (the Dialog that apreas when you click on a Lot) if the sim has State 
Description (the little Text that apears underneath the Sims Head on the Status Screen). If it hasn't 
the Lot will probably not load.

Even tho sometimes all seems right and the Lot loads, the Sims will not be a Part of the Family. I
don't know why, so I can't tell you how to fix it! Sorry!

Editing Family Ties:
---------------------------
I know this is not much but it's only to get you started. To Edit FamilyTies, you have to choose
the "Family Ties" Filetype on the left and selet the on File that shows. On the Plugin View you will
see  SelectionBox on the Top, where all Sims are stored, that have active Family Ties. Select on and 
you get all the Ties available for the Sim.
If a Sim is not Listed, you can add it by Selecting the Sim in the SelectionList in the Middle of the 
Plugin View (which is also used in order to create new Ties for a Selected Sim), and click the create 
Button. If you look at the bottom of the upper SelectionBox you'll find that Sim, select him and you 
can add new Ties.

More Help:
---------------------------
If you're german check out http://www.simforum.de maybe your question did already come up there. 
Both german and english speaking users can come to the SimPE Forum at http://ambertation.de/simpeforum/. Lot's of basic Questions concerning SimPe were already discussed there!


Known Issues:
---------------------------
- At release time i do only know of this Problem: When you add a Sim to two Families 
(yes you can do that!), it might happen that he does not show up in the new Family. So whenever 
you add a  Sim to a Family and it will not be palyable with that Fam, you must remove the Sim from
the other Family (lots of Families there ;)

- "I can only sees "Unknow Unknow" for the names of my Sims, and it sasy No File found on the 
"Sim Description Editor": This might be a Problem of settings. Please make sure that the Option
"No Meta Information" in the Extra Menu is NOT checked!! If it isn't and you dont get any names 
or images, pleas check if the Folder where the .package File is stored contains a Directorx named
Characters.

- I can se the HexEditor Button but it is not Enabled: Well, SimPe does not ship with a HexEditor, because 
I thin every external Editor is better than anythin i would program into SimPe. So to activate this you 
first need a external HexEditor. If you have it installed go to Extra->Options and Enter the Location 
where the Hexeditor is stored. NOTE: This Feature is some sort of Developers Feature and is kind of new, 
so it might not work all the times. Non Technical Users should NOT uses this!


Licenes:
---------------------------
SourceGrid - .NET(C#) Grid control
Copyright (c) 2004, Davide Icardi
All rights reserved.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR 
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY 
AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, 
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER 
IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT 
OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

Byte View
Based on Total Byte Informer by WATTO
http://www.watto.org

Hash Class
Classless.Hasher from http://www.classless.net/, the Code was not modified, so as long as the Source 
of SimPe isn't available, you can download the Classes Source on the location given above.

SharZipLib 
http://www.icsharpcode.net/OpenSource/SharpZipLib/Default.aspx

The New SimPe GUI was enhanced using Controls by 
divElements (http://www.divil.co.uk/net/) and 
SteepValley (http://www.steepvalley.net/).

Most of the Icons used in SimPe were created by http://www.everaldo.com/ (KDE Crystal Clear Theme)

SimPE is using the 7-Zip commandline Utility to handle archives (like .7z, .rar...). The Software is distributed under GPL. For more Informations visit: http://www.7-zip.org.


Credits:
---------------------------
Finally got the Time to write some quick Credits for all the People that helped to develop
SimPe.

Basic Package handling Algorithm was programed after the WIKI entries on MTS II
Interesst/Character Properties/Skills were discovered by Buggi
Woman/Man Interests were posted by Makkentass
German Translation by QAlphAlpha
Thanks to http://www.simszone.de/ for offering a mirror for the German Version
And thanks to all people who have tested SimPe in the last weeks and sent me their Bug Reports.
BHAV and BCON Formats are implemented as Described on http://simtech.sourceforge.net/. Thanks 
to Garrett Berg for his greate help on the BHAV and TTAB usage!
The SemiGlobal Groups were discovered by Inge Jones.
Thanks to Pumuckl for the (correct) DXT3, DXT5 Decompression Code.
Thanks to Carrigon for the Unblur Patch Line
Thanks to Inge Jones for the SemiGlobal Groups (sorry that I forgot to mention you before :()
Thanks to Motoki for discovering the new RelationsShip type values.
Thanks to Pinhead for dicovering the new Fileds for YA Clothes and Sim Exports for Bodyshop
Thanks to JMPescado for the EP -Family Information Format
Thanks to Pinhead, Numenor and RGiles for finding everything needed to make the Recolor Options in the Object Workshop possible.
Installer by Uecasm
Additional PhotoStudio Templates created by Pinhead and Deedee (http://daydream.etowns.net)
GMDC Obj Exporter created by Delphy (http://www.modthesims2.com)
GMDC and ANIM decoding by Miche

Polish Translation by wlodi
