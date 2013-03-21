using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public interface IRenderable
    {
        MatrixCoords GetTopLeft();

        char[,] GetImage();
    }
}
