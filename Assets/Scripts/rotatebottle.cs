using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatebottle : MonoBehaviour {

public Transform gameObject;
public ParticleSystem sparkles;
//public int angleX;
public float angleX;

	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.AngleAxis(angleX, Vector3.left);
		//transform.eulerAngles = new Vector3(0, 0, angleX);
		if(angleX <= 0)
		{
			sparkles.Play();
			//ParticleSystemStopBehavior.StopEmitting;
		}
		else
		{
			sparkles.Stop();
		}

	}

}
