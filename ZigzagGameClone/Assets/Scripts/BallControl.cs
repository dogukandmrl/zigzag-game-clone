using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public RandomPlatformSpawner playformSpawnerScript;
    public static bool isFall;
    public float addSpeed;
    void Start()
    {
        direction = Vector3.forward;
        isFall = false;
    }

    
    void Update()
    {
        if(transform.position.y<=0.5f)
        {
            isFall = true;
        }

        if (isFall == true)
        {
            Debug.Log("Fall");
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(direction.x ==0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            speed += addSpeed * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 moving = direction * Time.deltaTime * speed;
        transform.position += moving;
    }
    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "platform")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            playformSpawnerScript.platfromCreate();
            StartCoroutine(deletePlatform(collision.gameObject));
        }
    }
    IEnumerator deletePlatform (GameObject deleted)
    {
        yield return new WaitForSeconds(3f);
        Destroy(deleted);
    }
}
