using UnityEngine;
using System.Collections;

public class SpellButton : MonoBehaviour {
    GameObject spell;
  
    void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            spell = Instantiate(Resources.Load("Bolt")) as GameObject;
            spell.transform.position = this.gameObject.transform.position;
        }





    }





}
