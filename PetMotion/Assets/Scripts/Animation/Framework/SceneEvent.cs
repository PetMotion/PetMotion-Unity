#if UNITY_EDITOR
using UnityEngine;

namespace PetsonalAI {
	public abstract class SceneEvent : MonoBehaviour {
		public abstract void Callback(MotionEditor editor);
	}
}

#endif