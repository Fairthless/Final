using System;
using System.Collections.Generic;

namespace CourseWork
{
    class ListCoordinates
    {
        public List<string> GetCollectionCoordinates(string coordinates)
        {
            List<string> coordinate = new List<string>();
            string[] strings;
            strings = coordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in strings)
            {
                coordinate.Add(str);
            }
            return coordinate;
        }

    }
}
