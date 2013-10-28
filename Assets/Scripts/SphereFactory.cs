using UnityEngine;
using System.Collections;

public class SphereFactory : ObjectFactory
{
	public GameObject createNewObjectWithTexture(Texture2D texture)
	{
		GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		obj.AddComponent("Rigidbody");
		
		var sizeFactor = Random.Range(0.01f, 1f);
		var size = Random.Range(sizeFactor, 2f);
		
		//Start position values
		var randomX = Random.Range(-4f, 4f);
		var RandomY = Random.Range(8f, 12f);
		
		obj.transform.position = new Vector3(randomX, RandomY, -5);
		
		//"Falling speed"
		obj.rigidbody.drag = Random.Range(1f, 8f);
	
		((SphereCollider) obj.collider).radius = size;

		obj.renderer.material.mainTexture = texture;
		
		return obj;
	}
}
