using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject FollowCar;

    // Late Update, which means with this whole update cycle, all the

    // things that are happening on update, each frame we can say actually not do this as the very last thing

    //that happens in the game logic, the very last update thing.


    //guarantee that our camera will absolutely follow our car smoothly because we know it's not

    //going to be fighting with the car in terms of what's my position
    void LateUpdate()
    {
        transform.position = FollowCar.transform.position + new Vector3(0, 0, -10f);
    }
}
