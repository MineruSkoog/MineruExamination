using UnityEngine;

public class WalkLeft : MonoBehaviour
{
    Animator WalkAnimator;
    // Start is called before the first frame update
    void Start()
    {
        WalkAnimator = GetComponent<Animator>();
    
        WalkAnimator.SetBool("WalkLeft", false);
    }
    // update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            Debug.Log("Button Pressed");
            WalkAnimator.SetBool("WalkLeft",true); 
        }
        
        if (Input.GetKeyUp(KeyCode.A) )
        { 
            WalkAnimator.SetBool("WalkLeft",false); 
        }    
        
    }

   
}

