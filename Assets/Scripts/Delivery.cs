using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    float destroyDelay = 0.5f;

    [SerializeField] Color32 packageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;


    bool packagePickedUp = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Delivery") && !packagePickedUp)
        {
            Debug.Log("Delivery");
            packagePickedUp = true;
            spriteRenderer.color = packageColor;
            Destroy(collision.gameObject, destroyDelay);

        }

        if (collision.gameObject.CompareTag("Customer") && packagePickedUp)
        {
            Debug.Log("Delivered");
            packagePickedUp = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
