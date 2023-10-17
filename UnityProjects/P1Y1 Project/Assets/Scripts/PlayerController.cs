using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
[SerializeField] private Rigidbody2D playerRB;
[SerializeField] private float speed;
private float horizontalMovement;
private float verticalMovement;

[SerializeField] GameObject mainCamera;
[SerializeField] private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
horizontalMovement = Input.GetAxis("Horizontal");
verticalMovement = Input.GetAxis("Vertical");

playerRB.velocity = new Vector2 (horizontalMovement * speed, verticalMovement * speed);

mainCamera.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position + cameraOffset;


}

void  Jump(){
    if (Input.GetButtonDown("Jump")){
gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
    }

}
}