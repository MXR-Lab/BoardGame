using System;

namespace Oculus.Avatar2
{
    /// <summary>
    /// Data needed to drive face tracking of an avatar.
    /// </summary>
    public sealed class OvrAvatarFacePose
    {
        public readonly float[] expressionWeights = new float[(int)CAPI.ovrAvatar2FaceExpression.Count];
        public readonly float[] expressionConfidence = new float[(int)CAPI.ovrAvatar2FaceExpression.Count];
        public Int64 sampleTimeNS;

        #region Native Conversions
        internal CAPI.ovrAvatar2FacePose ToNative()
        {
            var native = new CAPI.ovrAvatar2FacePose();

            unsafe
            {
                for (var i = 0; i < expressionWeights.Length; i++)
                {
                    native.expressionWeights[i] = expressionWeights[i];
                }

                for (var i = 0; i < expressionConfidence.Length; i++)
                {
                    native.expressionConfidence[i] = expressionConfidence[i];
                }
            }

            return native;
        }

        internal void FromNative(in CAPI.ovrAvatar2FacePose native)
        {
            unsafe
            {
                for (var i = 0; i < expressionWeights.Length; i++)
                {
                    expressionWeights[i] = native.expressionWeights[i];
                }

                for (var i = 0; i < expressionConfidence.Length; i++)
                {
                    expressionConfidence[i] = native.expressionConfidence[i];
                }
            }
        }
        #endregion
    }
}
