using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OkBtn : MonoBehaviour
{
    public GameObject insert, enter, btn, turn, roll, endTurn;
    public Text insertText, scoreText;
    public InputField enterText;
    public ScorManager players;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        count = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OkBtnPressed()
    {
        if(count == -1)
        {
            players.noPlayers=int.Parse(enterText.text);
            if (players.noPlayers > 1 && players.noPlayers < 12)
            {
                count++;
                insertText.text = "Player " + (count + 1).ToString() + " name:";
            }
        }
        else if(count<players.noPlayers-1)
        {
            players.namePlayer[count]=enterText.text;
            count++;
            insertText.text = "Player " + (count + 1).ToString() + " name:";
        }
        else
        {
            players.namePlayer[count] = enterText.text;
            for(int i = 0; i < players.noPlayers; i++)
            {
                scoreText.text = scoreText.text + players.namePlayer[i] + "\n";
            }
            insert.SetActive(false);
            enter.SetActive(false);
            btn.SetActive(false);
            turn.SetActive(true);
            roll.SetActive(true);
            endTurn.SetActive(true);
        }
        enterText.text = "";
    }
}
