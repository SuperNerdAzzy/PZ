using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyManager : MonoBehaviour {

    public List<BaseCharacter> PartyList;   //CHange this to an array? Then I don't need the int
    public Transform PartyTravelTarget;
    public int MaxPartySize = 3;    //THIS IS PUBLIC FOR EDITOR ACCESS ONLY.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Iterate through and call update on each player?
	}

    //TODO: Is XP shared equally among party members or split up based on kills and stuff?
    public void AwardXP(int xp)
    {
        for (int i = 0; i < PartyList.Count; i++)
            PartyList[i].MemberExperience.AddXP(xp / PartyList.Count);
    }

    public void SetMaxPartySize(int maxSize)
    {
        MaxPartySize = maxSize;
    }

    public void AddToParty(BaseCharacter character)
    {
        //TODO: Null checks for character?
        if (PartyList.Count < MaxPartySize)
            PartyList.Add(character);
        else { /*TODO: Error message on screen for player?*/ }
    }

    public void RemoveFromParty(BaseCharacter character)
    {
        if (PartyList.Contains(character))
            PartyList.Remove(character);
    }
}
