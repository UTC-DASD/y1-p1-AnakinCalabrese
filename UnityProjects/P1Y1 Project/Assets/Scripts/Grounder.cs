using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Grounder : MonoBehaviour
{
    public UnityEvent OnLandEvent;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
       Player = gameObject.transform.parent.gameObject; 
    }

    // Update is called once per frame
    void Update(){
    
        
    }
private void OnCollisionEnter2D(Collision2D collision)
{
if (collision.collider.tag == "Ground"){
Player.GetComponent<PlayerControllerwithjump>().isGrounded = true;
OnLandEvent.Invoke();
}

}
private void OnCollisionExit2D(Collision2D collision)
{
    if (collision.collider.tag == "Ground"){
    Player.GetComponent<PlayerControllerwithjump>().isGrounded = false;
}
}

}