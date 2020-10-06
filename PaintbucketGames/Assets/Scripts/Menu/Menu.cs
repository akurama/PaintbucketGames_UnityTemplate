using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintbucketGames.Menu
{
    public abstract class Menu : MonoBehaviour, IMenu
    {
        #region MonoBehaviour

        [SerializeField] private Canvas canvas;

        private void OnEnable() => Open();

        private void OnDisable() => Close();

        #endregion

        public Canvas Canvas => canvas;

        public abstract void Open();
        public abstract void Initialize();
        public abstract void Close();
    }
}
