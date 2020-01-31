using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    [SerializeField] private PlayerManager playerManager;
    [SerializeField, Range(0, 1)] private float speed;
    [SerializeField] private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 min = Vector2.positiveInfinity;
        Vector2 max = Vector2.negativeInfinity;
        Vector3 centrepoint = Vector2.zero;

        for (int i = 0; i < playerManager.players.Count; i++)
        {
            var position = playerManager.players[i].transform.position;
            if (position.x < min.x)
            {
                min.x = position.x;
            }
            if (position.z < min.y)
            {
                min.y = position.z;
            }
            if (position.x > max.x)
            {
                max.x = position.x;
            }
            if (position.z > max.y)
            {
                max.y = position.z;
            }
        }

        centrepoint.x = (min.x + max.x) / 2;
        centrepoint.z = (min.y + max.y) / 2;

        float maxClampDistance = 15.0f;
        float minClampDistance = 5.5f;


        var distance = Vector3.Distance(min, max);
        print(distance);
        distance = Mathf.Clamp(distance, minClampDistance, maxClampDistance);
        var offset = _offset * distance;
       
        transform.position = Vector3.Lerp(transform.position, centrepoint + offset, speed);
    }
}
