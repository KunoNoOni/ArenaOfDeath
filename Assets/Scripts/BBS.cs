using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BBS : MonoBehaviour 
{
    Text gameText;

    float timer = 3;
    bool launchGame = false;
    bool onDoorPage = false;
    bool onMainMenu = true;
    bool modemInit = false;
    bool connecting = false;


    AudioSource asource;

	void Start ()
	{
        gameText = GameObject.FindWithTag("gameTextBox").GetComponent<Text>();
        asource = GetComponent<AudioSource>();
        if(Registry.alreadyConnected)
            LoadBBS();
        else
            ConnectToBBS();
        //gameText.text = "<color=#008000ff>(1) Arena of Death</color>";
	}

	void Update () 
	{
        if(onMainMenu && Input.GetKeyDown(KeyCode.Alpha3))
        {
            onDoorPage = true;
            Input.ResetInputAxes();
            LoadDoorPage();
        }

        if(onMainMenu && Input.GetKeyDown(KeyCode.Alpha4))
        {
            Application.Quit();
        }

        if(onDoorPage && Input.GetKeyDown(KeyCode.Alpha1))
        {
            onDoorPage = false;
            launchGame = true;
            Input.ResetInputAxes();
            gameText.text = "<color=#008000ff>\nEntering the Arena! Good Luck!</color>";
        }

        if(onDoorPage && Input.GetKeyDown(KeyCode.Alpha2))
        {
            onDoorPage = false;
            onMainMenu = true;
            Input.ResetInputAxes();
            LoadBBS();
        }

        if(launchGame)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                timer = 3;
                launchGame = false;
                SceneManager.LoadScene("Main");
            }
        }

        if(modemInit)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                timer = 3;
                modemInit = false;
                gameText.text += "<color=#008000ff>" + "\nDialing Ludum Dare BBS..."  + "</color>";
                asource.Play();
                connecting = true;
            }
        }

        if(connecting)
        {
            if(!asource.isPlaying)   
            {
                timer -= Time.deltaTime;
                if(timer < 0)
                {
                    timer = 3;
                    connecting = false;
                    LoadBBS();
                }
            }
        }
	}

    void ConnectToBBS()
    {
        gameText.text = "<color=#008000ff>" + "Initializing Modem..."  + "</color>";
        Registry.alreadyConnected = true;
        modemInit = true;

        
    }

    void LoadBBS()
    {
        //1. Arena of Death
        gameText.text = "<color=#008000ff>" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#######################################" + "</color>";
        gameText.text += "<color=#ff0000ff>" + "WELCOME TO THE LUDUM DARE BBS"+"</color>";
        gameText.text += "<color=#008000ff>" + "######################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########    SYSOP Note: This is an up and coming BBS. Right now I don't have much just one door game\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########    that I created myself. Its called the Arena of Death! Check it out and don't forget\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########    to check back often as I'll be making changes to the BBS.\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tM A I N   M E N U \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t++++++++++++++ \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t" + "</color>" + "<color=#ff0000ff>" + "1" + "</color>" + "<color=#008000ff>" + ". Message Board (Not Available)  \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t" + "</color>" +"<color=#ff0000ff>" + "2" + "</color>" + "<color=#008000ff>" + ". Files (Not Available)  \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t" + "</color>" +"<color=#ff0000ff>" + "3" + "</color>" + "<color=#008000ff>" + ". Door Games  \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t" + "</color>" +"<color=#ff0000ff>" + "4" + "</color>" + "<color=#008000ff>" + ". Logout\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "</color>";
    }

    void LoadDoorPage()
    {
        gameText.text = "<color=#008000ff>" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tDoor Games \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t++++++++++ \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t##########\n" +
            "\t\t\t##########\t\t\t\t\t\t" + "</color>" + "<color=#ff0000ff>" + "1" + "</color>" + "<color=#008000ff>" + ". Arena of Death\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t" + "</color>" + "<color=#ff0000ff>" + "2" + "</color>" + "<color=#008000ff>" + ". Main Menu\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" + "</color>" + "<color=#008000ff>" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t##########\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ##########\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "\t\t\t#############################################################################################################\n" +
            "</color>";
    }

}
