using UnityEngine;
using System.Collections;
public class sunRotate : MonoBehaviour {
	public float speed = -1.0f;
	void Update () {
		    transform.Rotate(Vector3.up * speed * Time.deltaTime);
			}
}
