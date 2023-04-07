using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public PlayerController starterAssetsInputs;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterAssetsInputs.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            starterAssetsInputs.RotateInput(virtualLookDirection);
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
            starterAssetsInputs.BoostInput(virtualSprintState);
        }
        
    }

}
