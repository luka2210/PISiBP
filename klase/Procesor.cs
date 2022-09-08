// File:    Procesor.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Procesor

using System;

public class Procesor : ModelHardverskeKomponenta
{
   private string takt;
   private int brojJezgara;
   
   public string Takt
   {
      get
      {
         return takt;
      }
      set
      {
         this.takt = value;
      }
   }
   
   public int BrojJezgara
   {
      get
      {
         return brojJezgara;
      }
      set
      {
         this.brojJezgara = value;
      }
   }

}