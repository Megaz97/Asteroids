﻿using UnityEngine;
using System.Collections;

public class ScreenWrap : MonoBehaviour
{
		Renderer[] renderers;
		private bool isWrappingX;
		private bool isWrappingY;

		// Use this for initialization
		void Start ()
		{

				renderers = GetComponentsInChildren<Renderer> ();
		}
		bool CheckRenderers ()
		{
				foreach (var renderer in renderers) {
						// If at least one render is visible, return true
						if (renderer.isVisible) {
								return true;
						}
				}
		
				// Otherwise, the object is invisible
				return false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				Warp ();
		}

		void Warp ()
		{
				var isVisible = CheckRenderers ();
		
				if (isVisible) {
						isWrappingX = false;
						isWrappingY = false;
						return;
				}
		
				if (isWrappingX && isWrappingY) {
						return;
				}
		
				var cam = Camera.main;
				var viewportPosition = cam.WorldToViewportPoint (transform.position);
				var newPosition = transform.position;
		
				if (!isWrappingX && (viewportPosition.x > 1 || viewportPosition.x < 0)) {
						newPosition.x = -newPosition.x;
			
						isWrappingX = true;
				}
		
				if (!isWrappingY && (viewportPosition.y > 1 || viewportPosition.y < 0)) {
						newPosition.y = -newPosition.y;
			
						isWrappingY = true;
				}
		
				transform.position = newPosition;
		}
}