using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ButtonImageTarget : MonoBehaviour
{
    public GameObject[] list3DImage;
    public GameObject[] panelProv;
    public GameObject panelbelakang, panelAR;
    public GameObject imagetarget;
    public GameObject[] video;
    int panel;
    int ang;
    bool tracking = false;
    // Start is called before the first frame update
    void Start()
    {
        Kembali();
    }

    // Update is called once per frame
    void Update()
    {
        if (tracking == true)
        {
            video[ang - 1].GetComponent<VideoPlayer>().Play();
        }
        else
        {
            video[ang - 1].GetComponent<VideoPlayer>().Stop();
        }
    }
    public void Tampil3D(int angka)
    {
        panelbelakang.SetActive(false);
        panelAR.SetActive(true);
        imagetarget.SetActive(true);
        ang = angka;
        list3DImage[angka - 1].SetActive(true);

        if (angka >1 && angka <= 10)
        {
            panel = 1;
        }
        else if (angka >10 && angka <= 16)
        {
            panel = 2;
        }
        else if (angka > 16 && angka <= 19)
        {
            panel = 3;
        }
        else if (angka > 19 && angka <= 24)
        {
            panel = 4;
        }
        else if (angka > 24 && angka <= 30)
        {
            panel = 5;
        }
        else if (angka > 30 && angka <= 32)
        {
            panel = 6;
        }
        else 
        {
            panel = 7;
        }
    }
    public void Kembali()
    {
        
        panelbelakang.SetActive(true);
        panelAR.SetActive(false);
        imagetarget.SetActive(false);
        for (int i = 0; i <= list3DImage.Length; i++)
        {
            if (i == list3DImage.Length)
            {
                
            }
            else
            {
                list3DImage[i].SetActive(false);
            }
        }
        panelProv[panel - 1].SetActive(true);
    }
    public void tracked()
    {
        tracking = true;
    }
    public void Untreacked()
    {
        tracking = false;
    }
}
