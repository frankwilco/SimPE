Please youes the __Solution/Example Plugin Project to compile this Plugin.

Remember this project is not intended to be distributed, if you want to build a plugin, 
make soure you at least rename the classes provided in this example. 
Using Visual Studio 2005 (Express) this is relativley easy. Simply open your Solution, 
and open all contained .cs Files in the "SimPE ExamplePugin" Project 
(You may want to open the Project Explorer (Ctrl+Alt+L) to do this). Then simply right 
click on all class names (Like MyWrapperFactory, MyPackedFileWrapper...) and select
Refactor/Rename... to change the name of your classes Project wide!

DO NOT ALTER ANY FILES BESIDES THE ONES IN "SimPE ExamplePugin", OTHERWISE YOUR PLUGIN WILL NOT
WORK USING A REGULAR SimPE!!!

Also, you might want to remove or at least deactivate the parts of the example Plugin you 
are not intending to use. (If you only offer a windowed Plugin, you should not provide the
example packed file wrappers or the dock plugins.
You can either remove the files and the the references in MyWrapperFactory, or you 
can disable the apropriate lines on top of MyWrapperFactory.cs.


If you need to compile the Plugin with VB.NET, you should use the VB Project stored in "SimPe ExamplePlugin\VB Project"
