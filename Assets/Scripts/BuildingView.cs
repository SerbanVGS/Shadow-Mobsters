using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildingView : MonoBehaviour
{
    public Building buildingType;
    public int noBuilding;
    public EndTurn turn;
    public ScorManager player;
    public GameObject building;
    // Start is called before the first frame update
    void Start()
    {
        building.SetActive(false);
    }

    // Update is called once per frame
    public void ViewBuild()
    {
        if(buildingType.buildingCount[(turn.turnCount - 1) % player.noPlayers]>=noBuilding)
        {
            building.SetActive(true);
        }
        else
        {
            building.SetActive(false);
        }
    }
    public void HideBuild()
    {
        building.SetActive(false);
    }
    public void ViewAllBuilds()
    {
        building.SetActive(true);
    }
}
