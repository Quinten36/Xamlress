using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public Vector3 player;
    public float pakAfstand = 2f;
    public BackpackPickup BackpackPickUp;
    public GameObject Backpack;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward * pakAfstand);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pakAfstand))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * pakAfstand;
            Debug.DrawRay(transform.position, forward, Color.green);
            if (hit.collider.tag == "Item")
            {
                Debug.Log("ray");
                BackpackPickUp.glowStart();
                if (Input.GetKey(KeyCode.E))
                {
                    BackpackPickUp.pickupBackpack();
                    Destroy(Backpack);
                    Debug.Log("Backpack opgepakt");
                }
            }
        }
    }
}
