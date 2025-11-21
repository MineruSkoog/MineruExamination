using Unity.VisualScripting;
using UnityEngine;

public class SidekickScript : MonoBehaviour
{
    Animator WalkAnimator;
    // Start is called before the first frame update
    void Start()
{
    WalkAnimator = GetComponent<Animator>();
    
    WalkAnimator.SetBool("Walk", false);
    }
    // update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) )
            {
                Debug.Log("Button Pressed");
                WalkAnimator.SetBool("Walk",true); 
            }
        
        if (Input.GetKeyUp(KeyCode.D) )
            { 
                WalkAnimator.SetBool("Walk",false); 
            }    
        
    }

   
}
    
    
