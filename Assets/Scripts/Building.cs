using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public int[] buildingPoints, buildingCount, buildingUnlock;
    public TotalZar total;
    public EndTurn turn;
    public ScorManager player;
    public int buildingCost;
    public GameObject cantText,rollBtn;
    public Building cube;
    public BuildingView[] bld;
    public string sunet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Build()
    {
        if(total.totalZar%this.buildingCost==0&&cube.buildingCount[(turn.turnCount - 1) % player.noPlayers]>=this.buildingUnlock[this.buildingCount[(turn.turnCount - 1) % player.noPlayers]])
        {
            total.totalZar=total.totalZar/this.buildingCost;
            turn.turnScore = turn.turnScore+this.buildingPoints[this.buildingCount[(turn.turnCount - 1) % player.noPlayers]];
            this.buildingCount[(turn.turnCount - 1) % player.noPlayers]++;
            rollBtn.SetActive(false);
            FindObjectOfType<AudioManager>().Play(sunet);
            for (int i=0;i<bld.Length;i++)
            {
                bld[i].ViewBuild();
            }
        }
        else
        {
            cantText.SetActive(true);
            Invoke("CloseCantChange", 2f);
        }
    }

    public void CloseCantChange()
    {
        cantText.SetActive(false);
    }
}
