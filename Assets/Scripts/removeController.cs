using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeController : MonoBehaviour {
    public IconController iconController;

	// Use this for initialization
	void Start () {
        iconController = GameObject.FindObjectOfType<IconController>();
	}

    // Update is called once per frame
    void Update()
    {
        foreach (var touch in Input.touches)
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);

                if (hit && hit.collider.gameObject.CompareTag("Block"))
                {
                    Destroy(hit.collider.gameObject);
                    iconController.IncreaseBalance();
                    iconController.IncreaseKills();
                }

            }
    }
}
