using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Security.Principal;

namespace PictureShapes
{
    class Dice
    {
        
        private Circle dot1;
        private Circle dot2;
        private Circle dot3;
        private Circle dot4;
        private Circle dot5;
        private Circle dot6;
        private Circle dot0;
        private int number;
        private static Random numberGenerator;
        
        


        public Dice()
        {
            numberGenerator = new Random();
            DrawImage();
        }

        public void Roll()
        {
            number = numberGenerator.Next(0, 7);

            if (number % 2 != 0)
            {
                dot0.MakeVisible();
            }
            if (number >= 2)
            {
                dot1.MakeVisible();
                dot2.MakeVisible();
            }
            if (number >= 4)
            {
                dot3.MakeVisible();
                dot4.MakeVisible();
            }
            if (number == 6)
            {
                dot5.MakeVisible();
                dot6.MakeVisible();
            }


        }
        public void DrawImage()
        {
            dot1 = new Circle();
            dot1.MakeInVisible();
            dot1.ChangeColor("red");
            dot1.ChangeSize(100);

            dot2 = new Circle();
            dot2.MakeInVisible();
            dot2.ChangeColor("red");
            dot2.ChangeSize(100);
            dot2.MoveVertical(350);
            dot2.MoveHorizontal(350);

            dot3 = new Circle();
            dot3.MakeInVisible();
            dot3.ChangeColor("red");
            dot3.ChangeSize(100);
            dot3.MoveVertical(350);


            dot4 = new Circle();
            dot4.MakeInVisible();
            dot4.ChangeColor("red");
            dot4.ChangeSize(100);
            dot4.MoveHorizontal(350);

            dot5 = new Circle();
            dot5.MakeInVisible();
            dot5.ChangeColor("red");
            dot5.ChangeSize(100);
            dot5.MoveVertical(175);

            dot6 = new Circle();
            dot6.MakeInVisible();
            dot6.ChangeColor("red");
            dot6.ChangeSize(100);
            dot6.MoveVertical(175);
            dot6.MoveHorizontal(350);

            dot0 = new Circle();
            dot0.MakeInVisible();
            dot0.ChangeColor("red");
            dot0.ChangeSize(100);
            dot0.MoveVertical(175);
            dot0.MoveHorizontal(175);




        }
    }
}
