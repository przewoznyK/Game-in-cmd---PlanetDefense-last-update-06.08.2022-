using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetDefense3
{
    class Earth : Planet
    {
        public Earth(string name, int gold, int materials, int minerals) : base(name, gold, materials, minerals)
        {

        }
        public string[,] arrayHidden = new string[100, 25];
        public string[,] arrayVisual = new string[100, 25];
        public int[,] arrayBuildingTime = new int[100, 25];
        public Dictionary<string, bool> DictionaryButton = new Dictionary<string, bool>();

        int topUIBorderX = 0;
        int topUIBorderY = 0;
        int shipBorderX = 0;
        int shipBorderY = 0;
        public int planetBorderX = 5;
        public int planetborderY = 6;
        public int controlPanelX = 5;
        public int controlPanelY = 21;
        public int enemyBorderX = 40;
        public int enemyBorderY = 6;

        public int round = 1;
        public int profitGold = 0;
        public int profitMaterials = 0;
        public int profitMinerals = 0;
        public bool activeProgram = true;
        public bool selectAction = true;
        public bool activeMainMenu = false;
        public bool activeBuyMenu = false;
        public bool activeOptionsMenu = false;
        public bool activeBuyBuildingMenu = false;
        public bool activeBuyWeaponMenu = false;

        //Count
        public int countGoldFactory = 0;
        public int countMaterialsFactory = 0;
        public int countMine = 0;
        public int countDevelopmentBuilding = 0;

        public int actualX = 0;
        public int actualY = 0;
        public string actualBuilding;
        public bool choosePlaceToBuildBuilding = false;
        public bool choosePlaceToBuildWeapon = false;
        public bool choosePlaceToUpgrade = false;

        public int timeToBuildTier1 = 3;
        public int timeToBuildTier2 = 6;
        public int timeToBuildTier3 = 9;
        public int activeTimeToBuild = 0;

        // Enemy
        public int enemyPositionX;
        public int enemyPositionY;

        public SortedDictionary<int, bool> canFireOnSlot = new SortedDictionary<int, bool>();
        public SortedDictionary<int, int> countEnemyOnslot = new SortedDictionary<int, int>();

        public void VariablesOnStart()
        {
            //Main Menu
            DictionaryButton.Add("Buy Menu", false);
            DictionaryButton.Add("Options Menu", false);
            DictionaryButton.Add("Next Round", false);
            //Buy Menu
            DictionaryButton.Add("Buy Building", false);
            DictionaryButton.Add("Buy Weapon", false);
            DictionaryButton.Add("Back To Main Menu", false);
            // Options
            DictionaryButton.Add("Upgrade", false);
            DictionaryButton.Add("Sell", false);
            DictionaryButton.Add("Move Ship", false);
            DictionaryButton.Add("Unlock", false);
            DictionaryButton.Add("Trade", false);
            //Buy Building
            DictionaryButton.Add("Buy Gold Factory", false);
            DictionaryButton.Add("Buy Materials Factory", false);
            DictionaryButton.Add("Buy Mine", false);
            DictionaryButton.Add("Buy Development Building", false);
            DictionaryButton.Add("Back To Buy Menu", false);
            //Buy Weapon
            DictionaryButton.Add("Buy Canon", false);
            DictionaryButton.Add("Buy Ship", false);
            DictionaryButton.Add("Buy Shield", false);
            //Dictionary Enemy
            canFireOnSlot.Add(1, false);
            canFireOnSlot.Add(2, false);
            canFireOnSlot.Add(3, false);
            canFireOnSlot.Add(4, false);
            canFireOnSlot.Add(5, false);
            canFireOnSlot.Add(6, false);
            canFireOnSlot.Add(7, false);
            canFireOnSlot.Add(8, false);
            canFireOnSlot.Add(9, false);
            canFireOnSlot.Add(10, false);
            canFireOnSlot.Add(11, false);
            canFireOnSlot.Add(12, false);
            canFireOnSlot.Add(13, false);
            canFireOnSlot.Add(14, false);

            countEnemyOnslot.Add(1, 0);
            countEnemyOnslot.Add(2, 0);
            countEnemyOnslot.Add(3, 0);
            countEnemyOnslot.Add(4, 0);
            countEnemyOnslot.Add(5, 0);
            countEnemyOnslot.Add(6, 0);
            countEnemyOnslot.Add(7, 0);
            countEnemyOnslot.Add(8, 0);
            countEnemyOnslot.Add(9, 0);
            countEnemyOnslot.Add(10, 0);
            countEnemyOnslot.Add(11, 0);
            countEnemyOnslot.Add(12, 0);
            countEnemyOnslot.Add(13, 0);
            countEnemyOnslot.Add(14, 0);

        }
        public void StartMakeHidden()
        {
            // Top UI
            for (int i = topUIBorderX; i < arrayHidden.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayHidden[i, j] = "T";
                }
            }
            // Ship Border
            for (int i = 0; i < shipBorderX + 40; i++)
            {
                arrayHidden[i, 3] = "V";
            }
            for (int i = 0; i < shipBorderX + 41; i++)
            {
                arrayHidden[i, shipBorderY + 21] = "V";
            }
            for (int i = 3; i < shipBorderY + 21; i++)
            {
                arrayHidden[0, i] = "V";
            }
            for (int i = 3; i < shipBorderY + 21; i++)
            {
                arrayHidden[shipBorderX + 40, i] = "V";
            }
            // Place For The Enemy
            for (int i = shipBorderX + 41; i < 100; i++)
            {
                for (int j = 3; j < 22; j++)
                {
                    arrayHidden[i, j] = "E";
                }
            }
            // Place For Buildings
            for (int i = planetBorderX + 11; i < planetBorderX + 19; i++)
            {
                arrayHidden[i, planetborderY + 1] = "P";
            }
            for (int i = planetBorderX + 7; i < planetBorderX + 23; i++)
            {
                arrayHidden[i, planetborderY + 2] = "P";
            }
            for (int i = planetBorderX + 3; i < planetBorderX + 27; i++)
            {
                arrayHidden[i, planetborderY + 3] = "P";
            }
            for (int i = planetBorderX + 2; i < planetBorderX + 28; i++)
            {
                arrayHidden[i, planetborderY + 4] = "P";
            }
            for (int i = planetBorderX + 1; i < planetBorderX + 29; i++)
            {
                arrayHidden[i, planetborderY + 5] = "P";
            }
            for (int i = planetBorderX + 1; i < planetBorderX + 29; i++)
            {
                arrayHidden[i, planetborderY + 6] = "P";
            }
            for (int i = planetBorderX + 1; i < planetBorderX + 29; i++)
            {
                arrayHidden[i, planetborderY + 7] = "P";
            }
            for (int i = planetBorderX + 2; i < planetBorderX + 28; i++)
            {
                arrayHidden[i, planetborderY + 8] = "P";
            }
            for (int i = planetBorderX + 3; i < planetBorderX + 27; i++)
            {
                arrayHidden[i, planetborderY + 9] = "P";
            }
            for (int i = planetBorderX + 7; i < planetBorderX + 23; i++)
            {
                arrayHidden[i, planetborderY + 10] = "P";
            }
            for (int i = planetBorderX + 11; i < planetBorderX + 19; i++)
            {
                arrayHidden[i, planetborderY + 11] = "P";
            }
            // Place For Ships
            for (int i = shipBorderX; i < 41; i++)
            {
                for (int j = 3; j < 22; j++)
                {
                    if (arrayHidden[i, j] == null)
                    {
                        arrayHidden[i, j] = "S";
                    }
                }
            }
        }
        public void StartMakeVisual()
        {
            display(planetBorderX + 11, planetborderY, "O");
            display(planetBorderX + 12, planetborderY, "O");
            display(planetBorderX + 13, planetborderY, "O");
            display(planetBorderX + 14, planetborderY, "O");
            display(planetBorderX + 15, planetborderY, "O");
            display(planetBorderX + 16, planetborderY, "O");
            display(planetBorderX + 17, planetborderY, "O");
            display(planetBorderX + 18, planetborderY, "O");
            arrayVisual[planetBorderX + 11, planetborderY] = "O";
            arrayVisual[planetBorderX + 12, planetborderY] = "O";
            arrayVisual[planetBorderX + 13, planetborderY] = "O";
            arrayVisual[planetBorderX + 14, planetborderY] = "O";
            arrayVisual[planetBorderX + 15, planetborderY] = "O";
            arrayVisual[planetBorderX + 16, planetborderY] = "O";
            arrayVisual[planetBorderX + 17, planetborderY] = "O";
            arrayVisual[planetBorderX + 18, planetborderY] = "O";

            // 2. Left Wall
            display(planetBorderX + 7, planetborderY + 1, "O");
            display(planetBorderX + 8, planetborderY + 1, "O");
            display(planetBorderX + 9, planetborderY + 1, "O");
            display(planetBorderX + 10, planetborderY + 1, "O");
            arrayVisual[planetBorderX + 7, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 8, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 9, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 10, planetborderY + 1] = "O";
            // 2. Right Wall
            display(planetBorderX + 19, planetborderY + 1, "O");
            display(planetBorderX + 20, planetborderY + 1, "O");
            display(planetBorderX + 21, planetborderY + 1, "O");
            display(planetBorderX + 22, planetborderY + 1, "O");
            arrayVisual[planetBorderX + 19, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 20, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 21, planetborderY + 1] = "O";
            arrayVisual[planetBorderX + 22, planetborderY + 1] = "O";

            // 3. Left Wall
            display(planetBorderX + 3, planetborderY + 2, "O");
            display(planetBorderX + 4, planetborderY + 2, "O");
            display(planetBorderX + 5, planetborderY + 2, "O");
            display(planetBorderX + 6, planetborderY + 2, "O");
            arrayVisual[planetBorderX + 3, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 4, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 5, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 6, planetborderY + 2] = "O";

            // 3. Right Wall
            display(planetBorderX + 23, planetborderY + 2, "O");
            display(planetBorderX + 24, planetborderY + 2, "O");
            display(planetBorderX + 25, planetborderY + 2, "O");
            display(planetBorderX + 26, planetborderY + 2, "O");
            arrayVisual[planetBorderX + 23, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 24, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 25, planetborderY + 2] = "O";
            arrayVisual[planetBorderX + 26, planetborderY + 2] = "O";

            // 4. Left Wall
            display(planetBorderX + 2, planetborderY + 3, "O");
            arrayVisual[planetBorderX + 2, planetborderY + 3] = "O";

            // 4. Right Wall
            display(planetBorderX + 27, planetborderY + 3, "O");
            arrayVisual[planetBorderX + 27, planetborderY + 3] = "O";

            // 5. Left Wall
            display(planetBorderX + 1, planetborderY + 4, "O");
            arrayVisual[planetBorderX + 1, planetborderY + 4] = "O";

            // 5. Right Wall
            display(planetBorderX + 28, planetborderY + 4, "O");
            arrayVisual[planetBorderX + 28, planetborderY + 4] = "O";

            // 6. Left Wall
            display(planetBorderX + 0, planetborderY + 5, "O");
            arrayVisual[planetBorderX + 0, planetborderY + 5] = "O";

            // 6. Right Wall
            display(planetBorderX + 29, planetborderY + 5, "O");
            arrayVisual[planetBorderX + 29, planetborderY + 5] = "O";

            // 7. Left Wall
            display(planetBorderX + 0, planetborderY + 6, "O");
            arrayVisual[planetBorderX + 0, planetborderY + 6] = "O";

            // 7. Right Wall
            display(planetBorderX + 29, planetborderY + 6, "O");
            arrayVisual[planetBorderX + 29, planetborderY + 6] = "O";

            // 8. Left Wall
            display(planetBorderX + 0, planetborderY + 7, "O");
            arrayVisual[planetBorderX + 0, planetborderY + 7] = "O";

            // 8. Right Wall
            display(planetBorderX + 29, planetborderY + 7, "O");
            arrayVisual[planetBorderX + 29, planetborderY + 7] = "O";


            // 9. Left Wall
            display(planetBorderX + 1, planetborderY + 8, "O");
            arrayVisual[planetBorderX + 1, planetborderY + 8] = "O";

            // 9. Right Wall
            display(planetBorderX + 28, planetborderY + 8, "O");
            arrayVisual[planetBorderX + 28, planetborderY + 8] = "O";

            // 10. Left Wall
            display(planetBorderX + 2, planetborderY + 9, "O");
            arrayVisual[planetBorderX + 2, planetborderY + 9] = "O";

            // 10. Right Wall
            display(planetBorderX + 27, planetborderY + 9, "O");
            arrayVisual[planetBorderX + 27, planetborderY + 9] = "O";

            // 11. Left Wall
            display(planetBorderX + 3, planetborderY + 10, "O");
            display(planetBorderX + 4, planetborderY + 10, "O");
            display(planetBorderX + 5, planetborderY + 10, "O");
            display(planetBorderX + 6, planetborderY + 10, "O");
            arrayVisual[planetBorderX + 3, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 4, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 5, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 6, planetborderY + 10] = "O";

            // 11. Right Wall
            display(planetBorderX + 23, planetborderY + 10, "O");
            display(planetBorderX + 24, planetborderY + 10, "O");
            display(planetBorderX + 25, planetborderY + 10, "O");
            display(planetBorderX + 26, planetborderY + 10, "O");
            arrayVisual[planetBorderX + 23, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 24, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 25, planetborderY + 10] = "O";
            arrayVisual[planetBorderX + 26, planetborderY + 10] = "O";

            // 12. Left Wall
            display(planetBorderX + 7, planetborderY + 11, "O");
            display(planetBorderX + 8, planetborderY + 11, "O");
            display(planetBorderX + 9, planetborderY + 11, "O");
            display(planetBorderX + 10, planetborderY + 11, "O");
            arrayVisual[planetBorderX + 7, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 8, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 9, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 10, planetborderY + 11] = "O";

            // 12. Left Wall
            display(planetBorderX + 19, planetborderY + 11, "O");
            display(planetBorderX + 20, planetborderY + 11, "O");
            display(planetBorderX + 21, planetborderY + 11, "O");
            display(planetBorderX + 22, planetborderY + 11, "O");
            arrayVisual[planetBorderX + 19, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 20, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 21, planetborderY + 11] = "O";
            arrayVisual[planetBorderX + 22, planetborderY + 11] = "O";

            //Bottom
            display(planetBorderX + 11, planetborderY + 12, "O");
            display(planetBorderX + 12, planetborderY + 12, "O");
            display(planetBorderX + 13, planetborderY + 12, "O");
            display(planetBorderX + 14, planetborderY + 12, "O");
            display(planetBorderX + 15, planetborderY + 12, "O");
            display(planetBorderX + 16, planetborderY + 12, "O");
            display(planetBorderX + 17, planetborderY + 12, "O");
            display(planetBorderX + 18, planetborderY + 12, "O");
            arrayVisual[planetBorderX + 11, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 12, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 13, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 14, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 15, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 16, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 17, planetborderY + 12] = "O";
            arrayVisual[planetBorderX + 18, planetborderY + 12] = "O";
        }
        public void PrintTopUI()
        {
            //Clear
            Console.ResetColor();

            display(topUIBorderX + 20, topUIBorderY, "Gold:                             ");
            display(topUIBorderX + 50, topUIBorderY, "Materials:                         ");
            display(topUIBorderX + 80, topUIBorderY, "Minerals:                           ");

            display(topUIBorderX + 3, topUIBorderY, "Round: " + round.ToString());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            display(topUIBorderX + 20, topUIBorderY, "Gold: " + gold.ToString());
            display(topUIBorderX + 20, topUIBorderY + 1, profitGold.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            display(topUIBorderX + 50, topUIBorderY, "Materials: " + materials.ToString());
            display(topUIBorderX + 50, topUIBorderY + 1, profitMaterials.ToString());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            display(topUIBorderX + 80, topUIBorderY, "Minerals: " + minerals.ToString());
            display(topUIBorderX + 80, topUIBorderY + 1, profitMinerals.ToString());
            Console.ResetColor();
        }
        public void PrintMainMenu()
        {
            ClearControlPanel();
            activeMainMenu = true;
            activeBuyMenu = false;
            activeOptionsMenu = false;
            DictionaryButton["Buy Menu"] = true;
            display(controlPanelX, controlPanelY + 2, "Options Menu");
            display(controlPanelX, controlPanelY + 4, "Next Round");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX, controlPanelY, "Buy Menu");
            Console.ResetColor();
        }
        public void PrintBuyMenu()
        {
            ClearControlPanel();
            activeMainMenu = false;
            activeBuyMenu = true;
            activeBuyBuildingMenu = false;
            activeBuyWeaponMenu = false;
            DictionaryButton["Buy Building"] = true;
            display(controlPanelX, controlPanelY + 2, "Buy Weapon");
            display(controlPanelX, controlPanelY + 4, "Back To Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX, controlPanelY, "Buy Building");
            Console.ResetColor();
        }
        public void PrintOptionsMenu()
        {
            ClearControlPanel();
            activeMainMenu = false;
            activeMainMenu = false;
            activeOptionsMenu = true;
            DictionaryButton["Upgrade"] = true;
            display(controlPanelX, controlPanelY + 2, "Sell");
            display(controlPanelX, controlPanelY + 4, "Back To Main Menu");
            display(controlPanelX + 30, controlPanelY, "Move Ship");
            display(controlPanelX + 30, controlPanelY + 2, "Trade");
            display(controlPanelX + 30, controlPanelY + 4, "Unlock");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX, controlPanelY, "Upgrade");
            Console.ResetColor();
        }
        public void PrintBuyBuildingMenu()
        {

            ClearControlPanel();
            activeBuyBuildingMenu = true;
            DictionaryButton["Buy Gold Factory"] = true;
            display(controlPanelX, controlPanelY + 2, "Buy Materials Factory");
            display(controlPanelX, controlPanelY + 4, "Back To Buy Menu");
            display(controlPanelX + 30, controlPanelY, "Buy Mine");
            display(controlPanelX + 30, controlPanelY + 2, "Buy Development Building");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX, controlPanelY, "Buy Gold Factory");
            Console.ResetColor();
        }
        public void PrintBuyWeaponMenu()
        {
            ClearControlPanel();
            activeBuyWeaponMenu = true;
            DictionaryButton["Buy Canon"] = true;
            display(controlPanelX, controlPanelY + 2, "Buy Ship");
            display(controlPanelX, controlPanelY + 4, "Back To Buy Menu");
            display(controlPanelX + 30, controlPanelY, "Buy Shield");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX, controlPanelY, "Buy Canon");
            Console.ResetColor();
        }
        public void ClearControlPanel()
        {

            display(controlPanelX, controlPanelY + 2, "                                                                ");
            display(controlPanelX, controlPanelY + 4, "                                                                ");
            display(controlPanelX, controlPanelY, "                                                                ");
        }
        public void ControlPanelJump(string from, string to, int fromY, int toY, int fromX = 0, int toX = 0)
        {
            Console.ResetColor();
            DictionaryButton[from] = false; DictionaryButton[to] = true;
            display(controlPanelX + fromX, controlPanelY + fromY, from);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            display(controlPanelX + toX, controlPanelY + toY, to);
            Console.ResetColor();
        }
        public void StartBuyBuilding(string building)
        {
            choosePlaceToBuildBuilding = true;
            actualBuilding = building;
            Cost(actualBuilding, false);
            if (gold >= 0 & materials >= 0 & minerals >= 0)
            {
                Cost(actualBuilding, true);
                DictionaryButton["Buy " + actualBuilding] = false;
                ChoosePlaceToPlaceBuilding(actualBuilding, timeToBuildTier1);
            }
            else
            {
                Cost(actualBuilding, true);
                PrintRedToDarkCyanButton();
                choosePlaceToBuildBuilding = false;
            }
        }

        public void ChoosePlaceToPlaceBuilding(string building, int time)
        {
            ClearControlPanel();
            choosePlaceToBuildBuilding = true;
            activeTimeToBuild = time;
            for (int i = 0; i < arrayHidden.GetLength(0); i++)
            {
                for (int j = 0; j < arrayHidden.GetLength(1); j++)
                {
                    if (arrayHidden[i, j] == "P")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                    else if (arrayVisual[i, j] == "O")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                    else if (arrayHidden[i, j] == "S")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                }
            }

            actualX = planetBorderX + 14;
            actualY = planetborderY + 6;
            if (arrayHidden[actualX, actualY] == "P")
            {
                ActualBuildingColor();
                display(actualX, actualY, " ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                ShowTimeOrBuild(actualX, actualY);
            }
        }
        public void EndBuyBuilding(string shortcut)
        {
            arrayHidden[actualX, actualY] = shortcut;
            arrayBuildingTime[actualX, actualY] = activeTimeToBuild;
            if (arrayHidden[actualX, actualY] != "C")
            {
                arrayVisual[actualX, actualY] = ".";
            }
            else { arrayVisual[actualX, actualY] = "C"; }
            ActualXYColor();
            display(actualX, actualY, activeTimeToBuild.ToString());
            Cost(actualBuilding, false);
            PrintTopUI();
            choosePlaceToBuildBuilding = false;
            ChoosePlaceToPlaceBuildingExit();
            if (actualBuilding == "Canon") { PrintBuyWeaponMenu(); }
            else { PrintBuyBuildingMenu(); }
        }
        public void ChoosePlaceToPlaceBuildingExit()
        {
            for (int i = 0; i < arrayHidden.GetLength(0); i++)
            {
                for (int j = 0; j < arrayHidden.GetLength(1); j++)
                {
                    if (arrayHidden[i, j] == "P")
                    {
                        Console.ResetColor();
                        display(i, j, " ");
                    }
                    else if (arrayVisual[i, j] == "O")
                    {
                        Console.ResetColor();
                        display(i, j, "O");
                    }
                    else if (arrayHidden[i, j] == "S")
                    {
                        Console.ResetColor();
                        display(i, j, " ");
                    }
                }
            }
        }

        public void ActualBuildingColor()
        {
            if (actualBuilding == "Gold Factory")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (actualBuilding == "Materials Factory")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (actualBuilding == "Mine")
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (actualBuilding == "Development Building")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (actualBuilding == "Canon")
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (actualBuilding == "Ship")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
        public void ActualXYColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            if (arrayHidden[actualX, actualY] == "G") { Console.BackgroundColor = ConsoleColor.DarkYellow; }
            else if (arrayHidden[actualX, actualY] == "M") { Console.BackgroundColor = ConsoleColor.DarkBlue; }
            else if (arrayHidden[actualX, actualY] == "I") { Console.BackgroundColor = ConsoleColor.DarkGray; }
            else if (arrayHidden[actualX, actualY] == "D") { Console.BackgroundColor = ConsoleColor.DarkMagenta; }
            else if (arrayHidden[actualX, actualY] == "C") { Console.ResetColor(); }
            else if (arrayHidden[actualX, actualY] == "H") { Console.ResetColor(); }
            else if (arrayHidden[actualX, actualY] == "P") { Console.BackgroundColor = ConsoleColor.Green; }
        }
        public void ShowTimeOrBuild(int x, int y)
        {
            if (arrayBuildingTime[x, y] > 1)
            {
                display(x, y, arrayBuildingTime[x, y].ToString());
            }
            else
            {
                display(x, y, arrayVisual[x, y]);
            }
        }
        public void Cost(string actual, bool reverse, int times = 1)
        {
            if (!reverse)
            {
                if (actualBuilding == "Gold Factory")
                {
                    materials -= 50 * times;
                    minerals -= 100 * times;
                }
                else if (actualBuilding == "Materials Factory")
                {
                    gold -= 200 * times;
                    minerals -= 100 * times;
                }
                else if (actualBuilding == "Mine")
                {
                    gold -= 400 * times;
                    materials -= 50 * times;
                }
                else if (actualBuilding == "Development Building")
                {
                    gold -= 2000 * times;
                    materials -= 1000 * times;
                    minerals -= 1000 * times;
                }
                else if (actualBuilding == "Canon")
                {
                    gold -= 500 * times;
                    materials -= 300 * times;
                    minerals -= 100 * times;
                }
                else if (actualBuilding == "Ship")
                {
                    gold -= 500 * times;
                    materials -= 300 * times;
                    minerals -= 100 * times;
                }
            }
            if (reverse)
            {
                if (actualBuilding == "Gold Factory")
                {
                    materials += 50 * times;
                    minerals += 100 * times;
                }
                else if (actualBuilding == "Materials Factory")
                {
                    gold += 200 * times;
                    minerals += 100 * times;
                }
                else if (actualBuilding == "Mine")
                {
                    gold += 400 * times;
                    materials += 50 * times;
                }
                else if (actualBuilding == "Development Building")
                {
                    gold += 2000 * times;
                    materials += 1000 * times;
                    minerals += 1000 * times;

                }
                else if (actualBuilding == "Canon")
                {
                    gold += 500 * times;
                    materials += 300 * times;
                    minerals += 100 * times;
                }
                else if (actualBuilding == "Ship")
                {
                    gold += 500 * times;
                    materials += 300 * times;
                    minerals += 100 * times;
                }
            }
        }
        public void PrintRedToDarkCyanButton()
        {
            if (actualBuilding == "Gold Factory")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX, controlPanelY, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX, controlPanelY, "Buy " + actualBuilding);
            }
            else if (actualBuilding == "Materials Factory")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX, controlPanelY + 2, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX, controlPanelY + 2, "Buy " + actualBuilding);
            }
            else if (actualBuilding == "Mine")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX + 30, controlPanelY, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX + 30, controlPanelY, "Buy " + actualBuilding);
            }
            else if (actualBuilding == "Development Building")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX + 30, controlPanelY + 2, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX + 30, controlPanelY + 2, "Buy " + actualBuilding);
            }
            else if (actualBuilding == "Canon")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX, controlPanelY, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX, controlPanelY, "Buy " + actualBuilding);
            }
            else if (actualBuilding == "Ship")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                display(controlPanelX, controlPanelY + 2, "Buy " + actualBuilding);
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                display(controlPanelX, controlPanelY + 2, "Buy " + actualBuilding);
            }
        }
        public void StartBuyWeapon(string weapon)
        {
            choosePlaceToBuildWeapon = true;
            actualBuilding = weapon;
            Cost(actualBuilding, false);
            if (gold >= 0 & materials >= 0 & minerals >= 0)
            {
                Cost(actualBuilding, true);
                DictionaryButton["Buy " + actualBuilding] = false;
                ChoosePlaceToPlaceWeapon(actualBuilding, timeToBuildTier1);
            }
            else
            {
                Cost(actualBuilding, true);
                PrintRedToDarkCyanButton();
                choosePlaceToBuildWeapon = false;
            }
        }
        public void ChoosePlaceToPlaceWeapon(string weapon, int time)
        {
            ClearControlPanel();
            choosePlaceToBuildWeapon = true;
            activeTimeToBuild = time;
            for (int i = 0; i < arrayHidden.GetLength(0); i++)
            {
                for (int j = 0; j < arrayHidden.GetLength(1); j++)
                {
                    if (arrayHidden[i, j] == "P")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                    else if (arrayVisual[i, j] == "O")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                    else if (arrayHidden[i, j] == "S")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        display(i, j, " ");
                        Console.ResetColor();
                    }
                }
            }
            actualBuilding = weapon;
            actualX = planetBorderX + 2;
            actualY = planetborderY + 2;
            if (arrayHidden[actualX, actualY] == "S")
            {
                ActualBuildingColor();
                display(actualX, actualY, " ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                display(actualX, actualY, arrayVisual[actualX, actualY]);
            }
        }
        public void EndBuyWeapon(string shortcut)
        {
            arrayHidden[actualX, actualY] = shortcut;
            arrayBuildingTime[actualX, actualY] = activeTimeToBuild;
            arrayVisual[actualX, actualY] = "H";
            ActualXYColor();
            display(actualX, actualY, activeTimeToBuild.ToString());
            Cost(actualBuilding, false);
            PrintTopUI();
            choosePlaceToBuildWeapon = false;
            ChoosePlaceToPlaceBuildingExit();
            PrintBuyWeaponMenu();

        }

        public void CreateEnemy()
        {
            for (int i = 0; i < arrayVisual.GetLength(0); i++)
            {
                for (int j = 0; j < arrayVisual.GetLength(1); j++)
                {
                    if (arrayVisual[i, j] == "-")
                    {
                        if (arrayVisual[i - 1, j] == "O")
                        {
                            arrayVisual[i, j] = "E";
                            display(i, j, " ");
                        }
                        else
                        {
                            arrayVisual[i, j] = "E";
                            display(i, j, " ");
                            arrayVisual[i - 1, j] = "-";

                            display(i - 1, j, "-");
                        }
                    }
                }
            }
            enemyPositionX = arrayVisual.GetLength(1);
            Random genetaorY = new Random();
            enemyPositionY = genetaorY.Next(enemyBorderY, 10);
            display(enemyPositionX + 50, enemyPositionY, "-");
            arrayVisual[enemyPositionX + 50, enemyPositionY] = "-";
            countEnemyOnslot[enemyPositionY]++;
        }
    }
}
