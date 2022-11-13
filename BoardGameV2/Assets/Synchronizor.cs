namespace Photon.Pun
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Oculus.Interaction;

    public class Synchronizor : MonoBehaviourPun, IPunObservable
    {
        bool onClick = false;
        [SerializeField, Interface(typeof(IInteractableView))]
        private MonoBehaviour _interactableView;
        private IInteractableView InteractableView;
        protected virtual void Awake()
        {
            InteractableView = _interactableView as IInteractableView;
        }
        public void Update(Oculus.Interaction.InteractableState select)
        {
            if (select == Oculus.Interaction.InteractableState.Select)
                onClick = true;
            else
                onClick = false;
        }

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            if (stream.IsWriting)
            {
                if (onClick == true)
                    stream.SendNext(onClick);
            }
            else
            {
                this.onClick = (bool)stream.ReceiveNext();
            }
        }
    }
}
