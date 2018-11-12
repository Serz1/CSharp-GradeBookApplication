using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandartGradebook : BaseGradeBook

    {
        public StandartGradebook(string name) : base(name)

        {

            Type = GradeBookType.Standard;

        }
            
    }
}
