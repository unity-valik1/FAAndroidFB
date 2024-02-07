// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("VtdxYyQ6r+yO9CcLhImw0l/FD93c0S05VzNPUKTY0zNdlPSRBuVlCfQtgUOWhFko9d7nnosledd/vThHzGBWhRaDJlTCI8DDqWisitZoGAvuqUgbwxTqK7/xZIi1QveHwV9x7aEGHVWnQJHgS/Mv3ewPlY1+paq7goGvVC4cfKeCY3+hvmTcJucTXoDa7596s8mPyw9H0TdCcG9o5UlE2C+dHj0vEhkWNZlXmegSHh4eGh8cryvuJVw28cAbNDj4sCaRlFjMv0X5RwhmYOYLhVs9Ccx2tUZqI8R+Dp24icN4hzYgEkkA9YlLguYNk/BKMjIA1KjS19cafVcOMsHP/1OMIVSdHhAfL50eFR2dHh4fnm876f6PibrI+Ck2BeSNJh0cHh8e");
        private static int[] order = new int[] { 2,7,5,13,11,12,9,8,12,11,10,11,13,13,14 };
        private static int key = 31;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
