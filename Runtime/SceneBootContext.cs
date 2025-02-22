using System;
using UnityEngine;
using WhiteArrow.Bootstraping;
using Zenject;

namespace WhiteArrow.Bootstrapping.Zenject
{
    public abstract class SceneBootContext : SceneBoot
    {
        public static DiContainer DiContainer { get; private set; }



        public override sealed void Run(Action onEnded)
        {
            DiContainer?.UnbindAll();
            DiContainer = CreateDiContainer();

            if (DiContainer == null)
                Debug.LogWarning($"{nameof(DiContainer)} is null.");

            RunCore(onEnded);
        }


        protected abstract DiContainer CreateDiContainer();
        protected abstract void RunCore(Action onEnded);
    }
}
