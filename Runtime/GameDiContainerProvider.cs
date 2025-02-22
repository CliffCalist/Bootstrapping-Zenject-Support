using Zenject;

namespace WhiteArrow.Bootstrapping.Zenject
{
    public static class GameDiContainerProvider
    {
        private static DiContainer s_container;

        public static DiContainer Container
        {
            get
            {
                if (s_container == null)
                    s_container = new();

                return s_container;
            }
        }
    }
}