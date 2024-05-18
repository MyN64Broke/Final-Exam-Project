using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Pocket")){
            Destroy(gameObject);
            PlayerController playerController = player.GetComponent<PlayerController>();
            playerController.count++;
            playerController.SetCountText();
        }
    }
}
