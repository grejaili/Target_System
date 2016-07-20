using UnityEngine;
using System.Collections;

public class Bolt : MonoBehaviour {
    public GameObject Target;
    Rigidbody theRigidbody;
    Transform followThis;
    public float moveSpeed = 1;
    public int id;

    void Start()
    {
        Destroy(this.gameObject, 5);
        theRigidbody = GetComponent<Rigidbody>();
        Target = GameObject.FindGameObjectWithTag("Target");
        followThis = Target.GetComponent<Targeting>().selectedTarget.transform;
    }

    void Update()
    {
        lookAtTarget();
    }

    void lookAtTarget()
    {
        this.gameObject.transform.LookAt(followThis);
        movePlease();
    }

    void movePlease()
    {
        gameObject.transform.position += transform.forward * moveSpeed * 1;
    }
}
