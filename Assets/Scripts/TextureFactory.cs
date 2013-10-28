using UnityEngine;
using System.Collections;

public class TextureFactory
{
	public Texture2D generateNewTexture()
	{
		var texture = new Texture2D(64, 64);
		
		for (int y = 0; y < texture.height; y++) 
		{
			for (int x = 0; x < texture.width; x++) 
			{
				//Texture design algorithm
				Color color = Color.green;
				if (x > y & x < (texture.width - y)) color = Color.blue;
				if (x < y & x < (texture.height - y)) color = Color.red; 
				if (x > y & x > (texture.height - y)) color = Color.yellow;
				texture.SetPixel(x, y, color);
			}
		}

		texture.Apply();
		
		return texture;
	}
}
