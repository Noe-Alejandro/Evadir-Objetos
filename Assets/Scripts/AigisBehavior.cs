using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AigisBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.D))
        {
            if (!GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            GetComponent<Animator>().SetBool("Run",true);
            transform.Translate(5f*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            GetComponent<Animator>().SetBool("Run", true);
            transform.Translate(-5f*Time.deltaTime,0,0);
        }
        Para unidades con píxeles*/

        if (Input.GetKey(KeyCode.D))
        {
            if (!GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            GetComponent<Animator>().SetBool("Run", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f*Time.deltaTime,0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            GetComponent<Animator>().SetBool("Run", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f*Time.deltaTime, 0));
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Animator>().SetBool("Run", false);
        }
    }
}
