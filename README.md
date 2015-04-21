# Level Editor Tool
This is a windows tool to quicly generate a layout for a top down 2D tiled based level.
You can draw the level layout in the application, it will generate a map file that you can then import into Unity using the editor script.
Once in Unity, the level should be playable straight away.

Using the Editor:
---
Once you open the editor, you a greated with a blank window. You can create a new room by going into File > Create New Room (CTRL + N), or open an existing map by going to File > Open Room (CTRL + O).
The following window should appear:

![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step1.jpg)
 
 You can set the room size, the first number is the width and the second the height. The cell size represents the size of each tiles that are going to be represented in the canvas.
 This means that the total width of the canvas in screen space is going to be the width * cell size.
 
 Once you hit Create, an empty canvas should appear. You first need to select which tile you want to draw, becuase the most common one is the floor, you can either press CTRL + D or go to Tools > Select Tile > floor.
 You can then start clicking on the canvas to start drawing tiles!
 Becuase drawing every single tile one click at the time is painfully slow and tedious, you can enable Rectangle Draw Mode, which makes it so you only need to click two points and it will fill a rectangle of the selected tile in between.
 You can enable it by pressing CTRL + Q or by going in Tools > Rectangle Draw Mode. You can toggle back and forth the same way.
 
![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step2.jpg)
 
 Notice that you can check which tile you have selected and if Rectangle Draw Mode is enabled at the bottom of the window.
 
 If you want to remove tiles, select the empty tile by pressing CTRL + A, or by going to Tools > Select Tile > Empty, and start drawing empty tiles.
 
 You can save your work at any time by pressing CTRL + S and exporting the map. You can Open it back up at a later time with CTRL + O.
 
![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step3.jpg)
 
 Once you are done with the layout, you don't have to start drawing each different tiles by hand. You can automatically generate the wall data by pressing CTRL + W or going into Tools > Generate Walls.
 If you want to do more changes to the layout after generating the walls, you can remove them by going into Tools > Clear Walls.
 If you want to add special walls, or if there was an error in the wall generation, you still have the option to manually draw wall tiles. You can select them by going into Tools > Select Tile > Tile Picker.
 This opens the following menu:
 
 ![alt tag](https://raw.github.com/Sigf/Level-Editor/master/tile_picker.jpg)
 
 You can click on each tile to select them. You can keep it open while working on the level.
 If you have a hard visualizing which tile is which, here is a handy reference for you:
 
 ![alt tag](https://raw.github.com/Sigf/Level-Editor/master/tile_types.jpg)
 
 When you are happy with the result, you can export it by pressing CTRL + S and choosing a file location. You should be done with the editor. Now we can import it in Unity!
 
![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step4.jpg)

Inside Unity:
---
Now let's open the scene and go to Window > Load Level. If it isn't there, please make sure that the levelLoader.cs script is in the Editor folder.
 
![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step5.jpg)
 
The way the tiles should be organized is in a sub-folder of Assets, with a prefix and then numbered the following way:

![alt tag](https://raw.github.com/Sigf/Level-Editor/master/tile_example.jpg)

Select the map file, name the level, plug in the floor tile and type the prefix of the tiles and the folder name. Click on load, the level should instanciate itself in a subobject in the scene.
If you want to do some changes, you can go back to the editor, load the map, edit it and re-save it. If it is saved at the same place with the same name, you can just remove the level object and click on Load again. You don't need to re-select it.
 
![alt tag](https://raw.github.com/Sigf/Level-Editor/master/step6.jpg)
 
 And there you go! the level should be playable. Please test it and post an issue if you find any bugs or if you think of a good feature to have.
 
 
 
