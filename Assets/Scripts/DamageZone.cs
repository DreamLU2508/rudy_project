using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        RudyController controller = collision.GetComponent<RudyController>();

        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
