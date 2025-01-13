[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.
1.This game has two objects: player character, plants and text on the upper left(#of seed planted & # of seed remain). 

2.The player can use wasd key to move around. The text # of seed planted can increase and the # of seeds remaining will decrease. Player can instantiate plant, which appear at the same position as the player.

3. Player character can instantiate plants and by doing so, the text on the upper left will change accordingly. When the # of seeds remaining turns 0, player character will not be able to plant more seeds

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
For starter, we need to let the player control their character using wasd key. Since we want the character to move as long as the player is pressing the key, I chosed GetKey rather than GetKeyDown and since it is a 2D game, the movement should be on the x and y axis, thus I used Vector3.left/right and Vector3.Up and down. 
In order to create plant and make it appears right where the player is, I decided to use instantiate(Object original, Vector3 position, Quaternion rotation) and use _playerTransform to give the plant the same position as the player character. And because we want to only have 5 plants available I added in the if statement that seeds can only be instantiated if the variable numofseedremaining is larger than 0. 
Lastly, I need to make the text to change in the way I wrote above in the activity. To do so, first, in the if statement for planting seed, if the seed successfully planted, the variable seedleft and _numberofseedPlanted will change accordingly. And to display them, I need to work on the other script, plantCountUI, I placed this script in Canvas so the player script can refer to it later. Its variables are connected to Text_SeedsPlantedNum and Text_SeedsRemainingNum since they are the two we want to change. Inside the script, I added  {_plantedText.text = "" + seedsPlanted;} because seedsPlanted is a int and in order to display in text, I need to change it to string. And I did the same to seedsremaining. Finally, in the player script, I put _plantCountUI.UpdateSeeds(_numSeedsPlanted, _numSeeds); in the Update method which will give the correct number of seed planted and seed remain and let the plantCountUI to display them. 
 
## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
