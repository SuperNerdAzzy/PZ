using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour {

    public Experience MemberExperience;
    //HP, Attack, Defense, etc

	// Use this for initialization
	void Start () {
        MemberExperience = new Experience();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
