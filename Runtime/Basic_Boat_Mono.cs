using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace AppolyonKnight
{
    public class Basic_Boat_Mono : MonoBehaviour
    {
        [ContextMenu("teleport Forward")]
        public void TeleportForward()
        {
            transform.position += transform.forward * 1;
        }
    }
}

