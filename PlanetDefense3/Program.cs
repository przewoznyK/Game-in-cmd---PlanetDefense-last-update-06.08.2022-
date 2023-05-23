using System;

namespace PlanetDefense3
{

    public class Program : Planet
    {

        static void Main(string[] args)
        {

            Earth ChoosedMap = new("Earth", 1000, 1000, 1000);
            ChoosedMap.VariablesOnStart();
            ChoosedMap.StartMakeHidden();
            ChoosedMap.StartMakeVisual();
            ChoosedMap.PrintTopUI();
            ChoosedMap.PrintMainMenu();
            while (ChoosedMap.activeProgram)
            {
                var input = Console.ReadKey(true);
                if (ChoosedMap.selectAction)
                {
                    switch (input.Key)
                    {
                        //if (ChoosedMap.DictionaryButton[""] == true) { { ChoosedMap.ControlPanelJump("", "", , ); } }
                        case ConsoleKey.W:
                            // Main Menu
                            if (ChoosedMap.DictionaryButton["Buy Menu"] == true & ChoosedMap.activeMainMenu) { ChoosedMap.ControlPanelJump("Buy Menu", "Next Round", 0, 4); }
                            else if (ChoosedMap.DictionaryButton["Next Round"] == true & ChoosedMap.activeMainMenu) { ChoosedMap.ControlPanelJump("Next Round", "Options Menu", 4, 2); }
                            else if (ChoosedMap.DictionaryButton["Options Menu"] == true & ChoosedMap.activeMainMenu) { ChoosedMap.ControlPanelJump("Options Menu", "Buy Menu", 2, 0); }
                            //-----Buy Menu-----
                            if (ChoosedMap.DictionaryButton["Buy Building"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Buy Building", "Back To Main Menu", 0, 4); }
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Back To Main Menu", "Buy Weapon", 4, 2); }
                            else if (ChoosedMap.DictionaryButton["Buy Weapon"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Buy Weapon", "Buy Building", 2, 0); }
                            // Buy Building Menu
                            if (ChoosedMap.DictionaryButton["Buy Gold Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Gold Factory", "Back To Buy Menu", 0, 4); }
                            else if (ChoosedMap.DictionaryButton["Back To Buy Menu"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Back To Buy Menu", "Buy Materials Factory", 4, 2); }
                            else if (ChoosedMap.DictionaryButton["Buy Materials Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Materials Factory", "Buy Gold Factory", 2, 0); }
                            else if (ChoosedMap.DictionaryButton["Buy Mine"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Mine", "Buy Development Building", 0, 2, 30, 30); }
                            else if (ChoosedMap.DictionaryButton["Buy Development Building"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Development Building", "Buy Mine", 2, 0, 30, 30); }
                            // Buy Weapon Menu
                            if (ChoosedMap.DictionaryButton["Buy Canon"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Canon", "Back To Buy Menu", 0, 4); } }
                            else if (ChoosedMap.DictionaryButton["Back To Buy Menu"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Back To Buy Menu", "Buy Ship", 4, 2); } }
                            else if (ChoosedMap.DictionaryButton["Buy Ship"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Ship", "Buy Canon", 2, 0); } }
                            //-----Options Menu-----
                            if (ChoosedMap.DictionaryButton["Upgrade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Upgrade", "Back To Main Menu", 0, 4); } }
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Back To Main Menu", "Sell", 4, 2); } }
                            else if (ChoosedMap.DictionaryButton["Sell"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Sell", "Upgrade", 2, 0); } }
                            else if (ChoosedMap.DictionaryButton["Move Ship"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Move Ship", "Unlock", 0, 4, 30, 30); } }
                            else if (ChoosedMap.DictionaryButton["Unlock"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Unlock", "Trade", 4, 2, 30, 30); } }
                            else if (ChoosedMap.DictionaryButton["Trade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Trade", "Move Ship", 2, 0, 30, 30); } }
                            break;
                        case ConsoleKey.S:
                            // Main Menu
                            if (ChoosedMap.DictionaryButton["Buy Menu"] == true & ChoosedMap.activeMainMenu) { { ChoosedMap.ControlPanelJump("Buy Menu", "Options Menu", 0, 2); } }
                            else if (ChoosedMap.DictionaryButton["Options Menu"] == true & ChoosedMap.activeMainMenu) { { ChoosedMap.ControlPanelJump("Options Menu", "Next Round", 2, 4); } }
                            else if (ChoosedMap.DictionaryButton["Next Round"] == true & ChoosedMap.activeMainMenu) { { ChoosedMap.ControlPanelJump("Next Round", "Buy Menu", 4, 0); } }
                            // Buy Menu
                            else if (ChoosedMap.DictionaryButton["Buy Building"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Buy Building", "Buy Weapon", 0, 2); }
                            else if (ChoosedMap.DictionaryButton["Buy Weapon"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Buy Weapon", "Back To Main Menu", 2, 4); }
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true & ChoosedMap.activeBuyMenu) { ChoosedMap.ControlPanelJump("Back To Main Menu", "Buy Building", 4, 0); }
                            // Buy Building Menu
                            else if (ChoosedMap.DictionaryButton["Buy Gold Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Gold Factory", "Buy Materials Factory", 0, 2); }
                            else if (ChoosedMap.DictionaryButton["Buy Materials Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Materials Factory", "Back To Buy Menu", 2, 4); }


                            else if (ChoosedMap.DictionaryButton["Back To Buy Menu"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Back To Buy Menu", "Buy Gold Factory", 4, 0); }
                            else if (ChoosedMap.DictionaryButton["Buy Mine"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Mine", "Buy Development Building", 0, 2, 30, 30); }
                            else if (ChoosedMap.DictionaryButton["Buy Development Building"] == true & ChoosedMap.activeBuyBuildingMenu) { ChoosedMap.ControlPanelJump("Buy Development Building", "Buy Mine", 2, 0, 30, 30); }
                            // Buy Weapon Menu
                            if (ChoosedMap.DictionaryButton["Buy Canon"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Canon", "Buy Ship", 0, 2); } }
                            else if (ChoosedMap.DictionaryButton["Buy Ship"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Ship", "Back To Buy Menu", 2, 4); } }
                            else if (ChoosedMap.DictionaryButton["Back To Buy Menu"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Back To Buy Menu", "Buy Canon", 4, 0); } }
                            //-----Options Menu-----
                            if (ChoosedMap.DictionaryButton["Upgrade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Upgrade", "Sell", 0, 2); } }
                            else if (ChoosedMap.DictionaryButton["Sell"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Sell", "Back To Main Menu", 2, 4); } }
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Back To Main Menu", "Upgrade", 4, 0); } }


                            else if (ChoosedMap.DictionaryButton["Move Ship"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Move Ship", "Trade", 0, 2, 30, 30); } }
                            else if (ChoosedMap.DictionaryButton["Trade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Trade", "Unlock", 2, 4, 30, 30); } }
                            else if (ChoosedMap.DictionaryButton["Unlock"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Unlock", "Move Ship", 4, 0, 30, 30); } }
                            break;

                        case ConsoleKey.A:
                            // Buy Building Menu
                            if (ChoosedMap.DictionaryButton["Buy Mine"] == true & ChoosedMap.activeBuyBuildingMenu) { { ChoosedMap.ControlPanelJump("Buy Mine", "Buy Gold Factory", 0, 0, 30, 0); } }
                            else if (ChoosedMap.DictionaryButton["Buy Development Building"] == true & ChoosedMap.activeBuyBuildingMenu) { { ChoosedMap.ControlPanelJump("Buy Development Building", "Buy Materials Factory", 2, 2, 30, 0); } }
                            // Buy Weapon Menu
                            if (ChoosedMap.DictionaryButton["Buy Shield"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Shield", "Buy Canon", 0, 0, 30, 0); } }
                            //-----Options Menu-----
                            if (ChoosedMap.DictionaryButton["Move Ship"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Move Ship", "Upgrade", 0, 0, 30, 0); } }
                            else if (ChoosedMap.DictionaryButton["Trade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Trade", "Sell", 2, 2, 30, 0); } }
                            else if (ChoosedMap.DictionaryButton["Unlock"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Unlock", "Back To Main Menu", 4, 4, 30, 0); } }
                            break;

                        case ConsoleKey.D:
                            // Buy Building Menu
                            if (ChoosedMap.DictionaryButton["Buy Gold Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { { ChoosedMap.ControlPanelJump("Buy Gold Factory", "Buy Mine", 0, 0, 0, 30); } }
                            else if (ChoosedMap.DictionaryButton["Buy Materials Factory"] == true & ChoosedMap.activeBuyBuildingMenu) { { ChoosedMap.ControlPanelJump("Buy Materials Factory", "Buy Development Building", 2, 2, 0, 30); } }
                            // Buy Weapon Menu
                            if (ChoosedMap.DictionaryButton["Buy Canon"] == true & ChoosedMap.activeBuyWeaponMenu) { { ChoosedMap.ControlPanelJump("Buy Canon", "Buy Shield", 0, 0, 0, 30); } }
                            //-----Options Menu-----
                            if (ChoosedMap.DictionaryButton["Upgrade"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Upgrade", "Move Ship", 0, 0, 0, 30); } }
                            else if (ChoosedMap.DictionaryButton["Sell"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Sell", "Trade", 2, 2, 0, 30); } }
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true & ChoosedMap.activeOptionsMenu) { { ChoosedMap.ControlPanelJump("Back To Main Menu", "Unlock", 4, 4, 0, 30); } }
                            break;
                        case ConsoleKey.Enter:
                            // Main Menu
                            if (ChoosedMap.DictionaryButton["Buy Menu"] == true)
                            {
                                ChoosedMap.DictionaryButton["Buy Menu"] = false;
                                ChoosedMap.PrintBuyMenu();
                            }
                            else if (ChoosedMap.DictionaryButton["Options Menu"] == true)
                            {
                                ChoosedMap.DictionaryButton["Options Menu"] = false;
                                ChoosedMap.PrintOptionsMenu();
                            }
                            // Buy Menu
                            else if (ChoosedMap.DictionaryButton["Back To Main Menu"] == true)
                            {
                                ChoosedMap.DictionaryButton["Back To Main Menu"] = false;
                                ChoosedMap.PrintMainMenu();
                            }
                            else if (ChoosedMap.DictionaryButton["Buy Building"] == true)
                            {
                                ChoosedMap.DictionaryButton["Buy Building"] = false;
                                ChoosedMap.PrintBuyBuildingMenu();
                            }
                            else if (ChoosedMap.DictionaryButton["Buy Weapon"] == true)
                            {
                                ChoosedMap.DictionaryButton["Buy Weapon"] = false;
                                ChoosedMap.PrintBuyWeaponMenu();
                            }
                            // Buy Building Menu
                            else if (ChoosedMap.DictionaryButton["Back To Buy Menu"] == true)
                            {
                                ChoosedMap.DictionaryButton["Back To Buy Menu"] = false;
                                ChoosedMap.activeBuyBuildingMenu = false;
                                ChoosedMap.PrintBuyMenu();
                            }
                            // Start Buy Gold Factory
                            else if (ChoosedMap.DictionaryButton["Buy Gold Factory"])
                            {
                                ChoosedMap.StartBuyBuilding("Gold Factory");
                            }
                            // End Buy Gold Factory
                            else if (ChoosedMap.actualBuilding == "Gold Factory" & ChoosedMap.choosePlaceToBuildBuilding & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyBuilding("G");
                            }
                            // Start Buy Materials Factory
                            else if (ChoosedMap.DictionaryButton["Buy Materials Factory"]) //
                            {
                                ChoosedMap.StartBuyBuilding("Materials Factory");
                            }

                            // End Buy Materials Factory
                            else if (ChoosedMap.actualBuilding == "Materials Factory" & ChoosedMap.choosePlaceToBuildBuilding & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyBuilding("M");
                            }
                            // Start Buy Mine

                            else if (ChoosedMap.DictionaryButton["Buy Mine"]) //
                            {
                                ChoosedMap.StartBuyBuilding("Mine");

                            }
                            // End Buy Mine
                            else if (ChoosedMap.actualBuilding == "Mine" & ChoosedMap.choosePlaceToBuildBuilding & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyBuilding("I");
                            }
                            // Start Buy Development Building
                            else if (ChoosedMap.DictionaryButton["Buy Development Building"]) //
                            {
                                ChoosedMap.StartBuyBuilding("Development Building");
                            }
                            // End Buy Development Building
                            else if (ChoosedMap.actualBuilding == "Development Building" & ChoosedMap.choosePlaceToBuildBuilding & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyBuilding("D");
                            }

                            // Buy Weapon Menu
                            // Start Buy Canon
                            else if (ChoosedMap.DictionaryButton["Buy Canon"]) //
                            {
                                ChoosedMap.StartBuyBuilding("Canon");
                            }
                            // End Buy Canon Building
                            else if (ChoosedMap.actualBuilding == "Canon" & ChoosedMap.choosePlaceToBuildBuilding & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyBuilding("C");
                            }
                            // Start Buy Ship
                            else if (ChoosedMap.DictionaryButton["Buy Ship"]) //
                            {
                                ChoosedMap.StartBuyWeapon("Ship");
                            }
                            // End Buy Ship
                            else if (ChoosedMap.actualBuilding == "Ship" & ChoosedMap.choosePlaceToBuildWeapon & Console.BackgroundColor != ConsoleColor.Red)
                            {
                                ChoosedMap.EndBuyWeapon("H");
                            }
                            // Next Round
                            else if (ChoosedMap.DictionaryButton["Next Round"] == true)
                            {
                                ChoosedMap.CreateEnemy();
                                ChoosedMap.gold += ChoosedMap.profitGold;
                                ChoosedMap.materials += ChoosedMap.profitMaterials;
                                ChoosedMap.minerals += ChoosedMap.profitMinerals;
                                ChoosedMap.round++;
                                for (int i = 0; i < ChoosedMap.arrayBuildingTime.GetLength(0); i++)
                                {
                                    for (int j = 0; j < ChoosedMap.arrayBuildingTime.GetLength(1); j++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        if (ChoosedMap.arrayHidden[i, j] == "G") { Console.BackgroundColor = ConsoleColor.DarkYellow; }
                                        else if (ChoosedMap.arrayHidden[i, j] == "M") { Console.BackgroundColor = ConsoleColor.DarkBlue; }
                                        else if (ChoosedMap.arrayHidden[i, j] == "I") { Console.BackgroundColor = ConsoleColor.DarkGray; }
                                        else if (ChoosedMap.arrayHidden[i, j] == "D") { Console.BackgroundColor = ConsoleColor.DarkMagenta; }
                                        else if (ChoosedMap.arrayHidden[i, j] == "C") { Console.ResetColor(); }
                                        else if (ChoosedMap.arrayHidden[i, j] == "H") { Console.ResetColor(); }
                                        else if (ChoosedMap.arrayHidden[i, j] == "P") { Console.BackgroundColor = ConsoleColor.Green; }
                                        if (ChoosedMap.arrayBuildingTime[i, j] > 1)
                                        {
                                            ChoosedMap.arrayBuildingTime[i, j] -= 1;
                                            ChoosedMap.display(i, j, ChoosedMap.arrayBuildingTime[i, j].ToString());

                                        }
                                        else if (ChoosedMap.arrayBuildingTime[i, j] == 1 & ChoosedMap.arrayVisual[i, j] == ".")
                                        {
                                            ChoosedMap.arrayBuildingTime[i, j] -= 1;
                                            ChoosedMap.display(i, j, ChoosedMap.arrayVisual[i, j]);
                                            if (ChoosedMap.arrayHidden[i, j] == "G") { ChoosedMap.profitGold += 20; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "M") { ChoosedMap.profitMaterials += 10; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "I") { ChoosedMap.profitMinerals += 5; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "D") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "C") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "H") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "P") { }
                                        }
                                        else if (ChoosedMap.arrayBuildingTime[i, j] == 1 & ChoosedMap.arrayVisual[i, j] == ";")
                                        {
                                            ChoosedMap.arrayBuildingTime[i, j] -= 1;
                                            ChoosedMap.display(i, j, ChoosedMap.arrayVisual[i, j]);
                                            if (ChoosedMap.arrayHidden[i, j] == "G") { ChoosedMap.profitGold += 40; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "M") { ChoosedMap.profitMaterials += 20; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "I") { ChoosedMap.profitMinerals += 10; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "D") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "C") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "H") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "P") { }
                                        }
                                        else if (ChoosedMap.arrayBuildingTime[i, j] == 1 & ChoosedMap.arrayVisual[i, j] == "!")
                                        {
                                            ChoosedMap.arrayBuildingTime[i, j] -= 1;
                                            ChoosedMap.display(i, j, ChoosedMap.arrayVisual[i, j]);
                                            if (ChoosedMap.arrayHidden[i, j] == "G") { ChoosedMap.profitGold += 60; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "M") { ChoosedMap.profitMaterials += 30; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "I") { ChoosedMap.profitMinerals += 15; }
                                            else if (ChoosedMap.arrayHidden[i, j] == "D") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "C") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "H") { }
                                            else if (ChoosedMap.arrayHidden[i, j] == "P") { }
                                        }
                                        else if (ChoosedMap.arrayBuildingTime[i, j] == 1 & ChoosedMap.arrayVisual[i, j] == "C" || ChoosedMap.arrayBuildingTime[i, j] == 1 & ChoosedMap.arrayVisual[i, j] == "H")
                                        {
                                            ChoosedMap.arrayBuildingTime[i, j] -= 1;
                                            ChoosedMap.display(i, j, ChoosedMap.arrayVisual[i, j]);
                                        }
                                        if (ChoosedMap.arrayVisual[i, j] == "C" & ChoosedMap.arrayBuildingTime[i, j] < 1)
                                        {
                                            if (ChoosedMap.countEnemyOnslot[j] > 0) { ChoosedMap.canFireOnSlot[j] = true; }
                                            else { ChoosedMap.canFireOnSlot[j] = false; }
                                            if (ChoosedMap.canFireOnSlot[j] == true)
                                            {
                                                for (int k = 0; i + k < ChoosedMap.arrayVisual.GetLength(0); k++)
                                                {
                                                    ChoosedMap.display(i + k, j, "-");
                                                    Thread.Sleep(10);
                                                    if (ChoosedMap.arrayVisual[i + k, j] == "-")
                                                    {
                                                        ChoosedMap.arrayVisual[i + k, j] = " ";
                                                        ChoosedMap.display(i + k, j, "X");
                                                        Thread.Sleep(10);
                                                        ChoosedMap.display(i + k, j, " ");
                                                        ChoosedMap.countEnemyOnslot[j]--;
                                                        break;
                                                    }
                                                    if (ChoosedMap.arrayHidden[i + k, j] == "E" || ChoosedMap.arrayHidden[i + k, j] == "S" || ChoosedMap.arrayHidden[i + k, j] == "P" || ChoosedMap.arrayHidden[i + k, j] == "V")
                                                    {
                                                        ChoosedMap.display(i + k, j, " ");
                                                    }
                                                    if (ChoosedMap.arrayVisual[i + k, j] != " " & ChoosedMap.arrayVisual[i + k, j] != "X")
                                                    {
                                                        ChoosedMap.ActualXYColor();
                                                        ChoosedMap.ShowTimeOrBuild(i + k, j);
                                                    }
                                                    else
                                                    {
                                                        ChoosedMap.display(i + k, j, " ");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                ChoosedMap.PrintTopUI();
                            }
                            // Upgrade Start
                            else if (ChoosedMap.DictionaryButton["Upgrade"] == true)
                            {
                                ChoosedMap.ClearControlPanel();
                                ChoosedMap.choosePlaceToUpgrade = true;
                                ChoosedMap.DictionaryButton["Upgrade"] = false;
                                ChoosedMap.actualX = ChoosedMap.planetBorderX + 14;
                                ChoosedMap.actualY = ChoosedMap.planetborderY + 6;
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY] == 0 & ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] != "!")
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            // Upgrade End
                            else if (ChoosedMap.choosePlaceToUpgrade & Console.BackgroundColor == ConsoleColor.Green)
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "P" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "O")
                                {
                                    if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "G") { ChoosedMap.actualBuilding = "Gold Factory"; }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "M") { ChoosedMap.actualBuilding = "Materials Factory"; }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "I") { ChoosedMap.actualBuilding = "Mine"; }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "D") { ChoosedMap.actualBuilding = "Development Building"; }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "C") { ChoosedMap.actualBuilding = "Canon"; }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "H") { ChoosedMap.actualBuilding = "Ship"; }
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == ".")
                                    {
                                        ChoosedMap.Cost(ChoosedMap.actualBuilding, false, 2);
                                    }
                                    else if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == ";")
                                    {
                                        ChoosedMap.Cost(ChoosedMap.actualBuilding, false, 3);
                                    }

                                    if (ChoosedMap.gold >= 0 & ChoosedMap.materials >= 0 & ChoosedMap.minerals >= 0)
                                    {
                                        if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == ".")
                                        {
                                            ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY] = ChoosedMap.timeToBuildTier2;
                                            ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] = ";";
                                        if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "G") { Console.BackgroundColor = ConsoleColor.DarkYellow; ChoosedMap.profitGold -= 20; }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "M") { Console.BackgroundColor = ConsoleColor.DarkBlue; ChoosedMap.profitMaterials -= 10; }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "I") { Console.BackgroundColor = ConsoleColor.DarkGray; ChoosedMap.profitMaterials -= 5; }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "D") { Console.BackgroundColor = ConsoleColor.DarkMagenta; --ChoosedMap.countDevelopmentBuilding; }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "C") { Console.ResetColor(); }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "H") { Console.ResetColor(); }
                                        else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P") { Console.BackgroundColor = ConsoleColor.Green; }
                                        }
                                        else if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == ";")
                                        {
                                            ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY] = ChoosedMap.timeToBuildTier3;
                                            ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] = "!";
                                            if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "G") { Console.BackgroundColor = ConsoleColor.DarkYellow; ChoosedMap.profitGold -= 40; }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "M") { Console.BackgroundColor = ConsoleColor.DarkBlue; ChoosedMap.profitMaterials -= 20; }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "I") { Console.BackgroundColor = ConsoleColor.DarkGray; ChoosedMap.profitMaterials -= 10; }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "D") { Console.BackgroundColor = ConsoleColor.DarkMagenta; --ChoosedMap.countDevelopmentBuilding; }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "C") { Console.ResetColor(); }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "H") { Console.ResetColor(); }
                                            else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P") { Console.BackgroundColor = ConsoleColor.Green; }
                                        }


                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY].ToString());
                                        Console.ResetColor();
                                        ChoosedMap.choosePlaceToUpgrade = false;
                                        ChoosedMap.PrintOptionsMenu();
                                    }
                                    else
                                    {
                                        ChoosedMap.Cost(ChoosedMap.actualBuilding, true, 2);
                                        Console.ResetColor();
                                        ChoosedMap.display(ChoosedMap.controlPanelX, ChoosedMap.controlPanelY, "You dont have enough money");
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.Escape:
                            if (ChoosedMap.choosePlaceToBuildBuilding)
                            {
                                if (Console.BackgroundColor == ConsoleColor.Red) { ChoosedMap.ActualXYColor(); ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);  }
                                Console.ResetColor();
                                ChoosedMap.choosePlaceToBuildBuilding = false;
                                ChoosedMap.ChoosePlaceToPlaceBuildingExit();
                                if (ChoosedMap.actualBuilding == "Canon") { ChoosedMap.PrintBuyWeaponMenu(); }
                                else { ChoosedMap.PrintBuyBuildingMenu(); }
                            }
                            else if (ChoosedMap.choosePlaceToBuildWeapon)
                            {
                                if (Console.BackgroundColor == ConsoleColor.Red) { ChoosedMap.ActualXYColor(); ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY); }
                                Console.ResetColor();
                                ChoosedMap.choosePlaceToBuildWeapon = false;
                                ChoosedMap.ChoosePlaceToPlaceBuildingExit();
                                ChoosedMap.PrintBuyWeaponMenu();
                            }
                            else if (ChoosedMap.choosePlaceToUpgrade)
                            {
                                if (Console.BackgroundColor == ConsoleColor.Red) { ChoosedMap.ActualXYColor(); ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY); }
                                Console.ResetColor();
                                ChoosedMap.choosePlaceToUpgrade = false;
                                ChoosedMap.ChoosePlaceToPlaceBuildingExit();
                                ChoosedMap.PrintOptionsMenu();
                            }
                            break;
                    }
                }
                if (ChoosedMap.choosePlaceToBuildBuilding)
                {
                    switch (input.Key)
                    {
                        //if (ChoosedMap.DictionaryButton[""] == true) { { ChoosedMap.ControlPanelJump("", "", , ); } }
                        case ConsoleKey.W:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "O")
                            {

                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "P")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "P")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(ChoosedMap.actualX, --ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "P")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, --ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.S:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "O")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "P")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "P")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(ChoosedMap.actualX, ++ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "P")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ++ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.A:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "O")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "P")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "P")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(--ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(--ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.D:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "O")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "P")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "P")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(++ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "P")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(++ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.Enter:

                            break;
                    }
                }
                if (ChoosedMap.choosePlaceToBuildWeapon)
                {
                    switch (input.Key)
                    {
                        //if (ChoosedMap.DictionaryButton[""] == true) { { ChoosedMap.ControlPanelJump("", "", , ); } }
                        case ConsoleKey.W:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "O" & ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "V")
                            {

                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "S")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "S")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(ChoosedMap.actualX, --ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "S")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, --ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.S:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "O" & ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "S")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "S")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(ChoosedMap.actualX, ++ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "S")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ++ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.A:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "O" & ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "S")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "S")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(--ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "S")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(--ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.D:
                            if (ChoosedMap.arrayVisual[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "O" & ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S")
                                {
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] != "S")
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "S")
                                {
                                    ChoosedMap.ActualBuildingColor();
                                    ChoosedMap.display(++ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                }
                                else if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "S")
                                {

                                    Console.BackgroundColor = ConsoleColor.Red;
                                    ChoosedMap.ShowTimeOrBuild(++ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.Enter:
                            break;
                    }
                }
                if (ChoosedMap.choosePlaceToUpgrade)
                {
                    switch (input.Key)
                    {
                        //if (ChoosedMap.DictionaryButton[""] == true) { { ChoosedMap.ControlPanelJump("", "", , ); } }
                        case ConsoleKey.W:
                            if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P" || ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                {
                                    Console.ResetColor();
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                    {

                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else
                                    {
                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }

                                }
                                else
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "P" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "O")
                                {
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "O")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        ChoosedMap.display(ChoosedMap.actualX, --ChoosedMap.actualY, "O");
                                    }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY - 1] == "P")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Magenta;
                                        ChoosedMap.display(ChoosedMap.actualX, --ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    if (ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY - 1] > 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                    }


                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, --ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.S:
                            if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P" || ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                {
                                    Console.ResetColor();
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                    {

                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else
                                    {
                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "P" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "O")
                                {
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "O")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        ChoosedMap.display(ChoosedMap.actualX, ++ChoosedMap.actualY, "O");
                                    }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY + 1] == "P")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Magenta;
                                        ChoosedMap.display(ChoosedMap.actualX, ++ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    if (ChoosedMap.arrayBuildingTime[ChoosedMap.actualX, ChoosedMap.actualY + 1] > 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                    }

                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ++ChoosedMap.actualY);
                                }
                            }

                            break;
                        case ConsoleKey.A:
                            if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P" || ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                {
                                    Console.ResetColor();
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                    {

                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else
                                    {
                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }

                                }
                                else
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "P" || ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "O")
                                {
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "O")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        ChoosedMap.display(--ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX - 1, ChoosedMap.actualY] == "P")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Magenta;
                                        ChoosedMap.display(--ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    if (ChoosedMap.arrayBuildingTime[ChoosedMap.actualX - 1, ChoosedMap.actualY] > 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                    }


                                    ChoosedMap.ShowTimeOrBuild(--ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.D:
                            if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] != "V")
                            {
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX, ChoosedMap.actualY] == "P" || ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                {
                                    Console.ResetColor();
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX, ChoosedMap.actualY] == "O")
                                    {

                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else
                                    {
                                        ChoosedMap.display(ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    ChoosedMap.ActualXYColor();
                                    ChoosedMap.ShowTimeOrBuild(ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                                if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "P" || ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "O")
                                {
                                    if (ChoosedMap.arrayVisual[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "O")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        ChoosedMap.display(++ChoosedMap.actualX, ChoosedMap.actualY, "O");
                                    }
                                    else if (ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "S" || ChoosedMap.arrayHidden[ChoosedMap.actualX + 1, ChoosedMap.actualY] == "P")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Magenta;
                                        ChoosedMap.display(++ChoosedMap.actualX, ChoosedMap.actualY, " ");
                                    }
                                }
                                else
                                {
                                    if (ChoosedMap.arrayBuildingTime[ChoosedMap.actualX + 1, ChoosedMap.actualY] > 1)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                    }

                                    ChoosedMap.ShowTimeOrBuild(++ChoosedMap.actualX, ChoosedMap.actualY);
                                }
                            }
                            break;
                        case ConsoleKey.Enter:
                            break;
                    }
                }

            }
        }
    }
}