using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soal : MonoBehaviour
{
    int a, b, c, d, e, f, g, h, i, j, total;
    public Text textnya;
    public GameObject[] jawaban;
    // Start is called before the first frame update
    void Start()
    {
        a = b = c = d = e = f = g = h = i = j = 0;
    }

    // Update is called once per frame
    void Update()
    {
        total = (a + b + c + d + e + f + g + h + i + j)*10;
        textnya.text = "Nilai Anda = " + total;
    }
    public void soal01(int nilai)
    {
        a = nilai;
    }
    public void soal02(int nilai)
    {
        b = nilai;
    }
    public void soal03(int nilai)
    {
        c = nilai;
    }
    public void soal04(int nilai)
    {
        d = nilai;
    }
    public void soal05(int nilai)
    {
        e = nilai;
    }
    public void soal06(int nilai)
    {
        f = nilai;
    }
    public void soal07(int nilai)
    {
        g = nilai;
    }
    public void soal08(int nilai)
    {
        h = nilai;
    }
    public void soal09(int nilai)
    {
        i = nilai;
    }
    public void soal10(int nilai)
    {
        j = nilai;
    }
    public void ResetSoal()
    {
        a = b = c = d = e = f = g = h = i = j = 0;
        for (int i=0; i<jawaban.Length; i++)
        {
            jawaban[i].SetActive(false);
        }
    }
}
