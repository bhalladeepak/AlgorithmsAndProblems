using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    /*
     * https://leetcode.com/problems/reconstruct-itinerary/
     * You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure and the arrival airports of one flight. 
     * Reconstruct the itinerary in order and return it.
     * 
     * All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK". If there are multiple valid itineraries, 
     * you should return the itinerary that has the smallest lexical order when read as a single string.
     * 
     * For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
     * You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once.
     * 
     * Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
     * Output: ["JFK","MUC","LHR","SFO","SJC"]
     * 
     * Input: tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
     * Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
     * Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"] but it is larger in lexical order.
     * 
     * Step1: Find all the list where first element is JFK. From that list find the first with the smallest lexical order. Remove it from the tickets list
     * Step2: Get the second element from the list in the first step and look for the list with the element. Get the second element and add to the return list and remove it
     *        from the tickets list. This CAN be a utility function
     *        
     *        https://baihuqian.github.io/2018-08-11-reconstruct-itinerary/
     */
    public class ReconstructItinerary
    {
        public void demo()
        {
            string[,] tickets = new string[4, 2] { { "MUC", "LHR" }, { "JFK", "MUC" }, {"SFO", "SJC"}, {"LHR", "SFO"} };
            findItinerary(tickets);
        }

        public List<string> findItinerary(string[][] tickets)
        {
            Dictionary<string, Queue<string>> dests = new Dictionary<string, Queue<string>>();

            foreach (string[] t in tickets)
            {
                if(dests.ContainsKey(t[0]))
                {
                    Queue<string> tempQueue = dests[t[0]];
                    tempQueue.Enqueue(t[1]);
                }
                else
                {
                    Queue<string> tempQueue = new Queue<string>();
                    tempQueue.Enqueue(t[1]);
                    dests.Add(t[0], tempQueue);
                }

            }

            List<string> res = new List<string>();
            Stack<string> stack = new Stack<string>();
            stack.Push("JFK");
            while (!stack.Any())
            {
                while (dests.ContainsKey(stack.Peek()) && dests[stack.Peek()].Count != 0)
                    stack.Push(dests[].get(stack.Peek()).poll());
                res.Add(stack.Pop());
            }
            return res;
        }
    }
}
