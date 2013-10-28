using UnityEngine;
using System.Collections;
using System.Collections.ObjectModel;

public class ObjectManager
{
	private static ObjectManager Instance;

	private ObjectManager() {}
	
	public static ObjectManager getInstance()
	{
		if (Instance == null) Instance = new ObjectManager();
		return Instance;
	}
	
	public void CreateObject(ObjectFactory objectFactory, TextureFactory textureFactory)
	{
		var texture = textureFactory.generateNewTexture();
		var obj = objectFactory.createNewObjectWithTexture(texture);
		IncreaseObjectSpeed(obj);
	}
	
	//Increase objects speed in time
	float increaseFactor = 0.025f;
	
	private void IncreaseObjectSpeed(GameObject obj)
	{
		obj.rigidbody.drag = 
			obj.rigidbody.drag - increaseFactor > 0 ? obj.rigidbody.drag - increaseFactor : increaseFactor / 10;
		increaseFactor += 0.025f;
	}
}
