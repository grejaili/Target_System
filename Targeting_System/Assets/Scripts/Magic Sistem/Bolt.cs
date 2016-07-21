using UnityEngine;
using System.Collections;

public class Bolt : MonoBehaviour {
    public GameObject Target;
    Rigidbody theRigidbody;
    Transform followThis;

    public string Name;
    public float moveSpeed = 1;
    public int id;
    public float damage;
    
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

    void OnCollisionEnter(Collision col)
    {
         //float Health = col.gameObject.GetComponent<EnemyStats>().health;
        Debug.Log(col.gameObject.tag.Contains("Enemy"));
        Debug.Log(followThis);

        if (Target.GetComponent<Targeting>().selectedTarget == col.gameObject)
        {
            Debug.Log("oi");
            col.gameObject.GetComponent<EnemyStats>().health = col.gameObject.GetComponent<EnemyStats>().health - DealDamage();
            Destroy(this.gameObject);
        }
        
          
    }

    float DealDamage()
    {
           // we can make the enemy resistence as a variable in the EnemyStats script and return
           // damage-resistence
        return damage;
    }

}
