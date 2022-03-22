using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControls: MonoBehaviour
{

    Animation animate;

    // Start is called before the first frame update
    void Start()
    {
        animate = gameObject.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnimation() {

        animate.Play();
    
    }

    public void pauseAnimation()
    {

        animate.Stop();
        

    }
}
