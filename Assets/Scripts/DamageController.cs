using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    public IconController iconController;

    // Use this for initialization
    void Start()
    {
        iconController = GameObject.FindObjectOfType<IconController>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("here");
        if (other.CompareTag("Block"))
        {
            Destroy(other);
            iconController.TakeDamange();
        }
    }

}
