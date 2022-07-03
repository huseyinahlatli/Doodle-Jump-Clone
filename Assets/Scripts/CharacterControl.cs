using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] float characterSpeed, jumpSpeed;
    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(horizontalAxis * characterSpeed * Time.deltaTime, 0, 0);
    }
    
    public void CharacterSpeed()
    {
        rigidbody.AddForce(Vector2.up * jumpSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<CharacterControl>().CharacterSpeed();            
        }
    }
}
 