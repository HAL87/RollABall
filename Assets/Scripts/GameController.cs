using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scorelabel;
    public GameObject cleartext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scorelabel.text = count.ToString();
        if(count == 0)
        {
            cleartext.SetActive(true);
        }
    }
}
