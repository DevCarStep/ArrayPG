using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPG
{
    public class GenerationField
    {
        public Element[,] generationArray;

        public GenerationField(int height, int width)
        {
            generationArray = new Element[height, width];
        }
    }

    public class Element
    {
        public Quad[] structure;
    }

    public class Quad : Element
    {

    }
}
