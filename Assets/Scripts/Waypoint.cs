using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waypoint : MonoBehaviour
{
    public Image waypoint;
    public Transform Target;

    private void Update()
    {
        float minX = waypoint.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = waypoint.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(Target.position);

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        waypoint.transform.position = pos;
    }
}
