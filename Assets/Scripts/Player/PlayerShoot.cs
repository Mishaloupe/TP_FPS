using System;
using Unity.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   [SerializeField] private Camera cameraFPS;
   [SerializeField] private float Range = 100.0f;
   [SerializeField] private float Damage = 10.0f;

   void Update()
   {
      if (Input.GetKeyDown(keyco))
      {
         Shoot();
      }
   }

   void Shoot()
   {
      
   }
}
