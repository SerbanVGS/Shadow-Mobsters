using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalZar : MonoBehaviour
{
    public Resursa zar1, zar2, zar3, zar4, zar5, zar6;
    public int totalZar, rollCount, tradeResource;
    public GameObject rollBtn;
    public Text rollBtnText;
    // Start is called before the first frame update
    void Start()
    {
        totalZar = 1;
        rollCount = 0;
        tradeResource = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZarTotal()
    {
        totalZar = 1;
        totalZar = zar1.dieValue * zar2.dieValue * zar3.dieValue * zar4.dieValue * zar5.dieValue * zar6.dieValue;
    }

    public void RollCount()
    {
        rollCount++;
        if(rollCount == 3)
        {
            rollBtn.SetActive(false);
        }
    }
}
