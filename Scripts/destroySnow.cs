using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySnow : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
     //[SerializeField] NumberField scoreField;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == triggeringTag && enabled ) {

            Debug.Log("--->");
            Destroy(this.gameObject);
        }
    }
}
