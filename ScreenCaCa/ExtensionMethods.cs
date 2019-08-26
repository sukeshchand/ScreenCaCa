namespace ScreenCaCa
{
    public partial class FrmHome
    {
        public static class ExtensionMethods
        {
            public static int Map(int value, int fromSource, int toSource, int fromTarget, int toTarget)
            {
                return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
            }
        }
    }
}
