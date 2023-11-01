using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerControllerwithjump : MonoBehaviour
{
   
    public GameObject Firepoint;
    public GameObject firesprite;
    float inputHorizontal;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    inputHorizontal = Input.GetAxisRaw("Horizontal");
animator.SetFloat("speed", Mathf.Abs(inputHorizontal));
    Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void  Jump(){
    if (Input.GetButtonDown("Jump") && isGrounded == true){
gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
   
    }
if (inputHorizontal > 0)
{
    gameObject.transform.localScale = new Vector3(1,1,1);
    Firepoint.transform.localRotation = Quaternion.Euler(0, 0, 0);
    firesprite.transform.localRotation = Quaternion.Euler(0, 0, 0);
}
else if (inputHorizontal < 0)
{

Firepoint.transform.localRotation = Quaternion.Euler(0, 180, 0);
    gameObject.transform.localScale = new Vector3(-1,1,1);
    firesprite.transform.localRotation = Quaternion.Euler(0, 180, 0);
}
}

}
