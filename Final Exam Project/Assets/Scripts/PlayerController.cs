using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    public int count;
    public float speed;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    void FixedUpdate(){
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnMove(InputValue movementValue){
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    /**void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Pickup")){
            count++;
            SetCountText();
        }
    }*/

    public void SetCountText(){
        countText.text = "Count: " + count.ToString();
        if(count >= 15){
            winTextObject.SetActive(true);
        }
    }
}
