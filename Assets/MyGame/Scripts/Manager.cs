using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{
    [SerializeField] private Image computer, player;
    [SerializeField] private TextMeshProUGUI msg;

    // Start is called before the first frame update
    //Bei Btn Press: Schere Stein Papier spielen:
    /*
     * P random Schere Stein Papier waehlen
     * C random Schere Stein Papier waehlen
     * Sieger auswerten
     * Msg ausgeben
     */

    public void PlayGame()
    {      
        //Schere rot 0, Stein blau 2, Papier gruen 1
        //computer.GetComponent<Image>().color = Color.red;
        //player.color = Color.blue;

        int rnd = Random.Range(0, 3);
        if (rnd == 0)
        {
            computer.color = Color.red;
        }

        if (rnd == 1)
        {
            computer.color = Color.green;
        }
        if (rnd == 2)
        {
            computer.color = Color.blue;
        }

        int rndP = Random.Range(0, 3);
        if (rndP == 0)
        {
            player.color = Color.red;
        }

        if (rndP == 1)
        {
            player.color = Color.green;
        }
        if (rndP == 2)
        {
            player.color = Color.blue;
        }

        if (rnd == rndP)
        {
            msg.text = "Gewonnen hat keiner";
        }

        if (rnd == 0 && rndP == 1)
        {
            msg.text = "Gewonnen hat C";
        } 
        
        if (rnd == 0 && rndP == 2)
        {
            msg.text = "Gewonnen hat P";
        } 
        
        if (rnd == 1 && rndP == 0)
        {
            msg.text = "Gewonnen hat P";
        } 
        
        if (rnd == 1 && rndP == 2)
        {
            msg.text = "Gewonnen hat C";
        }  
        
        if (rnd == 2 && rndP == 0)
        {
            msg.text = "Gewonnen hat C";
        } 
        
        if (rnd == 2 && rndP == 1)
        {
            msg.text = "Gewonnen hat P";
        }
    }


    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Ich werde ausgefuehrt"); 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
