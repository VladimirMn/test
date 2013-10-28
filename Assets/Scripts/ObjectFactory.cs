using UnityEngine;
using System.Collections;

public interface ObjectFactory
{
	GameObject createNewObjectWithTexture(Texture2D texture);
}
