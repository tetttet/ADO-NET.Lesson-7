global using System;

namespace demoNS {
  class Program {
    static void Main(string[] args) {
      try {

        var context = new ApplicationDbContext();

      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
      Console.WriteLine("\nEnd . . .");
      Console.ReadLine();
    }
  }
}