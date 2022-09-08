// File:    Nalog.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Nalog

using System;

public class Nalog
{
   private int idNaloga;
   private string ime;
   private string prezime;
   private string eMail;
   private string username;
   private string password;
   private DateTime datumRegistracije;
   
   public int IdNaloga
   {
      get
      {
         return idNaloga;
      }
      set
      {
         this.idNaloga = value;
      }
   }
   
   public string Ime
   {
      get
      {
         return ime;
      }
      set
      {
         this.ime = value;
      }
   }
   
   public string Prezime
   {
      get
      {
         return prezime;
      }
      set
      {
         this.prezime = value;
      }
   }
   
   public string EMail
   {
      get
      {
         return eMail;
      }
      set
      {
         this.eMail = value;
      }
   }
   
   public string Username
   {
      get
      {
         return username;
      }
      set
      {
         this.username = value;
      }
   }
   
   public string Password
   {
      get
      {
         return password;
      }
      set
      {
         this.password = value;
      }
   }
   
   public DateTime DatumRegistracije
   {
      get
      {
         return datumRegistracije;
      }
      set
      {
         this.datumRegistracije = value;
      }
   }

}