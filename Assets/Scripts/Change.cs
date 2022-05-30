using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public TotalZar total;
    public GameObject changeZar1, changeZar2, changeZar3, changeZar4, changeZar5, cantChange, rollBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DiceChange()
    {
        if(total.totalZar%169==0)
        {
            changeZar1.SetActive(true);
            changeZar2.SetActive(true);
            changeZar3.SetActive(true);
            changeZar4.SetActive(true);
            changeZar5.SetActive(true);
            rollBtn.SetActive(false);
            total.tradeResource = 6;
        }
        else
        {
            cantChange.SetActive(true);
            Invoke("CloseCantChange", 2f);
        }
    }

    public void CloseCantChange()
    {
        cantChange.SetActive(false);
    }
}
