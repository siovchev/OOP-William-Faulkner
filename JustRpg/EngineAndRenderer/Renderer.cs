namespace JustRpg.EngineAndRenderer
{
    using System;
    using System.Text;

    using JustRpg.Interfaces;
    

    public class Renderer : IRenderer
    {
        private const int Rows = 35;
        private const int Cols = 100;

        
        // Setting the size of the game window
        private readonly char[,] matrixToPrint;

        public Renderer()
        {
            matrixToPrint = new char[Rows, Cols];

            Console.BufferHeight = Rows;
            Console.WindowHeight = Rows;
            Console.BufferWidth = Cols;
            Console.WindowWidth = Cols;

            this.ClearQueue();
        }

        public void EnqueueForRendering(IRenderable unit)
        {
            char[,] unitImage = unit.GetImage();

            int imageRows = unitImage.GetLength(0);
            int imageCols = unitImage.GetLength(1);

            MatrixCoords unitTopLeft = unit.GetTopLeft();

            int lastRow = Math.Min(unitTopLeft.Row + imageRows, Rows);
            int lastCol = Math.Min(unitTopLeft.Col + imageCols, Cols);

            for (int row = unit.GetTopLeft().Row; row < lastRow; row++)
            {
                for (int col = unit.GetTopLeft().Col; col < lastCol; col++)
                {
                    if (row >= 0 && row < Rows && col >= 0 && col < Cols)
                    {
                        matrixToPrint[row, col] = unitImage[row - unit.GetTopLeft().Row, col - unit.GetTopLeft().Col];
                    }
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);

            StringBuilder scene = new StringBuilder();

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    scene.Append(this.matrixToPrint[row, col]);
                }

                scene.Append(Environment.NewLine);
            }

            Console.WriteLine(scene.ToString());
        }

        public void ClearQueue()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    this.matrixToPrint[row, col] = ' ';
                }
            }
        }
    }
}
    