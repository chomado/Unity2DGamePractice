using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var component = GetComponent<Transform>();
        // フレーム切り替わるごとに上に移動
        component.Translate(x: 0.0f, y: 0.1f, z: 0.0f);
        // 座標表示
        Debug.Log(component.position);
	}
}
