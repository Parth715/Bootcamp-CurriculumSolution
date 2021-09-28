using System;

namespace Bootcamp_Curriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            var Git = new Topic();
            Git.Name = "Git/Github";
            Git.Category = "SCM";
            Git.Difficulty = 2;
            Git.Print();
            var SQL = new Topic()
            {
                Name = "SQL Server",
                Category = "Database",
                Difficulty = 3,
            };
            SQL.Print();
            var CSharp = new Topic();
            CSharp.Name = "Git/Github";
            CSharp.Category = "SCM";
            CSharp.Difficulty = 2;
            CSharp.Print();


        }
    }
}
