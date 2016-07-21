using UnityEngine;
using System.Collections;

public class Targeting : MonoBehaviour {
    public GameObject[] players;
    public GameObject closestTarget;
    Rigidbody theRigidBody;
    Vector3 myPosition;
    public GameObject Self;
  public   GameObject selectedTarget;


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            TargetSystemButton();
        

        }
        // Allways follow the selected target
        FollowTarget();
    }

    void TargetSystemButton()
    {
        #region ClearVariables
        players = null;
        closestTarget = null;
        #endregion

        #region localVariables
        players = GameObject.FindGameObjectsWithTag("Enemy");
        float distance = Mathf.Infinity;
        Vector3 position = Self.GetComponent<Transform>().position;

       
        #endregion

        for (int i = 0; i < players.Length;i++)
        {
            Vector3 diff = players[i].transform.position - position;

            float curDistance = diff.sqrMagnitude;


            if ((curDistance < distance) && (players[i] != Self) && (this.gameObject.transform.position != players[i].transform.position ))
            {
                distance = curDistance;
                closestTarget = players[i];
            }
        }

        if ((closestTarget != selectedTarget) || (selectedTarget == null))
        {
            SwapTarget();
        }

       
    }

   public  void SwapTarget()
    {
        
        selectedTarget = closestTarget;

    }

  public  void FollowTarget ()
    {
         if (selectedTarget != null)    
        this.gameObject.transform.position = selectedTarget.transform.position;
    }

  
}
