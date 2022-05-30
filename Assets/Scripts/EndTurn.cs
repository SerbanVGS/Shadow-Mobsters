using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    public Text turn, scoreText, buildInfo;
    public int turnCount, turnScore;
    public ScorManager player;
    public TotalZar theRollCounter;
    public GameObject rollBtn,endTurnBtn;
    public Resursa zar1,zar2,zar3,zar4,zar5,zar6;
    public Sprite imgResursaX;
    public BuildingView[] bld,soldatView;
    public ChangeResursaSoldat[] soldat;
    public Building asezare, mRoad, sRoad, city, soldatChange;
    // Start is called before the first frame update
    void Start()
    {
        turnCount = 1;
        turnScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        turn.text = "Turn "+ turnCount.ToString() + " of " + (player.noPlayers*15).ToString() + "\n" + player.namePlayer[(turnCount-1)%player.noPlayers] + "'s turn";
        buildInfo.text = "MRoad: " + mRoad.buildingCount[(turnCount - 1) % player.noPlayers].ToString() + "\n"
            + "SRoad: " + sRoad.buildingCount[(turnCount - 1) % player.noPlayers].ToString() + " need MRoad: " + sRoad.buildingUnlock[sRoad.buildingCount[(turnCount - 1) % player.noPlayers]].ToString() + "\n"
            + "Asezare: " + asezare.buildingCount[(turnCount - 1) % player.noPlayers].ToString() + " need MRoad: " + asezare.buildingUnlock[asezare.buildingCount[(turnCount - 1) % player.noPlayers]].ToString() + "\n"
            + "City: " + city.buildingCount[(turnCount - 1) % player.noPlayers].ToString() + " need SRoad: " + city.buildingUnlock[city.buildingCount[(turnCount - 1) % player.noPlayers]].ToString() + "\n"
            + "Soldat: " + soldatChange.buildingCount[(turnCount - 1) % player.noPlayers].ToString();
    }

    public void TurnEnds()
    {
        if (turnScore > 0)
        {
            player.score[(turnCount - 1) % player.noPlayers] = player.score[(turnCount - 1) % player.noPlayers] + turnScore;
        }
        else
        {
            player.score[(turnCount - 1) % player.noPlayers] = player.score[(turnCount - 1) % player.noPlayers] - 2;
            FindObjectOfType<AudioManager>().Play("Skip");
        }
        scoreText.text = "";
        for (int i = 0; i < player.noPlayers; i++)
        {
            scoreText.text = scoreText.text + player.namePlayer[i] + " " + player.score[i].ToString() + "\n";
        }
        zar1.dieValue = 17;
        zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar1.checkImg.SetActive(false);
        zar1.pressCount = 0;
        zar2.dieValue = 17;
        zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar2.checkImg.SetActive(false);
        zar2.pressCount = 0;
        zar3.dieValue = 17;
        zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar3.checkImg.SetActive(false);
        zar3.pressCount = 0;
        zar4.dieValue = 17;
        zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar4.checkImg.SetActive(false);
        zar4.pressCount = 0;
        zar5.dieValue = 17;
        zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar5.checkImg.SetActive(false);
        zar5.pressCount = 0;
        zar6.dieValue = 17;
        zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        zar6.checkImg.SetActive(false);
        zar6.pressCount = 0;
        theRollCounter.rollCount = 0;
        rollBtn.SetActive(false);
        rollBtn.SetActive(true);
        turnCount++;
        turnScore = 0;
        for(int i = 0; i < 30; i++)
        {
            bld[i].ViewBuild();
        }
        for (int i = 0; i < 5; i++)
        {
            if (soldat[i].used[(turnCount - 1) % player.noPlayers] != 1)
            {
                soldatView[i].ViewBuild();
            }
            else soldatView[i].HideBuild();
        }
        if (turnCount == (player.noPlayers*15)+1)
        {
            FindObjectOfType<AudioManager>().Play("Win");
            int maxScore = -10000;
            int maxScoreDraw = -10000;
            string maxName="";
            for(int i=0;i<player.noPlayers;i++)
            {
                if (player.score[i] > maxScoreDraw)
                {
                    if (player.score[i] > maxScore)
                    {
                        maxScore = player.score[i];
                        maxName = player.namePlayer[i];
                    }
                    else
                    {
                        maxScoreDraw = player.score[i];
                    }
                }
            }
            if (maxScore != maxScoreDraw)
            {
                scoreText.text = maxName + " WINS!";
            }
            else
            {
                scoreText.text = "Draw game";
            }
            endTurnBtn.SetActive(false);
            rollBtn.SetActive(false);
            for (int i = 0; i < 30; i++)
            {
                bld[i].ViewAllBuilds();
            }
            for (int i = 0; i < 5; i++)
            {
                soldatView[i].HideBuild();
            }
        }
    }
}
