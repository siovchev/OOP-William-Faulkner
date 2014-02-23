namespace JustRpg.Interfaces
{
    using System;

    using JustRpg.EngineAndRenderer;
    public interface IRenderable
    {
        MatrixCoords GetTopLeft();

        char[,] GetImage();
    }
}
