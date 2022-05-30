using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resursa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
        this.dieValue = 17;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int dieValue, pressCount;
    public GameObject checkImg,treasureImg;
    public Sprite imgResursaLemn;
    public Sprite imgResursaArgila;
    public Sprite imgResursaOaie;
    public Sprite imgResursaFan;
    public Sprite imgResursaPiatra;
    public Sprite imgResursaAur;
    public Sprite imgResursaX;
    public static int[] randomValue = new int[] { 2, 3, 5, 7, 11, 13 };
    public int length = randomValue.Length;

    public void DieRoll()
    {
        FindObjectOfType<AudioManager>().Play("Pacanea");
        treasureImg.SetActive(true);
        Invoke("CloseTreasure", 1f);

        if (dieValue != 1&&pressCount!=1)
        {
            dieValue = randomValue[Random.Range(0, length)];
        }
        switch (dieValue)
        {
            case 2:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaLemn;
                break;
            case 3:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaArgila;
                break;
            case 5:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaOaie;
                break;
            case 7:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaFan;
                break;
            case 11:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaPiatra;
                break;
            case 13:
                this.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaAur;
                break;
            default:
                break;
        }

    }
    public void CheckedResource()
    {
        if(pressCount==0)
        {
            checkImg.SetActive(true);
            pressCount=1;
        }
        else
        {
            checkImg.SetActive(false);
            pressCount=0;
        }
    }
    public void CloseTreasure()
    {
        treasureImg.SetActive(false);
    }
}
