using UnityEngine;
using System.Collections;

public class MainSceneScript : MonoBehaviour 
{
	int frames = 0;
	float score = 0f;
	void Start() 
	{
		ObjectManager.getInstance().CreateObject(new SphereFactory(), new TextureFactory());
	}
	
	void Update () 
	{
		//Gerenarate object every 30 frames
		frames++;
		if (frames == 30)
		{
			ObjectManager.getInstance().CreateObject(new SphereFactory(), new TextureFactory());
			frames = 0;
		}
		
		//Check for left click on object
		if (Input.GetMouseButtonDown(0)) 
		{ 
			RaycastHit hit;
    		Ray ray = camera.ScreenPointToRay(Input.mousePosition); 
    		if (Physics.Raycast(ray, out hit, 50f)) 
			{
        		if(hit.collider.gameObject.name != "Plane")
				{
					//Using radius as score base
					score += Mathf.Round(((SphereCollider) hit.collider).radius * 10);
        			Destroy(hit.collider.gameObject);
				}
    		}
		}	
	}
	
	//Score
	void OnGUI()
	{
    	GUI.Label(new Rect(10, 550, 200, 100), "Заработано очков: " + score);
	}
}
