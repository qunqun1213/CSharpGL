﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL
{
    abstract class ZeroIndexLineSearcher
    {
        internal abstract uint[] Search(RenderEventArgs arg,
            int x, int y,
            uint lastVertexId, ZeroIndexModernRenderer modernRenderer);
        
    }
}
