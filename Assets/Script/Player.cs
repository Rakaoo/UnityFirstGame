using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    public GameObject firlatma;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * HorizontalInput * Time.deltaTime * speed);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(firlatma, transform.position,firlatma.transform.rotation);
        }
    }
}
