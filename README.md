# Offset Champion

Offset Champion is a nifty little program that takes your Game Maker: Studio room.gmx and background.gmx files and adjusts them to work with a new tile offset and separation. It was programmed as a companion to Tileset Champion, a program that adds extra graphical space between tiles in tilesets in order to prevent cracking or seaming of tiles (see this tech blog post for more information). 

How does Offset Champion work? 

First, Offset Champion applies the new offsets to every background.gmx file marked as a tileset so that they show up properly in the editor. Then, Offset Champion splits up all tile groups in every room, marking each split tile with a new procedurally generated tile name. After that, Offset Champion goes through all the rooms, assigns each tile a new ID, and corrects the tile’s offset window. Offset Champion also has the option to lock all tiles on maps (just go to Options -> Lock Maps). 

What do I need to use Offset Champion? 

- Your project needs to be a Game Maker: Studio project! 
- Your tilesets must ALL have the same horizontal offset, vertical offset, horizontal separation, and vertical separation 
- You must have tilesets with extra graphical “bleed” in between the tiles (Tileset Champion will automate this for you) 

How do I use Offset Champion? 

Just point the program to your source background and rooms directories in your Game Maker: Studio project. After doing that, point the program to the directories you’d like to dump the processed files to. Let the program know your current tile offset and separation, and then let it know the offset you’d like to move it to. After all that, click “Process” and the program will process your files. Make sure to back up your files before you process them! You only have yourself to blame for lost project files. 

Offset Champion 1.1 © 2016 Modest Arcade LLC. Offset Champion is free to use, including for commercial games. 
DotNetZip Licensed under Microsoft Public License (Ms-PL). See http://dotnetzip.codeplex.com for more information.
