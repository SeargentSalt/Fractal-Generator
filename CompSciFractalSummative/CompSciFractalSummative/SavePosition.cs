using System;
namespace CompSciFractalSummative
{
    public struct SavePosition
    {
        public double saveX;
        public double saveY;
        public Vector2 saveVector;

        public SavePosition(double x, double y, Vector2 vector)
        {
            saveX = x;
            saveY = y;
            saveVector = vector;
        }
    }
}
