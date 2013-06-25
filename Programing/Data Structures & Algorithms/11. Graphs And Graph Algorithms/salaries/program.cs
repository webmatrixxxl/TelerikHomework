using System;
using System.Linq;
using System.IO;

class Program
{
    static void Main() 
    {
        Console.SetIn(new StringReader(
@"6
NNNNNN
YNYNNY
YNNNNY
NNNNNN
YNYNNN
YNNYNN"));
        var count = int.Parse(Console.ReadLine());

         
        // dynamic programming solution:
        // determine the number of people each person manages (directly or 
        // indirectly)
        // then calculate salaries in ascending order of managed people


        // dynamic programming table
        var salary = new long[count];

        // order of evaluation
        var managedCount = new long[count];

        // adjacency matrix
        var edge = new bool[count, count];
        
        for (var ii = 0; ii < count; ++ii) 
        {
            var jj = 0;
            
            foreach(var ch in Console.ReadLine().Trim()) 
            {
                edge[ii,jj] = (ch == 'Y');
                managedCount[ii] += edge[ii,jj] ? 1 : 0;
                jj += 1;
            }
            
            if(managedCount[ii] == 0) 
            {
                salary[ii] = 1;
            }
        }
        
        Func<int, long> getSalary = null;
        
        getSalary = ii => 
        {
            if (salary[ii] == 0) 
            {
                for (var jj = 0; jj < count; ++jj) 
                {
                    if (edge[ii,jj])
                        salary[ii] += getSalary(jj);
                }
            }
            return salary[ii];
        };
        
        long total = Enumerable.Range(0, count)
                               .OrderBy(who => managedCount[who])
                               .Select(getSalary)
                               .Sum();
            
        Console.WriteLine(total);
         
    }
 
}