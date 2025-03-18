using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        //var list = dominoes.ToList();

        //if (list.Count == 0) return true;
        //if (list.Count == 1) return list[0].Item1 == list[0].Item2;

        //var first = list.First();
        //list.RemoveAt(0);

        //var newList = new List<(int, int)> { first };

        //bool added = true;

        //while (added)
        //{
        //    added = false;
        //    var toRemove = new List<(int, int)>(); //List with items to be removed later

        //    foreach (var domino in list)
        //    {
        //        if (domino.Item1 == first.Item2)
        //        {
        //            first = domino;
        //            newList.Add(first);
        //            toRemove.Add(domino);
        //            added = true;
        //            break; //only add 1 piece per iteratin
        //        }
        //        else if (domino.Item2 == first.Item2)
        //        {
        //            first = (domino.Item2, domino.Item1);
        //            newList.Add(first);
        //            toRemove.Add(domino);
        //            added = true;
        //            break; //only add 1 piece per iteratin
        //        }
        //    }

        //    // Eliminamos los elementos marcados fuera del bucle
        //    foreach (var item in toRemove)
        //    {
        //        list.Remove(item);
        //    }
        //}
        //if (newList.Count != dominoes.Count()) return false;
        //else return newList[0].Item1 == newList[newList.Count - 1].Item2;
    }
    private static bool CanChainRecursive(List<(int, int)> remaining, List<(int, int)> chain, int start)
    {
        if (!remaining.Any())
            return chain.First().Item1 == chain.Last().Item2;

        for (int i = 0; i < remaining.Count; i++)
        {
            var domino = remaining[i];
            var newRemaining = new List<(int, int)>(remaining);
            newRemaining.RemoveAt(i);




        }
    }
}
