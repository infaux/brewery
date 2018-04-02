using UnityEngine;
using System.Collections;
public class onDemand : MonoBehaviour {
	private ReflectionProbe probe;

	void Awake () {
		probe = GetComponent<ReflectionProbe> ();
		probe.RenderProbe();
		}

		public void RefreshProbe(){
			probe.RenderProbe();
		}

}
