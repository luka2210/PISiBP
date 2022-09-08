// File:    Racun.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Racun

using System;

public class Racun
{
   private decimal ukupnaCena;
   private bool placen;
   
   public decimal UkupnaCena
   {
      get
      {
         return ukupnaCena;
      }
      set
      {
         this.ukupnaCena = value;
      }
   }
   
   public bool Placen
   {
      get
      {
         return placen;
      }
      set
      {
         this.placen = value;
      }
   }

}