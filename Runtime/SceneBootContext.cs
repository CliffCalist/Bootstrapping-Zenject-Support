using System;
using UnityEngine;
using WhiteArrow.Bootstraping;
using Zenject;

namespace WhiteArrow.Bootstrapping.Zenject
{
    public abstract class SceneBootContext : SceneBoot
    {
        public static DiContainer Container { get; private set; }



        public override sealed void Run(Action onEnded)
        {
            Container?.UnbindAll();
            Container = CreateDiContainer();

            if (Container == null)
                Debug.LogWarning($"{nameof(Container)} is null.");

            RunCore(onEnded);
        }


        protected abstract DiContainer CreateDiContainer();
        protected abstract void RunCore(Action onEnded);
    }
}
