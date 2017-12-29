using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour {

    Dictionary<string, Sprite> pose = new Dictionary<string, Sprite>()
    {
        { "Normal", null },
        { "Right", null },
        { "Left", null },
        { "Both", null },
    };

	// Use this for initialization
	void Start () {

		foreach (var key in new List<string>(pose.Keys))
        {
            var texture = (Texture2D)Resources.Load(path: "Rpbot_" + key);

            pose[key] = Sprite.Create(
                texture: texture
                , rect: new Rect(x: 0, y: 0, width: texture.width, height: texture.height)
                , pivot: new Vector2(x: 0.5f, y: 0.5f)
            );
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        var isLeftClicked = Input.GetMouseButton(button: 0);
        var isRightClicked = Input.GetMouseButton(button: 1);

        // マウスの左と右が両方押された
        if (isLeftClicked && isRightClicked)
        {
            GetComponent<SpriteRenderer>().sprite = pose["Both"];
        }
        // マウスの左が両方押された
        else if (isLeftClicked)
        {

        }
        // マウスの右が押された
        else if (isRightClicked)
        {

        }
	}
}
