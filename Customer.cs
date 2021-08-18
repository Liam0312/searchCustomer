using System;

class Customer
{
  public String Last_name {get; set;}
  public String First_name {get; set;}
  public String Address {get; set;}
  public String City {get; set;}
  public String State {get; set;}
  public String Zip_code {get; set;}
  public String Phone_number {get; set;}
  public String Email {get; set;}
  public String Photo {get; set;}

  public Customer()
{
  Last_name = "";
  First_name = "";
  Address = "";
  City = "";
  State = "";
  Zip_code = "";
  Phone_number = "";
  Email = "";
  Photo = "";
}

public Customer(String n, String n1, String n2, String n3, String n4, String i1, String i2, String n5, String n6)
  {
    //in order
    Last_name = n;
    First_name = n1;
    Address = n2;
    City = n3;
    State = n4;
    Zip_code = i1;
    Phone_number = i2;
    Email = n5;
    Photo = n6;
  }

  public override string ToString() 
 {
     return Last_name + "  : " + First_name + "  : " + Address + "  : " + City + "  : " + State + "  : " + Zip_code + "  : " + Phone_number + "  : " + Email;
 }
}



  