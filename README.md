# Space-Engineers-Refinery-Management-Script
Ingame script for Space Engineers that automatically manages refineries and Arc Furnaces.

The script lets you set desired amounts for each individual refined item in the game, and will automatically manage all available Refineries / Arc Furnaces on the grid in order to maintain these goals, given the required Ores are present.

Desired amounts can be set by editing the corresponding variables at the top of the script.</br>
Ex:</br>
"int gravelTres = 10000" -> set the number to desired amount of gravel.

The script works on a priority system, the order is currently hard coded, but can rather easily be changed.</br>
This priority system will try to satisfy the demands for each individual ingot type sequentially.</br>
However, Ores that can be processed by the Arc Furnace, will be processed in parallel with Ores in the refineries if possible.</br>
Refineries will help out Arc Furnaces if their own demand or supply hits 0.

Manual override:</br>
Ex:</br>
Platinum target not reached, platinum being refined.</br>
You need silver asap.

Just manually drag the silver to the first slot on any refinery(ies) you want, the script will omit those refineries untill the silver you added in has been processed. Afterwards it will regain functionality as if nothing happened.

Current default priority order:

Refineries</br>
1.) Platinum</br>
2.) Silver</br>
3.) Gold</br>
4.) Silicon</br>
5.) Magnesium</br>
6.) Gravel</br>
7.) Uranium</br>


Refineries/Arc Furnaces</br>
8.)/1.)Cobalt</br>
9.)/2.)Nickel</br>
10.)/3.)Iron</br>

Requirements:</br>
Programmable block</br>
Timer block</br>
At least 1 refinery and/or Arc Furnace</br>
1 Container called "Ores"</br>
1 Container called "Ingots"</br>
The named Containers and ALL Refineries/Arc Furnaces on the grid are connected.

Note: All ores and ingots need to be stacked as much as possible.</br>
Ex:</br>
GOOD</br>
10000iron;4586gold;689platinum</br>

BAD</br>
8000iron;4586gold;689platinum;2000iron</br>
-> doing this, the script will only account for the last encountered stack.
