using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {

	public Material[] colormaterial;
	private ParticleSystem colorParticleCauldron;
	Renderer rend;
	//public Color newcolor;
	//public Keycode changecolor;
	//public string numberValue;
	public int potion;

	// Use this for initialization
	void Start ()
	{
rend = GetComponent<Renderer>();
rend.enabled =  true;
rend.material = colormaterial[0];
colorParticleCauldron = GetComponent<ParticleSystem>();
//ParticleSystem.MainModule ma = colorParticleCauldron.main;


	}

	// Update is called once per frame
	void Update ()
	{
		if (potion == 0)
		{
			 Debug.Log("This potion is purple.");
			 rend.sharedMaterial = colormaterial[0];
			 colorParticleCauldron.startColor = new Color(0.2F, 0.3F, 1F, 0.5F);
		}
		else if (potion > 0 && potion < 10)
		{
			 Debug.Log("This potion is blue.");
			 rend.sharedMaterial = colormaterial[1];
			 colorParticleCauldron.startColor = new Color(1F, 0.3F, 0.4F, 0.5F);
		}
		else if (potion > 10 && potion < 20)
		{
			 Debug.Log("This potion is navy.");
			 rend.sharedMaterial = colormaterial[2];
			 colorParticleCauldron.startColor = new Color(0.2F, 1F, 0.4F, 0.5F);
		}
		else if (potion > 30 && potion < 40)
		{
			 Debug.Log("This potion is teal.");
			 rend.sharedMaterial = colormaterial[3];
		}
		else if (potion > 40 && potion < 50)
		{
			 Debug.Log("This potion is green.");
			 rend.sharedMaterial = colormaterial[4];
		}
		else if (potion > 50 && potion < 60)
		{
			 Debug.Log("This potion is olive.");
			 rend.sharedMaterial = colormaterial[5];
		}
		else if (potion > 60 && potion < 70)
		{
			 Debug.Log("This potion is yellow.");
			 rend.sharedMaterial = colormaterial[6];
		}
		else if (potion > 70 && potion < 80)
		{
			 Debug.Log("This potion is orange.");
			 rend.sharedMaterial = colormaterial[7];
		}
		else if (potion > 80 && potion < 90)
		{
			 Debug.Log("This potion is red.");
			 rend.sharedMaterial = colormaterial[8];
		}
		else if (potion > 90 && potion < 100)
		{
			 Debug.Log("This potion is pink.");
			 rend.sharedMaterial = colormaterial[9];
		}
		else if (potion == 100)
		{
			 Debug.Log("This potion is irridescent.");
			 rend.sharedMaterial = colormaterial[10];
		}
		else if (potion == 444)
		{
			 Debug.Log("This potion is the song of the  universe.");
			 rend.sharedMaterial = colormaterial[12];
		}
		else if (potion == 90)
		{
			 Debug.Log("This potion is oceanic.");
			 rend.sharedMaterial = colormaterial[13];
		}
		else if (potion == 80)
		{
			 Debug.Log("This potion is glowing like the sun.");
			 rend.sharedMaterial = colormaterial[14];
		}
		else if (potion == 70)
		{
			 Debug.Log("This potion has an eyeball in it.");
			 rend.sharedMaterial = colormaterial[15];
		}
		else if (potion == 60)
		{
			 Debug.Log("This potion looks like blood.");
			 rend.sharedMaterial = colormaterial[16];
		}
		else if (potion == 50)
		{
			 Debug.Log("This potion is crystalizing as we speak...");
			 rend.sharedMaterial = colormaterial[17];
		}
		else if (potion == 40)
		{
			 Debug.Log("This potion is gaseous for some reason.");
			 rend.sharedMaterial = colormaterial[18];
		}
		else if (potion == 30)
		{
			 Debug.Log("This potion is making cracking sounds.");
			 rend.sharedMaterial = colormaterial[19];
		}
		else if (potion == 20)
		{
			 Debug.Log("This potion is frozen over.");
			 rend.sharedMaterial = colormaterial[20];
		}
		else if (potion == 10)
		{
			 Debug.Log("This potion is hot to the touch.");
			 rend.sharedMaterial = colormaterial[21];
		}
		else
		{
			 Debug.Log("What did you do...?");
			 rend.sharedMaterial = colormaterial[22];
		}
}
}
