using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Wood"){
            Debug.Log("Wood");
        }
        else if(other.gameObject.tag == "Grass"){
            Debug.Log("Grass");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "DeadLine"){
            Debug.Log("You're Dead!");
        }
    }
}
