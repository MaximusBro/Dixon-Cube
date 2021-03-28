using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    private bool Ispaused = false;
    public GameObject pp;
    
    // Start is called before the first frame update
    void Start()
    {
        pp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !Ispaused)
        {
            pp.SetActive(true);
            Time.timeScale = 0;
            Ispaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Ispaused)
        {
            pp.SetActive(false);
            Time.timeScale = 1;
            Ispaused = false;
        }
    }
    public void pauseOn()
    {
        pp.SetActive(true);
        Time.timeScale = 0;
        Ispaused = true;
    }
    public void _continue()
    {
        pp.SetActive(false);
        Time.timeScale = 1;
        Ispaused = false;
    }
}
