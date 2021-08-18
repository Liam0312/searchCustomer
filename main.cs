using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[]args) {
    List<Customer> customerlist = new List<Customer>();
    string []lines = System.IO.File.ReadAllLines("CustomersData500.csv - CustomersData500.csv.csv");
    String found = "false";

      for(int i=0; i<lines.Length; i++){
        string line = lines[i];
        string[] parts = line.Split(',');
        Customer C = new Customer(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8]);
        customerlist.Add(C);
      } 
        foreach (Customer s in customerlist) {
          Console.WriteLine(s);
        }

      Console.WriteLine("Who is the person to search?(using Linear)");
      String name = Console.ReadLine();
        for( int i = 0; i < customerlist.Count; i++){
          if (customerlist[i].Last_name == name ){
              Console.WriteLine(customerlist[i]);
              found = "true";
          }     
        }
            if (found == "false"){
                Console.WriteLine("Information not found");
            }
      Console.WriteLine("Where is the State to search?(using Linear)");
      String state = Console.ReadLine();
          for( int i = 0; i < customerlist.Count; i++){
            if (customerlist[i].State == state ){
              Console.WriteLine(customerlist[i]);
            }
          }
              if (found == "false"){
                Console.WriteLine("Information not found");
              } 
    }
}