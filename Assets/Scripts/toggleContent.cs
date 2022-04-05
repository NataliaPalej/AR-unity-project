using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleContent : MonoBehaviour
{

    //
    public bool hideAllButtonsAtStart = true;
    public GameObject[] toggleList;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in toggleList)
        {

            if (hideAllButtonsAtStart)
            {
                go.SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle() {

        foreach (GameObject go in toggleList) {

            if (go.active) {
                go.SetActive(false);
            }
            else {
                go.SetActive(true);
            }
        }

    }
}
