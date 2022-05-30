using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeResursa : MonoBehaviour
{
    public Resursa zar1, zar2, zar3, zar4, zar5, zar6;
    public Sprite imgResursa, imgResursaX;
    public TotalZar total;
    public GameObject changeZar1, changeZar2, changeZar3, changeZar4, changeZar5, rollBtn;
    public TotalZar rollCounter;
    public int numarResursa;
    

    public void AlegiResursa()
    {
        if (total.tradeResource == 6)
        {
            FindObjectOfType<AudioManager>().Play("Change");
            int cate = 0;
            total.totalZar = (total.totalZar / 169) * numarResursa;
            if (zar1.dieValue == 13 && cate != 1)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
                cate = 1;
            }
            if (zar2.dieValue == 13 && cate != 1)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
                cate = 1;
            }
            if (zar3.dieValue == 13 && cate != 1)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
                cate = 1;
            }
            if (zar4.dieValue == 13 && cate != 1)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
                cate = 1;
            }
            if (zar5.dieValue == 13 && cate != 1)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
                cate = 1;
            }
            if (zar6.dieValue == 13 && cate != 1)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
                cate = 1;
            }


            if (zar1.dieValue == 13 && cate != 2)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar1.dieValue = 1;
                cate = 2;
            }
            if (zar2.dieValue == 13 && cate != 2)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar2.dieValue = 1;
                cate = 2;
            }
            if (zar3.dieValue == 13 && cate != 2)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar3.dieValue = 1;
                cate = 2;
            }
            if (zar4.dieValue == 13 && cate != 2)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar4.dieValue = 1;
                cate = 2;
            }
            if (zar5.dieValue == 13 && cate != 2)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar5.dieValue = 1;
                cate = 2;
            }
            if (zar6.dieValue == 13 && cate != 2)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursaX;
                zar6.dieValue = 1;
                cate = 2;
            }
        }
        else if(total.tradeResource==2)
        {
            total.totalZar = (total.totalZar / 2) * numarResursa;
            if (zar1.dieValue == 2)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
            }
            else if (zar2.dieValue == 2)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
            }
            else if (zar3.dieValue == 2)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
            }
            else if (zar4.dieValue == 2)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
            }
            else if (zar5.dieValue == 2)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
            }
            else if (zar6.dieValue == 2)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
            }
        }
        else if (total.tradeResource == 3)
        {
            total.totalZar = (total.totalZar / 3) * numarResursa;
            if (zar1.dieValue == 3)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
            }
            else if (zar2.dieValue == 3)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
            }
            else if (zar3.dieValue == 3)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
            }
            else if (zar4.dieValue == 3)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
            }
            else if (zar5.dieValue == 3)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
            }
            else if (zar6.dieValue == 3)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
            }
        }
        else if (total.tradeResource == 5)
        {
            total.totalZar = (total.totalZar / 5) * numarResursa;
            if (zar1.dieValue == 5)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
            }
            else if (zar2.dieValue == 5)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
            }
            else if (zar3.dieValue == 5)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
            }
            else if (zar4.dieValue == 5)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
            }
            else if (zar5.dieValue == 5)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
            }
            else if (zar6.dieValue == 5)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
            }
        }
        else if (total.tradeResource == 7)
        {
            total.totalZar = (total.totalZar / 7) * numarResursa;
            if (zar1.dieValue == 7)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
            }
            else if (zar2.dieValue == 7)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
            }
            else if (zar3.dieValue == 7)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
            }
            else if (zar4.dieValue == 7)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
            }
            else if (zar5.dieValue == 7)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
            }
            else if (zar6.dieValue == 7)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
            }
        }
        else if (total.tradeResource == 11)
        {
            total.totalZar = (total.totalZar / 11) * numarResursa;
            if (zar1.dieValue == 11)
            {
                zar1.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar1.dieValue = numarResursa;
            }
            else if (zar2.dieValue == 11)
            {
                zar2.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar2.dieValue = numarResursa;
            }
            else if (zar3.dieValue == 11)
            {
                zar3.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar3.dieValue = numarResursa;
            }
            else if (zar4.dieValue == 11)
            {
                zar4.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar4.dieValue = numarResursa;
            }
            else if (zar5.dieValue == 11)
            {
                zar5.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar5.dieValue = numarResursa;
            }
            else if (zar6.dieValue == 11)
            {
                zar6.transform.GetChild(1).GetComponent<Image>().sprite = imgResursa;
                zar6.dieValue = numarResursa;
            }
        }

    }
    public void AccChange()
    {
        changeZar1.SetActive(false);
        changeZar2.SetActive(false);
        changeZar3.SetActive(false);
        changeZar4.SetActive(false);
        changeZar5.SetActive(false);
        if (rollCounter.rollCount < 3)
        {
            rollBtn.SetActive(true);
        }
        total.tradeResource = 0;
    }
}
