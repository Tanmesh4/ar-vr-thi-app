using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private XRRig XROrigin;
    private CharacterController CharacterController;
    private CharacterController driver;
    void Start()
    {
        XROrigin = GetComponent<XRRig>();
        CharacterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }

     /// <summary>
        /// Updates the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
        /// based on the camera's position.
        /// </summary>
        protected virtual void UpdateCharacterController()
        {
            if (XROrigin == null || CharacterController == null)
                return;

            var height = Mathf.Clamp(XROrigin.CameraInOriginSpaceHeight, driver.minHeight, drover.maxHeight);

            Vector3 center = XROrigin.CameraInOriginSpacePos;
            center.y = height / 2f + CharacterController.skinWidth;

            CharacterController.height = height;
            CharacterController.center = center;
        }
}
