// File:    Monitor.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Monitor

using System;

public class Monitor : ModelHardverskeKomponenta
{
   private string dijagonala;
   private string refreshRate;
   
   public string Dijagonala
   {
      get
      {
         return dijagonala;
      }
      set
      {
         this.dijagonala = value;
      }
   }
   
   public string RefreshRate
   {
      get
      {
         return refreshRate;
      }
      set
      {
         this.refreshRate = value;
      }
   }

}