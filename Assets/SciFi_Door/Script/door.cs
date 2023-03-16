using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;

    public void Start()
    {
        thedoor = GameObject.FindWithTag("SF_Door");
    }


    void OnTriggerEnter ( Collider obj  ){
        
        if (IsCompleteTask())
		{
			thedoor.GetComponent<Animation>().Play("open");
		}
}

void OnTriggerExit ( Collider obj  ){

		if (IsCompleteTask())
		{
			thedoor.GetComponent<Animation>().Play("close");
		}
}

	public bool IsCompleteTask() 
	{
		if (MainManager.Instance != null)
		{
			if (MainManager.Instance.player.Inventory.Items.Count == 5)
			{
				return true;
			}
			else { return false; }
		}
		return false;
	}
}