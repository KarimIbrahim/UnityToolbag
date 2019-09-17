using UnityEngine;
using System;

namespace UnityToolbag
{
    /// <summary>
    /// A safe, drop-in replacement for MonoBehaviour as your base class. Each property value is cached
    /// and GetComponent will be called if the instance is null or is destroyed.
    /// </summary>
    public abstract class MiniCacheBehaviour : MonoBehaviour
    {
        [HideInInspector, NonSerialized]
        private Animator _animator;

        /// <summary>
        /// Gets the Animator attached to the object.
        /// </summary>
        public Animator Animator => _animator ? _animator : (_animator = GetComponent<Animator>());


        [HideInInspector, NonSerialized]
        private AudioSource _audioSource;

        /// <summary>
        /// Gets the AudioSource attached to the object.
        /// </summary>
        public AudioSource AudioSource => _audioSource ? _audioSource : (_audioSource = GetComponent<AudioSource>());


        [HideInInspector, NonSerialized]
        private Collider _collider;

        /// <summary>
        /// Gets the Collider attached to the object.
        /// </summary>
        public Collider Collider => _collider ? _collider : (_collider = GetComponent<Collider>());


        [HideInInspector, NonSerialized]
        private Rigidbody _rigidbody;

        /// <summary>
        /// Gets the Rigidbody attached to the object.
        /// </summary>
        public Rigidbody Rigidbody => _rigidbody ? _rigidbody : (_rigidbody = GetComponent<Rigidbody>());
    }
}
