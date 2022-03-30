using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class SearchListQuery
    {
        /*
         * 1. Sort the repository in a sorted list
         * 2. Write a for loop that will return a list of words starting with substring(0,1), substring(0,2), substring(0,3), substring(0,4)
         */

        public static void Execute()
        {
            List<string> repository = new List<string> { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string customerQuery = "mouse";

            var result = SearchSuggestions(repository, customerQuery);

        }
        private static List<List<string>> SearchSuggestions(List<string> repository, String customerQuery)
        {
            List<List<string>> suggestionList = new List<List<string>>();
            List<string> sortedRepository = repository.OrderBy(q => q).ToList();

            for(int i=2; i <= customerQuery.Length; i++ )
            {
                string wordToCheck = customerQuery.Substring(0, i);

                List<string> suggestions = sortedRepository.Where(q => q.StartsWith(wordToCheck)).Take(3).ToList();
                suggestionList.Add(suggestions);
            }

            return suggestionList;
        }


    }
}
