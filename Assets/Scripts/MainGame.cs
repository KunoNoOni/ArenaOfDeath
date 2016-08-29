using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainGame : MonoBehaviour 
{
    InputField mainInputField;
    Text gameText;

    bool hasCharacter = false;
    bool atMainMenu = false;
    bool atStatsScreen = false;
    bool atShop = false;
    bool atInstructions = false;
    bool buyingArmor = false;
    bool buyingWeapon = false;
    bool buyingPotion = false;
    bool buyingOil = false;
    bool atArena = false;
    bool createCharacter = false;
    bool getName = false;
    bool leavingGame = false;
    bool hasCLW = false;
    bool hasCSW = false;
    bool hasStr = false;
    bool hasDex = false;
    bool hasFire = false;
    bool hasFrost = false;
    bool hasPoison = false;
    bool hasKeen = false;
    bool hasHoly = false;
    bool hasPotion = false;
    bool hasOil = false;
    bool errorGold = false;
    bool buyingConf = false;
    bool alreadyAttacking = false;
    bool playerDead = false;
    bool monsterDead = false;
    bool fightOver = false;
    bool deleteCharacter = false;

    float timer = 2;
    float timerReset = 2;
    float tempFloat;
    int baseGold = 20;
    int baseXP = 100;
    int nextLevel = 1000;
    int tempInt;
    int d20;
    int tempMonHP;
    int tempMonDam;
    int tempMonAC;
    int tempPlayerDam;
    int tempStr;
    int tempDex;
    int tempInte;
    int tempCon;
    int tempHP;
    int orignalWepDam;
    int originalStr;
    int originalDex;
    int armorIndex;
    int weaponIndex;
    int potionIndex;
    int oilIndex;

    string[] weaponNames;
    int[] weaponDamage;
    int[] weaponGoldValue;
    string[] armorNames;
    int[] armorValues;
    int[] armorGoldValue;
    string[] potionNames;
    int[] potionValues;
    int[] potionGoldValue;
    string[] oilNames;
    int[] oilValues;
    int[] oilGoldValue;
    string[] monsterNames;
    int[] monsterHP;
    int[] monsterDamage;
    int[] monsterAC;


    //Strings for game
    string gameTitle;
    string shopTitle;
    string arenaTitle;
    string statsTitle;
    string armorTitle;
    string weaponTitle;
    string potionTitle;
    string oilTitle;
    string instructionTitle;
    string mainMenu;
    string menuItem1;
    string menuItem2;
    string menuItem3;
    string menuItem4;
    string menuItem5;
    string menuItem6;
    string menuItem7;
    string menuItem8;
    string menuItem9;
    string menuItem10;
    string menuItem11;
    string menuItem12;
    string menuItem13;
    string menuItem14;
    string menuItem15;
    string menuItem16;
    string menuItem17;
    string menuItem18;
    string menuItem19;
    string menuItem20;
    string menuNumOne;
    string menuNumTwo;
    string menuNumThree;
    string menuNumFour;
    string menuNumFive;
    string menuNumSix;
    string menuNumSeven;
    string menuNumEight;
    string menuNumNine;
    string menuNumTen;
    string pressSpaceKey;
    string charCreateTitle;
    string enterName;
    string welcomemsg;
    string statsmsg;
    string shopmsg;
    string arenaentrymsg;
    string arenaentrymsg2;
    string buyingConfirmation1;
    string buyingConfirmation2;
    string buyingConfirmation3;
    string buyingConfirmation4;
    string costmsg;
    string gpmsg;
    string acmsg;
    string damagemsg;
    string healsmsg;
    string incstrmsg;
    string incdexmsg;
    string incdmgmsg;
    string goldmsg;
    string winmsg;
    string losemsg;
    string healpotionmsg;
    string strpotionmsg;
    string dexpotionmsg;
    string fireoilmsg;
    string frostoilmsg;
    string poisonoilmsg;
    string keenoilmsg;
    string holyoilmsg;
    string notEnoughGoldmsg;
    string playerhitmsg;
    string playercrithitmsg;
    string monsterhitmsg;
    string monstercrithitmsg;
    string playermissmsg;
    string monstermissmsg;
    string levelupmsg;
    string xpmsg;
    string xpmsg2;
    string goldmsg2;
    string strgainmsg;
    string intgainmsg;
    string dexgainmsg;
    string congainmsg;
    string statgainmsg;
    string hpgainmsg;
    string levelgainmsg;
    string playerhpmsg;
    string monsterhpmsg;
    string delcharmsg;
    string ptsofdammsg;
    string newLine;
    string tab;
    string excalmation;

    string statStr;
    string statInt;
    string statDex;
    string statCon;
    string statLevel;
    string statName;
    string statHP;
    string statArmor;
    string statWeapon;
    string statArmorClass;
    string statGold;
    string statXP;
    string statDmg;

    string option1;
    string option2;
    string option3;
    string option4;
    string option5;
    string option6;
    string option7;
    string option8;
    string option9;
    string exitmsg;
    string holdingPotion;
    string holdingOil;


    //Character Stats
    string plrName;
    int level;
    int strength;
    int intelligence;
    int dexterity;
    int constitution;
    int hp;
    int maxHP;
    string armor;
    string weapon;
    int armorClass;
    int damage;
    int gold;
    int xp;
    int currArmGoldValue;
    int currWepGoldValue;
    int currPotGoldValue;
    int currOilGoldValue;
    int currArmorIndex;
    int currWeaponIndex;
    int currPotionIndex;
    int currOilIndex;



        

	void Start ()
	{
        gameText = GameObject.FindWithTag("gameTextBox").GetComponent<Text>();
        mainInputField = GameObject.FindWithTag("inputFieldBox").GetComponent<InputField>();

        Registry.alreadyConnected = true;
        mainInputField.image.enabled = false;
        mainInputField.enabled = false;
        mainInputField.placeholder.GetComponent<Text>().text = "";
        leavingGame = false;
        InitArrays();
        InitStrings();

        if(PlayerPrefs.HasKey("Name"))
        {
            hasCharacter = true;
            LoadCharacter();
        }

        atMainMenu = true;
        DisplayMainMenu();
	}
 //=====================================================>>>>>>>>>>>>>>>>>>>>>>>>
 //=========UPDATE FUNCTION IS BELOW====================>>>>>>>>>>>>>>>>>>>>>>>>
 //=====================================================>>>>>>>>>>>>>>>>>>>>>>>>

	void Update () 
	{

        if(Input.GetKeyDown(KeyCode.F1))
        {
            Debug.Log("<------------------------------>");
            Debug.Log("<------------------------------>");
            Debug.Log("atArena :" + atArena);
            Debug.Log("atMainMenu :" + atMainMenu);
            Debug.Log("atShop :" + atShop);
            Debug.Log("atStatsScreen :" + atStatsScreen);
            Debug.Log("buyingArmor :" + buyingArmor);
            Debug.Log("buyingConf :" + buyingConf);
            Debug.Log("buyingOil :" + buyingOil);
            Debug.Log("buyingPotion :" + buyingPotion);
            Debug.Log("buyingWeapon :" + buyingWeapon);
            Debug.Log("hasCLW :" + hasCLW);
            Debug.Log("<------------------------------>");
            Debug.Log("<------------------------------>");
            Debug.Log("<------------------------------>");
        }

        if(getName && Input.GetKeyDown(KeyCode.Return))
        {
            plrName = mainInputField.text;
            getName = false;
            mainInputField.image.enabled = false;
            mainInputField.enabled = false;
            mainInputField.text = "";
            mainInputField.placeholder.GetComponent<Text>().text = "";
            Input.ResetInputAxes();
            CreateCharacter();
        }

        //*****
        //Checks for Stat Screen

        if(atStatsScreen && Input.GetKeyDown(KeyCode.Space))
        {
            atStatsScreen = false;
            atMainMenu = true;
            Input.ResetInputAxes();
            DisplayMainMenu();
        }
            
        //*****
        //Checks for Main Menu

        if(atMainMenu && !hasCharacter && Input.GetKeyDown(KeyCode.Alpha1))
        {
            atMainMenu = false;
            createCharacter = true;
            getName = true;
            mainInputField.image.enabled = true;
            mainInputField.enabled = true;
            mainInputField.placeholder.GetComponent<Text>().text = "Enter Name...";
            Input.ResetInputAxes();
            CreateCharacter();
        }

        if(atMainMenu  && hasCharacter && Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Fight in the arena
            atMainMenu = false;
            Input.ResetInputAxes();
            FightInArena();
        }

        if(atMainMenu && hasCharacter && Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Visit Shop
            atMainMenu = false;
            Input.ResetInputAxes();
            VisitShop();
        }

        if(atMainMenu && hasCharacter && Input.GetKeyDown(KeyCode.Alpha3))
        {
            atMainMenu = false;
            Input.ResetInputAxes();
            ShowStats();
        }

        if(atMainMenu && hasCharacter && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            PlayerPrefs.DeleteAll();
            hasCharacter = false;
            deleteCharacter = true;
            gameText.text += newLine + newLine + delcharmsg + pressSpaceKey;
        }

        if(atMainMenu && Input.GetKeyDown(KeyCode.I))
        {
            Input.ResetInputAxes();
            atMainMenu = false;
            createCharacter = false;
            atInstructions = true;
            Instructions();
        }

        if(atMainMenu && deleteCharacter && Input.GetKeyDown(KeyCode.Space))
        {
            Input.ResetInputAxes();
            deleteCharacter = false;
            gameText.text += newLine + exitmsg;
            leavingGame = true;
        }

        if(atMainMenu && Input.GetKeyDown(KeyCode.L))
        {
            gameText.text += newLine + exitmsg;
            leavingGame = true;
        }

        if(leavingGame)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                if(hasCharacter)
                {
                    SaveCharacter();
                }
                SceneManager.LoadScene("BBS");
            }
        }

        //*****
        //Checks for Instruction Menu
        if(atInstructions && Input.GetKeyDown(KeyCode.Space))
        {
            atInstructions = false;
            atMainMenu = true;
            Input.ResetInputAxes();
            DisplayMainMenu();
        }

            
        //*****
        //Checks for Shop Menu
        if(atShop && !buyingArmor && !buyingWeapon && !buyingPotion 
            && !buyingOil && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Input.ResetInputAxes();
            DisplayArmorMenu();
        }

        if(atShop && !buyingArmor && !buyingWeapon && !buyingPotion 
            && !buyingOil && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Input.ResetInputAxes();
            DisplayWeaponMenu();
        }

        if(atShop && !buyingArmor && !buyingWeapon && !buyingPotion 
            && !buyingOil && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Input.ResetInputAxes();
            DisplayPotionMenu();
        }

        if(atShop && !buyingArmor && !buyingWeapon && !buyingPotion 
            && !buyingOil && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            DisplayOilMenu();
        }

        if(atShop && !buyingArmor && !buyingWeapon && !buyingPotion 
            && !buyingOil && Input.GetKeyDown(KeyCode.Alpha5))
        {
            atShop = false;
            atMainMenu = true;
            Input.ResetInputAxes();
            DisplayMainMenu();
        }

        if(atShop && Input.GetKeyDown(KeyCode.B))
        {
            buyingArmor = false;
            buyingWeapon = false;
            buyingPotion = false;
            buyingOil = false;
            Input.ResetInputAxes();
            VisitShop();
        }

        //Buying Plate Armor
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha0))
        {
            Input.ResetInputAxes();
            armorIndex = 9;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Heavy Robe
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Input.ResetInputAxes();
            armorIndex = 0;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Padded
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Input.ResetInputAxes();
            armorIndex = 1;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }
                
        //Buying Leather
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Input.ResetInputAxes();
            armorIndex = 2;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Studded Leather
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            armorIndex = 3;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Ringmail
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha5))
        {
            Input.ResetInputAxes();
            armorIndex = 4;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Scalemail
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha6))
        {
            Input.ResetInputAxes();
            armorIndex = 5;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Chainmail
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha7))
        {
            Input.ResetInputAxes();
            armorIndex = 6;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Splintedmail
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha8))
        {
            Input.ResetInputAxes();
            armorIndex = 7;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Bandedmail
        if(atShop && buyingArmor && Input.GetKeyDown(KeyCode.Alpha9))
        {
            Input.ResetInputAxes();
            armorIndex = 8;
            PurchaseArmor(currArmorIndex);
        }

        if(atShop && buyingArmor && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayArmorMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteArmorPurchase(armorIndex);
            }
        }

        //Buying Dagger
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Input.ResetInputAxes();
            weaponIndex = 0;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Short Sword
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Input.ResetInputAxes();
            weaponIndex = 1;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Broad Sword
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Input.ResetInputAxes();
            weaponIndex = 2;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Long Sword
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            weaponIndex = 3;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Bastard Sword
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha5))
        {
            Input.ResetInputAxes();
            weaponIndex = 4;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Great Sword
        if(atShop && buyingWeapon && Input.GetKeyDown(KeyCode.Alpha6))
        {
            Input.ResetInputAxes();
            weaponIndex = 5;
            PurchaseWeapon(currWeaponIndex);
        }

        if(atShop && buyingWeapon && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayWeaponMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteWeaponPurchase(weaponIndex);
            }
        }

        //Buying Cure Light Wounds Potion
        if(atShop && buyingPotion && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Input.ResetInputAxes();
            potionIndex = 0;
            PurchasePotion(currPotionIndex);
        }

        if(atShop && buyingPotion && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayPotionMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompletePotionPurchase(potionIndex);
            }
        }

        //Buying Cure Serious Wounds Potion
        if(atShop && buyingPotion && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Input.ResetInputAxes();
            potionIndex = 1;
            PurchasePotion(currPotionIndex);
        }

        if(atShop && buyingPotion && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayPotionMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompletePotionPurchase(potionIndex);
            }
        }

        //Buying Strength Potion
        if(atShop && buyingPotion && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Input.ResetInputAxes();
            potionIndex = 2;
            PurchasePotion(currPotionIndex);
        }

        if(atShop && buyingPotion && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayPotionMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompletePotionPurchase(potionIndex);
            }
        }

        //Buying Dexterity Potion
        if(atShop && buyingPotion && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            potionIndex = 3;
            PurchasePotion(currPotionIndex);
        }

        if(atShop && buyingPotion && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayPotionMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompletePotionPurchase(potionIndex);
            }
        }

        //Buying Fire Oil
        if(atShop && buyingOil && Input.GetKeyDown(KeyCode.Alpha1))
        {
            Input.ResetInputAxes();
            oilIndex = 0;
            PurchaseOil(currOilIndex);
        }

        if(atShop && buyingOil && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayOilMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteOilPurchase(oilIndex);
            }
        }

        //Buying Frost Oil
        if(atShop && buyingOil && Input.GetKeyDown(KeyCode.Alpha2))
        {
            Input.ResetInputAxes();
            oilIndex = 1;
            PurchaseOil(currOilIndex);
        }

        if(atShop && buyingOil && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayOilMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteOilPurchase(oilIndex);
            }
        }

        //Buying Poison Oil
        if(atShop && buyingOil && Input.GetKeyDown(KeyCode.Alpha3))
        {
            Input.ResetInputAxes();
            oilIndex = 2;
            PurchaseOil(currOilIndex);
        }

        if(atShop && buyingOil && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayOilMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteOilPurchase(oilIndex);
            }
        }

        //Buying Keen Oil
        if(atShop && buyingOil && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Input.ResetInputAxes();
            oilIndex = 3;
            PurchaseOil(currOilIndex);
        }

        if(atShop && buyingOil && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayOilMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteOilPurchase(oilIndex);
            }
        }

        //Buying Holy Oil
        if(atShop && buyingOil && Input.GetKeyDown(KeyCode.Alpha5))
        {
            Input.ResetInputAxes();
            oilIndex = 4;
            PurchaseOil(currOilIndex);
        }

        if(atShop && buyingOil && buyingConf)
        {
            if(Input.GetKeyDown(KeyCode.N))
            {
                Input.ResetInputAxes();
                DisplayOilMenu();
            }
            if(Input.GetKeyDown(KeyCode.Y))
            {
                Input.ResetInputAxes();
                CompleteOilPurchase(oilIndex);
            }
        }

        //Generic not enough gold error message
        if(errorGold)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                errorGold = false;
                Input.ResetInputAxes();
                timer = timerReset;
                if(buyingArmor)
                    DisplayArmorMenu();
                else if(buyingWeapon)
                    DisplayWeaponMenu();
                else if(buyingPotion)
                    DisplayPotionMenu();
                else if(buyingOil)
                    DisplayOilMenu();
            }
        }

        //*****
        //Checks for Create Character Menu
        if(createCharacter && Input.GetKeyDown(KeyCode.V))
        {
            //Visit Shop
            createCharacter = false;
            Input.ResetInputAxes();
            VisitShop();
        }

        if(createCharacter && Input.GetKeyDown(KeyCode.F))
        {
            //Fight in the Arena
            createCharacter = false;
            atArena = true;
            alreadyAttacking = false;
            Input.ResetInputAxes();
            FightInArena();
        }

        if(createCharacter && Input.GetKeyDown(KeyCode.I))
        {
            //Goto Instructions
            createCharacter = false;
            atInstructions = true;
            alreadyAttacking = false;
            Input.ResetInputAxes();
            Instructions();
        }


        //*****
        //Checks for Arena Menu
        // 
        if(atArena && !alreadyAttacking && Input.GetKeyDown(KeyCode.A))
        {
            //Attack Monster
            Input.ResetInputAxes();
            alreadyAttacking = true;
            AttackMonster();
        }

        if(atArena && !alreadyAttacking && hasPotion && Input.GetKeyDown(KeyCode.Q))
        {
            //Quaff Potion
            Input.ResetInputAxes();
            QuaffPotion();
        }

        if(atArena && !alreadyAttacking && hasOil && Input.GetKeyDown(KeyCode.U))
        {
            //Use Oil
            Input.ResetInputAxes();
            UseOil();
        }

        if(monsterDead)
        {
            xp += baseXP;
            gold += baseGold;
            damage = orignalWepDam;
            hp = maxHP;
            gameText.text += winmsg + newLine + newLine + xpmsg + baseXP + xpmsg2 +
                newLine + goldmsg2 + baseGold + gpmsg + newLine + newLine;
            
            //check to see if the player leveled up
            if(xp >= nextLevel)
            {
                gameText.text += levelupmsg + newLine + newLine;
                level += 1;
                xp = 0;
                tempStr = Random.Range(3,6);
                tempInte = Random.Range(3,6);
                tempDex = Random.Range(3,6);
                tempCon = Random.Range(3,6);
                strength = originalStr;
                dexterity = originalDex;
                strength += tempStr;
                intelligence += tempInte;
                dexterity += tempDex;
                constitution += tempCon;
                tempHP = constitution/2;
                hp = maxHP;
                hp += tempHP;
                maxHP = hp;
                gameText.text += statgainmsg + newLine + levelgainmsg + level +
                    excalmation + newLine + hpgainmsg + tempHP + excalmation + newLine +
                    strgainmsg + tempStr +excalmation + newLine + intgainmsg + tempInte +
                    excalmation +newLine +dexgainmsg + tempDex + excalmation + newLine +
                    congainmsg +tempCon +excalmation + newLine;
            }
            gameText.text += pressSpaceKey;
            SaveCharacter();
            monsterDead = false;
            deleteCharacter = false;
            fightOver = true;
        }

        if(playerDead)
        {
            gameText.text = losemsg + newLine + newLine + pressSpaceKey;
            deleteCharacter = true;
            playerDead = false;
        }

        if(atArena && deleteCharacter && Input.GetKeyDown(KeyCode.Space))
        {
            deleteCharacter = false;
            alreadyAttacking = false;
            Input.ResetInputAxes();
            PlayerPrefs.DeleteAll();
            atArena = false;
            atMainMenu = true;
            hasCharacter = false;
            fightOver = false;
            DisplayMainMenu();
        }


        if(fightOver && Input.GetKeyDown(KeyCode.Space))
        {
            fightOver = false;
            alreadyAttacking = false;
            Input.ResetInputAxes();
            atMainMenu = true;
            DisplayMainMenu();
        }
	}
//=====================================================>>>>>>>>>>>>>>>>>>>>>>>>
//=========UPDATE FUNCTION IS ABOVE====================>>>>>>>>>>>>>>>>>>>>>>>>
//=====================================================>>>>>>>>>>>>>>>>>>>>>>>>
    //Begin Purchase and CompletePurchase functions
    //
    //
    //
    void PurchaseArmor(int armIdx)
    {
        if(armorGoldValue[armorIndex] > gold)
        {
            gameText.text += notEnoughGoldmsg;
            errorGold = true;
        }
        else
        {
            buyingConf = true;
            if(currArmorIndex == 999)
            {   gameText.text += buyingConfirmation1 + "Rags" + 
                    buyingConfirmation2 + 0 + gpmsg + buyingConfirmation3;
            }
            else
            {
                gameText.text += buyingConfirmation1 + armorNames[armIdx] +
                    buyingConfirmation2 + currArmGoldValue / 2 + gpmsg + buyingConfirmation3;;
            }
        }   
    }

    void CompleteArmorPurchase(int armIdx)
    {
        if(currArmorIndex == 999)
        {
            gold -= armorGoldValue[armIdx];
            armor = armorNames[armIdx];
            armorClass = armorValues[armIdx];
            currArmGoldValue = armorGoldValue[armIdx];
            currArmorIndex = armIdx;
        }
        else
        {
            tempInt = armorGoldValue[armIdx];
            gold -= (tempInt - (tempInt/2));
            armor = armorNames[armIdx];
            armorClass = armorValues[armIdx];
            currArmGoldValue = armorGoldValue[armIdx];
            currArmorIndex = armIdx;
        }

        buyingConf = false;
        DisplayArmorMenu();
    }

    void PurchaseWeapon(int wepIdx)
    {
        if(weaponGoldValue[weaponIndex] > gold)
        {
            gameText.text += notEnoughGoldmsg;
            errorGold = true;
        }
        else
        {
            buyingConf = true;
            if(currWeaponIndex == 999)
            {   gameText.text += buyingConfirmation1 + "Pointy Stick" + 
                    buyingConfirmation2 + 0 + gpmsg + buyingConfirmation3;
            }
            else
            {
                gameText.text += buyingConfirmation1 + weaponNames[wepIdx] +
                    buyingConfirmation2 + currWepGoldValue / 2 + gpmsg + buyingConfirmation3;;
            }
        }   
    }

    void CompleteWeaponPurchase(int wepIdx)
    {
        if(currWeaponIndex == 999)
        {
            gold -= weaponGoldValue[wepIdx];
            weapon = weaponNames[wepIdx];
            damage = weaponDamage[wepIdx];
            currWepGoldValue = weaponGoldValue[wepIdx];
            currWeaponIndex = wepIdx;
        }
        else
        {
            tempInt = weaponGoldValue[wepIdx];
            gold -= (tempInt - (tempInt/2));
            weapon = weaponNames[wepIdx];
            damage = weaponDamage[wepIdx];
            currWepGoldValue = weaponGoldValue[wepIdx];
            currWeaponIndex = wepIdx;
        }

        buyingConf = false;
        DisplayWeaponMenu();
    }

    void PurchasePotion(int potIdx)
    {
        if(potionGoldValue[potionIndex] > gold)
        {
            gameText.text += notEnoughGoldmsg;
            errorGold = true;
        }
        else
        {
            buyingConf = true;
            if(currPotionIndex == 999)
            {
                gameText.text += buyingConfirmation4;
            }
            else
            {
                gameText.text += buyingConfirmation1 + potionNames[potIdx] +
                    buyingConfirmation2 + currPotGoldValue / 2 + gpmsg + buyingConfirmation3;    
            }
        }   
    }

    void CompletePotionPurchase(int potIdx)
    {
        if(currPotionIndex == 999)
        {
            tempInt = potionGoldValue[potIdx];
            gold -= tempInt;
            currPotGoldValue = potionGoldValue[potIdx];
            currPotionIndex = potIdx;
        }
        else
        {
            tempInt = potionGoldValue[potIdx];
            gold -= (tempInt - (tempInt/2));
            currPotGoldValue = potionGoldValue[potIdx];
            currPotionIndex = potIdx;
        }

        if(potIdx == 0)
        {
            hasCLW = true;
            hasCSW = false;
            hasStr = false;
            hasDex = false;
        }
        if(potIdx == 1)
        {
            hasCLW = false;
            hasCSW = true;
            hasStr = false;
            hasDex = false;
        }
        if(potIdx == 2)
        {
            hasCLW = false;
            hasCSW = false;
            hasStr = true;
            hasDex = false;
        } 
        if(potIdx == 3)
        {
            hasCLW = false;
            hasCSW = false;
            hasStr = false;
            hasDex = true;
        }   

        hasPotion = true;
        buyingConf = false;
        DisplayPotionMenu();
    }

    void PurchaseOil(int oilIdx)
    {
        if(oilGoldValue[oilIndex] > gold)
        {
            gameText.text += notEnoughGoldmsg;
            errorGold = true;
        }
        else
        {
            buyingConf = true;
            if(currOilIndex == 999)
            {
                gameText.text += buyingConfirmation4;
            }
            else
            {
                gameText.text += buyingConfirmation1 + oilNames[oilIdx] +
                    buyingConfirmation2 + currOilGoldValue / 2 + gpmsg + buyingConfirmation3;    
            }
        }   
    }

    void CompleteOilPurchase(int oilIdx)
    {
        if(currOilIndex == 999)
        {
            tempInt = oilGoldValue[oilIdx];
            gold -= tempInt;
            currOilGoldValue = oilGoldValue[oilIdx];
            currOilIndex = oilIdx;
        }
        else
        {
            tempInt = oilGoldValue[oilIdx];
            gold -= (tempInt - (tempInt/2));
            currOilGoldValue = oilGoldValue[oilIdx];
            currOilIndex = oilIdx;
        }

        if(oilIdx == 0)
        {
            hasFire = true;
            hasFrost = false;
            hasPoison = false;
            hasKeen = false;
            hasHoly = false;
        }
        if(oilIdx == 1)
        {
            hasFire = false;
            hasFrost = true;
            hasPoison = false;
            hasKeen = false;
            hasHoly = false;
        }
        if(oilIdx == 2)
        {
            hasFire = false;
            hasFrost = false;
            hasPoison = true;
            hasKeen = false;
            hasHoly = false;
        } 
        if(oilIdx == 3)
        {
            hasFire = false;
            hasFrost = false;
            hasPoison = false;
            hasKeen = true;
            hasHoly = false;
        }   
        if(oilIdx == 4)
        {
            hasFire = false;
            hasFrost = false;
            hasPoison = false;
            hasKeen = false;
            hasHoly = true;
        }

        hasOil = true;
        buyingConf = false;
        DisplayOilMenu();
    }
    //
    //
    //
    //End Purchase and CompletePurchase functions

    void QuaffPotion()
    {
        //get type of potion
        //save original values
        //apply affect
        //remove potion
        //display message
        if(hasCLW)
        {
            hasCLW = false;
            hasPotion = false;
            currPotionIndex = 999;
            hp += potionValues[0];
            if(hp > maxHP)
            {
                hp = maxHP;
            }
            gameText.text = arenaTitle + newLine + newLine + newLine +
                healpotionmsg + potionValues[0] + newLine + newLine + option8;
            if(hasOil)
                gameText.text += option6;
        }  
        if(hasCSW)
        {
            hasCSW = false;
            hasPotion = false;
            currPotionIndex = 999;
            hp += potionValues[1];
            if(hp > maxHP)
            {
                hp = maxHP;
            }
            gameText.text = arenaTitle + newLine + newLine + newLine +
                healpotionmsg + potionValues[1] + newLine + newLine + option8;
            if(hasOil)
                gameText.text += option6;
        } 
        if(hasStr)
        {
            hasStr = false;
            hasPotion = false;
            currPotionIndex = 999;
            originalStr = strength;
            strength += potionValues[2];
            gameText.text = arenaTitle + newLine + newLine + newLine +
                strpotionmsg + potionValues[2] + newLine + newLine + option8;
            if(hasOil)
                gameText.text += option6;
        }  
        if(hasDex)
        {
            hasDex = false;
            hasPotion = false;
            currPotionIndex = 999;
            originalDex = dexterity;
            dexterity += potionValues[3];
            gameText.text = arenaTitle + newLine + newLine + newLine +
                dexpotionmsg + potionValues[3] + newLine + newLine + option8;
            if(hasOil)
                gameText.text += option6;
        }   
    }

    void UseOil()
    {
        //get type of oil
        //save original values
        //apply affect
        //remove oil
        //display message
        if(hasFire)
        {
            hasFire = false;
            hasOil = false;
            currOilIndex = 999;
            orignalWepDam = damage;
            damage += oilValues[0];
            gameText.text = arenaTitle + newLine + newLine + newLine + fireoilmsg +
                oilValues[0] + newLine + newLine + option8;
            if(hasPotion)
                gameText.text += option5;
        }
        if(hasFrost)
        {
            hasFrost = false;
            hasOil = false;
            currOilIndex = 999;
            orignalWepDam = damage;
            damage += oilValues[1];
            gameText.text = arenaTitle + newLine + newLine + newLine + frostoilmsg +
                oilValues[1] + newLine + newLine + option8;
            if(hasPotion)
                gameText.text += option5;
        }   
        if(hasPoison)
        {
            hasPoison = false;
            hasOil = false;
            currOilIndex = 999;
            orignalWepDam = damage;
            damage += oilValues[2];
            gameText.text = arenaTitle + newLine + newLine + newLine + poisonoilmsg +
                oilValues[2] + newLine + newLine + option8;
            if(hasPotion)
                gameText.text += option5;
        } 
        if(hasKeen)
        {
            hasKeen = false;
            hasOil = false;
            currOilIndex = 999;
            orignalWepDam = damage;
            damage += oilValues[3];
            gameText.text = arenaTitle + newLine + newLine + newLine + keenoilmsg +
                oilValues[3] + newLine + newLine + option8;
            if(hasPotion)
                gameText.text += option5;
        } 
        if(hasHoly)
        {
            hasHoly = false;
            hasOil = false;
            currOilIndex = 999;
            orignalWepDam = damage;
            damage += oilValues[4];
            gameText.text = arenaTitle + newLine + newLine + newLine + holyoilmsg +
                oilValues[4] + newLine + newLine + option8;
            if(hasPotion)
                gameText.text += option5;
        }
    }

    void AttackMonster()
    {
        //this is the meat of the fighting
        gameText.text = arenaTitle + newLine + newLine; 

        //Player attacking the monster
        d20 = Random.Range(1,21);
        if(d20 == 1)
        {
            gameText.text += playermissmsg + newLine + newLine;
        }
        else if(d20 == 20)
        {
            tempFloat = strength*.5f;
            tempPlayerDam = ((damage + (int)tempFloat ) * 2);
            if(tempPlayerDam < 1)
                tempPlayerDam = 1;
            tempMonHP -= tempPlayerDam;
            gameText.text += playercrithitmsg + tempPlayerDam + ptsofdammsg + newLine + newLine;
        }
        else if(d20  >= tempMonAC)
        {
            tempFloat = strength*.5f;
            tempPlayerDam = (damage + (int)tempFloat);
            if(tempPlayerDam < 1)
                tempPlayerDam = 1;
            tempMonHP -= tempPlayerDam;
            gameText.text += playerhitmsg + tempPlayerDam + ptsofdammsg + newLine + newLine;
        }
        else
        {
            gameText.text += playermissmsg + newLine + newLine;
        }

        //Check to see if the monster is dead if not then it attacks
        if(tempMonHP <= 0)
        {
            monsterDead = true;
        }
        else
        {
            d20 = Random.Range(1,21);
            tempFloat = dexterity*.5f;

            if(d20 == 1)
            {
                gameText.text += monstermissmsg + newLine + newLine;
            }
            else if(d20 == 20)
            {
                tempMonDam *= 2;
                hp -= tempMonDam;
                gameText.text += monstercrithitmsg + tempMonDam + ptsofdammsg + newLine + newLine;
            }
            else if(d20 - (int)tempFloat >= armorClass)
            {
                hp -= tempMonDam;
                gameText.text += monsterhitmsg + tempMonDam + ptsofdammsg + newLine + newLine;
            }
            else
            {
                gameText.text += monstermissmsg + newLine + newLine;
            }

            //check if the player is dead.
            if(hp <= 0)
            {
                //*Said in the voice of GLADOS*
                //this is not good for the player.
                //In fact its very bad. His character will
                //be deleted now. The player will be very sad
                // and angry but will try again. He will not
                //quit as ragequitting was not a thing back
                //in the day. You died and tried again. Good
                //for you player!
                playerDead = true; 
            }
            else
            {
                alreadyAttacking = false;
                gameText.text += playerhpmsg + hp + monsterhpmsg + tempMonHP +
                    newLine + newLine + option8;
                if(hasPotion)
                    gameText.text += option5;
                if(hasOil)
                    gameText.text += option6;
            }
        }
    }

    void DisplayMainMenu()
    {
        if (hasCharacter)
        {
            gameText.text = gameTitle + mainMenu + menuNumOne + menuItem2 +
                menuNumTwo + menuItem3 + menuNumThree + menuItem4 + menuNumFour +
                menuItem10 + newLine + newLine + option4 + option3;
        }
        else
        {
            gameText.text = gameTitle + mainMenu + menuNumOne + menuItem1 +
                newLine + newLine + option4 + option3;
        }
    }

    void CreateCharacter()
    {
        gameText.text = charCreateTitle + enterName;
        if(!getName)
        {
            atArena = false;
            InitStats();

            gameText.text += welcomemsg + plrName + "!" + newLine + statsmsg +
                statLevel + tab + tab + tab + tab + level + newLine + statArmorClass + tab + armorClass + 
                newLine + statHP + tab + tab + tab + tab + tab + hp + newLine + statStr + tab + tab + tab + tab + tab + strength + newLine +
                statInt + tab + tab + tab + tab + tab + intelligence + newLine + statDex + tab + tab + tab + tab + dexterity + 
                newLine + statCon + tab + tab + tab + tab + constitution + newLine + statArmor + tab + tab + tab + tab + armor +
                newLine + statWeapon + tab + tab + tab + weapon + newLine + statDmg + tab + tab + tab + damage +
                newLine + statGold + tab + tab + tab + tab + gold + newLine + statXP + tab + tab + tab + tab + tab + xp + newLine +
                newLine + option1 + option2 + option3 + option4;
            hasCharacter = true;
            SaveCharacter();
        }
    }

    void FightInArena()
    {
        atArena = true;
        d20 = Random.Range(0,46);
        tempMonHP = monsterHP[d20] * level;
        tempMonDam = monsterDamage[d20] * level;
        tempMonAC = monsterAC[d20];

        gameText.text = arenaTitle + newLine + newLine + arenaentrymsg +
            monsterNames[d20] + arenaentrymsg2 + newLine + newLine + option8;
        if(hasPotion)
            gameText.text += option5;
        if(hasOil)
            gameText.text += option6;
    }

    void VisitShop()
    {
        atShop = true;
        gameText.text = shopTitle + newLine + newLine + shopmsg + plrName + "!" +
            newLine + newLine +
            menuNumOne + menuItem5 + newLine +
            menuNumTwo + menuItem6 + newLine +
            menuNumThree + menuItem7 + newLine +
            menuNumFour + menuItem8 + newLine +
            menuNumFive + menuItem9 + newLine;
    }

    void DisplayArmorMenu()
    {
        //display armor to buy
        buyingArmor = true;
        gameText.text = armorTitle + newLine + newLine + menuNumOne +
            armorNames[0] + tab + tab + tab + acmsg +
            armorValues[0]  + tab + tab + costmsg + armorGoldValue[0] +
            gpmsg + newLine + menuNumTwo + armorNames[1]  + tab + tab + tab + tab + tab + acmsg +
            armorValues[1] + tab + tab + costmsg + armorGoldValue[1] +
            gpmsg + newLine + menuNumThree + armorNames[2] + tab + tab + tab + tab + tab + acmsg +
            armorValues[2] + tab + tab + costmsg + armorGoldValue[2] +
            gpmsg + newLine + menuNumFour + armorNames[3] + tab + tab + acmsg +
            armorValues[3]+ tab + tab  + costmsg + armorGoldValue[3] +
            gpmsg + newLine + menuNumFive + armorNames[4] + tab + tab + tab + tab + tab + acmsg +
            armorValues[4] + tab + tab + costmsg + armorGoldValue[4] +
            gpmsg + newLine + menuNumSix + armorNames[5] + tab + tab + tab + tab + tab + acmsg +
            armorValues[5] + tab + tab + costmsg + armorGoldValue[5] +
            gpmsg + newLine + menuNumSeven + armorNames[6] + tab + tab + tab + tab + tab + acmsg +
            armorValues[6] + tab + tab + costmsg + armorGoldValue[6] +
            gpmsg + newLine + menuNumEight + armorNames[7] + tab + tab + tab + tab + tab + acmsg +
            armorValues[7] + tab + tab + costmsg + armorGoldValue[7] +
            gpmsg + newLine + menuNumNine + armorNames[8] + tab + tab + tab + tab + acmsg +
            armorValues[8] + tab + tab + costmsg + armorGoldValue[8] +
            gpmsg + newLine + menuNumTen + armorNames[9] + tab + tab + tab + tab + acmsg +
            armorValues[9] + tab + tab + costmsg + armorGoldValue[9] +
            gpmsg + newLine + newLine + goldmsg + gold + newLine + newLine + option7;
    }

    void DisplayWeaponMenu()
    {
        //display weapons to buy 
        buyingWeapon = true;
        gameText.text = weaponTitle + newLine + newLine + menuNumOne +
            weaponNames[0] + tab + tab + tab + tab + tab +
            damagemsg + weaponDamage[0]  + tab + tab + costmsg +
            weaponGoldValue[0] + gpmsg + newLine + menuNumTwo +
            weaponNames[1]  + tab + tab + tab + damagemsg +
            weaponDamage[1] + tab + tab + costmsg + weaponGoldValue[1] +
            gpmsg + newLine + menuNumThree + weaponNames[2] +
            tab + tab + damagemsg + weaponDamage[2] + tab + tab +
            costmsg + weaponGoldValue[2] + gpmsg + newLine + menuNumFour +
            weaponNames[3] + tab + tab + tab + damagemsg + weaponDamage[3]+ tab +
            tab  + costmsg + weaponGoldValue[3] + gpmsg + newLine +
            menuNumFive + weaponNames[4] + tab + tab +
            damagemsg + weaponDamage[4] + tab + tab + costmsg +
            weaponGoldValue[4] + gpmsg + newLine + menuNumSix +
            weaponNames[5] + tab + tab + damagemsg +
            weaponDamage[5] + tab + tab + costmsg + weaponGoldValue[5] +
            gpmsg + newLine + newLine + goldmsg + gold + newLine + newLine + option7;
    }

    void DisplayPotionMenu()
    {
        //display potions to buy
        buyingPotion = true;
        gameText.text = potionTitle + newLine + newLine + menuNumOne +
            potionNames[0] + tab + tab + tab +
            healsmsg + potionValues[0]  + tab + tab + tab + tab + tab + tab + tab + costmsg +
            potionGoldValue[0] + gpmsg + newLine + menuNumTwo +
            potionNames[1]  + tab + tab + healsmsg +
            potionValues[1] + tab + tab + tab + tab + tab + tab + tab + costmsg + potionGoldValue[1] +
            gpmsg + newLine + menuNumThree + potionNames[2] + tab + tab + tab + tab +
            tab + tab + tab + incstrmsg + potionValues[2] + tab + tab +
            costmsg + potionGoldValue[2] + gpmsg + newLine + menuNumFour +
            potionNames[3] + tab + tab + tab + tab + tab + tab + tab + incdexmsg + potionValues[3]+ tab +
            tab  + costmsg + potionGoldValue[3] + gpmsg + newLine + newLine +
            goldmsg + gold + newLine + newLine + option7;
    }

    void DisplayOilMenu()
    {
        //display oils to buy
        buyingOil = true;
        gameText.text = oilTitle + newLine + newLine + menuNumOne + oilNames[0] +
            tab + tab + tab + tab + tab + tab + incdmgmsg + oilValues[0]  + tab + tab + costmsg +
            oilGoldValue[0] + gpmsg + newLine + menuNumTwo +
            oilNames[1]  + tab + tab + tab + tab + tab + incdmgmsg +
            oilValues[1] + tab + tab + costmsg + oilGoldValue[1] +
            gpmsg + newLine + menuNumThree + oilNames[2] + tab + tab +
            tab + tab + tab + incdmgmsg + oilValues[2] + tab + tab +
            costmsg + oilGoldValue[2] + gpmsg + newLine + menuNumFour +
            oilNames[3] + tab + tab + tab + incdmgmsg + oilValues[3]+ tab +
            tab  + costmsg + oilGoldValue[3] + gpmsg + newLine +
            menuNumFive + oilNames[4] + tab + tab + tab + tab + tab + tab +
            incdmgmsg + oilValues[4] + tab + tab + costmsg +
            oilGoldValue[4] + gpmsg + newLine + newLine + goldmsg + gold +
            newLine + newLine + option7;
    }

    void ShowStats()
    {
        atStatsScreen = true;

        gameText.text = statsTitle + newLine + newLine + statName + tab + tab +
            tab + tab + plrName + newLine + statLevel + tab + tab + tab + tab +
            level + newLine  + statArmorClass + tab + armorClass + newLine +
            statHP + tab + tab + tab + tab + tab + hp + newLine + statStr + tab + tab +
            tab + tab + tab + strength + newLine + statInt + tab + tab + tab + tab + tab +
            intelligence + newLine + statDex + tab + tab + tab + tab + dexterity +
            newLine + statCon + tab + tab + tab + tab + constitution + newLine +
            statArmor + tab + tab + tab + tab + armor + newLine + statWeapon +
            tab + tab + tab + weapon + newLine + statDmg + tab + tab +
            tab + damage + newLine + statGold + tab + tab + tab + tab +
            gold + newLine + statXP + tab + tab + tab + tab + tab + xp + newLine + newLine;

        if(hasCLW)
            gameText.text += holdingPotion + potionNames[0] + newLine;
        if(hasCSW)
            gameText.text += holdingPotion + potionNames[1] + newLine;
        if(hasStr)
            gameText.text += holdingPotion + potionNames[2] + newLine;
        if(hasDex)
            gameText.text += holdingPotion + potionNames[3] + newLine;
        if(hasFire)
            gameText.text += holdingOil + oilNames[0] + newLine;
        if(hasFrost)
            gameText.text += holdingOil + oilNames[1] + newLine;
        if(hasPoison)
            gameText.text += holdingOil + oilNames[2] + newLine;
        if(hasKeen)
            gameText.text += holdingOil + oilNames[3] + newLine;
        if(hasHoly)
            gameText.text += holdingOil + oilNames[4] + newLine;

        gameText.text += newLine + pressSpaceKey;
    }

    void InitStats()
    {
        level = 1;
        xp = 0;
        hp = 10;
        maxHP = hp;
        armorClass = 0;
        damage = 1;
        armor = "Rags";
        weapon = "Pointy Stick";
        strength = Random.Range(3,6);
        intelligence = Random.Range(3,6);
        dexterity = Random.Range(3,6);
        constitution = Random.Range(3,6);
        gold = Random.Range(3,6);
        currArmGoldValue = 0;
        currWepGoldValue = 0;
        currPotGoldValue = 0;
        currOilGoldValue = 0;
        currArmorIndex = 999;
        currWeaponIndex = 999;
        currPotionIndex = 999;
        currOilIndex = 999;
    }

    void InitArrays()
    {
        weaponNames = new string[6] {"Dagger","Short Sword","Broad Sword",
            "Long Sword","Bastard Sword", "Great Sword"}; 
        weaponDamage = new int[6] {5,8,11,14,17,20};
        weaponGoldValue = new int[6] {100,200,300,400,500,600};
        armorNames = new string[10] {"Heavy Robes", "Padded", "Leather",
            "Studded Leather", "Ringmail", "Scalemail","Chainmail","Splintmail",
            "Bandedmail", "Platemail"};
        armorValues = new int[10] {8,9,10,11,12,13,14,15,16,17};
        armorGoldValue = new int[10] {100,200,300,400,500,600,700,800,900,1000};
        potionNames = new string[4] {"Cure Light Wounds", "Cure Serious Wounds",
            "Strength", "Dexterity"};
        potionValues = new int[4] {10,25,5,5};
        potionGoldValue = new int[4] {50,150,150,150};
        oilNames = new string[5] {"Fire", "Frost", "Poison", "Keen Edge", "Holy"};
        oilValues = new int[5] {4,4,8,6,4};
        oilGoldValue = new int[5] {150,150,300,200,150};
        monsterNames = new string[45] {"Anhkheg", "Giant Ant", "Badger", "Bugbear",
        "Centaur", "Giant Centipede", "Giant Dragonfly", "Dryad", "Fire Elemental",
        "Water Elemental", "Giant Frog", "Poisonous Frog", "Gargoyle", "Goblin",
        "Gray Ooze", "Green Slime", "Harpy", "HobGoblin", "Ice Lizard", "Iron Cobra",
        "Mustard Jelly", "Jackal", "Kobold", "Kuo-Toa", "Giant Lizard", "Lizardman",
        "Minotaur", "Mummy", "Orge", "Orc", "OwlBear", "Giant Porcupine","Pixie",
        "Giant Rat", "Giant Scorpion", "Skeleton", "Giant Snake", "Giant Spider",
        "Strige", "Troglodyte", "Thri-Kreen", "Vulture", "Giant Wasp", "Wolf",
        "Zombie"};
        monsterHP = new int[45]{4,2,2,5,5,3,3,2,3,3,2,2,4,2,3,3,4,3,3,4,3,2,2,3,
            4,5,5,4,5,3,4,3,2,3,4,3,3,4,3,3,4,3,3,3,3};
        monsterDamage = new int[45] {2,1,3,4,3,3,2,2,2,2,1,2,3,2,2,3,3,3,3,3,2,
            2,2,2,4,3,4,5,4,2,3,3,1,2,3,2,2,3,2,2,4,3,2,2,2};
        monsterAC = new int[45] {10,10,10,11,11,10,13,10,11,11,10,10,12,10,10,10,12,12,11,11,11,10,10,
            11,12,11,12,11,11,11,11,11,12,10,11,11,12,11,10,11,12,11,11,10,10};

    }

    void InitStrings()
    {
        gameTitle = "<color=#008000ff>      W E L C O M E  T O\n" +
            "                 T H E\n" +
            "A R E N A  O F  D E A T H !</color>\n\n\n";
        mainMenu = "<color=#008000ff>M A I N  M E N U</color>\n\n";
        shopTitle = "<color=#008000ff>A R E N A  S H O P</color>\n\n";
        arenaTitle = "<color=#008000ff>T H E  A R E N A  O F  D E A T H</color>\n\n";
        statsTitle = "<color=#008000ff>P L A Y E R  S T A T S</color>\n\n";
        armorTitle = "<color=#008000ff>A R E N A  S H O P::A R M O R::</color>\n\n";
        weaponTitle = "<color=#008000ff>A R E N A  S H O P::W E A P O N S::</color>\n\n";
        potionTitle = "<color=#008000ff>A R E N A  S H O P::P O T I O N S::</color>\n\n";
        oilTitle = "<color=#008000ff>A R E N A  S H O P::O I L S::</color>\n\n";
        instructionTitle = "<color=#008000ff>I N S T R U C T I O N S</color>\n\n";

        menuItem1 = "<color=#008000ff>Create A Character</color>\n";
        menuItem2 = "<color=#008000ff>Fight In The Arena</color>\n";
        menuItem3 = "<color=#008000ff>Visit Store</color>\n";
        menuItem4 = "<color=#008000ff>See Stats</color>\n";
        menuItem5 = "<color=#008000ff>Buy Armor</color>\n";
        menuItem6 = "<color=#008000ff>Buy Weapon</color>\n";
        menuItem7 = "<color=#008000ff>Buy Potion</color>\n";
        menuItem8 = "<color=#008000ff>Buy Oil</color>\n";
        menuItem9 = "<color=#008000ff>Back to Main Menu</color>\n";
        menuItem10 = "<color=#008000ff>Delete Character & Logout</color>\n";

        menuNumOne = "<color=#ff0000ff>1. </color>";
        menuNumTwo = "<color=#ff0000ff>2. </color>";
        menuNumThree = "<color=#ff0000ff>3. </color>";
        menuNumFour = "<color=#ff0000ff>4. </color>";
        menuNumFive = "<color=#ff0000ff>5. </color>";
        menuNumSix = "<color=#ff0000ff>6. </color>";
        menuNumSeven = "<color=#ff0000ff>7. </color>";
        menuNumEight = "<color=#ff0000ff>8. </color>";
        menuNumNine = "<color=#ff0000ff>9. </color>";
        menuNumTen = "<color=#008000ff>1(</color>"+"<color=#ff0000ff>0</color>"+"<color=#008000ff>). </color>";

        pressSpaceKey = "<color=#008000ff>\nPress Space to Continue</color>\n";
        charCreateTitle = "<color=#008000ff>Welcome to the Character Creation Screen!</color>\n\n\n";
        enterName = "<color=#008000ff>Please enter a name for your character</color>\n";
        welcomemsg = "<color=#008000ff>Welcome to the Arena of Death </color>";
        statsmsg = "<color=#008000ff>I see you come to us with the following stats</color>\n";
        shopmsg = "<color=#008000ff>Welcome to the Arena Shop </color>";
        costmsg = "<color=#008000ff> Cost:  </color>";
        gpmsg = "<color=#008000ff>gp</color>";
        acmsg = "<color=#008000ff> AC: </color>";
        damagemsg = "<color=#008000ff> Damage: </color>";
        healsmsg = "<color=#008000ff> Heals For: </color>";
        incstrmsg = "<color=#008000ff> Increases Strength By: </color>";
        incdexmsg = "<color=#008000ff> Increases Dexterity By: </color>";
        incdmgmsg = "<color=#008000ff> Increases Damage By: </color>";
        goldmsg = "<color=#008000ff> Your Gold: </color>";
        arenaentrymsg = "<color=#008000ff>You enter the arena valiantly ready to" +
            " face whatever foes come before you!\n\nFrom a dark tunnel emerges a </color>";
        arenaentrymsg2 = "<color=#008000ff>! Prepare for battle!</color>";
        notEnoughGoldmsg = "<color=#008000ff>\n\nYou do not have enough gold for that item!</color>";
        winmsg = "<color=#008000ff>With a mighty blow the creature is defeated. You are victorious!</color>";
        losemsg = "<color=#008000ff>The prowess of the creature was too much. You have died!</color>";
        healpotionmsg = "<color=#008000ff>You drink the red liquid and are healed for </color>";
        strpotionmsg = "<color=#008000ff>You drink the blue liquid and you feel more powerful!</color>";
        dexpotionmsg = "<color=#008000ff>You drink the yellow liquid and you fell lighter on your toes!</color>";
        fireoilmsg = "<color=#008000ff>You coat the weapon with the oil and using a torch you set it ablaze!</color>";
        frostoilmsg = "<color=#008000ff>You coat the weapon with the oil and the air around you feels colder!</color>";
        poisonoilmsg = "<color=#008000ff>You coat the weapon with the oil making sure not to cut yourself!</color>";
        keenoilmsg = "<color=#008000ff>You coat the weapon with the oil and to test it out you cut a nearby table in half!</color>";
        holyoilmsg = "<color=#008000ff>You coat the weapon with the oil and you notice a slight yellowish glosh around the weapon!</color>";
        playerhitmsg =  "<color=#008000ff>Your attack connects and hits for </color>";
        playercrithitmsg = "<color=#008000ff>Your attack </color><color=#ff0000ff>critically </color><color=#008000ff>connects and hits for </color>";
        playermissmsg =  "<color=#008000ff>You attack but miss!</color>";
        monsterhitmsg = "<color=#008000ff>The monster's attack connects and hits for </color>";
        monstercrithitmsg = "<color=#008000ff>The monster's attack </color><color=#ff0000ff>critically </color><color=#008000ff>connects and hits for </color>";
        monstermissmsg =  "<color=#008000ff>The monster's attack misses!</color>";
        levelupmsg = "<color=#008000ff>You have leveled up!</color>";
        xpmsg = "<color=#008000ff>You have gained </color>";
        xpmsg2 = "<color=#008000ff> xp!</color>";
        goldmsg2 = "<color=#008000ff>You have gained </color>";
        statgainmsg = "<color=#008000ff>Your stats have gone up! </color>";
        strgainmsg = "<color=#008000ff>Your Strength went up by  </color>";
        intgainmsg = "<color=#008000ff>Your Intelligence went up by  </color>";
        dexgainmsg = "<color=#008000ff>Your Dexterity went up by  </color>";
        congainmsg = "<color=#008000ff>Your Constitution went up by  </color>";
        hpgainmsg = "<color=#008000ff>Your Hit Points went up by  </color>";
        levelgainmsg = "<color=#008000ff>You are now level   </color>";
        playerhpmsg =  "<color=#008000ff>Your HP:  </color>";
        monsterhpmsg = "<color=#008000ff>     Monster HP:  </color>";
        delcharmsg = "<color=#008000ff>Your character has been deleted.</color>";
        ptsofdammsg = "<color=#008000ff> points of damage!</color>";
        buyingConfirmation1 = "<color=#008000ff>\n\nYou will sell your </color>";
        buyingConfirmation2 = "<color=#008000ff> for </color>";
        buyingConfirmation3 = "<color=#008000ff> . Continue? Y/N</color>";
        buyingConfirmation4 = "<color=#008000ff>\n\nContinue? Y/N</color>";

        statName = "<color=#008000ff>Name: </color>";
        statLevel = "<color=#008000ff>Level: </color>";
        statStr = "<color=#008000ff>Str: </color>";
        statInt = "<color=#008000ff>Int: </color>";
        statDex = "<color=#008000ff>Dex: </color>";
        statCon = "<color=#008000ff>Con: </color>";
        statHP = "<color=#008000ff>HP: </color>";
        statArmor = "<color=#008000ff>Armor: </color>";
        statWeapon = "<color=#008000ff>Weapon: </color>";
        statArmorClass = "<color=#008000ff>Armor Class: </color>";
        statGold = "<color=#008000ff>Gold: </color>";
        statXP = "<color=#008000ff>XP: </color>";
        statDmg = "<color=#008000ff>Damage: </color>";
        newLine = "\n";
        tab = "\t";
        excalmation = "!";
        holdingPotion = "<color=#008000ff>Holding a Potion of </color>";
        holdingOil = "<color=#008000ff>Holding a Oil of </color>";
       
        option1 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>F</color>" + "<color=#008000ff>)ight in Arena</color> ";
        option2 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>V</color>" + "<color=#008000ff>)isit Store</color> ";
        option3 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>I</color>" + "<color=#008000ff>)structions</color> ";
        option4 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>L</color>" + "<color=#008000ff>)eave Arena</color> ";
        option5 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>Q</color>" + "<color=#008000ff>)uaff Potion</color> ";
        option6 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>U</color>" + "<color=#008000ff>)se Oil</color> ";
        option7 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>B</color>" + "<color=#008000ff>)ack to Shop Menu</color> ";
        option8 = "<color=#008000ff>(</color>" + "<color=#ff0000ff>A</color>" + "<color=#008000ff>)ttack</color> ";
        exitmsg = "<color=#008000ff>Thank you for playing Arena of Death!</color>\n";
    }

    void Instructions()
    {
        gameText.text = instructionTitle + newLine + newLine + "<color=#008000ff>" +
            "Backstory:"+ newLine + newLine +
            "You've heard about the infamy of the Arena of Death and wanted to see it for yourself. While venturing" +
            " to the arena you were ambushed and all of your stuff was stolen. When you awoke all you had on you were" +
            " rags. Next to you on the ground is a pointy stick. You pick it up and continue your journey to the " +
            "arena. Finally arriving you decide to enter and face whatever foes you have to fight!" + newLine + newLine +
            "Tips for the surviving the Arena of Death" + newLine + newLine +
            "1. Pressing the letter or number of the item you want will get you around the menus and are also used to " +
            "purchase items." + newLine +
            "2. It is possible to instantly miss or instantly hit in combat. an instant hit is for double damage." + newLine +
            "3. Death is permanent! if you die your character will be deleted." + newLine +
            "4. You can only have 1 potion and/or 1 oil at a time." + newLine +
            "5. Certain features are not implemented yet. Like vulnerabilities, and certain stats affecting different aspects" +
            " of the game. These are planned for the next update." + newLine +
            "6. There is no winning the Arena of Death, you will keep fighting until you die." + newLine +
            "7. More items, armor and weapons are also planned for the next update. As are the introduction of classes. " +
            "Stay tuned!" + newLine + newLine +
            "Thats it! Enjoy the Arena of Death!" + newLine + newLine + pressSpaceKey + "</color>";
    }

    void SaveCharacter()
    {
        PlayerPrefs.SetString("Name",plrName);
        PlayerPrefs.SetInt("Level",level);
        PlayerPrefs.SetInt("Str", strength);
        PlayerPrefs.SetInt("Int", intelligence);
        PlayerPrefs.SetInt("Dex", dexterity);
        PlayerPrefs.SetInt("Con", constitution);
        PlayerPrefs.SetInt("HP",hp);
        PlayerPrefs.SetInt("MaxHP",maxHP);
        PlayerPrefs.SetInt("ArmorClass", armorClass);
        PlayerPrefs.SetInt("Damage", damage);
        PlayerPrefs.SetInt("Gold", gold);
        PlayerPrefs.SetInt("XP", xp);
        PlayerPrefs.SetString("Armor", armor);
        PlayerPrefs.SetString("Weapon", weapon);
        PlayerPrefs.SetInt("CurrentArmorGoldValue", currArmGoldValue);
        PlayerPrefs.SetInt("CurrentWeaponGoldValue", currWepGoldValue);
        PlayerPrefs.SetInt("CurrentPotionGoldValue", currPotGoldValue);
        PlayerPrefs.SetInt("CurrentOilGoldValue", currOilGoldValue);
        PlayerPrefs.SetInt("CurrentArmorIndex", currArmorIndex);
        PlayerPrefs.SetInt("CurrentWeaponIndex", currWeaponIndex);
        PlayerPrefs.SetInt("CurrentPotionIndex", currPotionIndex);
        PlayerPrefs.SetInt("CurrentOilIndex", currOilIndex);

        if(hasCLW)
            PlayerPrefs.SetInt("HasCLW", 1);
        else
            PlayerPrefs.SetInt("HasCLW", 0);
        if(hasCSW)
            PlayerPrefs.SetInt("HasCSW", 1);
        else
            PlayerPrefs.SetInt("HasCSW", 0);
        if(hasStr)
            PlayerPrefs.SetInt("HasStr", 1);
        else
            PlayerPrefs.SetInt("HasStr", 0);
        if(hasDex)
            PlayerPrefs.SetInt("HasDex", 1);
        else
            PlayerPrefs.SetInt("HasDex", 0);
        if(hasFire)
            PlayerPrefs.SetInt("HasFire", 1);
        else
            PlayerPrefs.SetInt("HasFire", 0);
        if(hasFrost)
            PlayerPrefs.SetInt("HasFrost", 1);
        else
            PlayerPrefs.SetInt("HasFrost", 0);
        if(hasPoison)
            PlayerPrefs.SetInt("HasPoison", 1);
        else
            PlayerPrefs.SetInt("HasPoison", 0);
        if(hasKeen)
            PlayerPrefs.SetInt("HasKeen", 1);
        else
            PlayerPrefs.SetInt("HasKeen", 0);
        if(hasHoly)
            PlayerPrefs.SetInt("HasHoly", 1);
        else
            PlayerPrefs.SetInt("HasHoly", 0);
        

    }

    void LoadCharacter()
    {
        plrName = PlayerPrefs.GetString("Name");
        level =PlayerPrefs.GetInt("Level");
        strength = PlayerPrefs.GetInt("Str");
        intelligence = PlayerPrefs.GetInt("Int");
        dexterity = PlayerPrefs.GetInt("Dex");
        constitution = PlayerPrefs.GetInt("Con");
        hp = PlayerPrefs.GetInt("HP");
        maxHP = PlayerPrefs.GetInt("MaxHP");
        armorClass = PlayerPrefs.GetInt("ArmorClass");
        damage = PlayerPrefs.GetInt("Damage");
        gold = PlayerPrefs.GetInt("Gold");
        xp = PlayerPrefs.GetInt("XP");
        armor = PlayerPrefs.GetString("Armor");
        weapon = PlayerPrefs.GetString("Weapon");
        currArmGoldValue = PlayerPrefs.GetInt("CurrentArmorGoldValue");
        currWepGoldValue = PlayerPrefs.GetInt("CurrentWeaponGoldValue");
        currPotGoldValue = PlayerPrefs.GetInt("CurrentPotionGoldValue");
        currOilGoldValue = PlayerPrefs.GetInt("CurrentOilGoldValue");
        currArmorIndex =  PlayerPrefs.GetInt("CurrentArmorIndex");
        currWeaponIndex = PlayerPrefs.GetInt("CurrentWeaponIndex");
        currPotionIndex = PlayerPrefs.GetInt("CurrentPotionIndex");
        currOilIndex = PlayerPrefs.GetInt("CurrentOilIndex");

        if(PlayerPrefs.GetInt("HasCLW") == 1)
        {
            hasCLW = true;
            hasPotion = true;
        }
        if(PlayerPrefs.GetInt("HasCSW") == 1)
        {  
            hasCSW = true;
            hasPotion = true;
        }
        if(PlayerPrefs.GetInt("HasStr") == 1)
        {
            hasStr = true;
            hasPotion = true;
        }
        if(PlayerPrefs.GetInt("HasDex") == 1)
        {
            hasDex = true;
            hasPotion = true;
        }
        if(PlayerPrefs.GetInt("HasFire") == 1)
        {   
            hasFire = true;
            hasOil = true;
        }
        if(PlayerPrefs.GetInt("HasFrost") == 1)
        {
            hasFrost = true;
            hasOil = true;
        }
        if(PlayerPrefs.GetInt("HasPoison") == 1)
        {   
            hasPoison = true;
            hasOil = true;
        }
        if(PlayerPrefs.GetInt("HasKeen") == 1)
        {
            hasKeen = true;
            hasOil = true;
        }
        if(PlayerPrefs.GetInt("HasHoly") == 1)
        {
            hasHoly = true;
            hasOil = true;
        }
    }
}
