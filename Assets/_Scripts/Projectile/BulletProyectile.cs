using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProyectile : MonoBehaviour
{

    [SerializeField] private float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *speed * Time.deltaTime);
    }
}
