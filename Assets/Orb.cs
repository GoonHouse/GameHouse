using UnityEngine;
using System.Collections;

public class Orb : MonoBehaviour {
    public CharacterController cc;

	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        var v3 = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        cc.SimpleMove(v3);
	}
}
