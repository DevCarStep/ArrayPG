using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPG
{
    public class GenerationField
    {
        public Quad[,] generationArray;

        public GenerationField(int height, int width)
        {
            generationArray = new Quad[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    generationArray[i, j] = null;
            }
        }
    }

    public class Element
    {
        public Quad[,] structure;

        public Element(Quad[,] structure)
        {
            this.structure = structure;
        }

        public Quad[,] InsertQuadElements(GenerationField field, int x, int y)
        {
            Quad[,] array = field.generationArray;
            for (int i = 0; i < structure.GetLength(0); i++)
            {
                for (int j = y; j < structure.GetLength(1); j++)
                {
                    array[x+i, x+j] = structure[i, j];
                }
            }
            return array;
        }
    }

    public class Quad
    {
        bool up;
        bool down;
        bool left;
        bool right;
        public Quad(bool up, bool down, bool left, bool right)
        {
            this.up = up;
            this.down = down;
            this.left = left;
            this.right = right;
        }
    }
}
