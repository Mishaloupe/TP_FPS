using System;
using Unity.Collections;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
   [SerializeField] private Camera cameraFPS;
   [SerializeField] private float Range = 100.0f;
   [SerializeField] private float Damage = 10.0f;
   [SerializeField] private PlayerInputHandler playerInputHandler;
   [SerializeField] private Transform muzzlePoint;
   
   private LineRenderer lineRenderer;

   void Start()
   {
      // Créer et configurer le LineRenderer une seule fois
      lineRenderer = gameObject.AddComponent<LineRenderer>();
      lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
      lineRenderer.startColor = Color.red;
      lineRenderer.endColor = Color.green;
      lineRenderer.startWidth = 0.05f;
      lineRenderer.endWidth = 0.05f;
      lineRenderer.enabled = false; // désactivé par défaut
   }
   private void Update()
   {
      if (playerInputHandler.Shooting)
      {
         Shoot();
      }
   }

   void Shoot()
   {
      RaycastHit hit;
      Vector3 startPos = muzzlePoint.position;
      Vector3 direction = cameraFPS.transform.forward;
      Vector3 endPos;

      if (Physics.Raycast(startPos, direction, out hit, Range))
      {
         endPos = hit.point;
      }
      else
      {
         // Si rien n’est touché, la ligne va jusqu’à la portée max
         endPos = startPos + direction * Range;
      }

      // Dessiner la ligne (debug visuel)
      StartCoroutine(DrawShotLine(startPos, endPos));
   }

   System.Collections.IEnumerator DrawShotLine(Vector3 start, Vector3 end)
   {
      lineRenderer.SetPosition(0, start);
      lineRenderer.SetPosition(1, end);
      lineRenderer.positionCount = 2;
      lineRenderer.enabled = true;

      yield return new WaitForSeconds(0.05f); // durée visible courte
      lineRenderer.enabled = false;
   }
}

