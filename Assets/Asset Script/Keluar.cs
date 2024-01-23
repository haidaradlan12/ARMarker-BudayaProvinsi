using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keluar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void keluar()
    {
        Application.Quit();
    }
    public void Pindahscene(string nama)
    {
        SceneManager.LoadScene(nama);
    }
}
