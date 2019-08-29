﻿using Rayffer.PersonalPortfolio.Sorters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayffer.PersonalPortfolio.Sorters
{
    public class CockTailSorter<SortType> : ISorter<SortType> where SortType : IComparable<SortType>
    {
        public IEnumerable<SortType> SortAscending(IEnumerable<SortType> listToSort)
        {
            List<SortType> sortedList = listToSort.ToList();
            int swapOperations = sortedList.Count - 1;
            for (int sortIteration = 0; sortIteration < swapOperations / 2; sortIteration++)
            {
                for (int sortIndex = sortIteration; sortIndex < swapOperations - sortIteration; sortIndex++)
                {
                    SortType firstComparedElement = sortedList[sortIndex];
                    SortType secondComparedElement = sortedList[sortIndex + 1];
                    if (firstComparedElement.CompareTo(secondComparedElement) > 0)
                    {
                        sortedList[sortIndex] = secondComparedElement;
                        sortedList[sortIndex + 1] = firstComparedElement;
                    }
                }
                for (int sortIndex = swapOperations - sortIteration; sortIndex > sortIteration; sortIndex--)
                {
                    SortType firstComparedElement = sortedList[sortIndex];
                    SortType secondComparedElement = sortedList[sortIndex - 1];
                    if (firstComparedElement.CompareTo(secondComparedElement) < 0)
                    {
                        sortedList[sortIndex] = secondComparedElement;
                        sortedList[sortIndex - 1] = firstComparedElement;
                    }
                }
            }
            return sortedList;
        }

        public IEnumerable<SortType> SortDescending(IEnumerable<SortType> listToSort)
        {
            List<SortType> sortedList = listToSort.ToList();
            int swapOperations = sortedList.Count - 1;
            for (int sortIteration = 0; sortIteration < swapOperations / 2; sortIteration++)
            {
                for (int sortIndex = sortIteration; sortIndex < swapOperations - sortIteration; sortIndex++)
                {
                    SortType firstComparedElement = sortedList[sortIndex];
                    SortType secondComparedElement = sortedList[sortIndex + 1];
                    if (firstComparedElement.CompareTo(secondComparedElement) < 0)
                    {
                        sortedList[sortIndex] = secondComparedElement;
                        sortedList[sortIndex + 1] = firstComparedElement;
                    }
                }
                for (int sortIndex = swapOperations - sortIteration; sortIndex > sortIteration; sortIndex--)
                {
                    SortType firstComparedElement = sortedList[sortIndex];
                    SortType secondComparedElement = sortedList[sortIndex - 1];
                    if (firstComparedElement.CompareTo(secondComparedElement) > 0)
                    {
                        sortedList[sortIndex] = secondComparedElement;
                        sortedList[sortIndex - 1] = firstComparedElement;
                    }
                }
            }
            return sortedList;
        }
    }
}