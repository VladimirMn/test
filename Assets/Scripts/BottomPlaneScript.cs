using UnityEngine;
using System.Collections;

public class BottomPlaneScript : MonoBehaviour
{
	int count = 0;
	
	//Objects lost
	void OnGUI()
	{
    	GUI.Label(new Rect(10, 520, 200, 100), "Пропущенно объектов: " + count);
	}
	
	void OnCollisionEnter(Collision collision)
	{
    	count++;
      	Destroy(collision.gameObject);
   	}
}
