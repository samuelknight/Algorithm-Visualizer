using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer.GUI
{

    public delegate void EntityDisposingArgs(IDrawable sender);

    /// <summary>
    /// Provides the ability to draw to a GUI
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Draws this object to the screen
        /// </summary>
        void Draw();
    }
}
