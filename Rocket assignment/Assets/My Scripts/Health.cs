using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	

	public float healthPoints = 1f;
	public int dammage = 1;
	public bool isAlive = true;	
	
	// Update is called once per frame
	void Update () 
	{
		if (healthPoints <= 0) 
		{
			isAlive = false;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
        {
			healthPoints -= dammage;
        }
	}

	public void ApplyDamage(float amount)
	{	
		healthPoints = healthPoints - amount;	
	}
}
