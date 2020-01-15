using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public int value;
    public bool high;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
