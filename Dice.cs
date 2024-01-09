using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Security.Principal;

namespace PictureShapes
{
    class Dice
    {
        
        private Circle dot0;
        private Circle dot1;
        private Circle dot2;
        private Circle dot3;
        private Circle dot4;
        private Circle dot5;
        private Circle dot6;
        private int number;
        private static Random numberGenerator;
        Circle[] dots;




        public Dice()
        {
            numberGenerator = new Random();
            dots = new Circle[7];
            DrawImage();



        }

        public void Roll()
        {
            number = numberGenerator.Next(0, 7);

            if (number % 2 != 0)
            {
                dots[0].MakeVisible();
            }
            if (number >= 2)
            {
                dots[1].MakeVisible();
                dots[2].MakeVisible();
            }
            if (number >= 4)
            {
                dots[3].MakeVisible();
                dots[4].MakeVisible();
            }
            if (number == 6)
            {
                dots[5].MakeVisible();
                dots[6].MakeVisible();
            }


        }
        public void DrawImage()
        {
            dots[1] = new Circle();
            dots[1].MakeInVisible();
            dots[1].ChangeColor("red");
            dots[1].ChangeSize(100);

            dots[2] = new Circle();
            dots[2].MakeInVisible();
            dots[2].ChangeColor("red");
            dots[2].ChangeSize(100);
            dots[2].MoveVertical(350);
            dots[2].MoveHorizontal(350);

            dots[3] = new Circle();
            dots[3].MakeInVisible();
            dots[3].ChangeColor("red");
            dots[3].ChangeSize(100);
            dots[3].MoveVertical(350);


            dots[4] = new Circle();
            dots[4].MakeInVisible();
            dots[4].ChangeColor("red");
            dots[4].ChangeSize(100);
            dots[4].MoveHorizontal(350);

            dots[5] = new Circle();
            dots[5].MakeInVisible();
            dots[5].ChangeColor("red");
            dots[5].ChangeSize(100);
            dots[5].MoveVertical(175);

            dots[6] = new Circle();
            dots[6].MakeInVisible();
            dots[6].ChangeColor("red");
            dots[6].ChangeSize(100);
            dots[6].MoveVertical(175);
            dots[6].MoveHorizontal(350);

            dots[0] = new Circle();
            dots[0].MakeInVisible();
            dots[0].ChangeColor("red");
            dots[0].ChangeSize(100);
            dots[0].MoveVertical(175);
            dots[0].MoveHorizontal(175);




        }
    }
}
