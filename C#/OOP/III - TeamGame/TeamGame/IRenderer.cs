using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public interface IRenderer
    {
        void EnqueueForRendering(IRenderable obj);

        void RenderAll();

        void ClearQueue();
    }
}
