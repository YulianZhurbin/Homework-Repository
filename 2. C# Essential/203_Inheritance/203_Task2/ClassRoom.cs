using System;

namespace _203_Task2
{
    class ClassRoom
    {
        Pupil firstPupil, secondPupil, thirdPupil, fourthPupil;
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil, Pupil fourthPupil)
        {
            this.firstPupil = firstPupil;
            this.secondPupil = secondPupil;
            this.thirdPupil = thirdPupil;
            this.fourthPupil = fourthPupil;
        }

        public void ShowClassRoom()
        {
            firstPupil.ShowGrades();
            secondPupil.ShowGrades();
            thirdPupil.ShowGrades();
            fourthPupil.ShowGrades();
        }
    }
}
