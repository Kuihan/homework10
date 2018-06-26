using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : NetworkBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            if (!isLocalPlayer || MyGUI.state < 4)
                return;
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }

        public override void OnStartLocalPlayer()
        {
            GameObject obj;
            foreach (Transform child in transform)
            {
                if(child.gameObject.name == "SkyCar")
                {
                    obj = child.gameObject;
                    foreach (Transform child2 in obj.transform)
                    {
                        if(child2.gameObject.name == "SkyCarBody")
                        {
                            child2.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                        }
                    }
                }
            }
        }
    }
}
