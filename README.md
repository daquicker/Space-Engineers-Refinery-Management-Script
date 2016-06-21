# Space-Engineers-Refinery-Management-Script
Ingame script for Space Engineers that automatically manages refineries and Arc Furnaces.

The script lets you set desired amounts for each individual refined item in the game, and will automatically manage all available Refineries / Arc Furnaces on the grid in order to maintain these goals, given the required Ores are present.

Desired amounts can be set by editing the corresponding variables at the top of the script.
Ex:
"int gravelTres = 10000" -> set the number to desired amount of gravel 

The script works on a priority system, the order is currently hard coded, but can rather easily be changed.
This priority system will try to satisfy the demands for each individual ingot type sequentially.
However, Ores that can be processed by the Arc Furnace, will be processed in parallel with Ores in the refineries if possible.
Refineries will help out Arc Furnaces if their own demand or supply hits 0.
Current default priority order:

Refineries
1.) Platinum
2.) Silver
3.) Gold
4.) Silicon
5.) Magnesium
6.) Gravel
7.) Uranium

Refineries/Arc Furnaces
8.)/1.)Cobalt
9.)/2.)Nickel
10.)/3.)Iron

Requirements:
Programmable block
Timer block
At least 1 refinery and/or Arc Furnace
1 Container called "Ores"
1 Container called "ingots"
The named Containers and ALL Refineries/Arc Furnaces on the grid are connected.

Note: All ores and ingots need to be stacked as much as possible.
Ex:
GOOD
10000iron;4586gold;689platinum

BAD
8000iron;4586gold;689platinum;2000iron
-> doing this, the script will only account for the last encountered stack.
